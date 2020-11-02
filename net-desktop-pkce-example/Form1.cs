using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography;
using static HelloXeroAPI_PKCE.Constants.XeroUrls;

namespace HelloXeroAPI_PKCE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            txtBoxCodeVerifier.Text = GenerateCodeVerifier();
        }

        private static string GenerateCodeVerifier()
        {
            //Generate a random string for our code verifier
            var rng = RandomNumberGenerator.Create();
            var bytes = new byte[32];
            rng.GetBytes(bytes);

            var codeVerifier = Convert.ToBase64String(bytes)
                .TrimEnd('=')
                .Replace('+', '-')
                .Replace('/', '_');
            return codeVerifier;
        }

        private string _authorisationCode;
        public string AuthorisationCode
        {
            get => _authorisationCode;

            set
            {
                txtBoxReturnedCode.Text = value;
                _authorisationCode = value;
            }
        }

        private string _state;
        public string State
        {
            get => _state;

            set
            {
                txtBoxReturnedState.Text = value;
                _state = value;
            }
        }

        private void btnGenerateLink_Click(object sender, EventArgs e)
        {
            //construct the link that the end user will need to visit in order to authorize the app
            var clientId = txtBoxClientID.Text;
            var scopes = Uri.EscapeUriString(txtBoxScopes.Text);
            var redirectUri = txtBoxRedirectURI.Text;
            var state = txtBoxState.Text;

            //generate the code challenge based on the verifier
            string codeChallenge;
            using (var sha256 = SHA256.Create())
            {
                var challengeBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(txtBoxCodeVerifier.Text));
                codeChallenge = Convert.ToBase64String(challengeBytes)
                    .TrimEnd('=')
                    .Replace('+', '-')
                    .Replace('/', '_');
            }
            
            var authLink = $"{AuthorisationUrl}?response_type=code&client_id={clientId}&redirect_uri={redirectUri}&scope={scopes}&state={state}&code_challenge={codeChallenge}&code_challenge_method=S256";
            txtBoxAuthLink.Text = authLink;
            btnAuthorise.Enabled = true;
        }

        private void btnAuthorise_Click(object sender, EventArgs e)
        {
            //open web browser with the link generated
            var authLink = txtBoxAuthLink.Text;

            System.Diagnostics.Process.Start(authLink);
            
            //start webserver to listen for the callback
            LocalHttpListener.StartWebServer(this);
        }
        
        private void txtBoxReturnedState_TextChanged(object sender, EventArgs e)
        {
            //if the callback has occurred the boxes will be updated, activate the next button once this has been done
            if (txtBoxReturnedState.Text == txtBoxState.Text && txtBoxReturnedCode.Text.Any())
            {
                btnGetTokens.Enabled = true;
            }
            else
            {
                btnGetTokens.Enabled = false;
            }
        }

        private async void btnGetTokens_ClickAsync(object sender, EventArgs e)
        {
            //exchange the code for a set of tokens
            const string url = "https://identity.xero.com/connect/token";

            var client = new HttpClient();
            var formContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "authorization_code"),
                new KeyValuePair<string, string>("client_id", txtBoxClientID.Text),
                new KeyValuePair<string, string>("code", txtBoxReturnedCode.Text),
                new KeyValuePair<string, string>("redirect_uri", txtBoxRedirectURI.Text),
                new KeyValuePair<string, string>("code_verifier", txtBoxCodeVerifier.Text),
            });

            var response = await client.PostAsync(url, formContent);
            
            //read the response and populate the boxes for each token
            //could also parse the expiry here if required
            var content = await response.Content.ReadAsStringAsync();
            var tokens = JObject.Parse(content);
            
            txtBoxIDToken.Text = tokens["id_token"]?.ToString();
            txtBoxAccessToken.Text = tokens["access_token"]?.ToString();
            txtBoxRefreshToken.Text = tokens["refresh_token"]?.ToString();
        }

        private void txtBoxAccessToken_TextChanged(object sender, EventArgs e)
        {
            //enable the next button once we have an access token
            if (txtBoxAccessToken.Text.Any())
            {
                btnGetConnections.Enabled = true;
            }
        }

        private async void btnGetConnections_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", txtBoxAccessToken.Text);
            
            var response = await client.GetAsync(ConnectionsUrl);
            var content = await response.Content.ReadAsStringAsync();

            //fill the dropdown box based on the results 
            var tenants = JsonConvert.DeserializeObject<List<Tenant>>(content);
            
            comboBoxTenants.DataSource = tenants;
            comboBoxTenants.DisplayMember = "Name";
            comboBoxTenants.ValueMember = "ID";
            comboBoxTenants.Enabled = true;
        }
        

        private void comboBoxTenants_SelectedIndexChanged(object sender, EventArgs e)
        {
            //once a tenant has been selected allow an api call to be made
            comboBoxMethod.Enabled = true;
            comboBoxEndpoint.Enabled = true;
            btnMakeCall.Enabled = true;
        }

        private async void btnMakeCall_Click(object sender, EventArgs e)
        {
            //make an api call - at the moment hardwired for GET calls
            var url = $"{XeroApiUrlBase}/{comboBoxEndpoint.SelectedItem}";
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", txtBoxAccessToken.Text);
            client.DefaultRequestHeaders.Add("xero-tenant-id", comboBoxTenants.SelectedValue.ToString());
            
            var response = await client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            
            textBox1.Text = content;
        }

        private void txtBoxRefreshToken_TextChanged(object sender, EventArgs e)
        {
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            const string url = "https://identity.xero.com/connect/token";
            var client = new HttpClient();
            var formContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "refresh_token"),
                new KeyValuePair<string, string>("client_id", txtBoxClientID.Text),
                new KeyValuePair<string, string>("refresh_token", txtBoxRefreshToken.Text),
            });

            var response = await client.PostAsync(url, formContent);

            //read the response and populate the boxes for each token
            //could also parse the expiry here if required
            var content = await response.Content.ReadAsStringAsync();
            var tokens = JObject.Parse(content);

            txtBoxAccessToken.Text = tokens["access_token"]?.ToString();
            txtBoxRefreshToken.Text = tokens["refresh_token"]?.ToString();
        }
    }
}

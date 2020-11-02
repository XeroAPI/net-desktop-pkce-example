namespace HelloXeroAPI_PKCE
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAuthorise = new System.Windows.Forms.Button();
            this.txtBoxClientID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxCodeVerifier = new System.Windows.Forms.TextBox();
            this.txtBoxRedirectURI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxScopes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGenerateLink = new System.Windows.Forms.Button();
            this.txtBoxState = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxAuthLink = new System.Windows.Forms.TextBox();
            this.txtBoxReturnedState = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxReturnedCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGetTokens = new System.Windows.Forms.Button();
            this.txtBoxIDToken = new System.Windows.Forms.TextBox();
            this.txtBoxAccessToken = new System.Windows.Forms.TextBox();
            this.txtBoxRefreshToken = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGetConnections = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxTenants = new System.Windows.Forms.ComboBox();
            this.btnMakeCall = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBoxMethod = new System.Windows.Forms.ComboBox();
            this.comboBoxEndpoint = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAuthorise
            // 
            this.btnAuthorise.Enabled = false;
            this.btnAuthorise.Location = new System.Drawing.Point(9, 498);
            this.btnAuthorise.Name = "btnAuthorise";
            this.btnAuthorise.Size = new System.Drawing.Size(299, 23);
            this.btnAuthorise.TabIndex = 0;
            this.btnAuthorise.Text = "1b - Authorise";
            this.btnAuthorise.UseVisualStyleBackColor = true;
            this.btnAuthorise.Click += new System.EventHandler(this.btnAuthorise_Click);
            // 
            // txtBoxClientID
            // 
            this.txtBoxClientID.Location = new System.Drawing.Point(9, 35);
            this.txtBoxClientID.Name = "txtBoxClientID";
            this.txtBoxClientID.Size = new System.Drawing.Size(299, 20);
            this.txtBoxClientID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Client ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Code Verifier";
            // 
            // txtBoxCodeVerifier
            // 
            this.txtBoxCodeVerifier.Location = new System.Drawing.Point(9, 90);
            this.txtBoxCodeVerifier.Name = "txtBoxCodeVerifier";
            this.txtBoxCodeVerifier.Size = new System.Drawing.Size(299, 20);
            this.txtBoxCodeVerifier.TabIndex = 5;
            // 
            // txtBoxRedirectURI
            // 
            this.txtBoxRedirectURI.Location = new System.Drawing.Point(9, 247);
            this.txtBoxRedirectURI.Name = "txtBoxRedirectURI";
            this.txtBoxRedirectURI.ReadOnly = true;
            this.txtBoxRedirectURI.Size = new System.Drawing.Size(299, 20);
            this.txtBoxRedirectURI.TabIndex = 6;
            this.txtBoxRedirectURI.Text = "http://localhost:8888/callback";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Redirect URI";
            // 
            // txtBoxScopes
            // 
            this.txtBoxScopes.Location = new System.Drawing.Point(9, 144);
            this.txtBoxScopes.Multiline = true;
            this.txtBoxScopes.Name = "txtBoxScopes";
            this.txtBoxScopes.Size = new System.Drawing.Size(299, 69);
            this.txtBoxScopes.TabIndex = 8;
            this.txtBoxScopes.Text = "offline_access openid profile email accounting.transactions accounting.settings a" +
    "ccounting.contacts";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Scopes";
            // 
            // btnGenerateLink
            // 
            this.btnGenerateLink.Location = new System.Drawing.Point(9, 333);
            this.btnGenerateLink.Name = "btnGenerateLink";
            this.btnGenerateLink.Size = new System.Drawing.Size(299, 23);
            this.btnGenerateLink.TabIndex = 10;
            this.btnGenerateLink.Text = "1a - Generate Authorisation Link";
            this.btnGenerateLink.UseVisualStyleBackColor = true;
            this.btnGenerateLink.Click += new System.EventHandler(this.btnGenerateLink_Click);
            // 
            // txtBoxState
            // 
            this.txtBoxState.Location = new System.Drawing.Point(9, 299);
            this.txtBoxState.Name = "txtBoxState";
            this.txtBoxState.Size = new System.Drawing.Size(299, 20);
            this.txtBoxState.TabIndex = 11;
            this.txtBoxState.Text = "123456789";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "State";
            // 
            // txtBoxAuthLink
            // 
            this.txtBoxAuthLink.Location = new System.Drawing.Point(9, 371);
            this.txtBoxAuthLink.Multiline = true;
            this.txtBoxAuthLink.Name = "txtBoxAuthLink";
            this.txtBoxAuthLink.ReadOnly = true;
            this.txtBoxAuthLink.Size = new System.Drawing.Size(299, 111);
            this.txtBoxAuthLink.TabIndex = 13;
            // 
            // txtBoxReturnedState
            // 
            this.txtBoxReturnedState.Location = new System.Drawing.Point(9, 35);
            this.txtBoxReturnedState.Name = "txtBoxReturnedState";
            this.txtBoxReturnedState.ReadOnly = true;
            this.txtBoxReturnedState.Size = new System.Drawing.Size(299, 20);
            this.txtBoxReturnedState.TabIndex = 14;
            this.txtBoxReturnedState.TextChanged += new System.EventHandler(this.txtBoxReturnedState_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Returned State";
            // 
            // txtBoxReturnedCode
            // 
            this.txtBoxReturnedCode.Location = new System.Drawing.Point(9, 90);
            this.txtBoxReturnedCode.Name = "txtBoxReturnedCode";
            this.txtBoxReturnedCode.ReadOnly = true;
            this.txtBoxReturnedCode.Size = new System.Drawing.Size(299, 20);
            this.txtBoxReturnedCode.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Returned Code";
            // 
            // btnGetTokens
            // 
            this.btnGetTokens.Enabled = false;
            this.btnGetTokens.Location = new System.Drawing.Point(9, 20);
            this.btnGetTokens.Name = "btnGetTokens";
            this.btnGetTokens.Size = new System.Drawing.Size(299, 23);
            this.btnGetTokens.TabIndex = 18;
            this.btnGetTokens.Text = "3 - Retrieve Tokens";
            this.btnGetTokens.UseVisualStyleBackColor = true;
            this.btnGetTokens.Click += new System.EventHandler(this.btnGetTokens_ClickAsync);
            // 
            // txtBoxIDToken
            // 
            this.txtBoxIDToken.Location = new System.Drawing.Point(9, 37);
            this.txtBoxIDToken.Multiline = true;
            this.txtBoxIDToken.Name = "txtBoxIDToken";
            this.txtBoxIDToken.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxIDToken.Size = new System.Drawing.Size(299, 97);
            this.txtBoxIDToken.TabIndex = 20;
            // 
            // txtBoxAccessToken
            // 
            this.txtBoxAccessToken.Location = new System.Drawing.Point(9, 156);
            this.txtBoxAccessToken.Multiline = true;
            this.txtBoxAccessToken.Name = "txtBoxAccessToken";
            this.txtBoxAccessToken.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxAccessToken.Size = new System.Drawing.Size(299, 95);
            this.txtBoxAccessToken.TabIndex = 21;
            this.txtBoxAccessToken.TextChanged += new System.EventHandler(this.txtBoxAccessToken_TextChanged);
            // 
            // txtBoxRefreshToken
            // 
            this.txtBoxRefreshToken.Location = new System.Drawing.Point(9, 272);
            this.txtBoxRefreshToken.Multiline = true;
            this.txtBoxRefreshToken.Name = "txtBoxRefreshToken";
            this.txtBoxRefreshToken.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxRefreshToken.Size = new System.Drawing.Size(299, 47);
            this.txtBoxRefreshToken.TabIndex = 22;
            this.txtBoxRefreshToken.TextChanged += new System.EventHandler(this.txtBoxRefreshToken_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "ID Token";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Access Token";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Refresh Token";
            // 
            // btnGetConnections
            // 
            this.btnGetConnections.Enabled = false;
            this.btnGetConnections.Location = new System.Drawing.Point(11, 35);
            this.btnGetConnections.Name = "btnGetConnections";
            this.btnGetConnections.Size = new System.Drawing.Size(299, 23);
            this.btnGetConnections.TabIndex = 26;
            this.btnGetConnections.Text = "5 - GET Connections";
            this.btnGetConnections.UseVisualStyleBackColor = true;
            this.btnGetConnections.Click += new System.EventHandler(this.btnGetConnections_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 67);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(299, 269);
            this.textBox1.TabIndex = 28;
            // 
            // comboBoxTenants
            // 
            this.comboBoxTenants.Enabled = false;
            this.comboBoxTenants.FormattingEnabled = true;
            this.comboBoxTenants.Location = new System.Drawing.Point(11, 89);
            this.comboBoxTenants.Name = "comboBoxTenants";
            this.comboBoxTenants.Size = new System.Drawing.Size(299, 21);
            this.comboBoxTenants.TabIndex = 29;
            this.comboBoxTenants.SelectedIndexChanged += new System.EventHandler(this.comboBoxTenants_SelectedIndexChanged);
            // 
            // btnMakeCall
            // 
            this.btnMakeCall.Enabled = false;
            this.btnMakeCall.Location = new System.Drawing.Point(208, 21);
            this.btnMakeCall.Name = "btnMakeCall";
            this.btnMakeCall.Size = new System.Drawing.Size(103, 23);
            this.btnMakeCall.TabIndex = 32;
            this.btnMakeCall.Text = "6 - Call the API";
            this.btnMakeCall.UseVisualStyleBackColor = true;
            this.btnMakeCall.Click += new System.EventHandler(this.btnMakeCall_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxAuthLink);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBoxState);
            this.groupBox1.Controls.Add(this.btnGenerateLink);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBoxScopes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxRedirectURI);
            this.groupBox1.Controls.Add(this.txtBoxCodeVerifier);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBoxClientID);
            this.groupBox1.Controls.Add(this.btnAuthorise);
            this.groupBox1.Location = new System.Drawing.Point(6, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 533);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Send a user to authorize your app";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtBoxReturnedCode);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtBoxReturnedState);
            this.groupBox2.Location = new System.Drawing.Point(340, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 121);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2. Users are redirected back to you with a code";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGetTokens);
            this.groupBox3.Location = new System.Drawing.Point(340, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(322, 56);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3. Exchange the code";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtBoxRefreshToken);
            this.groupBox4.Controls.Add(this.txtBoxAccessToken);
            this.groupBox4.Controls.Add(this.txtBoxIDToken);
            this.groupBox4.Location = new System.Drawing.Point(340, 206);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(321, 336);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "4. Receive your tokens";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBoxTenants);
            this.groupBox5.Controls.Add(this.btnGetConnections);
            this.groupBox5.Location = new System.Drawing.Point(677, 9);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(323, 120);
            this.groupBox5.TabIndex = 37;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "5. Check the tenants you\'re authorized to access";
            // 
            // comboBoxMethod
            // 
            this.comboBoxMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMethod.Enabled = false;
            this.comboBoxMethod.FormattingEnabled = true;
            this.comboBoxMethod.Items.AddRange(new object[] {
            "GET"});
            this.comboBoxMethod.Location = new System.Drawing.Point(11, 22);
            this.comboBoxMethod.Name = "comboBoxMethod";
            this.comboBoxMethod.Size = new System.Drawing.Size(51, 21);
            this.comboBoxMethod.TabIndex = 30;
            // 
            // comboBoxEndpoint
            // 
            this.comboBoxEndpoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEndpoint.Enabled = false;
            this.comboBoxEndpoint.FormattingEnabled = true;
            this.comboBoxEndpoint.Items.AddRange(new object[] {
            "invoices",
            "contacts",
            "organisation"});
            this.comboBoxEndpoint.Location = new System.Drawing.Point(71, 22);
            this.comboBoxEndpoint.Name = "comboBoxEndpoint";
            this.comboBoxEndpoint.Size = new System.Drawing.Size(131, 21);
            this.comboBoxEndpoint.TabIndex = 31;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnMakeCall);
            this.groupBox6.Controls.Add(this.comboBoxEndpoint);
            this.groupBox6.Controls.Add(this.comboBoxMethod);
            this.groupBox6.Controls.Add(this.textBox1);
            this.groupBox6.Location = new System.Drawing.Point(677, 139);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(323, 343);
            this.groupBox6.TabIndex = 38;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "6. Call the API";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnRefresh);
            this.groupBox7.Location = new System.Drawing.Point(677, 488);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(323, 54);
            this.groupBox7.TabIndex = 39;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Refreshing access tokens";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(11, 19);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(299, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh Tokens";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 547);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "net-desktop-pkce-example";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAuthorise;
        private System.Windows.Forms.TextBox txtBoxClientID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxCodeVerifier;
        private System.Windows.Forms.TextBox txtBoxRedirectURI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxScopes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGenerateLink;
        private System.Windows.Forms.TextBox txtBoxState;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxAuthLink;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxReturnedState;
        private System.Windows.Forms.TextBox txtBoxReturnedCode;
        private System.Windows.Forms.Button btnGetTokens;
        private System.Windows.Forms.TextBox txtBoxIDToken;
        private System.Windows.Forms.TextBox txtBoxAccessToken;
        private System.Windows.Forms.TextBox txtBoxRefreshToken;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGetConnections;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxTenants;
        private System.Windows.Forms.Button btnMakeCall;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBoxMethod;
        private System.Windows.Forms.ComboBox comboBoxEndpoint;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnRefresh;
    }
}


using System;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HelloXeroAPI_PKCE
{
    //this is based on code found at http://www.gabescode.com/dotnet/2018/11/01/basic-HttpListener-web-service.html 
    //made by https://stackoverflow.com/users/1202807/gabriel-luci thank you

    public class LocalHttpListener
    {
        private const int Port = 8888;

        private static readonly HttpListener Listener = new HttpListener { Prefixes = { $"http://localhost:{Port}/" } };

        private static bool _keepGoing = true;

        private static Task _mainLoop;

        public static void StartWebServer(Form1 frm1)
        {
            if (_mainLoop != null && !_mainLoop.IsCompleted) return; //Already started
            {
                _mainLoop = MainLoop(frm1);
            }
        }

        public static void StopWebServer()
        {
            _keepGoing = false;
            lock (Listener)
            {
                //Use a lock so we don't kill a request that's currently being processed
                Listener.Stop();
            }
            try
            {
                _mainLoop.Wait();
            }
            catch { /* je ne care pas */ }
        }

        private static async Task MainLoop(Form1 frm1)
        {
            Listener.Start();

            while (_keepGoing)
            {
                try
                {
                    //GetContextAsync() returns when a new request come in
                    var context = await Listener.GetContextAsync();
                    lock (Listener)
                    {
                        if (_keepGoing) ProcessRequest(context, frm1);
                    }
                }
                catch (Exception e)
                {
                    //this gets thrown when the listener is stopped
                    if (e is HttpListenerException)
                    {
                        return;
                    } 
                    
                    //TODO: Log the exception
                }
            }
        }

        private static void ProcessRequest(HttpListenerContext context, Form1 frm1)
        {
            using (var response = context.Response)
            {
                try
                {
                    var handled = false;
                    switch (context.Request.Url.AbsolutePath)
                    {
                        //This is where we do different things depending on the URL
                        case "/callback":
                            handled = HandleCallbackRequest(context, frm1, response);
                            break;
                    }

                    if (!handled)
                    {
                        response.StatusCode = 404;
                    }
                }
                catch (Exception e)
                {
                    //Return the exception details the client - you may or may not want to do this
                    response.StatusCode = 500;
                    response.ContentType = "application/json";

                    var buffer = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(e));
                    response.ContentLength64 = buffer.Length;
                    response.OutputStream.Write(buffer, 0, buffer.Length);

                    //TODO: Log the exception
                }
            }
        }

        private static bool HandleCallbackRequest(HttpListenerContext context, Form1 frm1, HttpListenerResponse response)
        {
            response.ContentType = "text/html";
            
            //Write it to the response stream
            var query = context.Request.Url.Query;
            var code = "";
            var state = "";

            if (query.Contains("?"))
            {
                query = query.Substring(query.IndexOf('?') + 1);
            }

            foreach (var vp in Regex.Split(query, "&"))
            {
                var singlePair = Regex.Split(vp, "=");

                if (singlePair.Length == 2)
                {
                    if (singlePair[0] == "code")
                    {
                        code = singlePair[1];
                        frm1.AuthorisationCode = code;
                    }

                    if (singlePair[0] == "state")
                    {
                        state = singlePair[1];
                        frm1.State = state;
                    }
                }
            }

            var buffer = Encoding.UTF8.GetBytes("Code = " + code + "<br />State = " + state);
            response.ContentLength64 = buffer.Length;
            response.OutputStream.Write(buffer, 0, buffer.Length);

            return true;
        }
    }
}

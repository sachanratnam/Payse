using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Payse
{
    public partial class Setup : Form
    {
        public string GoogleAuthorizationEndpoint { get; set; }
        public string GoogleTokenEndpoint { get; set; }
        public string GoogleUserInfoEndpoint { get; set; }

        public string StreamLabsauthorizationEndpoint { get; set; }
        public string StreamLabsTokenEndpoint { get; set; }
        public string StreamLabsRedirectURL { get; set; }

        public string StreamLabsClientID { get; set; }
        public string StreamLabsClientSecret { get; set; }
        public string StreamLabsAccessToken { get; set; }
        public string StreamLabsRefreshToken { get; set; }
        public DateTime StreamLabsAccessTokenExpireTime { get; set; }

        public string GoogleClientID { get; set; }
        public string GoogleClientSecret { get; set; }
        public string GoogleAccessToken { get; set; }
        public string GoogleRefreshToken { get; set; }
        public DateTime GoogleAccessTokenExpireTime { get; set; }

        public string UserEmail { get; set; }

        string code;
        string code_verifier;
        string redirectURI;
        string error;
        int SetupState = 0;

        public Setup()
        {
            InitializeComponent();
            InitializeEventsHandlers();
        }

        private void Setup_Load(object sender, EventArgs e)
        {
            ucEmailSetup1.BringToFront();
        }

        private void InitializeEventsHandlers()
        {
            PnlTitleBar.MouseMove += new MouseEventHandler(PnlTitleBar_MouseMove);
            ucEmailSetup1.MailLoginButtonClick += new EventHandler(UcEmailSetup_BtnMailLogin_Click);
            ucEmailSetupComplete1.MailSetupFinishButtonClick += new EventHandler(UcEmailSetupComplete_BtnMailSetupFinish_Click);
            ucStreamLabsSetup1.StreamLoginButtonClick += new EventHandler(UcStreamLabsSetup_BtnStreamLabsLogin_Click);
            ucStreamLabsCodeInput1.StreamLabsCodeVerifyButtonClick += new EventHandler(UcStreamLabsCodeInput_BtnStreamLabsCodeVerify_Click);
            ucSetupComplete1.SetupFinishButtonClick += new EventHandler(UsSetupComplete_BtnSetupFinish_Click);
        }

        private async void UcEmailSetup_BtnMailLogin_Click(object sender, EventArgs e)
        {
            int result;

            result = await PerformGoogleLogin();
            if (result != 0)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Starts the code exchange at the Token Endpoint.
            result = await PerformGoogleCodeExchange(code, code_verifier, redirectURI);
            if (result != 0)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            result = await GetUserEmail(GoogleAccessToken);
            if (result != 0)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SetupState = 1;
            BtnBack.Visible = true;
            ucEmailSetupComplete1.BringToFront();
            
            // Brings this app back to the foreground.
            this.Activate();
        }

        private void UcEmailSetupComplete_BtnMailSetupFinish_Click(object sender, EventArgs e)
        {
            ucStreamLabsSetup1.BringToFront();
        }

        private void UcStreamLabsSetup_BtnStreamLabsLogin_Click(object sender, EventArgs e)
        {
            PerformStreamLabsLogin();

            SetupState = 2;
            ucStreamLabsCodeInput1.TbStreamLabsCode.Text = "";
            ucStreamLabsCodeInput1.BringToFront();
        }

        private async void UcStreamLabsCodeInput_BtnStreamLabsCodeVerify_Click(object sender, EventArgs e)
        {
            int result;
            string code = ucStreamLabsCodeInput1.TbStreamLabsCode.Text;

            result = await PerformStreamLabsCodeExchange(code, StreamLabsRedirectURL);
            if (result != 0)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ucSetupComplete1.BringToFront();
        }

        private void UsSetupComplete_BtnSetupFinish_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async Task<int> PerformGoogleLogin()
        {
            try
            {
                // Generates state and PKCE values.
                string state = randomDataBase64url(32);
                code_verifier = randomDataBase64url(32);
                string code_challenge = base64urlencodeNoPadding(sha256(code_verifier));
                const string code_challenge_method = "S256";

                // Creates a redirect URI using an available port on the loopback address.
                redirectURI = string.Format("http://{0}:{1}/", IPAddress.Loopback, GetRandomUnusedPort());

                // Creates an HttpListener to listen for requests on that redirect URI.
                var http = new HttpListener();
                http.Prefixes.Add(redirectURI);
                http.Start();

                // Creates the OAuth 2.0 authorization request.
                string authorizationRequest = string.Format("{0}?response_type=code&scope=https%3A%2F%2Fmail.google.com%2F%20email&redirect_uri={1}&client_id={2}&state={3}&code_challenge={4}&code_challenge_method={5}",
                    GoogleAuthorizationEndpoint,
                    System.Uri.EscapeDataString(redirectURI),
                    GoogleClientID,
                    state,
                    code_challenge,
                    code_challenge_method);

                // Opens request in the browser.
                System.Diagnostics.Process.Start(authorizationRequest);

                // Waits for the OAuth authorization response.
                var context = await http.GetContextAsync();

                // Brings this app back to the foreground.
                //this.Activate();

                // Sends an HTTP response to the browser.
                var response = context.Response;
                string responseString = string.Format("<html><body>Please return to the app.</body></html>");
                var buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
                response.ContentLength64 = buffer.Length;
                var responseOutput = response.OutputStream;
                Task responseTask = responseOutput.WriteAsync(buffer, 0, buffer.Length).ContinueWith((task) =>
                {
                    responseOutput.Close();
                    http.Stop();
                    Console.WriteLine("HTTP server stopped.");
                });

                // Checks for errors.
                if (context.Request.QueryString.Get("error") != null)
                {
                    error = String.Format("OAuth authorization error: {0}.", context.Request.QueryString.Get("error"));
                    return 1;
                }
                if (context.Request.QueryString.Get("code") == null
                    || context.Request.QueryString.Get("state") == null)
                {
                    error = "Malformed authorization response. " + context.Request.QueryString;
                    return 2;
                }

                // extracts the code
                code = context.Request.QueryString.Get("code");
                var incoming_state = context.Request.QueryString.Get("state");

                // Compares the receieved state to the expected value, to ensure that
                // this app made the request which resulted in authorization.
                if (incoming_state != state)
                {
                    error = String.Format("Received request with invalid state ({0})", incoming_state);
                    return 3;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return 4;
            }

            return 0;
        }

        async Task<int> PerformGoogleCodeExchange(string code, string code_verifier, string redirectURI)
        {
            int result = -1;
            try
            {
                // builds the  request
                string tokenRequestBody = string.Format("code={0}&redirect_uri={1}&client_id={2}&code_verifier={3}&client_secret={4}&scope=&grant_type=authorization_code",
                    code,
                    System.Uri.EscapeDataString(redirectURI),
                    GoogleClientID,
                    code_verifier,
                    GoogleClientSecret
                    );

                // sends the request
                HttpWebRequest tokenRequest = (HttpWebRequest)WebRequest.Create(GoogleTokenEndpoint);
                tokenRequest.Method = "POST";
                tokenRequest.ContentType = "application/x-www-form-urlencoded";
                tokenRequest.Accept = "Accept=text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                byte[] _byteVersion = Encoding.ASCII.GetBytes(tokenRequestBody);
                tokenRequest.ContentLength = _byteVersion.Length;
                Stream stream = tokenRequest.GetRequestStream();
                await stream.WriteAsync(_byteVersion, 0, _byteVersion.Length);
                stream.Close();

                try
                {
                    // gets the response
                    WebResponse tokenResponse = await tokenRequest.GetResponseAsync();
                    using (StreamReader reader = new StreamReader(tokenResponse.GetResponseStream()))
                    {
                        // reads response body
                        string responseText = await reader.ReadToEndAsync();

                        // converts to dictionary
                        Dictionary<string, string> tokenEndpointDecoded = JsonConvert.DeserializeObject<Dictionary<string, string>>(responseText);

                        GoogleAccessToken = tokenEndpointDecoded["access_token"];
                        GoogleRefreshToken = tokenEndpointDecoded["refresh_token"];
                        int Expire_in = Convert.ToInt16(tokenEndpointDecoded["expires_in"]);
                        GoogleAccessTokenExpireTime = DateTime.Now.AddSeconds(Expire_in);
                        result = 0;
                    }
                }
                catch (WebException ex)
                {
                    result = 1;
                    error = ex.Message;

                    if (ex.Status == WebExceptionStatus.ProtocolError)
                    {
                        var response = ex.Response as HttpWebResponse;
                        if (response != null)
                        {
                            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                            {
                                // reads response body
                                string responseText = await reader.ReadToEndAsync();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result = 2;
                error = ex.Message;
            }

            return result;
        }

        async Task<int> GetUserEmail(string access_token)
        {
            try
            {
                // builds the  request
                HttpWebRequest userinfoRequest = (HttpWebRequest)WebRequest.Create(GoogleUserInfoEndpoint);
                userinfoRequest.Method = "GET";
                userinfoRequest.Headers.Add(string.Format("Authorization: Bearer {0}", access_token));
                userinfoRequest.ContentType = "application/x-www-form-urlencoded";
                userinfoRequest.Accept = "Accept=text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";

                // gets the response
                WebResponse userinfoResponse = await userinfoRequest.GetResponseAsync();
                using (StreamReader userinfoResponseReader = new StreamReader(userinfoResponse.GetResponseStream()))
                {
                    // reads response body
                    string userinfoResponseText = await userinfoResponseReader.ReadToEndAsync();

                    // converts to dictionary
                    Dictionary<string, string> userInfoDecoded = JsonConvert.DeserializeObject<Dictionary<string, string>>(userinfoResponseText);

                    UserEmail = userInfoDecoded["email"];
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return 1;
            }
            return 0;
        }

        private void PerformStreamLabsLogin()
        {
            string authorizationRequest = string.Format("{0}?response_type=code&scope=donations.create&redirect_uri={1}&client_id={2}",
                StreamLabsauthorizationEndpoint,
                System.Uri.EscapeDataString(StreamLabsRedirectURL),
                StreamLabsClientID);

            // Opens request in the browser.
            System.Diagnostics.Process.Start(authorizationRequest);
        }

        async Task<int> PerformStreamLabsCodeExchange(string code, string redirectURI)
        {
            int result = -1;
            try
            {

                // builds the  request
                string tokenRequestBody = string.Format("code={0}&redirect_uri={1}&client_id={2}&client_secret={3}&grant_type=authorization_code",
                    code,
                    System.Uri.EscapeDataString(redirectURI),
                    StreamLabsClientID,
                    StreamLabsClientSecret
                    );

                // sends the request
                HttpWebRequest tokenRequest = (HttpWebRequest)WebRequest.Create(StreamLabsTokenEndpoint);
                tokenRequest.Method = "POST";
                tokenRequest.ContentType = "application/x-www-form-urlencoded";
                tokenRequest.Accept = "Accept=text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                byte[] _byteVersion = Encoding.ASCII.GetBytes(tokenRequestBody);
                tokenRequest.ContentLength = _byteVersion.Length;
                Stream stream = tokenRequest.GetRequestStream();
                await stream.WriteAsync(_byteVersion, 0, _byteVersion.Length);
                stream.Close();

                try
                {
                    // gets the response
                    WebResponse tokenResponse = await tokenRequest.GetResponseAsync();
                    using (StreamReader reader = new StreamReader(tokenResponse.GetResponseStream()))
                    {
                        // reads response body
                        string responseText = await reader.ReadToEndAsync();

                        // converts to dictionary
                        Dictionary<string, string> tokenEndpointDecoded = JsonConvert.DeserializeObject<Dictionary<string, string>>(responseText);

                        StreamLabsAccessToken = tokenEndpointDecoded["access_token"];
                        StreamLabsRefreshToken = tokenEndpointDecoded["refresh_token"];
                        int Expire_in = Convert.ToInt16(tokenEndpointDecoded["expires_in"]);
                        StreamLabsAccessTokenExpireTime = DateTime.Now.AddSeconds(Expire_in);
                        result = 0;
                    }
                }
                catch (WebException ex)
                {
                    result = 1;
                    error = ex.Message;

                    if (ex.Status == WebExceptionStatus.ProtocolError)
                    {
                        var response = ex.Response as HttpWebResponse;
                        if (response != null)
                        {
                            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                            {
                                // reads response body
                                string responseText = await reader.ReadToEndAsync();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result = 2;
                error = ex.Message;
            }
            return result;
        }


        // ref http://stackoverflow.com/a/3978040
        public static int GetRandomUnusedPort()
        {
            var listener = new TcpListener(IPAddress.Loopback, 0);
            listener.Start();
            var port = ((IPEndPoint)listener.LocalEndpoint).Port;
            listener.Stop();
            return port;
        }

        public static string randomDataBase64url(uint length)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] bytes = new byte[length];
            rng.GetBytes(bytes);
            return base64urlencodeNoPadding(bytes);
        }

        public static byte[] sha256(string inputStirng)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(inputStirng);
            SHA256Managed sha256 = new SHA256Managed();
            return sha256.ComputeHash(bytes);
        }

        public static string base64urlencodeNoPadding(byte[] buffer)
        {
            string base64 = Convert.ToBase64String(buffer);

            // Converts base64 to base64url.
            base64 = base64.Replace("+", "-");
            base64 = base64.Replace("/", "_");
            // Strips padding.
            base64 = base64.Replace("=", "");

            return base64;
        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void PnlTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            SetupState--;

            if (SetupState == 0)
            {
                ucEmailSetup1.BringToFront();
                BtnBack.Visible = false;
            }
            else if (SetupState == 1)
            {
                ucStreamLabsSetup1.BringToFront();
            }
        }
    }
}

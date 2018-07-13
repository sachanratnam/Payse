//Icons made by Smashicons(https://www.flaticon.com/authors/smashicons) from Flaticon(https://www.flaticon.com)

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using Newtonsoft.Json;
using MailKit.Net.Imap;
using MailKit.Search;
using MailKit;
using MailKit.Security;
using System.Net.Http;

namespace Payse
{
    public partial class Dashboard : Form
    {
        const string GoogleClientID = "YOUR_GOOGLE_CLIENT_ID";
        const string GoogleClientSecret = "YOUR_GOOGLE_CLIENT_SECRET";

        const string StreamLabsClientID = "YOUR_STREAM_LABS_CLIENT_ID";
        const string StreamLabsClientSecret = "YOUR_STREAM_LABS_CLIENT_SECRET";

        const string StreamLabsRedirectURL = "YOUR_APP_STREAM_LABS_REDIRECT_URL";


        const string GoogleAuthorizationEndpoint = "https://accounts.google.com/o/oauth2/v2/auth";
        const string GoogleTokenEndpoint = "https://www.googleapis.com/oauth2/v4/token";
        const string GoogleUserInfoEndpoint = "https://www.googleapis.com/oauth2/v3/userinfo";

        const string StreamLabsauthorizationEndpoint = "https://streamlabs.com/api/v1.0/authorize";
        const string StreamLabsTokenEndpoint = "https://streamlabs.com/api/v1.0/token";

        const string FromEmailAddressForUser = "alerts@paytm.com";
        const string FromEmailAddressForMerchant = "no-reply@paytm.com";

        string StreamLabsAccessToken;
        string StreamLabsRefreshToken;
        string GoogleAccessToken;
        string GoogleRefreshToken;
        string UserEmail;

        DateTime SetupDate;
        DateTime StreamLabsAccessTokenExpireTime;
        DateTime GoogleAccessTokenExpireTime;

        private bool isStart;
        private CancellationTokenSource CancelToken;
        private int RefreshDelay;
        private int ReconnectDelay;
        private decimal ExchangeRate;

        HttpClient Http_client = new HttpClient();

        public Dashboard()
        {
            InitializeComponent();
            InitializeEventsHandlers();
            Http_client.BaseAddress = new Uri("https://streamlabs.com");
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            bool SetupComplete = Properties.Settings.Default.SetupComplete;
            if (!SetupComplete)
            {
                using (Setup Setupform = new Setup())
                {
                    Setupform.GoogleClientID = GoogleClientID;
                    Setupform.GoogleClientSecret = GoogleClientSecret;
                    Setupform.StreamLabsClientID = StreamLabsClientID;
                    Setupform.StreamLabsClientSecret = StreamLabsClientSecret;

                    Setupform.GoogleAuthorizationEndpoint = GoogleAuthorizationEndpoint;
                    Setupform.GoogleTokenEndpoint = GoogleTokenEndpoint;
                    Setupform.GoogleUserInfoEndpoint = GoogleUserInfoEndpoint;

                    Setupform.StreamLabsauthorizationEndpoint = StreamLabsauthorizationEndpoint;
                    Setupform.StreamLabsTokenEndpoint = StreamLabsTokenEndpoint;
                    Setupform.StreamLabsRedirectURL = StreamLabsRedirectURL;

                    var result = Setupform.ShowDialog();

                    if (result != DialogResult.OK)
                    {
                        Application.Exit();
                        return;
                    }

                    StreamLabsAccessToken = Setupform.StreamLabsAccessToken;
                    StreamLabsRefreshToken = Setupform.StreamLabsRefreshToken;
                    StreamLabsAccessTokenExpireTime = Setupform.StreamLabsAccessTokenExpireTime;
                    GoogleRefreshToken = Setupform.GoogleRefreshToken;
                    GoogleAccessToken = Setupform.GoogleAccessToken;
                    GoogleAccessTokenExpireTime = Setupform.GoogleAccessTokenExpireTime;
                    UserEmail = Setupform.UserEmail;
                }

                SetupDate = DateTime.Now;
                Properties.Settings.Default.StreamLabsAccessToken = StreamLabsAccessToken;
                Properties.Settings.Default.StreamLabsRefreshToken = StreamLabsRefreshToken;
                Properties.Settings.Default.StreamLabsAccessTokenExpireTime = StreamLabsAccessTokenExpireTime;
                Properties.Settings.Default.GoogleAccessToken = GoogleAccessToken;
                Properties.Settings.Default.GoogleRefreshToken = GoogleRefreshToken;
                Properties.Settings.Default.GoogleAccessTokenExpireTime = GoogleAccessTokenExpireTime;
                Properties.Settings.Default.UserEmail = UserEmail;
                Properties.Settings.Default.SetupDate = SetupDate;
                Properties.Settings.Default.SetupComplete = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                StreamLabsAccessToken = Properties.Settings.Default.StreamLabsAccessToken;
                StreamLabsRefreshToken = Properties.Settings.Default.StreamLabsRefreshToken;
                StreamLabsAccessTokenExpireTime = Properties.Settings.Default.StreamLabsAccessTokenExpireTime;
                GoogleAccessToken = Properties.Settings.Default.GoogleAccessToken;
                GoogleRefreshToken = Properties.Settings.Default.GoogleRefreshToken;
                GoogleAccessTokenExpireTime = Properties.Settings.Default.GoogleAccessTokenExpireTime;
                UserEmail = Properties.Settings.Default.UserEmail;
                SetupDate = Properties.Settings.Default.SetupDate;
            }

            RefreshDelay = Properties.Settings.Default.RefreshDelay;
            ReconnectDelay = Properties.Settings.Default.ReconnectDelay;
            ExchangeRate = Properties.Settings.Default.ExchangeRate;

            ucSettings1.TrkBarRefreshDelay.Value = RefreshDelay / 5;
            ucSettings1.TrkBarReconnectDelay.Value = ReconnectDelay / 30;
            ucSettings1.NumUDExchangeRate.Value = ExchangeRate;

            ucSettings1.LblRefreshValue.Text = RefreshDelay.ToString() + "s";
            if (ReconnectDelay == 0)
                ucSettings1.LblReconnectValue.Text = "Never";
            else
                ucSettings1.LblReconnectValue.Text = ReconnectDelay.ToString() + "s";
        }

        private void InitializeEventsHandlers()
        {
            PnlTitleBar.MouseMove += new MouseEventHandler(PnlTitleBar_MouseMove);
            ucHome1.StartButtonClick += new EventHandler(UcHome_BtnStart_Click);
            ucSettings1.SaveButtonClick += new EventHandler(UcSettings_BtnSave_Click);
            ucSettings1.ResetButtonClick += new EventHandler(UcSettings_BtnReset_Click);
        }

        private void UcHome_BtnStart_Click(object sender, EventArgs e)
        {
            if (isStart == false)
            {
                isStart = true;
                ucHome1.PicBoxStatus.Image = Properties.Resources.active;
                ucHome1.LblStatus.Text = "Active";
                ucHome1.TbError.Text = "";
                ucHome1.TbError.Visible = false;
                ucHome1.BtnStart.Text = "STOP";

                ucSettings1.TrkBarRefreshDelay.Enabled = false;
                ucSettings1.TrkBarReconnectDelay.Enabled = false;
                ucSettings1.NumUDExchangeRate.Enabled = false;
                ucSettings1.BtnReset.Enabled = false;
                ucSettings1.BtnSave.Enabled = false;

                CancelToken = new CancellationTokenSource();
                BackgroundWorker1.RunWorkerAsync();
            }
            else
            {
                ucHome1.BtnStart.Text = "PLEASE WAIT";
                BackgroundWorker1.CancelAsync();
                CancelToken.Cancel();
            }
        }

        private void UcSettings_BtnSave_Click(object sender, EventArgs e)
        {
            RefreshDelay = ucSettings1.TrkBarRefreshDelay.Value * 5;
            ReconnectDelay = ucSettings1.TrkBarReconnectDelay.Value * 30;
            ExchangeRate = ucSettings1.NumUDExchangeRate.Value;

            Properties.Settings.Default.RefreshDelay = RefreshDelay;
            Properties.Settings.Default.ReconnectDelay = ReconnectDelay;
            Properties.Settings.Default.ExchangeRate = ExchangeRate;
            Properties.Settings.Default.Save();
        }

        private void UcSettings_BtnReset_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("After resetting you have to reconnect your accounts. Do you want to continue?", "Reset Application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                Properties.Settings.Default.SetupComplete = false;
                Properties.Settings.Default.Save();

                MessageBox.Show("Application has been reset successfully and will exit now. Please relaunch the application to continue.", "Reset Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            PnlButtonBar.Top = BtnHome.Top;
            ucHome1.BringToFront();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            PnlButtonBar.Top = BtnSettings.Top;
            ucSettings1.BringToFront();
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            PnlButtonBar.Top = BtnAbout.Top;
            ucAbout1.BringToFront();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if(isStart == false)
                Application.Exit();
            else
                MessageBox.Show("Please stop the application first", "Exit Application", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            isStart = false;
            ucHome1.BtnStart.Text = "START";
            ucHome1.LblStatus.Text = "Inactive";
            ucHome1.PicBoxStatus.Image = Properties.Resources.inactive;
            ucSettings1.TrkBarRefreshDelay.Enabled = true;
            ucSettings1.TrkBarReconnectDelay.Enabled = true;
            ucSettings1.NumUDExchangeRate.Enabled = true;
            ucSettings1.BtnReset.Enabled = true;
            ucSettings1.BtnSave.Enabled = true;

            // There was an error during the operation.
            if (e.Error != null)
                ucHome1.TbError.Text = e.Error.Message;
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = sender as BackgroundWorker;

            Monitor(bw, RefreshDelay, ReconnectDelay, CancelToken.Token);
            if (bw.CancellationPending)
                e.Cancel = true;
        }

        private void Monitor(BackgroundWorker bw, int sleepPeriod, int reconnectPeriod, CancellationToken token)
        {
            while (!bw.CancellationPending)
            {
                try
                {
                    while (!bw.CancellationPending)
                    {
                        if (GoogleAccessTokenExpireTime < DateTime.Now)
                        {
                            RefreshTokenFromGoogle();
                        }
                        else
                        {
                            using (var client = new ImapClient())
                            {
                                // For demo-purposes, accept all SSL certificates
                                client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                                client.Connect("imap.gmail.com", 993, true);
                                var oauth2 = new SaslMechanismOAuth2(UserEmail, GoogleAccessToken);
                                client.Authenticate(oauth2);

                                var inbox = client.Inbox;
                                inbox.Open(FolderAccess.ReadWrite);

                                var query = SearchQuery.DeliveredAfter(SetupDate).And(SearchQuery.FromContains(FromEmailAddressForUser).Or(SearchQuery.FromContains(FromEmailAddressForMerchant))).And(SearchQuery.NotSeen);
                                foreach (var uid in inbox.Search(query))
                                {
                                    var message = inbox.GetMessage(uid);
                                    PostDonation(((MimeKit.MailboxAddress)message.From[0]).Address, message.Subject);
                                    inbox.AddFlags(uid, MessageFlags.Seen, true);

                                    if (bw.CancellationPending)
                                        break;

                                }
                                client.Disconnect(true);

                                this.Invoke(new MethodInvoker(delegate {
                                    ucHome1.TbError.Text = "";
                                    ucHome1.TbError.Visible = false;
                                }));

                                if (bw.CancellationPending)
                                    break;

                                var cancelled = token.WaitHandle.WaitOne(sleepPeriod * 1000);
                                if (cancelled)
                                    break;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    this.Invoke(new MethodInvoker(delegate {
                        ucHome1.TbError.Text = ex.Message;
                        ucHome1.TbError.Visible = true;
                    }));

                    if (reconnectPeriod == 0)
                        break;
                    else
                    {
                        this.Invoke(new MethodInvoker(delegate {
                            ucHome1.TbError.Text += "; Waiting for retry..";
                        }));

                        var cancelled = token.WaitHandle.WaitOne(reconnectPeriod * 1000);
                        if (cancelled)
                            break;
                    }
                }

                if (bw.CancellationPending)
                    break;
            }
        }

        private int PostDonation(String email_from, String subject)
        {
            string name;
            string amount_inr;

            if (email_from == FromEmailAddressForUser)
            {
                try
                {
                    int sub_index1 = subject.IndexOf("from ");
                    int sub_index2 = subject.IndexOf("Rs.");
                    int sub_index3 = subject.IndexOf(" from");

                    if (sub_index1 < 0 || sub_index2 < 0 || sub_index3 < 0)
                        return 1;

                    sub_index1 += 5;
                    sub_index2 += 3;
                    sub_index3 -= sub_index2;

                    name = subject.Substring(sub_index1);
                    amount_inr = subject.Substring(sub_index2, sub_index3);
                }
                catch (Exception)
                {
                    return 1;
                }
            }
            else if (email_from == FromEmailAddressForMerchant)
            {
                try
                {
                    int sub_index1 = subject.IndexOf("by ");
                    int sub_index2 = subject.IndexOf(" at");

                    int sub_index3 = subject.IndexOf("Rs. ");
                    int sub_index4 = subject.IndexOf(" paid");

                    if (sub_index1 < 0 || sub_index2 < 0 || sub_index3 < 0 || sub_index4 < 0)
                        return 1;

                    sub_index1 += 3;
                    sub_index2 -= sub_index1;
                    sub_index3 += 4;
                    sub_index4 -= sub_index3;

                    name = subject.Substring(sub_index1, sub_index2);
                    amount_inr = subject.Substring(sub_index3, sub_index4);
                }
                catch (Exception)
                {
                    return 1;
                }
            }
            else
                return 1;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(amount_inr))
                return 1;

            name = name.Replace(" ", "_");
            decimal amount = Convert.ToDecimal(amount_inr) / ExchangeRate;
            
            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("name", name),
                new KeyValuePair<string, string>("identifier", name + "_payse"),
                new KeyValuePair<string, string>("message", "Received Rs." + amount_inr + " on PayTm"),
                new KeyValuePair<string, string>("amount", amount.ToString("0.##")),
                new KeyValuePair<string, string>("currency", "USD"),
                new KeyValuePair<string, string>("access_token", StreamLabsAccessToken)
            });

            var result = Http_client.PostAsync("/api/v1.0/donations", content).Result;

            if (result.IsSuccessStatusCode)
                return 0;
            else
                throw new Exception("Error in posting donation to StreamLabs");
        }

        private void RefreshTokenFromGoogle()
        {
            // builds the  request
            string tokenRequestBody = string.Format("client_id={0}&client_secret={1}&refresh_token={2}&grant_type=refresh_token",
                GoogleClientID,
                GoogleClientSecret,
                GoogleRefreshToken);

            // sends the request
            HttpWebRequest tokenRequest = (HttpWebRequest)WebRequest.Create(GoogleTokenEndpoint);
            tokenRequest.Method = "POST";
            tokenRequest.ContentType = "application/x-www-form-urlencoded";
            tokenRequest.Accept = "Accept=text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            byte[] _byteVersion = Encoding.ASCII.GetBytes(tokenRequestBody);
            tokenRequest.ContentLength = _byteVersion.Length;
            Stream stream = tokenRequest.GetRequestStream();
            stream.Write(_byteVersion, 0, _byteVersion.Length);
            stream.Close();

            // gets the response
            WebResponse tokenResponse = tokenRequest.GetResponseAsync().Result;
            using (StreamReader reader = new StreamReader(tokenResponse.GetResponseStream()))
            {
                // reads response body
                string responseText = reader.ReadToEndAsync().Result;

                // converts to dictionary
                Dictionary<string, string> tokenEndpointDecoded = JsonConvert.DeserializeObject<Dictionary<string, string>>(responseText);

                GoogleAccessToken = tokenEndpointDecoded["access_token"];
                int Expire_in = Convert.ToInt16(tokenEndpointDecoded["expires_in"]);
                GoogleAccessTokenExpireTime = DateTime.Now.AddSeconds(Expire_in);
            }
            
            Properties.Settings.Default.GoogleAccessToken = GoogleAccessToken;
            Properties.Settings.Default.GoogleAccessTokenExpireTime = GoogleAccessTokenExpireTime;
            Properties.Settings.Default.Save();
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

        
    }
}

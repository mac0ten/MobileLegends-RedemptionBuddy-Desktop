using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net;

namespace RedemptionBuddyDesktopVersion
{
    public partial class FacebookGrabber : Form
    {
        Form1 frm1;

        private static readonly HttpClient client = new HttpClient();
        User[] users;
        public FacebookGrabber(Form1 frm)
        {
            frm1 = frm;
            InitializeComponent();
        }
        public FacebookGrabber()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            web.Show();
            web.Navigate(txtURL.Text);
        }

        private void btnGrab_Click(object sender, EventArgs e)
        {
            try
            {
                HtmlElementCollection elemCol = web.Document.GetElementsByTagName("span");
                List<String> listUIDs = new List<string>();

                foreach (HtmlElement link in elemCol)
                {
                    if (link.GetAttribute("className") == txtElement.Text)
                    {

                        var stripped = Regex.Replace(link.InnerText, "[^0-9 ]", "");

                        string[] fresult = stripped.Split(' ');
                        if (fresult[0].Length > 2 && fresult[1].Length > 2)
                        {
                            listUIDs.Add("[" + fresult[0] + "] = [" + fresult[1] + "]");


                        }
                    }
                }

                DialogResult dr = MessageBox.Show("Transfer to RedemptionBuddy all Users!", "Transfer?", MessageBoxButtons.YesNo, MessageBoxIcon.Information, 0);
                if (dr == DialogResult.Yes)
                {
                    foreach (string s in listUIDs)
                    {
                        frm1.lstUsers.Items.Add(s);
                    }

                }
                this.Hide();
            }catch(Exception ee) { MessageBox.Show(ee.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error, 0); }
        }

        private void FacebookGrabber_Load(object sender, EventArgs e)
        {
            txtURL.Text = Properties.Settings.Default.url;
            txtElement.Text = Properties.Settings.Default.element;
            cmbEvents.SelectedIndex = 0;
        }

        private void FacebookGrabber_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.url = txtURL.Text;
            Properties.Settings.Default.element = txtElement.Text;
            Properties.Settings.Default.Save();
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button== MouseButtons.Right) { boostContextMenu.Show(MousePosition); }
        }

        private void boostContextMenu_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void btnBoostAdd_Click(object sender, EventArgs e)
        {
            string uidsid = Interaction.InputBox("Enter userid serverid : [example] 42342342 3030", "Add user to boost!", "23971296 3030", -1, -1);
            lstUsersToBoost.Items.Add(uidsid);

        }

        async Task<Login> login(User user)
        {

            var values = new Dictionary<string, string>
            {
            { "type", "mobile" },
            { "group_id", user.sid},
            { "support_type", user.supportType },
            { "user_id",  user.uid},
            { "cdk",  ""},
            { "randomNumber", "0undefined20547516039433145"}
            };

            var content = new FormUrlEncodedContent(values);
            try
            {
                var response = await client.PostAsync("https://eventapi.mobilelegends.com/comm_activity_api/Login", content);
                var responseString = await response.Content.ReadAsStringAsync();
                Login login = JsonConvert.DeserializeObject<Login>(responseString);
                user.code = login.code;
                user.msg = login.message;
                return login;
            }
            catch (Exception e)
            {
                user.code = "201";
                user.msg = e.Message;
                return new Login();
            }


        }
        public string random = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public Random rnd = new Random();
        async Task<SendVc> bindUser(Login login, User usr)
        {
            
            var stringChars = new char[28];

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = random[rnd.Next(random.Length)];
            }
            string finalRandom = new String(stringChars);
            Console.WriteLine("Random number is " + finalRandom);
            var values = new Dictionary<string, string>
            {
            { "user_id", usr.uid },
            { "support_type", "AmazonSecound"},
            { "group_id",  usr.sid},
            { "token",  login.tocken},
            { "amazon_id",  "amzn1.account." + finalRandom.ToUpper()},
            { "amazon_email",  "🐱‍👤MLMoLo🐱‍👤@ph.com"},
            { "amazon_token", "Atza|IwEBIORtq7WHWpQ5-zJcD_BH4k6F7j2VFWntVln1z4N38mC4_sGpzTvk8vQYgQ1IkRrv-_PON2tUkmz7CnJI6PhOdjWzunf-x0hHdztifYaWBOHs5leoE55nqAT3wkgEe_uvdRdi2uaf43QLu9Fwt3hB7IwIbREjo_rxHQaxEIE9_HJsh-KiPgbCQriHg_RLNb0Dnc7tfVrHS695UwNzKd-HvmpAfoBUpYae-LPKkC0RMOch1HTxsvmSIoWWkymEf6Aq0TQRJDldvibMVSwvby-Wmx_vsD1zVMx3k2z4X4VAIvm5MJfXwIIHVM8HvWmbcWwjBXNw-BVa-YSoJT8ewItwDIwqmdcZ7bTzwJ6RvbTJDclHvN6u6b3Y8OrjbfC-HIYRGGZC5E2ODOdXfvPjJMI2PobDS7hhBxO5blGsaZSU-PfHFJHdRfuycBhVX4gwe2DRjAxfTIvRkoyJXXTrWQrA8SQAhqaRP-8aJ7RcUA0eoL7S5WFQ5fU283sjzqOGIQoclMbeDn6IRbc_WJTS42SeHV0LJ5bTEaqdk19dopD3DuAGPOEMTqhpCKZnpNQ3vYG5N__z6dgzeCvp2m0Sc-o7LddG"}
            };
            var content = new FormUrlEncodedContent(values);
            try
            {
                var response = await client.PostAsync("https://eventapi.mobilelegends.com/comm_activity_api/addAmazonSecoundRelatedAccount", content);
                var responseString = await response.Content.ReadAsStringAsync();
                SendVc result = JsonConvert.DeserializeObject<SendVc>(responseString);

                Console.WriteLine("Binding Account!");
                
                return result;
            }
            catch (Exception e)
            {
                SendVc svc = new SendVc();
                svc.code = "999";
                svc.code = e.Message;
                return svc;
            }


        }

        async Task<SendVc> eventboost(Login login,User usr)
        {

            var values = new Dictionary<string, string>
            {
            { "amazontoken", "Atza|IwEBID6AwpRNEA8nPd1pOZwO4GODFloyLQX8gpmCaC_h-_HIzXlX3ClBP3H_MZSgeKLX_viCv2rHTNsGl6bAP9UrvTGrodR5USUXSfHvS64zMSUpY2kfYPGoKm6uS62KWFslK1ZfvtR-DhmyArVCgugv7QvQtcjKOymqKr8Ya6esbAYoqy8qTTaXmfk7tswT3bq6T4viFdcPR9mfrcTzeCpuuKS3sdyrpUcsmPt2PBgAQ_aveu5eOkdl5LgRWR0KjKhFL1Xn-U8F3oyFMTIOlSj_udE1PK-RpchItAneR9bMXaUfUTLoA2zbrLwOH5tcAxKuJWJvFrEyAuvp-U-JhxfpDePJrsA_3dzi7CGEX6rA9Tz0OWeApdptEddhn0YuCQQ0SPcEalw-0AO6NqvnaVDyZOFowuNzJ0ugwkdraDFPw5FdZZoZARIBwCpM8gc5-WWWwfdXrxdhnTAGIGk_dbGrwFK-UbAskyGlWyAqBRomr8e0hNTwZfWAXfPF7h1dVWhevJAIbC9vwfOdKgfviM_J2p8_Y9FXCDj4dz1kqFdpzkenO_VSqS_UN6QVVWAlyYm2yZ7XxXLlUPhAgqkiQu8ucCOp" },
            { "support_type", usr.supportType},
            { "token",  login.tocken},
            { "group_id",  usr.sid},
            { "user_id",  usr.uid},
            { "type",  "1"},
            { "randomNumber", "0undefined20547516039433145"}
            };

            var content = new FormUrlEncodedContent(values);
            try
            {
                var response = await client.PostAsync("https://eventapi.mobilelegends.com/comm_activity_api/exchangeAmazonSecoundReward", content);
                var responseString = await response.Content.ReadAsStringAsync();
                SendVc result = JsonConvert.DeserializeObject<SendVc>(responseString);
                switch (result.code)
                {
                    case "200":
                        result.message = "Amazon Claimed Successful!";
                        break;
                    case "508":
                        result.message = "Players have received!";
                        break;
                    case "1003":
                        result.message = "The role does not exist";
                        break;

                    case "410":
                        result.message = "The player has no account";
                        break;
                }
                return result;
            }
            catch (Exception e)
            {
                SendVc svc = new SendVc();
                svc.code = "999";
                svc.code = e.Message;
                return svc;
            }


        }
        HttpClient http;
        private async void cookie()
        {
            var baseAddress = new Uri("https://na.account.amazon.com/ap/oa?arb=eda80c02-3e6e-4e45-a277-3cbbed7ad065");
            var cookieContainer = new CookieContainer();
            using (var handler = new HttpClientHandler() { CookieContainer = cookieContainer })
            using (var client = new HttpClient(handler) { BaseAddress = baseAddress })
            {
                var content = new FormUrlEncodedContent(new[]
                {
                new KeyValuePair<string, string>("foo", "bar"),
                });
                cookieContainer.Add(baseAddress, new Cookie("_fbp", "fb.1.1586357523038.1024751849"));
                cookieContainer.Add(baseAddress, new Cookie("_mkto_trk", "id:365-EFI-026&token:_mch-amazon.com-1586357522007-88986"));
                cookieContainer.Add(baseAddress, new Cookie("AMCV_4A8581745834114C0A495E2B%40AdobeOrg", "-432600572%7CMCIDTS%7C18361%7CMCMID%7C50723630527259637713024105408749471231%7CMCAAMLH-1586970947%7C3%7CMCAAMB-1586970947%7CRKhpRz8krg2tLO6pguXWp5olkAcUniQYPHaMWWgdJ3xzPWQmdj0y%7CMCOPTOUT-1586373348s%7CNONE%7CMCAID%7CNONE%7CvVersion%7C4.5.2"));
                cookieContainer.Add(baseAddress, new Cookie("AMCVS_4A8581745834114C0A495E2B%40AdobeOrg", "1"));
                cookieContainer.Add(baseAddress, new Cookie("appstore-devportal-locale", "en_US"));
                cookieContainer.Add(baseAddress, new Cookie("at_check", "true"));
                cookieContainer.Add(baseAddress, new Cookie("at-lwana", "Atza|IwEBIN_w3NRP4RWpMWLNY8QJYJ0hjF9XmD10kGB7cMWD36F8_yCu6sgpw6nQWLYnchP_ATKgR04wy21QdHIfvocZcZyizihLOgihjgSpDJfuYqZPS1a33HmcnLSk1OpnLgj3q140lTSzfs1WV3ljz5gTed_bIlD2p3PbwTG8yp0x8Jtd81wP4BStIQs4F_D_s3sWdo0iX2KFUzHWklGE4havgj-kAGpdMbnMuDG7IDMrTr21l9m9TpXd4O6wVYV6PLpE2LNkJko3jTrHyjOjuPcEBR0a2yDNypCD3O6Ukx5ljdMLM5vDAl4_aNSFoZfq_9cuqwbnkRYTL5QOitoiu0MWDVWErLE5d7lmGWMTDRmTTjzwLPDGJFSRg9oFZwl4QOWmtMThAH_zt0bJb2L4IbEfDCXlQRig_GO1Jcbhjoe3FI_iDQ"));
                cookieContainer.Add(baseAddress, new Cookie("csm-hit", "tb:NNZA13W45Q84TWHKKEM7+s-NNZA13W45Q84TWHKKEM7|1586371878097&t:1586371878098&adb:adblk_no"));
                cookieContainer.Add(baseAddress, new Cookie("i18n-prefs", "USD"));
                cookieContainer.Add(baseAddress, new Cookie("lwa-context", "c34eee0ed0ae137ad423c6fe5583be35"));
                cookieContainer.Add(baseAddress, new Cookie("mbox", "PC#cfdb8f4877a04619a44fa2e82347d878.32_0#1649611270|session#6c87c7d8311f4dd7985b2b99f37521f8#1586368007"));
                cookieContainer.Add(baseAddress, new Cookie("s_cc", "true"));
                cookieContainer.Add(baseAddress, new Cookie("s_lv", "1586366472142"));
                cookieContainer.Add(baseAddress, new Cookie("s_nr", "1586366472140-Repeat"));
                cookieContainer.Add(baseAddress, new Cookie("session-id", "133-9886644-2546929"));
                cookieContainer.Add(baseAddress, new Cookie("session-id-lwana", "141-4324340-3043811"));
                cookieContainer.Add(baseAddress, new Cookie("session-id-time", "2217091882l"));
                cookieContainer.Add(baseAddress, new Cookie("session-id-time-lwana", "2217091883l"));
                cookieContainer.Add(baseAddress, new Cookie("session-token", "zErR3erdRoUgGE5GiJYCsUYzHQfzNfVaXbxQ30Tb8UrAZZ5tDl/1o2fpEZdVYB+IyTJmVm/nWTYdQ8Grpwb/60gfxpVkslqF1imRBfyl8GYE9gYP1XUtA0/tAg2v9yJ/PjBUmXgdl3jcHgLUK8ui4nLO+NwP+lUNTJ2BTYyqVZrJDyFeA9AkAycOVma3r/dP0SJl1OL31+RLtY4UPIUsTi/WHRWnsLzC"));
                cookieContainer.Add(baseAddress, new Cookie("skin", "noskin"));
                cookieContainer.Add(baseAddress, new Cookie("sp-cdn", "\"L5Z9: PH\""));
                cookieContainer.Add(baseAddress, new Cookie("ubid-lwana", "132-8338224-0791405"));
                cookieContainer.Add(baseAddress, new Cookie("ubid-main", "130-6566393-3522508"));
                cookieContainer.Add(baseAddress, new Cookie("x-lwana", "\"6O40MG4wCqHhrw9W0@P@5T351AoYu2keASRn2B9jHn@iG38N5zeO9R81cJYZFCI7\""));
                var result = await client.PostAsync("https://na.account.amazon.com/ap/oa?arb=eda80c02-3e6e-4e45-a277-3cbbed7ad065", content);
                result.EnsureSuccessStatusCode();
            }

        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            cookie();   
            //users = new User[lstUsersToBoost.Items.Count];
            //lstResults.Items.Clear();
            //foreach (string s in lstUsersToBoost.Items) lstResults.Items.Add("");
            //Console.WriteLine(users.Length);
            //for (int i = 0; i < lstUsersToBoost.Items.Count; i++)
            //{
            //    users[i] = new User();
            //    string s = lstUsersToBoost.GetItemText(lstUsersToBoost.Items[i]);
            //    string[] ss = s.Split(' ');
            //    Console.WriteLine(ss[0] + " " + ss[1]);
            //    users[i].sid = ss[1];
            //    users[i].uid = ss[0];
            //    Login result = await login(users[i]);
            //    //lstUsersToBoost.Items[i] = result.code;
            //    if (result.code == "200")
            //    {

            //        SendVc amazonResult = await eventboost(result,users[i]);
            //        //lstUsersToBoost.Items[i] = result.code;
            //        if (amazonResult.code == "410") {
            //            SendVc resultBind = await bindUser(result, users[i]);
            //            if (resultBind.code == "200")
            //            {
            //                amazonResult = await eventboost(result, users[i]);
            //            }else
            //            {
            //                amazonResult = await eventboost(result, users[i]);
            //            }
            //        }
            //        lstResults.Items[i] = (users[i].uid + " " + users[i].sid + " Claim Status : [" + amazonResult.code + "] " + amazonResult.message);


            //    }

            //}
        }

    }
}

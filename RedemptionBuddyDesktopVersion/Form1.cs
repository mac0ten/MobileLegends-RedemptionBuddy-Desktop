using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace RedemptionBuddyDesktopVersion
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private User user;
        private bool update = false;
        private int updateIndex = -1;
        private bool updateCode = false;
        private int updateCodeIndex = -1;
        private bool autostop = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUser.Text = Properties.Settings.Default.uid;
            txtCode.Text = Properties.Settings.Default.code;
            txtVc.Text = Properties.Settings.Default.vc;
            try
            {
                List<String> lst1 = new List<String>(Properties.Settings.Default.lstUsers.Count);
                if (lst1.Count > 0)
                {

                    foreach (string i in lst1)
                    {
                        lstUsers.Items.Add(i);
                    }
                }
                List<String> lst2 = new List<String>(Properties.Settings.Default.lstCodes.Count);
                if (lst2.Count > 0)
                {

                    foreach (string i in lst2)
                    {
                        lstCodes.Items.Add(i);
                    }
                }
               
            }
            catch (Exception ee) { Console.Write(ee.Message); }
        }

        private void btnSendVc_Click(object sender, EventArgs e)
        {
            sendVc();
        }

        private string CleanString(string str) {
            return str.Replace(" ", "").Trim();
        }
        public async void sendVc()
        {
            user = new User();
            user.uid = CleanString(txtUser.Text);


            var values = new Dictionary<string, string>
            {
            { "gameid", user.uid },
            { "language", "en" },
            { "captcha", "" }
            };

            var content = new FormUrlEncodedContent(values);
            try
            {
                var response = await client.PostAsync("https://mapi.mobilelegends.com/api/sendmail", content);
                var responseString = await response.Content.ReadAsStringAsync();
                SendVc ts = JsonConvert.DeserializeObject<SendVc>(responseString);
                ts.code = (ts.code == null) ? "200" : ts.code;
                
                lstHistory.Items.Add(combineResult(ts,user,true));
            }
            catch (Exception e) { MessageBox.Show(e.Message, "Internet Connection Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);  }
            

        }
        public async void redeemCode()
        {
            user = new User();
            
            //Split User List Selected 
            string selectedUser = lstUsers.GetItemText(lstUsers.SelectedItem);
            selectedUser = selectedUser.Replace("[", "").Replace("]", "").Replace(" ", "");
            string[] stripped = selectedUser.Split('=');
            user.uid = CleanString(stripped[0]);
            user.vc = stripped[1];
            user.code = lstCodes.GetItemText(lstCodes.SelectedIndex);

            var values = new Dictionary<string, string>
            {
            { "gameid", user.uid },
            { "language", "en" },
            { "captcha", "" },
            { "redeemcode",  user.code},
            { "vcode", user.vc}
            };

            var content = new FormUrlEncodedContent(values);
            try
            {
                var response = await client.PostAsync("https://mapi.mobilelegends.com/api/sendredeem", content);
                var responseString = await response.Content.ReadAsStringAsync();
                SendVc ts = JsonConvert.DeserializeObject<SendVc>(responseString);
                ts.code = (ts.code == null) ? "2000" : ts.code;

                lstHistory.Items.Add(combineResult(ts, user,false));
            }
            catch (Exception e) { MessageBox.Show(e.Message, "Internet Connection Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }


        }

        private void clearUserForm()
        {
            txtUser.Clear();
            txtVc.Clear();
        }
        private void clearCodeForm()
        {
            txtCode.Clear();
        }
        private string combineResult(SendVc result,User user,bool sendVc)
        {
            string tmp = " [" + user.uid + "] "+((sendVc)?"":user.code)+ ((sendVc)?" Sending Status": " Redeeming Status" ) + " : [" +result.code+"] "+ resultColors(true, result); ;

            return tmp;
        }
        private string resultColors(bool sendvc ,SendVc result)
        {
            if (sendvc)
            {

                string resultmsg = result.message;
                switch (result.code)
                {
                    case "200":
                        resultmsg = "Verification Code Sent!";
                        break;

                    case "201":
                        resultmsg = "Sending too frequently, please try again in a minute";
                        break;

                }
                lblStatus.ForeColor = (result.code=="200") ? System.Drawing.Color.LightGreen : System.Drawing.Color.Red;
                lblStatus.Text = resultmsg;
                return resultmsg;
            } else
            {
                string resultmsg = result.message;
                
                return resultmsg;

            }

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {

           
            if (txtUser.TextLength>0 && txtVc.TextLength > 0 && !update)
            {
                lstUsers.Items.Add("["+txtUser.Text + "] = [" + txtVc.Text+"]");
                txtVc.Text = "";
                txtUser.Text = "";
            }else if(lstUsers.SelectedItems.Count > 0 && update && updateIndex>-1) {
                lstUsers.Items[updateIndex] = "[" + txtUser.Text + "] = [" + txtVc.Text + "]";
                update = false;
                updateIndex = -1;
                lstUsers.ClearSelected();
               
                btnAddUser.Text = "Add User";
            }

            clearUserForm();

        }

        private void lstUsers_SizeChanged(object sender, EventArgs e)
        {
            lblUsersSize.Text = lstUsers.Items.Count.ToString();
        }

        private void btnAddCode_Click(object sender, EventArgs e)
        {
            
            if (txtCode.TextLength > 0 && !updateCode) {
                lstCodes.Items.Add(txtCode.Text);
            }
            else if (lstCodes.SelectedItems.Count > 0 && updateCode && updateCodeIndex > -1)
            {
                lstCodes.Items[updateCodeIndex] = txtCode.Text;
                updateCode = false;
                updateCodeIndex = -1;
                lstCodes.ClearSelected();
                
                btnAddCode.Text = "Add Code";
            }
            clearCodeForm();
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstUsers_MouseDown(object sender, MouseEventArgs e)
        {
            if (lstUsers.SelectedItems.Count > 0)
            {
                userRemove.Visible = true;
                userEdit.Visible = true;
            } else
            {
                userRemove.Visible = false;
                userEdit.Visible = false;

            }
            if (e.Button == MouseButtons.Right) { usersContextMenu.Show(MousePosition); }
        }

        private void userRemove_Click(object sender, EventArgs e)
        {
            lstUsers.Items.RemoveAt(lstUsers.SelectedIndex);
        }

        private void userEdit_Click(object sender, EventArgs e)
        {
            update = true;
            updateIndex = lstUsers.SelectedIndex;
            string selectedUser = lstUsers.GetItemText(lstUsers.SelectedItem);
            selectedUser = selectedUser.Replace("[", "").Replace("]","").Replace(" ","");
            string[] stripped = selectedUser.Split('=');

            Console.WriteLine(selectedUser);
            txtUser.Text = stripped[0];
            txtVc.Text = stripped[1];

            btnAddUser.Text = "Update!";
        }

        private void userClear_Click(object sender, EventArgs e)
        {
            lstUsers.Items.Clear();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lstCodes.Items.RemoveAt(lstCodes.SelectedIndex);
        }

        private void codeClear_Click(object sender, EventArgs e)
        {
            lstCodes.Items.Clear();
        }

        private void codeEdit_Click(object sender, EventArgs e)
        {
            updateCode = true;
            updateCodeIndex = lstCodes.SelectedIndex;
            string selectedCode = lstCodes.GetItemText(lstCodes.SelectedItem);
            selectedCode = selectedCode.Replace("[", "").Replace("]", "").Replace(" ", "");
            txtCode.Text = selectedCode;
            btnAddCode.Text = "Update!";
        }

        private void lstCodes_MouseDown(object sender, MouseEventArgs e)
        {
            if (lstUsers.SelectedItems.Count > 0 && lstCodes.SelectedItems.Count > 0)
            {
                codeRedeem.Enabled = true;
                codeRedeem.Text = "Single Redeem Code [" +lstCodes.GetItemText(lstCodes.SelectedItem)+ "] ";
            }
            else
            {
                codeRedeem.Enabled = false;

                codeRedeem.Text = "Redeem! ";
            }
            if (lstCodes.SelectedItems.Count > 0)
            {
                codeRemove.Visible = true;
                codeEdit.Visible = true;
            }
            else
            {
                codeRemove.Visible = false;
                codeEdit.Visible = false;

            }
            if (e.Button == MouseButtons.Right) { codesContextMenu.Show(MousePosition); }
        }

        private void codeRedeem_Click(object sender, EventArgs e)
        {
            redeemCode();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public async void startBotRedeem()
        {
            if (!btnStartBot.Text.ToLower().Contains("start"))
            {
                user = new User();

                //Split User List Selected 
                string selectedUser = lstUsers.GetItemText(lstUsers.SelectedItem);
                selectedUser = selectedUser.Replace("[", "").Replace("]", "").Replace(" ", "");
                string[] stripped = selectedUser.Split('=');
                user.uid = CleanString(stripped[0]);
                user.vc = stripped[1];
                user.code = lstCodes.GetItemText(lstCodes.SelectedItem);

                var values = new Dictionary<string, string>
            {
            { "gameid", user.uid },
            { "language", "en" },
            { "captcha", "" },
            { "redeemcode",  user.code},
            { "vcode", user.vc}
            };

                var content = new FormUrlEncodedContent(values);
                try
                {
                    var response = await client.PostAsync("https://mapi.mobilelegends.com/api/sendredeem", content);
                    var responseString = await response.Content.ReadAsStringAsync();
                    SendVc ts = JsonConvert.DeserializeObject<SendVc>(responseString);
                    ts.code = (ts.code == null) ? "2000" : ts.code;
                    lstHistory.Items.Add(combineResult(ts, user, false));
                    chckToStopBot();
                    //redeemTimer.Enabled = true;
                }
                catch (Exception e)
                {

                    lstHistory.Items.Add("[" + e.Message + "] Internet Connection Error!");

                    chckToStopBot();
                    //redeemTimer.Enabled = true;

                }
            }
            else startRedeemBot(false);

        }


        public void chckToStopBot()
        {
            int selected = lstUsers.SelectedIndex;
            int selectedCode = lstCodes.SelectedIndex;


            if (selected != lstUsers.Items.Count - 1)
            {
                redeemTimer.Enabled = true;
                lstUsers.SelectedIndex = selected + 1;
            }
            else
            {
                    if (selectedCode != lstCodes.Items.Count - 1)
                    {
                        lstUsers.SelectedIndex = 0;
                        lstCodes.SelectedIndex = selectedCode + 1;
                    }else
                    {
                    if (autostop)
                    {
                        redeemTimer.Enabled = false;
                        startRedeemBot(false);
                    }
                    else lstCodes.SelectedIndex = 0;
                    }
               
                
            }
        }
       
        private void startRedeemBot(bool start)
        {
            if (!start)
            {
                btnStartBot.Text = "Start Bot";
                lblStatus.Text = "Bot Stopped!";
            }
            else
            {
                btnStartBot.Text = "Stop Bot";
                lblStatus.Text = "Bot Started!";
            }
            lblStatus.ForeColor = (start) ? System.Drawing.Color.LightGreen : System.Drawing.Color.Red;
        }

        private void redeemTimer_Tick(object sender, EventArgs e)
        {
            if (lstUsers.SelectedItems.Count > 0)
            {
                
                startBotRedeem();

            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblUsersSize_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblCodesSize_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnStartBot_Click(object sender, EventArgs e)
        {
            if (lstCodes.SelectedItems.Count > 0 && lstUsers.SelectedItems.Count>0)
            {
                if (!redeemTimer.Enabled)
                {
                    startRedeemBot(true);
                    redeemTimer.Enabled = true;
                }
                else
                {
                    startRedeemBot(false);
                    redeemTimer.Enabled = false;
                }
            }else
            {

                MessageBox.Show( "Please Select starting point for Users and Codes","Unable to Find Items!",MessageBoxButtons.OK,MessageBoxIcon.Error,0);
            }
        }

        private void lstUsers_Move(object sender, EventArgs e)
        {
            Console.WriteLine(lstUsers.SelectedIndex);
        }

        private void lstUsers_Click(object sender, EventArgs e)
        {
            Console.WriteLine(lstUsers.SelectedIndex + " : " + lstUsers.Items.Count);
        }

        private void clearHistory_Click(object sender, EventArgs e)
        {
            lstHistory.Items.Clear();
        }

        private void lstHistory_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) historyContext.Show(MousePosition);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void rdFinishCodesFirst_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lstHistory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            int itemsPerPage = (int)(lstHistory.Height / lstHistory.ItemHeight);
            lstHistory.TopIndex = lstHistory.Items.Count - itemsPerPage;
        }

        private void chckAutoStop_CheckedChanged(object sender, EventArgs e)
        {
            if (autostop) autostop = false; else autostop = true;
        }

        private void facebookCommentGrabberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacebookGrabber frm = new FacebookGrabber(this);
            frm.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.uid = txtUser.Text;
            Properties.Settings.Default.code = txtCode.Text;
            Properties.Settings.Default.vc = txtVc.Text;
            if (lstUsers.Items.Count > 0)
            {
                List<String> lst = new List<String>();
                foreach (string i in lstUsers.Items)
                {
                    lst.Add(i);
                }
                Properties.Settings.Default.lstUsers = lst;
            }

            if (lstCodes.Items.Count > 0)
            {
                List<String> lst = new List<String>();
                foreach (string i in lstCodes.Items)
                {
                    lst.Add(i);
                }
                Properties.Settings.Default.lstCodes = lst;
            }
            Properties.Settings.Default.Save();
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void lstCodes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

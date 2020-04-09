namespace RedemptionBuddyDesktopVersion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lstCodes = new System.Windows.Forms.ListBox();
            this.btnSendVc = new System.Windows.Forms.Button();
            this.txtVc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnAddCode = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rdFinishCodesFirst = new System.Windows.Forms.RadioButton();
            this.rdFinishUsersFirst = new System.Windows.Forms.RadioButton();
            this.lstHistory = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblUsersSize = new System.Windows.Forms.Label();
            this.lblCodesSize = new System.Windows.Forms.Label();
            this.usersContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.userRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.userEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.userClear = new System.Windows.Forms.ToolStripMenuItem();
            this.codesContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.codeRedeem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.codeEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.codeClear = new System.Windows.Forms.ToolStripMenuItem();
            this.redeemTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnStartBot = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facebookCommentGrabberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificationSendBotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webEventBoosterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chckAutoStop = new System.Windows.Forms.CheckBox();
            this.usersContextMenu.SuspendLayout();
            this.codesContextMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.historyContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstUsers
            // 
            this.lstUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.lstUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(153)))), ((int)(((byte)(217)))));
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.Location = new System.Drawing.Point(7, 46);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(256, 93);
            this.lstUsers.TabIndex = 0;
            this.lstUsers.Click += new System.EventHandler(this.lstUsers_Click);
            this.lstUsers.SelectedIndexChanged += new System.EventHandler(this.lstUsers_SelectedIndexChanged);
            this.lstUsers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstUsers_MouseDown);
            this.lstUsers.Move += new System.EventHandler(this.lstUsers_Move);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Users";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(272, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Codes";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "User ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtUser
            // 
            this.txtUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtUser.ForeColor = System.Drawing.Color.White;
            this.txtUser.Location = new System.Drawing.Point(57, 148);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 5;
            // 
            // lstCodes
            // 
            this.lstCodes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.lstCodes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstCodes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(153)))), ((int)(((byte)(217)))));
            this.lstCodes.FormattingEnabled = true;
            this.lstCodes.Location = new System.Drawing.Point(269, 46);
            this.lstCodes.Name = "lstCodes";
            this.lstCodes.Size = new System.Drawing.Size(254, 93);
            this.lstCodes.TabIndex = 6;
            this.lstCodes.SelectedIndexChanged += new System.EventHandler(this.lstCodes_SelectedIndexChanged);
            this.lstCodes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstCodes_MouseDown);
            // 
            // btnSendVc
            // 
            this.btnSendVc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendVc.ForeColor = System.Drawing.Color.White;
            this.btnSendVc.Location = new System.Drawing.Point(163, 146);
            this.btnSendVc.Name = "btnSendVc";
            this.btnSendVc.Size = new System.Drawing.Size(100, 23);
            this.btnSendVc.TabIndex = 7;
            this.btnSendVc.Text = "Send Verification";
            this.btnSendVc.UseVisualStyleBackColor = true;
            this.btnSendVc.Click += new System.EventHandler(this.btnSendVc_Click);
            // 
            // txtVc
            // 
            this.txtVc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtVc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.txtVc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVc.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtVc.ForeColor = System.Drawing.Color.White;
            this.txtVc.Location = new System.Drawing.Point(57, 174);
            this.txtVc.Name = "txtVc";
            this.txtVc.Size = new System.Drawing.Size(56, 20);
            this.txtVc.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "VC";
            // 
            // btnAddUser
            // 
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(119, 172);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(68, 23);
            this.btnAddUser.TabIndex = 10;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnAddCode
            // 
            this.btnAddCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCode.ForeColor = System.Drawing.Color.White;
            this.btnAddCode.Location = new System.Drawing.Point(412, 146);
            this.btnAddCode.Name = "btnAddCode";
            this.btnAddCode.Size = new System.Drawing.Size(111, 23);
            this.btnAddCode.TabIndex = 13;
            this.btnAddCode.Text = "Add Code";
            this.btnAddCode.UseVisualStyleBackColor = true;
            this.btnAddCode.Click += new System.EventHandler(this.btnAddCode_Click);
            // 
            // txtCode
            // 
            this.txtCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtCode.ForeColor = System.Drawing.Color.White;
            this.txtCode.Location = new System.Drawing.Point(306, 148);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(268, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Code";
            // 
            // rdFinishCodesFirst
            // 
            this.rdFinishCodesFirst.AutoSize = true;
            this.rdFinishCodesFirst.Enabled = false;
            this.rdFinishCodesFirst.ForeColor = System.Drawing.Color.White;
            this.rdFinishCodesFirst.Location = new System.Drawing.Point(420, 178);
            this.rdFinishCodesFirst.Name = "rdFinishCodesFirst";
            this.rdFinishCodesFirst.Size = new System.Drawing.Size(103, 17);
            this.rdFinishCodesFirst.TabIndex = 14;
            this.rdFinishCodesFirst.Text = "Finish codes first";
            this.rdFinishCodesFirst.UseVisualStyleBackColor = true;
            this.rdFinishCodesFirst.CheckedChanged += new System.EventHandler(this.rdFinishCodesFirst_CheckedChanged);
            // 
            // rdFinishUsersFirst
            // 
            this.rdFinishUsersFirst.AutoSize = true;
            this.rdFinishUsersFirst.Checked = true;
            this.rdFinishUsersFirst.ForeColor = System.Drawing.Color.White;
            this.rdFinishUsersFirst.Location = new System.Drawing.Point(316, 178);
            this.rdFinishUsersFirst.Name = "rdFinishUsersFirst";
            this.rdFinishUsersFirst.Size = new System.Drawing.Size(99, 17);
            this.rdFinishUsersFirst.TabIndex = 15;
            this.rdFinishUsersFirst.TabStop = true;
            this.rdFinishUsersFirst.Text = "Finish users first";
            this.rdFinishUsersFirst.UseVisualStyleBackColor = true;
            // 
            // lstHistory
            // 
            this.lstHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.lstHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstHistory.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(187)))), ((int)(((byte)(241)))));
            this.lstHistory.FormattingEnabled = true;
            this.lstHistory.Location = new System.Drawing.Point(529, 46);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstHistory.Size = new System.Drawing.Size(407, 132);
            this.lstHistory.TabIndex = 16;
            this.lstHistory.SelectedIndexChanged += new System.EventHandler(this.lstHistory_SelectedIndexChanged);
            this.lstHistory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstHistory_MouseDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(526, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "History status";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(529, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Status : ";
            // 
            // lblStatus
            // 
            this.lblStatus.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblStatus.Location = new System.Drawing.Point(581, 182);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(355, 21);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Text = "...";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // lblUsersSize
            // 
            this.lblUsersSize.AutoSize = true;
            this.lblUsersSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(77)))), ((int)(((byte)(66)))));
            this.lblUsersSize.Location = new System.Drawing.Point(250, 30);
            this.lblUsersSize.Name = "lblUsersSize";
            this.lblUsersSize.Size = new System.Drawing.Size(13, 13);
            this.lblUsersSize.TabIndex = 20;
            this.lblUsersSize.Text = "0";
            this.lblUsersSize.Click += new System.EventHandler(this.lblUsersSize_Click);
            // 
            // lblCodesSize
            // 
            this.lblCodesSize.AutoSize = true;
            this.lblCodesSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(77)))), ((int)(((byte)(66)))));
            this.lblCodesSize.Location = new System.Drawing.Point(507, 30);
            this.lblCodesSize.Name = "lblCodesSize";
            this.lblCodesSize.Size = new System.Drawing.Size(13, 13);
            this.lblCodesSize.TabIndex = 21;
            this.lblCodesSize.Text = "0";
            this.lblCodesSize.Click += new System.EventHandler(this.lblCodesSize_Click);
            // 
            // usersContextMenu
            // 
            this.usersContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userRemove,
            this.userEdit,
            this.userClear});
            this.usersContextMenu.Name = "usersContextMenu";
            this.usersContextMenu.Size = new System.Drawing.Size(118, 70);
            // 
            // userRemove
            // 
            this.userRemove.Name = "userRemove";
            this.userRemove.Size = new System.Drawing.Size(117, 22);
            this.userRemove.Text = "Remove";
            this.userRemove.Visible = false;
            this.userRemove.Click += new System.EventHandler(this.userRemove_Click);
            // 
            // userEdit
            // 
            this.userEdit.Name = "userEdit";
            this.userEdit.Size = new System.Drawing.Size(117, 22);
            this.userEdit.Text = "Edit";
            this.userEdit.Visible = false;
            this.userEdit.Click += new System.EventHandler(this.userEdit_Click);
            // 
            // userClear
            // 
            this.userClear.Name = "userClear";
            this.userClear.Size = new System.Drawing.Size(117, 22);
            this.userClear.Text = "Clear";
            this.userClear.Click += new System.EventHandler(this.userClear_Click);
            // 
            // codesContextMenu
            // 
            this.codesContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codeRedeem,
            this.codeRemove,
            this.codeEdit,
            this.codeClear});
            this.codesContextMenu.Name = "usersContextMenu";
            this.codesContextMenu.Size = new System.Drawing.Size(118, 92);
            this.codesContextMenu.Text = "Edit";
            // 
            // codeRedeem
            // 
            this.codeRedeem.Enabled = false;
            this.codeRedeem.Name = "codeRedeem";
            this.codeRedeem.Size = new System.Drawing.Size(117, 22);
            this.codeRedeem.Text = "Redeem";
            this.codeRedeem.Click += new System.EventHandler(this.codeRedeem_Click);
            // 
            // codeRemove
            // 
            this.codeRemove.Name = "codeRemove";
            this.codeRemove.Size = new System.Drawing.Size(117, 22);
            this.codeRemove.Text = "Remove";
            this.codeRemove.Visible = false;
            this.codeRemove.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // codeEdit
            // 
            this.codeEdit.Name = "codeEdit";
            this.codeEdit.Size = new System.Drawing.Size(117, 22);
            this.codeEdit.Text = "Edit";
            this.codeEdit.Visible = false;
            this.codeEdit.Click += new System.EventHandler(this.codeEdit_Click);
            // 
            // codeClear
            // 
            this.codeClear.Name = "codeClear";
            this.codeClear.Size = new System.Drawing.Size(117, 22);
            this.codeClear.Text = "Clear";
            this.codeClear.Click += new System.EventHandler(this.codeClear_Click);
            // 
            // redeemTimer
            // 
            this.redeemTimer.Interval = 500;
            this.redeemTimer.Tick += new System.EventHandler(this.redeemTimer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStartBot,
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(948, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // btnStartBot
            // 
            this.btnStartBot.Name = "btnStartBot";
            this.btnStartBot.Size = new System.Drawing.Size(64, 20);
            this.btnStartBot.Text = "Start Bot";
            this.btnStartBot.Click += new System.EventHandler(this.btnStartBot_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facebookCommentGrabberToolStripMenuItem,
            this.verificationSendBotToolStripMenuItem,
            this.webEventBoosterToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // facebookCommentGrabberToolStripMenuItem
            // 
            this.facebookCommentGrabberToolStripMenuItem.Name = "facebookCommentGrabberToolStripMenuItem";
            this.facebookCommentGrabberToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.facebookCommentGrabberToolStripMenuItem.Text = "Facebook Comment Grabber";
            this.facebookCommentGrabberToolStripMenuItem.Click += new System.EventHandler(this.facebookCommentGrabberToolStripMenuItem_Click);
            // 
            // verificationSendBotToolStripMenuItem
            // 
            this.verificationSendBotToolStripMenuItem.Enabled = false;
            this.verificationSendBotToolStripMenuItem.Name = "verificationSendBotToolStripMenuItem";
            this.verificationSendBotToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.verificationSendBotToolStripMenuItem.Text = "Verification Send Bot";
            // 
            // webEventBoosterToolStripMenuItem
            // 
            this.webEventBoosterToolStripMenuItem.Enabled = false;
            this.webEventBoosterToolStripMenuItem.Name = "webEventBoosterToolStripMenuItem";
            this.webEventBoosterToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.webEventBoosterToolStripMenuItem.Text = "Web Event Booster";
            // 
            // historyContext
            // 
            this.historyContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearHistory});
            this.historyContext.Name = "usersContextMenu";
            this.historyContext.Size = new System.Drawing.Size(102, 26);
            this.historyContext.Text = "Edit";
            // 
            // clearHistory
            // 
            this.clearHistory.Name = "clearHistory";
            this.clearHistory.Size = new System.Drawing.Size(101, 22);
            this.clearHistory.Text = "Clear";
            this.clearHistory.Click += new System.EventHandler(this.clearHistory_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // chckAutoStop
            // 
            this.chckAutoStop.Checked = true;
            this.chckAutoStop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckAutoStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(77)))), ((int)(((byte)(66)))));
            this.chckAutoStop.Location = new System.Drawing.Point(193, 177);
            this.chckAutoStop.Name = "chckAutoStop";
            this.chckAutoStop.Size = new System.Drawing.Size(104, 24);
            this.chckAutoStop.TabIndex = 24;
            this.chckAutoStop.Text = "Auto stop Bot";
            this.chckAutoStop.UseVisualStyleBackColor = true;
            this.chckAutoStop.CheckedChanged += new System.EventHandler(this.chckAutoStop_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(948, 208);
            this.Controls.Add(this.chckAutoStop);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblCodesSize);
            this.Controls.Add(this.lblUsersSize);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstHistory);
            this.Controls.Add(this.rdFinishUsersFirst);
            this.Controls.Add(this.rdFinishCodesFirst);
            this.Controls.Add(this.btnAddCode);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVc);
            this.Controls.Add(this.btnSendVc);
            this.Controls.Add(this.lstCodes);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstUsers);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RedemptionBuddy Desktop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.usersContextMenu.ResumeLayout(false);
            this.codesContextMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.historyContext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.ListBox lstCodes;
        private System.Windows.Forms.Button btnSendVc;
        private System.Windows.Forms.TextBox txtVc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnAddCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdFinishCodesFirst;
        private System.Windows.Forms.RadioButton rdFinishUsersFirst;
        private System.Windows.Forms.ListBox lstHistory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblUsersSize;
        private System.Windows.Forms.Label lblCodesSize;
        private System.Windows.Forms.ContextMenuStrip usersContextMenu;
        private System.Windows.Forms.ToolStripMenuItem userRemove;
        private System.Windows.Forms.ToolStripMenuItem userEdit;
        private System.Windows.Forms.ToolStripMenuItem userClear;
        private System.Windows.Forms.ContextMenuStrip codesContextMenu;
        private System.Windows.Forms.ToolStripMenuItem codeRedeem;
        private System.Windows.Forms.ToolStripMenuItem codeRemove;
        private System.Windows.Forms.ToolStripMenuItem codeEdit;
        private System.Windows.Forms.ToolStripMenuItem codeClear;
        private System.Windows.Forms.Timer redeemTimer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facebookCommentGrabberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificationSendBotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnStartBot;
        private System.Windows.Forms.ContextMenuStrip historyContext;
        private System.Windows.Forms.ToolStripMenuItem clearHistory;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox chckAutoStop;
        public System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.ToolStripMenuItem webEventBoosterToolStripMenuItem;
    }
}


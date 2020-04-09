namespace RedemptionBuddyDesktopVersion
{
    partial class FacebookGrabber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacebookGrabber));
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtElement = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.web = new System.Windows.Forms.WebBrowser();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnGrab = new System.Windows.Forms.Button();
            this.lstUsersToBoost = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.cmbEvents = new System.Windows.Forms.ComboBox();
            this.boostContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnBoostAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBoostClear = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBoostEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBoostRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBoostImportExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBoostManual = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCopyResults = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportResults = new System.Windows.Forms.ToolStripMenuItem();
            this.boosterTimer = new System.Windows.Forms.Timer(this.components);
            this.lstResults = new System.Windows.Forms.ListBox();
            this.boostContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.txtURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtURL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.txtURL.Location = new System.Drawing.Point(50, 12);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(392, 20);
            this.txtURL.TabIndex = 0;
            this.txtURL.Text = "https://facebook.com";
            // 
            // txtElement
            // 
            this.txtElement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.txtElement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtElement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.txtElement.Location = new System.Drawing.Point(576, 13);
            this.txtElement.Name = "txtElement";
            this.txtElement.Size = new System.Drawing.Size(66, 20);
            this.txtElement.TabIndex = 1;
            this.txtElement.Text = "_3l3x";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(519, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Element: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "URL:";
            // 
            // web
            // 
            this.web.Location = new System.Drawing.Point(12, 40);
            this.web.MinimumSize = new System.Drawing.Size(20, 20);
            this.web.Name = "web";
            this.web.Size = new System.Drawing.Size(742, 565);
            this.web.TabIndex = 4;
            this.web.Visible = false;
            // 
            // btnGo
            // 
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnGo.Location = new System.Drawing.Point(450, 11);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(63, 23);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnGrab
            // 
            this.btnGrab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnGrab.Location = new System.Drawing.Point(648, 11);
            this.btnGrab.Name = "btnGrab";
            this.btnGrab.Size = new System.Drawing.Size(106, 23);
            this.btnGrab.TabIndex = 6;
            this.btnGrab.Text = "Grab Values";
            this.btnGrab.UseVisualStyleBackColor = true;
            this.btnGrab.Click += new System.EventHandler(this.btnGrab_Click);
            // 
            // lstUsersToBoost
            // 
            this.lstUsersToBoost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.lstUsersToBoost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstUsersToBoost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(182)))), ((int)(((byte)(97)))));
            this.lstUsersToBoost.FormattingEnabled = true;
            this.lstUsersToBoost.Location = new System.Drawing.Point(760, 51);
            this.lstUsersToBoost.Name = "lstUsersToBoost";
            this.lstUsersToBoost.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstUsersToBoost.Size = new System.Drawing.Size(176, 522);
            this.lstUsersToBoost.TabIndex = 7;
            this.lstUsersToBoost.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(182)))), ((int)(((byte)(97)))));
            this.btnStart.Location = new System.Drawing.Point(1218, 581);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 24);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Boost";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cmbEvents
            // 
            this.cmbEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.cmbEvents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEvents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(182)))), ((int)(((byte)(97)))));
            this.cmbEvents.FormattingEnabled = true;
            this.cmbEvents.Items.AddRange(new object[] {
            "Amazon"});
            this.cmbEvents.Location = new System.Drawing.Point(763, 584);
            this.cmbEvents.Name = "cmbEvents";
            this.cmbEvents.Size = new System.Drawing.Size(449, 21);
            this.cmbEvents.TabIndex = 11;
            // 
            // boostContextMenu
            // 
            this.boostContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBoostAdd,
            this.btnBoostClear,
            this.btnBoostEdit,
            this.btnBoostRemove,
            this.btnBoostImportExcel,
            this.btnBoostManual,
            this.btnCopyResults,
            this.btnExportResults});
            this.boostContextMenu.Name = "boostContextMenu";
            this.boostContextMenu.Size = new System.Drawing.Size(148, 180);
            this.boostContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.boostContextMenu_Opening);
            // 
            // btnBoostAdd
            // 
            this.btnBoostAdd.Name = "btnBoostAdd";
            this.btnBoostAdd.Size = new System.Drawing.Size(147, 22);
            this.btnBoostAdd.Text = "Add";
            this.btnBoostAdd.Click += new System.EventHandler(this.btnBoostAdd_Click);
            // 
            // btnBoostClear
            // 
            this.btnBoostClear.Name = "btnBoostClear";
            this.btnBoostClear.Size = new System.Drawing.Size(147, 22);
            this.btnBoostClear.Text = "Clear";
            // 
            // btnBoostEdit
            // 
            this.btnBoostEdit.Name = "btnBoostEdit";
            this.btnBoostEdit.Size = new System.Drawing.Size(147, 22);
            this.btnBoostEdit.Text = "Edit";
            this.btnBoostEdit.Visible = false;
            // 
            // btnBoostRemove
            // 
            this.btnBoostRemove.Name = "btnBoostRemove";
            this.btnBoostRemove.Size = new System.Drawing.Size(147, 22);
            this.btnBoostRemove.Text = "Remove";
            this.btnBoostRemove.Visible = false;
            // 
            // btnBoostImportExcel
            // 
            this.btnBoostImportExcel.Name = "btnBoostImportExcel";
            this.btnBoostImportExcel.Size = new System.Drawing.Size(147, 22);
            this.btnBoostImportExcel.Text = "Import EXCEL";
            // 
            // btnBoostManual
            // 
            this.btnBoostManual.Name = "btnBoostManual";
            this.btnBoostManual.Size = new System.Drawing.Size(147, 22);
            this.btnBoostManual.Text = "Boost Manual";
            this.btnBoostManual.Visible = false;
            // 
            // btnCopyResults
            // 
            this.btnCopyResults.Name = "btnCopyResults";
            this.btnCopyResults.Size = new System.Drawing.Size(147, 22);
            this.btnCopyResults.Text = "Copy Results";
            this.btnCopyResults.Visible = false;
            // 
            // btnExportResults
            // 
            this.btnExportResults.Name = "btnExportResults";
            this.btnExportResults.Size = new System.Drawing.Size(147, 22);
            this.btnExportResults.Text = "Export Results";
            this.btnExportResults.Visible = false;
            // 
            // lstResults
            // 
            this.lstResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.lstResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(182)))), ((int)(((byte)(97)))));
            this.lstResults.FormattingEnabled = true;
            this.lstResults.Location = new System.Drawing.Point(942, 53);
            this.lstResults.Name = "lstResults";
            this.lstResults.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstResults.Size = new System.Drawing.Size(351, 522);
            this.lstResults.TabIndex = 12;
            // 
            // FacebookGrabber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1305, 617);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.cmbEvents);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lstUsersToBoost);
            this.Controls.Add(this.btnGrab);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.web);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtElement);
            this.Controls.Add(this.txtURL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FacebookGrabber";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FacebookGrabber";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FacebookGrabber_FormClosing);
            this.Load += new System.EventHandler(this.FacebookGrabber_Load);
            this.boostContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtElement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.WebBrowser web;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnGrab;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cmbEvents;
        private System.Windows.Forms.ContextMenuStrip boostContextMenu;
        private System.Windows.Forms.ToolStripMenuItem btnBoostAdd;
        private System.Windows.Forms.ToolStripMenuItem btnBoostClear;
        private System.Windows.Forms.ToolStripMenuItem btnBoostEdit;
        private System.Windows.Forms.ToolStripMenuItem btnBoostRemove;
        private System.Windows.Forms.ToolStripMenuItem btnBoostImportExcel;
        private System.Windows.Forms.ToolStripMenuItem btnBoostManual;
        private System.Windows.Forms.ToolStripMenuItem btnCopyResults;
        private System.Windows.Forms.ToolStripMenuItem btnExportResults;
        private System.Windows.Forms.Timer boosterTimer;
        public System.Windows.Forms.ListBox lstUsersToBoost;
        public System.Windows.Forms.ListBox lstResults;
    }
}
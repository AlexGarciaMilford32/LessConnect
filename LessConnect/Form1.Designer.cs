namespace LessConnect
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.PictureBox pictureBox1;
            this.StartButton = new System.Windows.Forms.Button();
            LogBox = new System.Windows.Forms.RichTextBox();
            this.StopButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.machineNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iPv4AddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadLogFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideAdminToolsAndOptonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadTheDesktopClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verifyLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkLogValidityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkSystemTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSystemTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createSystemTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.selectprogramlabel = new System.Windows.Forms.Label();
            this.selectcommand32label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lessConnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.killServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mACHINENAMEToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.iPV4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.externalIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXTERNALIPToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadLessConnectCustomFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutLessConnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whatsNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(8, 434);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(224, 57);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // LogBox
            // 
            LogBox.BackColor = System.Drawing.SystemColors.Control;
            LogBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            LogBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            LogBox.Location = new System.Drawing.Point(242, 435);
            LogBox.Name = "LogBox";
            LogBox.ReadOnly = true;
            LogBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            LogBox.Size = new System.Drawing.Size(266, 56);
            LogBox.TabIndex = 1;
            LogBox.Text = "";
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(514, 434);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(224, 57);
            this.StopButton.TabIndex = 2;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(238, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Log :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Less Connect";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Developers Eddition : Default Port Used (4525)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(358, 91);
            this.label5.TabIndex = 9;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(750, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.machineNameToolStripMenuItem,
            this.iPv4AddressToolStripMenuItem,
            this.externalIPToolStripMenuItem,
            this.uploadLogFileToolStripMenuItem,
            this.checkForUpdateToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // machineNameToolStripMenuItem
            // 
            this.machineNameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mACHINENAMEToolStripMenuItem1});
            this.machineNameToolStripMenuItem.Name = "machineNameToolStripMenuItem";
            this.machineNameToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.machineNameToolStripMenuItem.Text = "Machine Name";
            this.machineNameToolStripMenuItem.Click += new System.EventHandler(this.machineNameToolStripMenuItem_Click);
            // 
            // iPv4AddressToolStripMenuItem
            // 
            this.iPv4AddressToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iPV4ToolStripMenuItem});
            this.iPv4AddressToolStripMenuItem.Name = "iPv4AddressToolStripMenuItem";
            this.iPv4AddressToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.iPv4AddressToolStripMenuItem.Text = "IPv4 Address";
            this.iPv4AddressToolStripMenuItem.Click += new System.EventHandler(this.iPv4AddressToolStripMenuItem_Click);
            // 
            // uploadLogFileToolStripMenuItem
            // 
            this.uploadLogFileToolStripMenuItem.Enabled = false;
            this.uploadLogFileToolStripMenuItem.Name = "uploadLogFileToolStripMenuItem";
            this.uploadLogFileToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.uploadLogFileToolStripMenuItem.Text = "Upload LogFile";
            this.uploadLogFileToolStripMenuItem.Click += new System.EventHandler(this.uploadLogFileToolStripMenuItem_Click);
            // 
            // checkForUpdateToolStripMenuItem
            // 
            this.checkForUpdateToolStripMenuItem.Enabled = false;
            this.checkForUpdateToolStripMenuItem.Name = "checkForUpdateToolStripMenuItem";
            this.checkForUpdateToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.checkForUpdateToolStripMenuItem.Text = "Check For Update";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideAdminToolsAndOptonsToolStripMenuItem,
            this.downloadTheDesktopClientToolStripMenuItem,
            this.verifyLogsToolStripMenuItem,
            this.checkSystemTicketToolStripMenuItem,
            this.removeSystemTicketToolStripMenuItem,
            this.createSystemTicketToolStripMenuItem,
            this.lessConnectToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // hideAdminToolsAndOptonsToolStripMenuItem
            // 
            this.hideAdminToolsAndOptonsToolStripMenuItem.CheckOnClick = true;
            this.hideAdminToolsAndOptonsToolStripMenuItem.Enabled = false;
            this.hideAdminToolsAndOptonsToolStripMenuItem.Name = "hideAdminToolsAndOptonsToolStripMenuItem";
            this.hideAdminToolsAndOptonsToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.hideAdminToolsAndOptonsToolStripMenuItem.Text = "Hide Admin Tools and Optons";
            this.hideAdminToolsAndOptonsToolStripMenuItem.Click += new System.EventHandler(this.hideAdminToolsAndOptonsToolStripMenuItem_Click);
            // 
            // downloadTheDesktopClientToolStripMenuItem
            // 
            this.downloadTheDesktopClientToolStripMenuItem.Enabled = false;
            this.downloadTheDesktopClientToolStripMenuItem.Name = "downloadTheDesktopClientToolStripMenuItem";
            this.downloadTheDesktopClientToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.downloadTheDesktopClientToolStripMenuItem.Text = "Download The Desktop Client";
            // 
            // verifyLogsToolStripMenuItem
            // 
            this.verifyLogsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkLogValidityToolStripMenuItem});
            this.verifyLogsToolStripMenuItem.Name = "verifyLogsToolStripMenuItem";
            this.verifyLogsToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.verifyLogsToolStripMenuItem.Text = "Verify Logs";
            // 
            // checkLogValidityToolStripMenuItem
            // 
            this.checkLogValidityToolStripMenuItem.Name = "checkLogValidityToolStripMenuItem";
            this.checkLogValidityToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.checkLogValidityToolStripMenuItem.Text = "Check Log Validity";
            // 
            // checkSystemTicketToolStripMenuItem
            // 
            this.checkSystemTicketToolStripMenuItem.Name = "checkSystemTicketToolStripMenuItem";
            this.checkSystemTicketToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.checkSystemTicketToolStripMenuItem.Text = "Check System Ticket";
            // 
            // removeSystemTicketToolStripMenuItem
            // 
            this.removeSystemTicketToolStripMenuItem.Name = "removeSystemTicketToolStripMenuItem";
            this.removeSystemTicketToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.removeSystemTicketToolStripMenuItem.Text = "Remove System Ticket";
            // 
            // createSystemTicketToolStripMenuItem
            // 
            this.createSystemTicketToolStripMenuItem.Name = "createSystemTicketToolStripMenuItem";
            this.createSystemTicketToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.createSystemTicketToolStripMenuItem.Text = "Create System Ticket";
            // 
            // backgroundWorker4
            // 
            this.backgroundWorker4.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker4_DoWork);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 494);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(750, 22);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(76, 17);
            this.toolStripStatusLabel1.Text = "Card Status : ";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.selectcommand32label);
            this.groupBox1.Controls.Add(this.selectprogramlabel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(13, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 240);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "";
            this.groupBox1.Text = "Available Request";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Message :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Hello There";
            // 
            // selectprogramlabel
            // 
            this.selectprogramlabel.AutoSize = true;
            this.selectprogramlabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectprogramlabel.Location = new System.Drawing.Point(9, 77);
            this.selectprogramlabel.Name = "selectprogramlabel";
            this.selectprogramlabel.Size = new System.Drawing.Size(80, 13);
            this.selectprogramlabel.TabIndex = 2;
            this.selectprogramlabel.Text = "Start a Program";
            this.selectprogramlabel.Click += new System.EventHandler(this.selectprogramlabel_Click);
            // 
            // selectcommand32label
            // 
            this.selectcommand32label.AutoSize = true;
            this.selectcommand32label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectcommand32label.Location = new System.Drawing.Point(9, 107);
            this.selectcommand32label.Name = "selectcommand32label";
            this.selectcommand32label.Size = new System.Drawing.Size(88, 13);
            this.selectcommand32label.TabIndex = 3;
            this.selectcommand32label.Text = "Win32 Command";
            this.selectcommand32label.Click += new System.EventHandler(this.selectcommand32label_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Kill";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Restart";
            // 
            // lessConnectToolStripMenuItem
            // 
            this.lessConnectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.killServerToolStripMenuItem,
            this.loadLessConnectCustomFileToolStripMenuItem});
            this.lessConnectToolStripMenuItem.Name = "lessConnectToolStripMenuItem";
            this.lessConnectToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.lessConnectToolStripMenuItem.Text = "LessConnect";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // killServerToolStripMenuItem
            // 
            this.killServerToolStripMenuItem.Name = "killServerToolStripMenuItem";
            this.killServerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.killServerToolStripMenuItem.Text = "Kill Server";
            // 
            // mACHINENAMEToolStripMenuItem1
            // 
            this.mACHINENAMEToolStripMenuItem1.Name = "mACHINENAMEToolStripMenuItem1";
            this.mACHINENAMEToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.mACHINENAMEToolStripMenuItem1.Text = "{MACHINENAME}";
            // 
            // iPV4ToolStripMenuItem
            // 
            this.iPV4ToolStripMenuItem.Name = "iPV4ToolStripMenuItem";
            this.iPV4ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.iPV4ToolStripMenuItem.Text = "{IPV4}";
            // 
            // externalIPToolStripMenuItem
            // 
            this.externalIPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eXTERNALIPToolStripMenuItem1});
            this.externalIPToolStripMenuItem.Name = "externalIPToolStripMenuItem";
            this.externalIPToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.externalIPToolStripMenuItem.Text = "External IP";
            this.externalIPToolStripMenuItem.Click += new System.EventHandler(this.externalIPToolStripMenuItem_Click);
            // 
            // eXTERNALIPToolStripMenuItem1
            // 
            this.eXTERNALIPToolStripMenuItem1.Name = "eXTERNALIPToolStripMenuItem1";
            this.eXTERNALIPToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.eXTERNALIPToolStripMenuItem1.Text = "{EXTERNALIP}";
            // 
            // loadLessConnectCustomFileToolStripMenuItem
            // 
            this.loadLessConnectCustomFileToolStripMenuItem.Name = "loadLessConnectCustomFileToolStripMenuItem";
            this.loadLessConnectCustomFileToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.loadLessConnectCustomFileToolStripMenuItem.Text = "Load LessConnect Card";
            this.loadLessConnectCustomFileToolStripMenuItem.Click += new System.EventHandler(this.loadLessConnectCustomFileToolStripMenuItem_Click);
            // 
            // toolStripStatusLabel2
            // 
            
            toolStripStatusLabel2.Name = "OEMCardStatusLabel";
            toolStripStatusLabel2.Size = new System.Drawing.Size(83, 17);
            toolStripStatusLabel2.Text = "OEM (Verified)";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(463, -32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(358, 382);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutLessConnectToolStripMenuItem,
            this.whatsNewToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutLessConnectToolStripMenuItem
            // 
            this.aboutLessConnectToolStripMenuItem.Name = "aboutLessConnectToolStripMenuItem";
            this.aboutLessConnectToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.aboutLessConnectToolStripMenuItem.Text = "About LessConnect";
            this.aboutLessConnectToolStripMenuItem.Click += new System.EventHandler(this.aboutLessConnectToolStripMenuItem_Click);
            // 
            // whatsNewToolStripMenuItem
            // 
            this.whatsNewToolStripMenuItem.Name = "whatsNewToolStripMenuItem";
            this.whatsNewToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.whatsNewToolStripMenuItem.Text = "Whats New";
            this.whatsNewToolStripMenuItem.Click += new System.EventHandler(this.whatsNewToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 516);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(LogBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(766, 555);
            this.MinimumSize = new System.Drawing.Size(766, 555);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LessConnect : v";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem machineNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadLogFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideAdminToolsAndOptonsToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem downloadTheDesktopClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verifyLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkLogValidityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkSystemTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSystemTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createSystemTicketToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        public static System.Windows.Forms.RichTextBox LogBox;
        private System.Windows.Forms.ToolStripMenuItem iPv4AddressToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.ComponentModel.BackgroundWorker backgroundWorker4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label selectcommand32label;
        private System.Windows.Forms.Label selectprogramlabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem mACHINENAMEToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem iPV4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem externalIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXTERNALIPToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lessConnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem killServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadLessConnectCustomFileToolStripMenuItem;
        public static System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutLessConnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whatsNewToolStripMenuItem;
    }
}


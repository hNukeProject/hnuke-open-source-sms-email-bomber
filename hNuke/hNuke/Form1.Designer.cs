namespace hNuke
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this._UseSSL = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._SmptPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._SmtpServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._EmailPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._EmailAddress = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this._SetInterval = new System.Windows.Forms.TextBox();
            this._SpamCounter = new System.Windows.Forms.Label();
            this._DelayTime = new System.Windows.Forms.TextBox();
            this._SetDelay = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this._PhoneNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._VictimsEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._PhoneSelect = new System.Windows.Forms.CheckBox();
            this._EmailSelect = new System.Windows.Forms.CheckBox();
            this._CarrierName = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this._SendTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(464, 288);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this._UseSSL);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this._SmptPort);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this._SmtpServer);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this._EmailPassword);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this._EmailAddress);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(456, 260);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SMTP Settings";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(442, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Test Settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _UseSSL
            // 
            this._UseSSL.AutoSize = true;
            this._UseSSL.Location = new System.Drawing.Point(303, 42);
            this._UseSSL.Name = "_UseSSL";
            this._UseSSL.Size = new System.Drawing.Size(148, 19);
            this._UseSSL.TabIndex = 10;
            this._UseSSL.Text = "SSL/TLS Enable/Disable";
            this._UseSSL.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Use SSL/TLS?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Port";
            // 
            // _SmptPort
            // 
            this._SmptPort.Location = new System.Drawing.Point(268, 67);
            this._SmptPort.MaxLength = 3;
            this._SmptPort.Name = "_SmptPort";
            this._SmptPort.PlaceholderText = "587";
            this._SmptPort.Size = new System.Drawing.Size(100, 23);
            this._SmptPort.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Server IP";
            // 
            // _SmtpServer
            // 
            this._SmtpServer.Location = new System.Drawing.Point(8, 67);
            this._SmtpServer.Name = "_SmtpServer";
            this._SmtpServer.PlaceholderText = "smtp.example.com";
            this._SmtpServer.Size = new System.Drawing.Size(254, 23);
            this._SmtpServer.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // _EmailPassword
            // 
            this._EmailPassword.Location = new System.Drawing.Point(146, 24);
            this._EmailPassword.Name = "_EmailPassword";
            this._EmailPassword.PasswordChar = '*';
            this._EmailPassword.PlaceholderText = "password";
            this._EmailPassword.Size = new System.Drawing.Size(151, 23);
            this._EmailPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            // 
            // _EmailAddress
            // 
            this._EmailAddress.Location = new System.Drawing.Point(3, 24);
            this._EmailAddress.Name = "_EmailAddress";
            this._EmailAddress.PlaceholderText = "email@example.com";
            this._EmailAddress.Size = new System.Drawing.Size(137, 23);
            this._EmailAddress.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gray;
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this._SetInterval);
            this.tabPage2.Controls.Add(this._SpamCounter);
            this.tabPage2.Controls.Add(this._DelayTime);
            this.tabPage2.Controls.Add(this._SetDelay);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this._PhoneNumber);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this._VictimsEmail);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this._PhoneSelect);
            this.tabPage2.Controls.Add(this._EmailSelect);
            this.tabPage2.Controls.Add(this._CarrierName);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(456, 260);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Attack Panel";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(251, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "Spam Interval (ms)";
            // 
            // _SetInterval
            // 
            this._SetInterval.Location = new System.Drawing.Point(251, 229);
            this._SetInterval.Name = "_SetInterval";
            this._SetInterval.Size = new System.Drawing.Size(197, 23);
            this._SetInterval.TabIndex = 21;
            // 
            // _SpamCounter
            // 
            this._SpamCounter.AutoSize = true;
            this._SpamCounter.Location = new System.Drawing.Point(45, 111);
            this._SpamCounter.Name = "_SpamCounter";
            this._SpamCounter.Size = new System.Drawing.Size(0, 15);
            this._SpamCounter.TabIndex = 20;
            // 
            // _DelayTime
            // 
            this._DelayTime.Location = new System.Drawing.Point(8, 200);
            this._DelayTime.Name = "_DelayTime";
            this._DelayTime.Size = new System.Drawing.Size(100, 23);
            this._DelayTime.TabIndex = 15;
            this._DelayTime.Text = "1000";
            // 
            // _SetDelay
            // 
            this._SetDelay.AutoSize = true;
            this._SetDelay.Location = new System.Drawing.Point(8, 182);
            this._SetDelay.Name = "_SetDelay";
            this._SetDelay.Size = new System.Drawing.Size(117, 19);
            this._SetDelay.TabIndex = 14;
            this._SetDelay.Text = "Enable Delay(ms)";
            this._SetDelay.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(227, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "Message";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(227, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(221, 122);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // _PhoneNumber
            // 
            this._PhoneNumber.Enabled = false;
            this._PhoneNumber.Location = new System.Drawing.Point(133, 153);
            this._PhoneNumber.Name = "_PhoneNumber";
            this._PhoneNumber.Size = new System.Drawing.Size(320, 23);
            this._PhoneNumber.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(133, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Phone Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Victims Email?";
            // 
            // _VictimsEmail
            // 
            this._VictimsEmail.Enabled = false;
            this._VictimsEmail.Location = new System.Drawing.Point(6, 71);
            this._VictimsEmail.Name = "_VictimsEmail";
            this._VictimsEmail.Size = new System.Drawing.Size(189, 23);
            this._VictimsEmail.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Carrier Select";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "I\'m spamming an?";
            // 
            // _PhoneSelect
            // 
            this._PhoneSelect.AutoSize = true;
            this._PhoneSelect.Location = new System.Drawing.Point(69, 24);
            this._PhoneSelect.Name = "_PhoneSelect";
            this._PhoneSelect.Size = new System.Drawing.Size(60, 19);
            this._PhoneSelect.TabIndex = 5;
            this._PhoneSelect.Text = "Phone";
            this._PhoneSelect.UseVisualStyleBackColor = true;
            this._PhoneSelect.CheckedChanged += new System.EventHandler(this._PhoneSelect_CheckedChanged);
            // 
            // _EmailSelect
            // 
            this._EmailSelect.AutoSize = true;
            this._EmailSelect.Location = new System.Drawing.Point(8, 24);
            this._EmailSelect.Name = "_EmailSelect";
            this._EmailSelect.Size = new System.Drawing.Size(55, 19);
            this._EmailSelect.TabIndex = 4;
            this._EmailSelect.Text = "Email";
            this._EmailSelect.UseVisualStyleBackColor = true;
            this._EmailSelect.CheckedChanged += new System.EventHandler(this._EmailSelect_CheckedChanged);
            // 
            // _CarrierName
            // 
            this._CarrierName.AllowDrop = true;
            this._CarrierName.Enabled = false;
            this._CarrierName.FormattingEnabled = true;
            this._CarrierName.Items.AddRange(new object[] {
            "",
            "AT&T",
            "Verizon Wireless",
            "T-Mobile",
            "Airfire Mobile",
            "Alaska Communications",
            "Alltel (Allied Wireless)",
            "Ameritech",
            "Assurance Wireless",
            "Formerly Cingular",
            "BellSouth",
            "Bluegrass Cellular",
            "Boost Mobile",
            "Cellcom",
            "Cellular South",
            "Chariton Valley Wireless",
            "Chat Mobility",
            "Cincinnati Bell",
            "Cingular (Postpaid)",
            "Cleartalk",
            "Consumer Cellular",
            "Cricket",
            "C Spire Wireless",
            "DTC",
            "Edge Wireless",
            "Element Mobile",
            "Esendex",
            "General Communications Inc.",
            "Golden State Cellular",
            "Greatcall",
            "Hawaiian Telcom Wireless",
            "Helio",
            "i-wireless (Sprint PCS)",
            "Kajeet",
            "LongLines",
            "MetroPCS",
            "Nextech",
            "Page Plust Cellular (V MVNO)",
            "Pocket Wireless",
            "Qwest Wireless",
            "Red Pocket Mobile",
            "Simple Mobile",
            "Southernlinc",
            "South Central Communication",
            "Straight Talk",
            "Solavei",
            "Syringa Wireless",
            "Teleflip",
            "TracFone (prepaid)",
            "Unicel",
            "US Cellular",
            "USA Mobility",
            "Verizon Wireless",
            "Viaro",
            "Virgin Mobile",
            "Voyager Mobile",
            "West Central Wireless",
            "XIT Communications"});
            this._CarrierName.Location = new System.Drawing.Point(6, 153);
            this._CarrierName.Name = "_CarrierName";
            this._CarrierName.Size = new System.Drawing.Size(121, 23);
            this._CarrierName.TabIndex = 3;
            this._CarrierName.Text = "SELECT A CARRIER";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(170, 229);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Set";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(89, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // _SendTimer
            // 
            this._SendTimer.Interval = 1000;
            this._SendTimer.Tick += new System.EventHandler(this._SendTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 288);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "hNuke E-Mail & SMS Bomber";
            this.TopMost = true;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button1;
        private CheckBox _UseSSL;
        private Label label5;
        private Label label4;
        private TextBox _SmptPort;
        private Label label3;
        private TextBox _SmtpServer;
        private Label label2;
        private TextBox _EmailPassword;
        private Label label1;
        private TextBox _EmailAddress;
        private CheckBox _PhoneSelect;
        private CheckBox _EmailSelect;
        private ComboBox _CarrierName;
        private Button button4;
        private Button button3;
        private Button button2;
        private TextBox _DelayTime;
        private CheckBox _SetDelay;
        private Label label10;
        private RichTextBox richTextBox1;
        private TextBox _PhoneNumber;
        private Label label9;
        private Label label8;
        private TextBox _VictimsEmail;
        private Label label7;
        private Label label6;
        private System.Windows.Forms.Timer _SendTimer;
        private Label _SpamCounter;
        private Label label11;
        private TextBox _SetInterval;
    }
}
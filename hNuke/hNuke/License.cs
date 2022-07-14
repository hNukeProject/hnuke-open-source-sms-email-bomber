using AuthGG;

namespace hNuke
{
    public partial class License : Form
    {
        public License()
        {
            InitializeComponent();
        }

        private void License_Load(object sender, EventArgs e)
        {

        }

        private void _LoginBtn_Click_1(object sender, EventArgs e)
        {
            if (API.Login(_LoginUser.Text, _LoginPassword.Text))
            {
                //Put code here of what you want to do after successful login
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 main = new Form1();
                main.Show();
                this.Close();
            }
        }

        private void _RegisterBtn_Click_1(object sender, EventArgs e)
        {
            if (API.Register(_Username.Text, _Password.Text, _Email.Text, _Key.Text))
            {
                //Put code here of what you want to do after successful login
                MessageBox.Show("Registeration has been successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

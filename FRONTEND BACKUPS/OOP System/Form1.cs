namespace OOP_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Admin" && txtPassword.Text == "pass")
            {
                lblErrorCredentials.Visible = false;
                Dashboard ds = new Dashboard();
                //move to new panel
                this.Hide();
                ds.Show();
            }
            else
            {
                lblErrorCredentials.Visible = true;
                txtPassword.Clear();
            }
        }

        private void lblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgot_Password fp = new Forgot_Password();
            this.Hide();
            fp.Show();
            // forgot password code backend

        }
    }
}

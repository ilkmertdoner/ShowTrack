using ShowTrack.Business;
using ShowTrack.DataAccess;
using ShowTrack.Properties;

namespace ShowTrack
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        bool isHidden = false;
        private void LoginButton_Click(object sender, EventArgs e)
        {
            var repo = new UserRepository();
            var service = new UserService(repo);

            var user = service.LoginControl(UsernameOrEmailTextBox.Text, PasswordTextBox.Text);

            if (user != null)
            {
                this.Hide();
                using (var mainForm = new MainForm(user))
                {
                    mainForm.ShowDialog();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username/email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SignUpLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var registerForm = new RegisterForm())
            {
                registerForm.ShowDialog();
            }
            this.Close();
        }

        private void ForgotPasswordLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var passwordReset = new PasswordResetForm())
            {
                passwordReset.ShowDialog();
            }
            this.Close();
        }

        private void PasswordTextBox_IconRightClick(object sender, EventArgs e)
        {

            if (isHidden)
            {
                PasswordTextBox.PasswordChar = '\0';
                isHidden = false;
                PasswordTextBox.IconRight = Properties.Resources.eye;
            }
            else
            {
                PasswordTextBox.PasswordChar = '●';
                isHidden = true;
                PasswordTextBox.IconRight = Properties.Resources.crossed_eye;
            }
        }
    }
}

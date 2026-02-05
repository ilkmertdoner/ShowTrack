using ShowTrack.Business;
using ShowTrack.DataAccess;

namespace ShowTrack
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

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
    }
}

using ShowTrack.Business;
using ShowTrack.DataAccess;
using ShowTrack.Properties;

namespace ShowTrack
{
    public partial class PasswordChangeUC : UserControl
    {
        public PasswordChangeUC()
        {
            InitializeComponent();
        }
        bool isHidden = false;
        private void LoginButton_Click(object sender, EventArgs e)
        {
            var repo = new UserRepository();
            var _userService = new UserService(repo);

            bool isValid = _userService.ChangePasswordControl(UserSession.CurrentUser.Id, UsernameOrEmailTextBox.Text,
                NewPasswordTextBox.Text, NewPasswordConfirmTextBox.Text);

            if (isValid)
            {
            }
        }

        private void NewPasswordTextBox_IconRightClick(object sender, EventArgs e)
        {
            if (isHidden)
            {
                NewPasswordTextBox.PasswordChar = '\0';
                isHidden = false;
                NewPasswordTextBox.IconRight = Properties.Resources.eye;
            }
            else
            {
                NewPasswordTextBox.PasswordChar = '●';
                isHidden = true;
                NewPasswordTextBox.IconRight = Properties.Resources.crossed_eye;
            }
        }

        private void ReturnLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

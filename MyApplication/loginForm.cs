using System.Linq;

namespace MyApplication
{
    public partial class LoginForm : Infrastructure.BaseForm
    {
        //private object corrent;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_load(object sender, System.EventArgs e)
        {
        }
        private void LoginButton_Click(object sender, System.EventArgs e)
        {

            System.Windows.Forms.MessageBox.Show("Login");

            Models.DatabaseContext DatabaseContext = null;

            try
            {
                DatabaseContext =
                    new Models.DatabaseContext();

                Models.User foundUser =
                    DatabaseContext.Users
                    .Where(current => string.Compare(current.Username, usernameTextBox.Text, true) == 0)
                    .FirstOrDefault();

                if (foundUser == null)

                {
                    System.Windows.Forms.MessageBox
                        .Show("username and/or password is not currect!");

                    usernameTextBox.Focus();

                    return;
                }

                if (string.Compare(foundUser.Password, passwordTextBox.Text, ignoreCase: false) != 0)
                {

                    System.Windows.Forms.MessageBox
                        .Show("username and/or password is not currect!");

                    usernameTextBox.Focus();

                    return;

                }

                if (foundUser.IsActive == false)
                {

                    System.Windows.Forms.MessageBox
                        .Show("you can not login to this application! please contact suport team.");

                    usernameTextBox.Focus();

                    return;
                }

                System.Windows.Forms.MessageBox.Show("Welcom!");


            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                if (DatabaseContext != null)
                {
                    DatabaseContext.Dispose();
                    DatabaseContext = null;
                }
            }

        }


        private void ResetButton_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Reset");
        }

        private void RegisterButton_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Register");
        }

        private void ExitButton_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Exit");
        }
    }
}

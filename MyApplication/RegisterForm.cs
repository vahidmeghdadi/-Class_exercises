using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace MyApplication
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Models.DatabaseContext DatabaseContext = null;

            try
            {
                DatabaseContext =
                    new Models.DatabaseContext();

                Models.User foundUser =
                    DatabaseContext.Users
                    .Where(current => string.Compare(current.Username, UsernameLabel.Text, true) == 0)
                    .FirstOrDefault();

                if (foundUser == null)

                {
                    System.Windows.Forms.MessageBox
                        .Show("username and/or password is not currect!");

                    UsernameLabel.Focus();

                    return;
                }

                if (string.Compare(foundUser.Password, passwordLabel.Text, ignoreCase: false) != 0)
                {

                    System.Windows.Forms.MessageBox
                        .Show("username and/or password is not currect!");

                    UsernameLabel.Focus();

                    return;

                }

                if (foundUser.IsActive == false)
                {

                    System.Windows.Forms.MessageBox
                        .Show("you can not login to this application! please contact suport team.");

                    UsernameLabel.Focus();

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

        private void resetButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Reset");
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Login");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Exit");
        }
    }
}

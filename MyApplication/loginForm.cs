using System;
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

				Infrastructure.Utility.AuthenticatedUser = foundUser;

				Hide();

				MainForm mainForm = new MainForm();

				mainForm.InitializeMainForm();

				mainForm.Show();


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

		internal void ResetForm()
		{
			throw new NotImplementedException();
		}

		private void ResetButton_Click(object sender, System.EventArgs e)
		{
			ResetForm();
		}

		public void resetForm()
		{
			passwordTextBox.Text = string.Empty;
			usernameTextBox.Text = string.Empty;

			usernameTextBox.Focus();
		}

		private void RegisterButton_Click(object sender, System.EventArgs e)
		{
			//system.windows.forms.messagebox.show("register");

			Infrastructure.Utility.RegisterForm.Show();
		}

		private void ExitButton_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.DialogResult result =
				System.Windows.Forms.MessageBox.Show
				(text: " آیا به خروج از برنامه اطمینان دارید ؟",
				caption: "سوال",
				buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
				icon: System.Windows.Forms.MessageBoxIcon.Question,
				defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
				options: System.Windows.Forms.MessageBoxOptions.RightAlign |
				System.Windows.Forms.MessageBoxOptions.RtlReading);

			if (result == System.Windows.Forms.DialogResult.Yes)
			{
				System.Windows.Forms.Application.Exit();
			}
		}

		private void LoginForm_Load_1(object sender, EventArgs e)
		{

		}
	}
}


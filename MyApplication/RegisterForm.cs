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
using System.Data.OleDb;
using System.Windows;
using System.Reflection;
using System.IO;
using Microsoft.Win32;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Runtime.InteropServices;



namespace MyApplication
{
	public partial class RegisterForm : Form
	{
		//private object usernameTextBox;
		//private object passwordTextBox;
		//private object fullnameTextBox;

		public RegisterForm()
		{
			InitializeComponent();
		}


		private void RegisterButton_Click(object sender, System.EventArgs e)
		{


			if ((string.IsNullOrWhiteSpace(usernameTextBox1.Text)) ||
				(string.IsNullOrWhiteSpace(usernameTextBox1.Text)))
			{

				usernameTextBox1.Text =
					usernameTextBox1.Text.Replace(" ", string.Empty);

				passwordTextBox1.Text =
					passwordTextBox1.Text.Replace(" ", string.Empty);

				System.Windows.Forms.MessageBox.Show("username and password is requied!");

				if (usernameTextBox1.Text == string.Empty)
				{
					usernameTextBox1.Focus();
				}
				else
				{
					passwordTextBox1.Focus();
				}
				return;
			}

			Models.DatabaseContext DatabaseContext = null;

			try
			{
				DatabaseContext =
					new Models.DatabaseContext();

				Models.User user =
					DatabaseContext.Users
					.Where(current => string.Compare(current.Username, usernameTextBox1.Text, true) == 0)
					.FirstOrDefault();

				if (user != null)
				{
					System.Windows.Forms.MessageBox.Show
						("this username is olready exist! please choose another one...!");

					usernameTextBox1.Focus();

					return;
				}

				user = new Models.User
				{
					FullName = fullnameTextBox1.Text,
					Password = passwordTextBox1.Text,
					Username = usernameTextBox1.Text,

					IsActive = true
				};

				DatabaseContext.Users.Add(user);

				DatabaseContext.SaveChanges();

				System.Windows.Forms.MessageBox.Show("Registration Done!");

				//دستور ذیل هم صحیح میباشد 
				//ResetButton_Click(null, null);

				resetForm();

			}

			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show("Error:" + ex.Message);
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

		//internal void ResetForm()
		//{
		//    throw new NotImplementedException();
		//}

		private void ResetButton_Click(object sender, System.EventArgs e)
		{
			resetForm();
		}

		private void resetForm()
		{
			usernameTextBox1.Text = string.Empty;
			passwordTextBox1.Text = string.Empty;
			fullnameTextBox1.Text = string.Empty;

			usernameTextBox1.Focus();
		}
	}


}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApplication
{
	public partial class Update_Profile_Form : Form
	{
		public Update_Profile_Form()
		{
			InitializeComponent();
		}

		private void Update_Profile_Form_Load(object sender, EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				Models.User currentUsers =
					databaseContext.Users
					.Where(current => current.Id == Infrastructure.Utility.AuthenticatedUser.Id)
					.FirstOrDefault();

				if (currentUsers == null)
				{
					System.Windows.Forms.Application.Exit();
				}

				fullnametextBox.Text = currentUsers.FullName;
				descriptionTextBox.Text = currentUsers.Description;
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show("Error" + ex.Message);
			}

			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					databaseContext = null;
				}
			}


		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				Models.User currentUser =
					databaseContext.Users
					.Where(current => current.Id == Infrastructure.Utility.AuthenticatedUser.Id)
					.FirstOrDefault();

				if (currentUser == null)
				{
					System.Windows.Forms.Application.Exit();
				}

				currentUser.FullName = fullnametextBox.Text;
				currentUser.Description = descriptionTextBox.Text;

				databaseContext.SaveChanges();

				Infrastructure.Utility.AuthenticatedUser = currentUser;

				//MainForm mainForm = this.MdiParent as MdiForm;

				//if (mainForm != null)
				//{
				//    mainForm.InitializeMainForm();
				//}

				Infrastructure.Utility.MainForm.InitializeMainForm();

				System.Windows.Forms.MessageBox
					.Show(" your profile was update successfully...");

			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show("Error:" + ex.Message);
			}

			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					databaseContext = null;
				}
			}

		}
	}
}

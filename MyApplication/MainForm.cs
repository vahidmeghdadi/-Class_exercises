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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        internal void InitializeMainForm()
        {
            throw new NotImplementedException();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private Form2 form2;
        //private DialogResult result;

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form2 form = new Form2();

            //form.mdiParent = this;

            //form.show();

            if ((form2 == null) || (form2.IsDisposed))
            {
                form2 = new Form2();

                form2.mdiParent = this;

                form2.show();
            }


        }

        private void StatusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
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

        private Update_Profile_Form updateProfileForm;

        private void UpdateProfileToolStripMeneuItem_Click(object sender, EventArgs e)
        {
            if ((updateProfileForm == null) || (updateProfileForm.IsDisposed))
            {
                updateProfileForm = new Update_Profile_Form
                {
                    MdiParent = this
                };
            }

            updateProfileForm.Show();
        }

        private ChangePasswordForm changePasswordForm;

        private void ChangePasswordToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if ((changePasswordForm == null) || (changePasswordForm.IsDisposed))
            {
                changePasswordForm = new ChangePasswordForm
                {
                    MdiParent = this
                };
            }

            changePasswordForm.Show();
        }

        private Admin.UserListForm userListForm;

        private void UserListToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if ((userListForm == null) || (userListForm.IsDisposed))
            {
                userListForm = new Admin.UserListForm
                {
                    MdiParent = this
                };
            }

            userListForm.Show();

        }

        private void LogoutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Infrastructure.Utility.MainForm.Hide();

            Infrastructure.Utility.AuthenticatedUser = null;

            Infrastructure.Utility.LoginForm.Show();
        }

        private void MainForm_FormClosed
            (object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}

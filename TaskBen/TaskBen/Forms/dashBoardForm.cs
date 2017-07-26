using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskBen.Class;
using MetroFramework;

namespace TaskBen.UserControls
{
    public partial class DashboardForm : UserControl
    {
        public DashboardForm()
        {
            InitializeComponent();
            round_image();
			init_data();
            
        }

		private void init_data()
		{
			fullnameLb.Text = Settings.user.FirstName + " " + Settings.user.LastName;
			emailLb.Text = Settings.user.Email;
			firstNameTb.Text = Settings.user.FirstName;
			lastNameTb.Text = Settings.user.LastName;
			emailTb.Text = Settings.user.Email;
		}

        private void round_image()
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;
        }

        private void editdataBtn_Click(object sender, EventArgs e)
        {
            if (firstNameTb.Text == "" || lastNameTb.Text == "" || emailTb.Text == "")
            {
                MetroMessageBox.Show(this, "Please complete all empty spaces!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (errorProvider1.GetError(emailTb) == "")
                {
                    Settings.user.FirstName = firstNameTb.Text;
                    Settings.user.LastName = lastNameTb.Text;
                    if (Settings.user.update_user())
                        init_data();
                }
                else
                    MetroMessageBox.Show(this, "The email need to be a valid one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editpassBtn_Click(object sender, EventArgs e)
        {
            Settings.user.Password = oldpassTb.Text;
            Settings.user.NewPassword = newpassTb.Text;
            if (Settings.user.update_password())
                init_data();
        }

        private void emailTb_TextChanged(object sender, EventArgs e)
        {
            string email = emailTb.Text;

            if (email.IndexOf("@") == -1 || email.IndexOf(".") == -1 || email.Length < 5)
                errorProvider1.SetError(emailTb, "Needs to be a valid email");
            else
                errorProvider1.Clear();

            Settings.user.Email = email;
        }

        /*private void emailTb_TextChanged(object sender, EventArgs e)
        {
            
        }*/
    }
}

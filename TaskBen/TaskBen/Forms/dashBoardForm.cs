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
using System.Text.RegularExpressions;

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
                    string mesaj = Settings.user.update_user();
                    if (mesaj == "User data has updated succesfully!")
                    {
                        MetroMessageBox.Show(this, "User data has updated succesfully!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        init_data();
                    }
                    else
                        MetroMessageBox.Show(this, mesaj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MetroMessageBox.Show(this, "The email need to be a valid one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editpassBtn_Click(object sender, EventArgs e)
        {
            if (errorProviderOldPass.GetError(oldpassTb) == "" && errorProviderNewPass.GetError(newpassTb) == "")
            {
                string mesaj = Settings.user.update_password();
                if (mesaj == "User data has updated succesfully!")
                {
                        MetroMessageBox.Show(this, "Password changed succesfully!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        init_data();
                }
                else
                     MetroMessageBox.Show(this, mesaj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MetroMessageBox.Show(this, "Needs to contain at least 8 characters and an upper character!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            oldpassTb.Text = "";
            newpassTb.Text = "";

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

        private void newpassTb_TextChanged(object sender, EventArgs e)
        {
            string password = newpassTb.Text;
            var hasUpperChar = new Regex(@"[A-Z]+");

            if (hasUpperChar.IsMatch(password) && password.Length >= 8)
                errorProviderNewPass.Clear();
            else
                errorProviderNewPass.SetError(newpassTb, "Needs to contain at least 8 characters and an upper character!");

            Settings.user.NewPassword = password;
        }

        private void oldpassTb_TextChanged(object sender, EventArgs e)
        {
            string password = oldpassTb.Text;
            var hasUpperChar = new Regex(@"[A-Z]+");

            if (hasUpperChar.IsMatch(password) && password.Length >= 8)
                errorProviderOldPass.Clear();
            else
                errorProviderOldPass.SetError(oldpassTb, "Needs to contain at least 8 characters and an upper character!");

            Settings.user.Password = password;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        /*private void emailTb_TextChanged(object sender, EventArgs e)
        {
            
        }*/
    }
}

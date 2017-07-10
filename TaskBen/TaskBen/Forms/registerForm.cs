using TaskBen.Forms;
using TaskBen.Class;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskBen.Forms
{
    public partial class registerForm : MetroFramework.Forms.MetroForm
    {
        User user = new User();
        
        public registerForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            loginForm form2 = new loginForm();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (nameTb.Text == "" || surrTb.Text == "" || passTb.Text == "" || emailTb.Text == "")
                MetroMessageBox.Show(this, "Please complete all empty spaces!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (errorProvider1.GetError(emailTb) == "" && errorProvider2.GetError(passTb) == "")
                {
                    if (user.register())
                    {
                        MetroMessageBox.Show(this, "Succes!", "Account created", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        this.Hide();
                        loginForm form2 = new loginForm();
                        form2.Closed += (s, args) => this.Close();
                        form2.Show();
                    }
                }
                else
                {
                    if (errorProvider1.GetError(emailTb) != "")
                        MetroMessageBox.Show(this, "The email need to be a valid one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if(errorProvider2.GetError(passTb) != "")
                        MetroMessageBox.Show(this, "The password needs to contain at least 8 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void emailTb_TextChanged(object sender, EventArgs e)
        {
            string a = emailTb.Text;

            if (a.IndexOf("@") == -1 || a.IndexOf(".") == -1 || a.Length<5)
                errorProvider1.SetError(emailTb, "Needs to be a valid email");
            else
                errorProvider1.Clear();

            user.Email = a;
        }

        private void passTb_TextChanged(object sender, EventArgs e)
        {
            string a = passTb.Text;

            if (a.Length < 8)
                errorProvider2.SetError(passTb, "Needs to contain at least 8 characters");
            else
                errorProvider2.Clear();

            user.Password = a;
        }

        private void nameTb_TextChanged(object sender, EventArgs e)
        {
            user.FirstName = nameTb.Text;
        }

        private void surrTb_TextChanged(object sender, EventArgs e)
        {
            user.LastName = surrTb.Text;
        }
    }
}

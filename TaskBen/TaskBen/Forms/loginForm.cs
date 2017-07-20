using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskBen.Class;
using TaskBen.Forms;


namespace TaskBen
{
    public partial class loginForm : MetroFramework.Forms.MetroForm
    {
        public User user = new User();

		public loginForm()
        {
            InitializeComponent();
            panel2.Visible = false;
            this.MaximizeBox = false;
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            registerForm form2 = new registerForm();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Location = new Point(247, 217);
            panel2.Visible = true;

            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (user.login())
            {
                this.Hide();
                screenForm form2 = new screenForm();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
        }


        private void emailTb_TextChanged(object sender, EventArgs e)
        {
            user.Email = emailTb.Text;
        }

        private void passTb_TextChanged(object sender, EventArgs e)
        {
            user.Password = passTb.Text;
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }
        
    }
}



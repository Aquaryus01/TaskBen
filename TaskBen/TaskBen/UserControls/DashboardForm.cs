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
            Settings.user.FirstName = firstNameTb.Text;
            Settings.user.LastName = lastNameTb.Text;
            Settings.user.Email = emailTb.Text;
            if (Settings.user.update_user())
                init_data();
        }

        private void editpassBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

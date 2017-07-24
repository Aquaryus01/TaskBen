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

        }

        private void editpassBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

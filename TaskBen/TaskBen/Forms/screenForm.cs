using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskBen.Class;

namespace TaskBen.Forms
{
    public partial class screenForm : MetroFramework.Forms.MetroForm
    {
        private void Hour_initialization()
        {
            for (int i = 1; i <= 24; i++)
            {
                string[] numbers = { i.ToString() };
                remHoursCB.Items.AddRange(numbers);
                dateHoursCB.Items.AddRange(numbers);
            }

            remHoursCB.SelectedIndex = Int32.Parse(DateTime.Now.ToString("hh")) - 1;
            dateHoursCB.SelectedIndex = Int32.Parse(DateTime.Now.ToString("hh")) - 1;
        }

        private void Minute_initialization()
        {
            for (int i = 1; i < 60; i++)
            {
                string[] numbers = { i.ToString() };
                remMinutesCB.Items.AddRange(numbers);
                dateMinuteCB.Items.AddRange(numbers);
            }

            remMinutesCB.SelectedIndex = Int32.Parse(DateTime.Now.ToString("mm")) - 1;
            dateMinuteCB.SelectedIndex = Int32.Parse(DateTime.Now.ToString("mm")) - 1;
        }

        public screenForm()
        {
            InitializeComponent();

            this.Opacity = 0.99;
            SubtitleLb.Text = (DateTime.Now.ToString("dd/MM/yyyy"));
            this.BackColor = Color.Red;
        }

        private void animBtn_Click(object sender, EventArgs e)
        {
            animUpTimer.Enabled = false;
            animDownTimer.Enabled = true;
            repeatCB.SelectedIndex = 0;
            Hour_initialization();
            Minute_initialization();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            animUpTimer.Enabled = true;
            animDownTimer.Enabled = false;
        }

        private void animTimer_Tick(object sender, EventArgs e)
        {
            if (addPanel.Height >= 417)
                animDownTimer.Enabled = false;
            else
                addPanel.Height += 12;
        }

        private void animUpTimer_Tick(object sender, EventArgs e)
        {
            if (addPanel.Height <= 0)
                animUpTimer.Enabled = false;
            else
                addPanel.Height -= 12;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            animUpTimer.Enabled = false;
            animDownTimer.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.new_instance_taks();
            if (timeCheck.Checked && remCheck.Checked)
            {
                //all
                Settings.task.Date = toDoDateTime.Value.ToString("d");
                Settings.task.repeat = repeatCB.Text;
                Settings.task.RemHH = remHoursCB.Text;
                Settings.task.RemMM = remMinutesCB.Text;
                Settings.task.DateHH = dateHoursCB.Text;
                Settings.task.DateMM = dateMinuteCB.Text;
                Settings.task.Description = descriptionTB.Text;
            }
            else if (timeCheck.Checked && !remCheck.Checked)
            {
                //only time
                Settings.task.Date = toDoDateTime.Value.ToString("d");
                Settings.task.repeat = repeatCB.Text;
                Settings.task.DateHH = dateHoursCB.Text;
                Settings.task.DateMM = dateMinuteCB.Text;
                Settings.task.Description = descriptionTB.Text;
            }
            else if (!timeCheck.Checked && remCheck.Checked)
            {
                //onlt rem
                Settings.task.Date = toDoDateTime.Value.ToString("d");
                Settings.task.repeat = repeatCB.Text;
                Settings.task.RemHH = remHoursCB.Text;
                Settings.task.RemMM = remMinutesCB.Text;
                Settings.task.Description = descriptionTB.Text;
                MessageBox.Show(Settings.task.RemMM);
            }
            else if (!(timeCheck.Checked && remCheck.Checked))
            {
                //none
                Settings.task.Date = toDoDateTime.Value.ToString("d");
                Settings.task.repeat = repeatCB.Text;
                Settings.task.Description = descriptionTB.Text;
            }

            Settings.task.task_add();
        }

        
    }
}

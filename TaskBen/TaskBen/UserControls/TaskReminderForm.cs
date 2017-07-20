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
using TaskBen.Forms;
using System.Media;

namespace TaskBen.UserControls
{
    public partial class TaskReminderForm : UserControl
    {
        public TaskReminderForm()
        {
            InitializeComponent();

        }

        string soundfile = @"alarm.wav";
        SoundPlayer sound;

        public void verify_time()
        {
            sound = new SoundPlayer(soundfile);
            foreach (Todo x in Settings.taskList)
            {

                string hour = x.ReminderHours;
                string minute = x.ReminderMinutes;

                if (hour == DateTime.Now.ToString("HH") && minute == DateTime.Now.ToString("mm"))
                {
                    textLb.Text = x.Description;
                    reminderLb.Text = "Just " + hour + " Hours and " + minute + " minutes until the task start!";
                    sound.Play();
                }
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            sound.Stop();
        }

        
    }
}

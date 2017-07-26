using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskBen.Class;

namespace TaskBen.Forms
{
    public partial class reminderForm : MetroFramework.Forms.MetroForm
    {
        public reminderForm()
        {
            InitializeComponent();
        }

        string soundfile = @"alarm.wav";
        SoundPlayer sound;

        public void verify_time()
        {  
            foreach (Todo x in Settings.taskList)
            {
                string hour = x.ReminderHours;
                string minute = x.ReminderMinutes;
                string Lhour = x.DateHours;
                string Lminute = x.DateMinutes;

                try
                {
                    int a = Convert.ToInt32(Lhour);
                    int b = Convert.ToInt32(hour);
                    int c = a - b;
                    string dif_hour = c.ToString();

                    a = Convert.ToInt32(Lminute);
                    b = Convert.ToInt32(minute);
                    c = a - b;
                    string dif_minutes = c.ToString();

                    if (hour == DateTime.Now.ToString("HH") && minute == DateTime.Now.ToString("mm"))
                    {
                        sound = new SoundPlayer(soundfile);
                        textLb.Text = x.Description;
                        reminderLb.Text = "Just " + dif_hour + " Hours and " + dif_minutes + " minutes until the task start!";
                        sound.Play();
                        this.Show();
                    }
                }
                catch
                {
                    if (hour == DateTime.Now.ToString("HH") && minute == DateTime.Now.ToString("mm"))
                    {
                        sound = new SoundPlayer(soundfile);
                        textLb.Text = x.Description;
                        reminderLb.Text = "";
                        sound.Play();
                        this.Show();
                    }
                }
            }
            
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            sound.Stop();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

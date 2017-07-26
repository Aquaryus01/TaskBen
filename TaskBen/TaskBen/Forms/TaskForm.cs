using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using TaskBen.Class;
using TaskBen.Forms;

namespace TaskBen.UserControls
{
    public partial class TaskForm : UserControl
    {
        Todo _task = new Todo();
        public screenForm ParentForm { get; set; }

        public TaskForm()
        {
            InitializeComponent();
        }

        public void Init_task(Todo task)
        {
            _task = task;
            //this.BackColor;
            titleLb.Text = _task.Title;
            descriptionLb.Text = task.Description;

            if (_task.DateHours == "" || _task.DateHours == null)
            {
                dateLb.Text = _task.Date;
            }
            else
            {
                dateLb.Text = _task.Date + " " + _task.DateHours + ":" + _task.DateMinutes;
            }

            if (_task.ReminderHours == "" || _task.ReminderHours == null)
            {
                reminderLb.Text = "None";
            }
            else
            {
                reminderLb.Text = _task.ReminderHours + ":" + _task.ReminderMinutes;
            }

            periodLb.Text = _task.Schedule;
            
            if (_task.Checked == 1)
            {
                checkBox.Checked = true;
            }
            else
            {
                checkBox.Checked = false;
            }


            if (descriptionLb.Text != "")
            {
                this.Size = new Size(969, 100 + descriptionLb.Height);
                descriptionLb.Location = new Point(45, 61);
            }
            else
                this.Size = new Size(969, 100);

            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Settings.taskList.Remove(_task);
            _task.remove_web();
            this.ParentForm.add_tasks_form();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox.Checked)
            {
                _task.Checked = 1;
				titleLb.Font = new Font(titleLb.Font, FontStyle.Strikeout);
			}
            else
            {
                _task.Checked = 0;
				titleLb.Font = new Font(titleLb.Font, FontStyle.Regular);
			}

            Settings.task = _task;
            Settings.task.update_web();

			


		}

        private void TaskForm_Click(object sender, EventArgs e)
        {
            Settings.task = _task;
            this.ParentForm.show_edit();
        }

        private void dateLb_Click(object sender, EventArgs e)
        {

        }

        private void descriptionLb_Click(object sender, EventArgs e)
        {

        }

        private void titleLb_Click(object sender, EventArgs e)
        {

        }
    }
}

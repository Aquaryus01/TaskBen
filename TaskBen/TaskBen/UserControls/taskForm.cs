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
            textLb.Text = _task.Description;
            
            if (_task.DateHours=="")
            {
                dateLb.Text = _task.Date;
            }
            else
            {
                dateLb.Text = _task.Date + " " + _task.DateHours + ":" + _task.DateMinutes;
            }

            if (_task.ReminderHours == "")
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
            }
            else
            {
                _task.Checked = 0;
            }

            Settings.task = _task;
            Settings.task.update_web();

        }
    }
}

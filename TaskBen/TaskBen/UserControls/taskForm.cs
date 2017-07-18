using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using TaskBen.Class;

namespace TaskBen.UserControls
{
    public partial class TaskForm : UserControl
    {
        Todo _task = new Todo();
        public TaskForm()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void Init_task(Todo task)
        {
            _task = task;
            textLb.Text = _task.Description;
            dateLb.Text = _task.Date + " " + _task.DateHH + ":" +_task.DateMM;
            reminderLb.Text = _task.repeat + " " + _task.RemHH + ":" + _task.RemMM;
        }

        private void xLb_Click(object sender, EventArgs e)
        {
            Settings.taskList.Remove(_task);
        }
    }
}

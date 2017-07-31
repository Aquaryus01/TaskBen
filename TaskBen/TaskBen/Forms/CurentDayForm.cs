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
using TaskBen.UserControls;

namespace TaskBen.Forms
{
    public partial class CurentDayForm : UserControl
    {
        int ok = 0;

        private void loading()
        {
            dateLb.Text = (DateTime.Now.ToString("dd MMMM, yyyy"));
            Settings.taskList = new List<Todo>();
            Settings.task.task_get_list_repeat();
            add_tasks_form();
        }

        public CurentDayForm()
        {
            InitializeComponent();
            loading();   
        }

        public void add_tasks_form()
        {
            ok = 0;
            Settings.poz_y_task = 0;
            listPanel.Controls.Clear();
            if (Settings.taskList != null)
            {
                foreach (Todo todo in Settings.taskList)
                {
                    TaskForm taskForm = new TaskForm();
                    taskForm.Init_task(todo);

                    taskForm.Location = new Point(Settings.poz_x_task - 3, listPanel.AutoScrollPosition.Y + Settings.poz_y_task);
                    taskForm.AutoScroll = true;
                    Settings.poz_y_task += taskForm.Height + 10;
                    taskForm.ParentFormToday = this;

                    ok = 1;
                    listPanel.Controls.Add(taskForm);
                }
            }

            if (ok == 0)
            {

            }
        }
    }
}

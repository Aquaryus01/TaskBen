using MetroFramework;
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
using TaskBen.UserControls;

namespace TaskBen.Forms
{
    public partial class screenForm : MetroFramework.Forms.MetroForm
    {
        private void Hour_initialization()
        {
            remHoursCB.SelectedIndex = Int32.Parse(DateTime.Now.ToString("HH")); //- 1;
            dateHoursCB.SelectedIndex = Int32.Parse(DateTime.Now.ToString("HH")); //- 1;
        }

        private void Minute_initialization()
        {

            remMinutesCB.SelectedIndex = Int32.Parse(DateTime.Now.ToString("mm"));//- 1;
            dateMinuteCB.SelectedIndex = Int32.Parse(DateTime.Now.ToString("mm")) ;///- 1;
        }

        private void time_initialization()
        {
            for (int i = 0; i < 60; i++)
            {
                if (i < 10)
                {
                    string[] numbers = {"0" + i.ToString() };
                    remMinutesCB.Items.AddRange(numbers);
                    dateMinuteCB.Items.AddRange(numbers);
                }
                else
                {
                    string[] numbers = { i.ToString() };
                    remMinutesCB.Items.AddRange(numbers);
                    dateMinuteCB.Items.AddRange(numbers);
                }
            }

            for (int i = 0; i <= 23; i++)
            {
                if (i < 10)
                {
                    string[] numbers = { "0" + i.ToString() };
                    remHoursCB.Items.AddRange(numbers);
                    dateHoursCB.Items.AddRange(numbers);
                }
                else
                {
                    string[] numbers = {i.ToString() };
                    remHoursCB.Items.AddRange(numbers);
                    dateHoursCB.Items.AddRange(numbers);
                }
            }
        }

        public screenForm()
        {
            InitializeComponent();
            time_initialization();
            SubtitleLb.Text = (DateTime.Now.ToString("dd/MM/yyyy"));
            Settings.task.task_get_list();
            add_tasks_form();
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

        private void downupTimer_Tick(object sender, EventArgs e)
        {
            if (addPanel.Height <= 0)
                animUpTimer.Enabled = false;
            else
                addPanel.Height -= 12;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.new_instance_taks();
            int date_comp = DateTime.Compare(DateTime.Now.Date, toDoDateTime.Value.Date);
            if (descriptionTB.Text != "")
            {
                if (date_comp<=0)
                {
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

                    Settings.taskList.Add(Settings.task);   //Add task in the list
                    Settings.task.add_web();   //Add task in the database
                    add_task_form(Settings.task);   //Add task in the screenForm
                    MetroMessageBox.Show(this,"You just created a new to-do", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    animUpTimer.Enabled = true;
                    animDownTimer.Enabled = false;
                }
                else
                {
                    MetroMessageBox.Show(this, "The date you have chosen has already passed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Please complete the Title!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void add_task_form(Todo task)
        {
            var item = Settings.taskList[Settings.taskList.Count - 1];
            TaskForm taskForm = new TaskForm();
            taskForm.Init_task(item);

            taskForm.Location = new Point(Settings.poz_x, listPanel.AutoScrollPosition.Y + Settings.poz_y);
            taskForm.AutoScroll = true;
            taskForm.ParentForm = this;
            Settings.poz_y+= 58;

            listPanel.Controls.Add(taskForm);
        }

        public void add_tasks_form()
        {
            Settings.poz_y = 0;
            listPanel.Controls.Clear(); 

            if(Settings.taskList != null)
                foreach (Todo todo in Settings.taskList)
                {
                    TaskForm taskForm = new TaskForm();
                    taskForm.Init_task(todo);

                    taskForm.Location = new Point(Settings.poz_x, listPanel.AutoScrollPosition.Y + Settings.poz_y);
                    taskForm.AutoScroll = true;
                    taskForm.ParentForm = this;
                    Settings.poz_y += 58;

                    listPanel.Controls.Add(taskForm);
                }
            
        }       
    }
}

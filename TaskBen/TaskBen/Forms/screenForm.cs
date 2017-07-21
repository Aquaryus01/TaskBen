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
        ReminderForm a = new ReminderForm();

        ///Settings
        private void Hour_initialization()
        {
            remHoursCB.SelectedIndex = Int32.Parse(DateTime.Now.ToString("HH"));
            dateHoursCB.SelectedIndex = Int32.Parse(DateTime.Now.ToString("HH"));
        }
        private void Minute_initialization()
        {
            remMinutesCB.SelectedIndex = Int32.Parse(DateTime.Now.ToString("mm"));
            dateMinutesCB.SelectedIndex = Int32.Parse(DateTime.Now.ToString("mm"));
        }
        private void time_initialization()
        {
            for (int i = 0; i < 60; i++)
            {
                if (i < 10)
                {
                    string[] numbers = {"0" + i.ToString() };
                    remMinutesCB.Items.AddRange(numbers);
                    dateMinutesCB.Items.AddRange(numbers);
                }
                else
                {
                    string[] numbers = { i.ToString() };
                    remMinutesCB.Items.AddRange(numbers);
                    dateMinutesCB.Items.AddRange(numbers);
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
        private void dezactivate_datetime_firsttime()
        {
            timeCheck.Checked = false;
            dateHoursCB.Enabled = false;
            dateMinutesCB.Enabled = false;
        }
        private void dezactivate_remtime_firsttime()
        {
            remCheck.Checked = false;
            remHoursCB.Enabled = false;
            remMinutesCB.Enabled = false;
        }
        private void tehnicalAdjustment_newtaks()
        {
            createBtn.Visible = true;
        }
        private bool getDataAccurate_task()
        {
            int date_comp = DateTime.Compare(DateTime.Now.Date, toDoDateTime.Value.Date);
            int date_now_hour = DateTime.Now.Hour;
            int date_now_minute = DateTime.Now.Minute;

            if (titleTb.Text == "")
            {
                MetroMessageBox.Show(this, "Please complete the Title!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (date_comp > 0)
            {
                MetroMessageBox.Show(this, "The date you have chosen has already passed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(timeCheck.Checked)
            { 
                if (((date_now_hour > Convert.ToInt32(dateHoursCB.Text) && date_comp == 0) || (date_now_hour == Convert.ToInt32(dateHoursCB.Text) && date_now_minute >= Convert.ToInt32(dateMinutesCB.Text) && date_comp == 0)))
                {
                    MetroMessageBox.Show(this, "The Date Time is incorect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else if (remCheck.Checked)
            {
                if ((Convert.ToInt32(dateHoursCB.Text) == Convert.ToInt32(remHoursCB.Text) && (Convert.ToInt32(dateMinutesCB.Text) <= Convert.ToInt32(remMinutesCB.Text) && date_comp == 0)) || (Convert.ToInt32(dateHoursCB.Text) < Convert.ToInt32(remHoursCB.Text) && date_comp == 0))
                {
                    MetroMessageBox.Show(this, "The reminder time is after the date time!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;


        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            animUpTimer.Enabled = true;
            animDownTimer.Enabled = false;

        }
        private void animTimer_Tick(object sender, EventArgs e)
        {
            if (addPanel.Height >= 607)
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
        ///Settings

        public screenForm()
        {
            /////VERIFICA INCA O DATA!!!!!
            InitializeComponent();
            time_initialization();

            Settings.task.task_get_list();
            add_tasks_form();
            
            Every10second.Start();

            int vertScrollWidth = SystemInformation.VerticalScrollBarWidth;
            listPanel.Padding = new Padding(0, 0, vertScrollWidth, 0);
        }
  
        private void animBtn_Click(object sender, EventArgs e)
        {
            //MAI VERIFICA
            animUpTimer.Enabled = false;
            animDownTimer.Enabled = true;
            tehnicalAdjustment_newtaks();
            dezactivate_datetime_firsttime();
            dezactivate_remtime_firsttime();
            Hour_initialization();
            Minute_initialization();
            descriptionTB.Text = "";
            repeatCB.SelectedIndex = 0;
        }





        private void button1_Click(object sender, EventArgs e)
        {
            Settings.new_instance_taks();   //new instance of class
            if (getDataAccurate_task())     //if the informatian were accurate
            {
                if (timeCheck.Checked && remCheck.Checked)
                {
                    //all
                    Settings.task.Date = toDoDateTime.Value.ToString("d");
                    Settings.task.Schedule = repeatCB.Text;
                    Settings.task.ReminderHours = remHoursCB.Text;
                    Settings.task.ReminderMinutes = remMinutesCB.Text;
                    Settings.task.DateHours = dateHoursCB.Text;
                    Settings.task.DateMinutes = dateMinutesCB.Text;
                    Settings.task.Description = descriptionTB.Text;
                    Settings.task.Title = titleTb.Text;
                }
                else if (timeCheck.Checked && !remCheck.Checked)
                {
                    //only time
                    Settings.task.Date = toDoDateTime.Value.ToString("d");
                    Settings.task.Schedule = repeatCB.Text;
                    Settings.task.DateHours = dateHoursCB.Text;
                    Settings.task.DateMinutes = dateMinutesCB.Text;
                    Settings.task.Description = descriptionTB.Text;
                    Settings.task.Title = titleTb.Text;
                }
                else if (!timeCheck.Checked && remCheck.Checked)
                {
                    //onlt rem
                    Settings.task.Date = toDoDateTime.Value.ToString("d");
                    Settings.task.Schedule = repeatCB.Text;
                    Settings.task.ReminderHours = remHoursCB.Text;
                    Settings.task.ReminderMinutes = remMinutesCB.Text;
                    Settings.task.Description = descriptionTB.Text;
                    Settings.task.Title = titleTb.Text;
                }
                else if (!(timeCheck.Checked && remCheck.Checked))
                {
                    //none
                    Settings.task.Date = toDoDateTime.Value.ToString("d");
                    Settings.task.Schedule = repeatCB.Text;
                    Settings.task.Description = descriptionTB.Text;
                    Settings.task.Title = titleTb.Text;
                }
                Settings.taskList.Add(Settings.task);   //Add task in the list
                if (Settings.task.add_web())             //Add task in the database
                {
                    add_task_form(Settings.task);   //Add task in the screenForm
                    MetroMessageBox.Show(this, "You just created a new to-do", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    animUpTimer.Enabled = true;
                    animDownTimer.Enabled = false;

                }


            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            int id = Settings.task.Id;
            Settings.task.clear();
            if (getDataAccurate_task())
            {
                    if (timeCheck.Checked && remCheck.Checked)
                    {
                        //all
                        Settings.task.Date = toDoDateTime.Value.ToString("d");
                        Settings.task.Schedule = repeatCB.Text;
                        Settings.task.ReminderHours = remHoursCB.Text;
                        Settings.task.ReminderMinutes = remMinutesCB.Text;
                        Settings.task.DateHours = dateHoursCB.Text;
                        Settings.task.DateMinutes = dateMinutesCB.Text;
                        Settings.task.Description = descriptionTB.Text;
                        Settings.task.Title = titleTb.Text;
                    }
                    else if (timeCheck.Checked && !remCheck.Checked)
                    {
                        //only time
                        Settings.task.Date = toDoDateTime.Value.ToString("d");
                        Settings.task.Schedule = repeatCB.Text;
                        Settings.task.DateHours = dateHoursCB.Text;
                        Settings.task.DateMinutes = dateMinutesCB.Text;
                        Settings.task.Description = descriptionTB.Text;
                        Settings.task.Title = titleTb.Text;
                    }
                    else if (!timeCheck.Checked && remCheck.Checked)
                    {
                        //onlt rem
                        Settings.task.Date = toDoDateTime.Value.ToString("d");
                        Settings.task.Schedule = repeatCB.Text;
                        Settings.task.ReminderHours = remHoursCB.Text;
                        Settings.task.ReminderMinutes = remMinutesCB.Text;
                        Settings.task.Description = descriptionTB.Text;
                        Settings.task.Title = titleTb.Text;
                    }
                    else if (!(timeCheck.Checked && remCheck.Checked))
                    {
                        //none
                        Settings.task.Date = toDoDateTime.Value.ToString("d");
                        Settings.task.Schedule = repeatCB.Text;
                        Settings.task.Description = descriptionTB.Text;
                        Settings.task.Title = titleTb.Text;
                    }

                    Settings.task.Id = id;
                    Settings.taskList = new List<Todo>();
                    Settings.task.update_web();
                    Settings.task.task_get_list();
                    add_tasks_form();
                    MetroMessageBox.Show(this, "You just edit the new to-do!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    animUpTimer.Enabled = true;
                    animDownTimer.Enabled = false;
            }
        }

        private void add_task_form(Todo task)
        {
            var item = Settings.taskList[Settings.taskList.Count - 1];
            TaskForm taskForm = new TaskForm();
            taskForm.Init_task(item);

            taskForm.Location = new Point(Settings.poz_x-3, listPanel.AutoScrollPosition.Y + Settings.poz_y);
            taskForm.AutoScroll = true;
            taskForm.ParentForm = this;
            Settings.poz_y += taskForm.Height + 10;

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

                    taskForm.Location = new Point(Settings.poz_x-3, listPanel.AutoScrollPosition.Y + Settings.poz_y);
                    taskForm.AutoScroll = true;
                    taskForm.ParentForm = this;
                    Settings.poz_y += taskForm.Height + 10;

                    listPanel.Controls.Add(taskForm);
                }
            
        }

        public void show_edit()
        {
            edit_task_settings();

            DateTime x = new DateTime();
            x = Convert.ToDateTime(Settings.task.Date);
            toDoDateTime.Value = x;
            repeatCB.Text =  Settings.task.Schedule;
            remHoursCB.Text = Settings.task.ReminderHours;
            remMinutesCB.Text = Settings.task.ReminderMinutes;
            dateHoursCB.Text = Settings.task.DateHours;
            dateMinutesCB.Text = Settings.task.DateMinutes;
            descriptionTB.Text = Settings.task.Description;
            titleTb.Text = Settings.task.Title;
        }

        public void edit_task_settings()
        {
            createBtn.Visible = false;
            animUpTimer.Enabled = false;
            animDownTimer.Enabled = true;

        }

        private void timeCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(timeCheck.Checked)
            {
                dateHoursCB.Enabled = true;
                dateMinutesCB.Enabled = true;
            }
            else
            {
                dateHoursCB.Enabled = false;
                dateMinutesCB.Enabled = false;
            }
        }
        private void remCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (remCheck.Checked)
            {
                remHoursCB.Enabled = true;
                remMinutesCB.Enabled = true;
            }
            else
            {
                remHoursCB.Enabled = false;
                remMinutesCB.Enabled = false;
            }
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            ShowInTaskbar = true;
        }
        private void xBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            notifyIcon1.Icon = SystemIcons.Application;
        }
        private void Every1minute_Tick(object sender, EventArgs e)
        {
            a.verify_time();
        }

        private void taskForm1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

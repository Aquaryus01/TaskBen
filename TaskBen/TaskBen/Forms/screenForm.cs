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
    public partial class ScreenForm : MetroFramework.Forms.MetroForm
    {
        ReminderForm remForm = new ReminderForm();
        DashboardForm dashboardForm = new DashboardForm();
        CurentDayForm curentDayForm = new CurentDayForm();
        
        Label notaskLb = new Label();
        int ok = 0;
        private void notaskLb_make()
        {
            notaskLb.AutoSize = true;
            notaskLb.BackColor = System.Drawing.Color.Transparent;
            notaskLb.Font = new System.Drawing.Font("Arctik 2.5", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            notaskLb.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            notaskLb.Location = new System.Drawing.Point(327, 182);
            notaskLb.Size = new System.Drawing.Size(283, 36);
            notaskLb.TabIndex = 0;
            notaskLb.Text = "                     Plan a to-do for today!\r\nPress \"Plan your next move!\" to cre" +
    "ate a task!";
        }
        
        public void Load_groups()
        {
            Settings.groupList = Settings.group.get_groups(Settings.user.ID);
            add_groups_form();
        }
        ///Settings
        private void Hour_initialization()
        {
            remHoursCB.SelectedIndex = Int32.Parse(DateTime.Now.ToString("HH"));
            dateHoursCB.SelectedIndex = Int32.Parse(DateTime.Now.ToString("HH"));
        }
        private void Minute_initialization()
        {
            remMinutesCB.SelectedIndex = Int32.Parse(DateTime.Now.ToString("mm")) + 1;
            dateMinutesCB.SelectedIndex = Int32.Parse(DateTime.Now.ToString("mm")) + 1;
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
                if (remHoursCB.Text == "" || dateHoursCB.Text == "" || dateMinutesCB.Text == "" || remMinutesCB.Text == "")
                {
                    MetroMessageBox.Show(this, "Please complete all date-time !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if ((date_now_hour > Convert.ToInt32(dateHoursCB.Text) && date_comp == 0) || (date_now_hour == Convert.ToInt32(dateHoursCB.Text) && date_now_minute >= Convert.ToInt32(dateMinutesCB.Text) && date_comp == 0))
                {
                    MetroMessageBox.Show(this, "The Date Time is before the time now!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if ((Convert.ToInt32(remHoursCB.Text) > Convert.ToInt32(dateHoursCB.Text)) || (Convert.ToInt32(remHoursCB.Text) == Convert.ToInt32(dateHoursCB.Text) && (Convert.ToInt32(remMinutesCB.Text) > Convert.ToInt32(dateMinutesCB.Text))))
                {
                    MetroMessageBox.Show(this, "The Reminder Time is after the Date Time!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if ((date_now_hour > Convert.ToInt32(remHoursCB.Text) && date_comp == 0) || (date_now_hour == Convert.ToInt32(remHoursCB.Text) && date_now_minute >= Convert.ToInt32(remMinutesCB.Text) && date_comp == 0))
                {
                    MetroMessageBox.Show(this, "The Reminder Time is before the time now!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void screenForm_Shown(object sender, EventArgs e)
        {

        }

        internal void openGroupForm(Group group)
        {
            panel_etc.Height = 607;
            panel_etc.Controls.Clear();
            GroupForm newGroupForm = new GroupForm();
            newGroupForm.initialization(group);
            panel_etc.Controls.Add(newGroupForm);
        }

        public void loading2()
        {
            time_initialization();

            Settings.screenForm = this;

            Every1minute.Start();

            Settings.task.task_get_list();
            add_tasks_form();

            Load_groups();
        }

        public ScreenForm()
        {
            InitializeComponent();
            loading2();
        }
  
        private void animBtn_Click(object sender, EventArgs e)
        {
            //MAI VERIFICA
            titleTb.Text = "";
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
                if (timeCheck.Checked)
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
                else if (!(timeCheck.Checked))
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
                    if (timeCheck.Checked)
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
                    else
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

            taskForm.Location = new Point(Settings.poz_x_task-3, listPanel.AutoScrollPosition.Y + Settings.poz_y_task);
            taskForm.AutoScroll = true;
            taskForm.ParentForm = this;
            Settings.poz_y_task += taskForm.Height + 10;

            listPanel.Controls.Add(taskForm);
            notaskLb.Visible = false;
        }

        public void add_group_form()
        {
            var item = Settings.groupList[Settings.groupList.Count - 1];
            GroupTabForm groupSelectForm = new GroupTabForm();
            groupSelectForm.Init_group(item);

            groupSelectForm.Location = new Point(Settings.poz_x_group, groupPanel.AutoScrollPosition.Y + Settings.poz_y_group);
            groupSelectForm.AutoScroll = true;
            groupPanel.Controls.Add(groupSelectForm);
            Settings.poz_y_group += groupSelectForm.Height + 1;
        }

        public void add_groups_form()
        {
            groupPanel.Controls.Clear();
            Settings.poz_y_group = 0;
            foreach (Group item in Settings.groupList)
            {
                GroupTabForm groupSelectForm = new GroupTabForm();
                groupSelectForm.Init_group(item);
                groupSelectForm.Location = new Point(Settings.poz_x_group, groupPanel.AutoScrollPosition.Y + Settings.poz_y_group);
                groupSelectForm.AutoScroll = true;
                groupPanel.Controls.Add(groupSelectForm);
                Settings.poz_y_group += groupSelectForm.Height + 1;
            }
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

                    taskForm.Location = new Point(Settings.poz_x_task, listPanel.AutoScrollPosition.Y + Settings.poz_y_task);
                    taskForm.AutoScroll = true;
                    taskForm.ParentForm = this;
                    Settings.poz_y_task += taskForm.Height + 10;

                    ok=1;
                    listPanel.Controls.Add(taskForm);
                }
            }

            if(ok==0)
            {
                notaskLb = new Label();
                notaskLb_make();
                listPanel.Controls.Add(notaskLb);
            }   
        }

        public void show_edit()
        {
            edit_task_settings();

            DateTime x = new DateTime();
            x = Convert.ToDateTime(Settings.task.Date);
            toDoDateTime.Value = x;

            if (Settings.task.Schedule == "")
                repeatCB.SelectedIndex = -1;
            repeatCB.Text = Settings.task.Schedule;
            if (Settings.task.ReminderHours == "")
                remHoursCB.SelectedIndex = -1;
            remHoursCB.Text = Settings.task.ReminderHours;
            if(Settings.task.ReminderMinutes=="")
                remMinutesCB.SelectedIndex = -1;
            remMinutesCB.Text = Settings.task.ReminderMinutes;
            if(Settings.task.DateHours=="")
                dateHoursCB.SelectedIndex = -1;
            dateHoursCB.Text = Settings.task.DateHours;
            if(Settings.task.DateMinutes=="")
                dateMinutesCB.SelectedIndex = -1;
            dateMinutesCB.Text = Settings.task.DateMinutes;
            descriptionTB.Text = Settings.task.Description;
            titleTb.Text = Settings.task.Title;
  
            if (remHoursCB.Text == "")
            {
                timeCheck.Checked = false;
            }
            else
            {
                timeCheck.Checked = true;
            }
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
                remHoursCB.Enabled = true;
                remMinutesCB.Enabled = true;
            }
            else
            {
                dateHoursCB.Enabled = false;
                dateMinutesCB.Enabled = false;
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
            remForm.verify_time();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            panel_etc.Height = 607;
            panel_etc.Controls.Clear();
            panel_etc.Controls.Add(dashboardForm);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Settings.task.task_get_list();
            add_tasks_form();
            searchBarTb.Text = "";
            panel_etc.Height = 0;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Settings.taskList = new List<Todo>();
            Settings.task.task_get_list(searchBarTb.Text);
            add_tasks_form();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void curentDayBtn_Click(object sender, EventArgs e)
        {
            panel_etc.Height = 607;
            panel_etc.Controls.Clear();
            CurentDayForm curentDayForm = new CurentDayForm();
            panel_etc.Controls.Add(curentDayForm);
        }

        public void button4_Click(object sender, EventArgs e)
        {
            panel_etc.Height = 607;
            panel_etc.Controls.Clear();
            CreateGroupForm newGroupForm = new CreateGroupForm();
            newGroupForm.ParentForm = this;

            panel_etc.Controls.Add(newGroupForm);
        }

        public void edit_group(Group _group)
        {
            panel_etc.Height = 607;
            panel_etc.Controls.Clear();
            CreateGroupForm newGroupForm = new CreateGroupForm(_group);
            newGroupForm.ParentForm = this;

            panel_etc.Controls.Add(newGroupForm);
        }


    }
}
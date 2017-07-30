using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using TaskBen.Class;
using TaskBen.UserControls;

namespace TaskBen.Forms
{
    public partial class GroupForm : UserControl
    {
        private int poz_x = 0;
        private int poz_y = 0;
        private List<Todo> todo_list = new List<Todo>();
        private Group group = new Group();
        private Todo task = new Todo();

        public GroupForm()
        {
            InitializeComponent();
            time_initialization();

            //SHOW TASK
            //Settings.task.task_get_list();
            
            //add_tasks_form();

            //SHOW TASK
        }

        internal void initialization(Group groupx)
        {
            group = groupx;
            TitleLb.Text = group.Name;
            DescriptionLb.Text = group.Description;
        }

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
            if (TaskPanel.Height >= 607)
                animDownTimer.Enabled = false;
            else
                TaskPanel.Height += 12;
        }
        private void animUpTimer_Tick(object sender, EventArgs e)
        {
            if (TaskPanel.Height <= 0)
                animUpTimer.Enabled = false;
            else
                TaskPanel.Height -= 12;
        }
        private void downupTimer_Tick(object sender, EventArgs e)
        {

        }

        private void animBtn_Click(object sender, EventArgs e)
        {

            task = new Todo();
            task.Date = toDoDateTime.Value.ToString("d");
            task.Schedule = repeatCB.Text;

            TitleLb.Text = task.Title;
            DescriptionLb.Text = task.Description;

            animUpTimer.Enabled = false;
            animDownTimer.Enabled = true;
            tehnicalAdjustment_newtaks();
            dezactivate_datetime_firsttime();
            dezactivate_remtime_firsttime();
            Hour_initialization();
            Minute_initialization();
            repeatCB.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            task = new Todo();
            task.IdGroup = group.Id;
            if (getDataAccurate_task())     //if the informatian were accurate
            {
                if (timeCheck.Checked)
                {
                    //all
                    task.Date = toDoDateTime.Value.ToString("d");
                    task.Schedule = repeatCB.Text;
                    task.ReminderHours = remHoursCB.Text;
                    task.ReminderMinutes = remMinutesCB.Text;
                    task.DateHours = dateHoursCB.Text;
                    task.DateMinutes = dateMinutesCB.Text;
                    task.Description = descriptionTB.Text;
                    task.Title = titleTb.Text;
                }
                else if (!(timeCheck.Checked))
                {
                    //none
                    task.Date = toDoDateTime.Value.ToString("d");
                    task.Schedule = repeatCB.Text;
                    task.Description = descriptionTB.Text;
                    task.Title = titleTb.Text;
                }

                
                todo_list.Add(task);   //Add task in the list
                if (task.add_web_group())    //Add task in the database
                {
                    add_task_form(task);   //Add task in the GroupForm
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

                    /*Settings.task.Id = id;
                    Settings.taskList = new List<Todo>();
                    Settings.task.update_web();
                    Settings.task.task_get_list();
                    add_tasks_form();
                    MetroMessageBox.Show(this, "You just edit the new to-do!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    animUpTimer.Enabled = true;
                    animDownTimer.Enabled = false;*/
            }
        }

        private void add_task_form(Todo task)
        {
            var item = todo_list[todo_list.Count - 1];
            TaskForm taskForm = new TaskForm();
            taskForm.Init_task(item);

            taskForm.Location = new Point(poz_x-3, TaskPanel.AutoScrollPosition.Y + poz_y);
            taskForm.AutoScroll = true;
            taskForm.Type("group");
            //taskForm.ParentForm = this;
            //Settings.poz_y_task += taskForm.Height + 10;

            listPanel.Controls.Add(taskForm);
            notaskLb.Visible = false;
        }

        public void add_tasks_form()
        {
            ok = 0;
            poz_y = 0;
            listPanel.Controls.Clear();
            if (Settings.taskList != null)
            {
                foreach (Todo todo in Settings.taskList)
                {

                    TaskForm taskForm = new TaskForm();
                    taskForm.Init_task(todo);

                    taskForm.Location = new Point(poz_x, listPanel.AutoScrollPosition.Y + poz_x);
                    taskForm.AutoScroll = true;
                    taskForm.GroupForm = this;
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

        private void titleTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void descriptionTB_TextChanged(object sender, EventArgs e)
        {

        }

        /*private void xBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            notifyIcon1.Icon = SystemIcons.Application;
        }*/// PUNE!!!!!!!!!!!!!!!!!!!!!

    }
}

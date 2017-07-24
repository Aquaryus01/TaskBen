namespace TaskBen.Forms
{
    partial class screenForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(screenForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_etc = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.addPanel = new System.Windows.Forms.Panel();
            this.titleTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.remCheck = new MetroFramework.Controls.MetroCheckBox();
            this.timeCheck = new MetroFramework.Controls.MetroCheckBox();
            this.dateHoursCB = new MetroFramework.Controls.MetroComboBox();
            this.dateMinutesCB = new MetroFramework.Controls.MetroComboBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.remHoursCB = new MetroFramework.Controls.MetroComboBox();
            this.remMinutesCB = new MetroFramework.Controls.MetroComboBox();
            this.repeatCB = new MetroFramework.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toDoDateTime = new MetroFramework.Controls.MetroDateTime();
            this.descriptionTB = new System.Windows.Forms.TextBox();
            this.editBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.animBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listPanel = new System.Windows.Forms.Panel();
            this.animDownTimer = new System.Windows.Forms.Timer(this.components);
            this.animUpTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Every1minute = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.addPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel_etc);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.addPanel);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.listPanel);
            this.panel1.Location = new System.Drawing.Point(0, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1193, 607);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Black", 8.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 45);
            this.button1.TabIndex = 22;
            this.button1.Text = "Curent Day";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel_etc
            // 
            this.panel_etc.Location = new System.Drawing.Point(199, 0);
            this.panel_etc.Name = "panel_etc";
            this.panel_etc.Size = new System.Drawing.Size(993, 0);
            this.panel_etc.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Black", 8.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 45);
            this.button2.TabIndex = 11;
            this.button2.Text = "Dashboard";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addPanel
            // 
            this.addPanel.BackColor = System.Drawing.Color.White;
            this.addPanel.Controls.Add(this.titleTb);
            this.addPanel.Controls.Add(this.label6);
            this.addPanel.Controls.Add(this.label4);
            this.addPanel.Controls.Add(this.backBtn);
            this.addPanel.Controls.Add(this.remCheck);
            this.addPanel.Controls.Add(this.timeCheck);
            this.addPanel.Controls.Add(this.dateHoursCB);
            this.addPanel.Controls.Add(this.dateMinutesCB);
            this.addPanel.Controls.Add(this.createBtn);
            this.addPanel.Controls.Add(this.remHoursCB);
            this.addPanel.Controls.Add(this.remMinutesCB);
            this.addPanel.Controls.Add(this.repeatCB);
            this.addPanel.Controls.Add(this.label3);
            this.addPanel.Controls.Add(this.label2);
            this.addPanel.Controls.Add(this.label1);
            this.addPanel.Controls.Add(this.toDoDateTime);
            this.addPanel.Controls.Add(this.descriptionTB);
            this.addPanel.Controls.Add(this.editBtn);
            this.addPanel.Location = new System.Drawing.Point(199, 188);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(993, 0);
            this.addPanel.TabIndex = 7;
            // 
            // titleTb
            // 
            this.titleTb.Location = new System.Drawing.Point(33, 46);
            this.titleTb.Name = "titleTb";
            this.titleTb.Size = new System.Drawing.Size(721, 20);
            this.titleTb.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arctik 1.5", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 35;
            this.label6.Text = "Description:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arctik 1.5", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Title:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Maroon;
            this.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Arial Black", 8.75F, System.Drawing.FontStyle.Bold);
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(272, 361);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(235, 23);
            this.backBtn.TabIndex = 27;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // remCheck
            // 
            this.remCheck.AutoSize = true;
            this.remCheck.Location = new System.Drawing.Point(345, 274);
            this.remCheck.Name = "remCheck";
            this.remCheck.Size = new System.Drawing.Size(99, 15);
            this.remCheck.TabIndex = 33;
            this.remCheck.Text = "Add Reminder";
            this.remCheck.UseSelectable = true;
            this.remCheck.CheckedChanged += new System.EventHandler(this.remCheck_CheckedChanged);
            // 
            // timeCheck
            // 
            this.timeCheck.AutoSize = true;
            this.timeCheck.Location = new System.Drawing.Point(39, 286);
            this.timeCheck.Name = "timeCheck";
            this.timeCheck.Size = new System.Drawing.Size(75, 15);
            this.timeCheck.TabIndex = 32;
            this.timeCheck.Text = "Add Time";
            this.timeCheck.UseSelectable = true;
            this.timeCheck.CheckedChanged += new System.EventHandler(this.timeCheck_CheckedChanged);
            // 
            // dateHoursCB
            // 
            this.dateHoursCB.DisplayMember = "12";
            this.dateHoursCB.FormattingEnabled = true;
            this.dateHoursCB.ItemHeight = 23;
            this.dateHoursCB.Location = new System.Drawing.Point(120, 274);
            this.dateHoursCB.Name = "dateHoursCB";
            this.dateHoursCB.Size = new System.Drawing.Size(91, 29);
            this.dateHoursCB.TabIndex = 31;
            this.dateHoursCB.UseSelectable = true;
            // 
            // dateMinutesCB
            // 
            this.dateMinutesCB.FormattingEnabled = true;
            this.dateMinutesCB.ItemHeight = 23;
            this.dateMinutesCB.Location = new System.Drawing.Point(217, 274);
            this.dateMinutesCB.Name = "dateMinutesCB";
            this.dateMinutesCB.Size = new System.Drawing.Size(91, 29);
            this.dateMinutesCB.TabIndex = 30;
            this.dateMinutesCB.UseSelectable = true;
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.createBtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.createBtn.FlatAppearance.BorderSize = 0;
            this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBtn.Font = new System.Drawing.Font("Arial Black", 8.75F, System.Drawing.FontStyle.Bold);
            this.createBtn.ForeColor = System.Drawing.Color.White;
            this.createBtn.Location = new System.Drawing.Point(33, 361);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(208, 23);
            this.createBtn.TabIndex = 29;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // remHoursCB
            // 
            this.remHoursCB.FormattingEnabled = true;
            this.remHoursCB.ItemHeight = 23;
            this.remHoursCB.Location = new System.Drawing.Point(345, 229);
            this.remHoursCB.Name = "remHoursCB";
            this.remHoursCB.Size = new System.Drawing.Size(91, 29);
            this.remHoursCB.TabIndex = 28;
            this.remHoursCB.UseSelectable = true;
            // 
            // remMinutesCB
            // 
            this.remMinutesCB.FormattingEnabled = true;
            this.remMinutesCB.ItemHeight = 23;
            this.remMinutesCB.Location = new System.Drawing.Point(453, 229);
            this.remMinutesCB.Name = "remMinutesCB";
            this.remMinutesCB.Size = new System.Drawing.Size(91, 29);
            this.remMinutesCB.TabIndex = 26;
            this.remMinutesCB.UseSelectable = true;
            // 
            // repeatCB
            // 
            this.repeatCB.FormattingEnabled = true;
            this.repeatCB.ItemHeight = 23;
            this.repeatCB.Items.AddRange(new object[] {
            "Once",
            "Working day",
            "Daily",
            "Weekly",
            "Monthly",
            ""});
            this.repeatCB.Location = new System.Drawing.Point(602, 229);
            this.repeatCB.Name = "repeatCB";
            this.repeatCB.Size = new System.Drawing.Size(152, 29);
            this.repeatCB.TabIndex = 25;
            this.repeatCB.UseSelectable = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arctik 1.5", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(607, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Repeat:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arctik 1.5", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(349, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Reminder:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arctik 1.5", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Date:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // toDoDateTime
            // 
            this.toDoDateTime.Location = new System.Drawing.Point(33, 229);
            this.toDoDateTime.MinimumSize = new System.Drawing.Size(4, 29);
            this.toDoDateTime.Name = "toDoDateTime";
            this.toDoDateTime.Size = new System.Drawing.Size(275, 29);
            this.toDoDateTime.TabIndex = 22;
            // 
            // descriptionTB
            // 
            this.descriptionTB.Location = new System.Drawing.Point(33, 104);
            this.descriptionTB.Multiline = true;
            this.descriptionTB.Name = "descriptionTB";
            this.descriptionTB.Size = new System.Drawing.Size(721, 82);
            this.descriptionTB.TabIndex = 20;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.editBtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Arial Black", 8.75F, System.Drawing.FontStyle.Bold);
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Location = new System.Drawing.Point(33, 361);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(208, 23);
            this.editBtn.TabIndex = 34;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Controls.Add(this.animBtn);
            this.panel4.Location = new System.Drawing.Point(199, 188);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(993, 69);
            this.panel4.TabIndex = 16;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // animBtn
            // 
            this.animBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.animBtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.animBtn.FlatAppearance.BorderSize = 0;
            this.animBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.animBtn.Font = new System.Drawing.Font("Arial Black", 8.75F, System.Drawing.FontStyle.Bold);
            this.animBtn.ForeColor = System.Drawing.Color.DimGray;
            this.animBtn.Location = new System.Drawing.Point(19, 18);
            this.animBtn.Name = "animBtn";
            this.animBtn.Size = new System.Drawing.Size(173, 36);
            this.animBtn.TabIndex = 10;
            this.animBtn.Text = "Plan your next move!";
            this.animBtn.UseVisualStyleBackColor = false;
            this.animBtn.Click += new System.EventHandler(this.animBtn_Click);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.metroTextBox1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(199, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(993, 188);
            this.panel3.TabIndex = 16;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(359, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Enabled = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(272, 128);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(381, 23);
            this.metroTextBox1.TabIndex = 20;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(373, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // listPanel
            // 
            this.listPanel.AutoScroll = true;
            this.listPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listPanel.Location = new System.Drawing.Point(199, 256);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(993, 351);
            this.listPanel.TabIndex = 15;
            this.listPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.listPanel_Paint);
            // 
            // animDownTimer
            // 
            this.animDownTimer.Interval = 15;
            this.animDownTimer.Tick += new System.EventHandler(this.animTimer_Tick);
            // 
            // animUpTimer
            // 
            this.animUpTimer.Interval = 15;
            this.animUpTimer.Tick += new System.EventHandler(this.animUpTimer_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Text = "TaskBen 1.2";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Every1minute
            // 
            this.Every1minute.Interval = 60000;
            this.Every1minute.Tick += new System.EventHandler(this.Every1minute_Tick);
            // 
            // screenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1191, 612);
            this.Controls.Add(this.panel1);
            this.Name = "screenForm";
            this.TransparencyKey = System.Drawing.Color.Ivory;
            this.Shown += new System.EventHandler(this.screenForm_Shown);
            this.panel1.ResumeLayout(false);
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.Timer animDownTimer;
        private System.Windows.Forms.Timer animUpTimer;
        private System.Windows.Forms.Panel listPanel;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer Every1minute;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button backBtn;
        private MetroFramework.Controls.MetroCheckBox remCheck;
        private MetroFramework.Controls.MetroCheckBox timeCheck;
        private MetroFramework.Controls.MetroComboBox dateHoursCB;
        private MetroFramework.Controls.MetroComboBox dateMinutesCB;
        private MetroFramework.Controls.MetroComboBox remHoursCB;
        private MetroFramework.Controls.MetroComboBox remMinutesCB;
        private MetroFramework.Controls.MetroComboBox repeatCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroDateTime toDoDateTime;
        private System.Windows.Forms.TextBox descriptionTB;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.TextBox titleTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button animBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel_etc;
        private System.Windows.Forms.Button button1;

    }
}
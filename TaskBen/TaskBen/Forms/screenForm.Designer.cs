namespace TaskBen.Forms
{
    partial class ScreenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.groupPanel = new System.Windows.Forms.Panel();
            this.curentDayBtn = new System.Windows.Forms.Button();
            this.panel_etc = new System.Windows.Forms.Panel();
            this.addPanel = new System.Windows.Forms.Panel();
            this.titleTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.searchBarTb = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.animBtn = new System.Windows.Forms.Button();
            this.animDownTimer = new System.Windows.Forms.Timer(this.components);
            this.animUpTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Every1minute = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.addPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.groupPanel);
            this.panel1.Controls.Add(this.curentDayBtn);
            this.panel1.Controls.Add(this.panel_etc);
            this.panel1.Controls.Add(this.addPanel);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.listPanel);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(-1, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1191, 607);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gainsboro;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial Black", 8.75F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.DimGray;
            this.button4.Location = new System.Drawing.Point(1, 231);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(196, 33);
            this.button4.TabIndex = 11;
            this.button4.Text = "Create a group";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupPanel
            // 
            this.groupPanel.AutoScroll = true;
            this.groupPanel.Location = new System.Drawing.Point(1, 266);
            this.groupPanel.Name = "groupPanel";
            this.groupPanel.Size = new System.Drawing.Size(197, 337);
            this.groupPanel.TabIndex = 24;
            // 
            // curentDayBtn
            // 
            this.curentDayBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.curentDayBtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.curentDayBtn.FlatAppearance.BorderSize = 0;
            this.curentDayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.curentDayBtn.Font = new System.Drawing.Font("Arctik 1", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curentDayBtn.ForeColor = System.Drawing.Color.White;
            this.curentDayBtn.Location = new System.Drawing.Point(1, 137);
            this.curentDayBtn.Name = "curentDayBtn";
            this.curentDayBtn.Size = new System.Drawing.Size(197, 28);
            this.curentDayBtn.TabIndex = 23;
            this.curentDayBtn.Text = "Curent Day";
            this.curentDayBtn.UseVisualStyleBackColor = false;
            this.curentDayBtn.Click += new System.EventHandler(this.curentDayBtn_Click);
            // 
            // panel_etc
            // 
            this.panel_etc.Location = new System.Drawing.Point(199, 0);
            this.panel_etc.Name = "panel_etc";
            this.panel_etc.Size = new System.Drawing.Size(993, 0);
            this.panel_etc.TabIndex = 21;
            // 
            // addPanel
            // 
            this.addPanel.BackColor = System.Drawing.Color.White;
            this.addPanel.Controls.Add(this.titleTb);
            this.addPanel.Controls.Add(this.label6);
            this.addPanel.Controls.Add(this.label4);
            this.addPanel.Controls.Add(this.backBtn);
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
            this.addPanel.Location = new System.Drawing.Point(199, 198);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(993, 500);
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
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Title:";
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
            // timeCheck
            // 
            this.timeCheck.AutoSize = true;
            this.timeCheck.Location = new System.Drawing.Point(332, 205);
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
            this.dateHoursCB.Location = new System.Drawing.Point(332, 229);
            this.dateHoursCB.Name = "dateHoursCB";
            this.dateHoursCB.Size = new System.Drawing.Size(91, 29);
            this.dateHoursCB.TabIndex = 31;
            this.dateHoursCB.UseSelectable = true;
            // 
            // dateMinutesCB
            // 
            this.dateMinutesCB.FormattingEnabled = true;
            this.dateMinutesCB.ItemHeight = 23;
            this.dateMinutesCB.Location = new System.Drawing.Point(429, 229);
            this.dateMinutesCB.Name = "dateMinutesCB";
            this.dateMinutesCB.Size = new System.Drawing.Size(91, 29);
            this.dateMinutesCB.TabIndex = 30;
            this.dateMinutesCB.UseSelectable = true;
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
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
            this.remHoursCB.Location = new System.Drawing.Point(562, 229);
            this.remHoursCB.Name = "remHoursCB";
            this.remHoursCB.Size = new System.Drawing.Size(91, 29);
            this.remHoursCB.TabIndex = 28;
            this.remHoursCB.UseSelectable = true;
            // 
            // remMinutesCB
            // 
            this.remMinutesCB.FormattingEnabled = true;
            this.remMinutesCB.ItemHeight = 23;
            this.remMinutesCB.Location = new System.Drawing.Point(659, 229);
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
            this.repeatCB.Location = new System.Drawing.Point(39, 300);
            this.repeatCB.Name = "repeatCB";
            this.repeatCB.Size = new System.Drawing.Size(152, 29);
            this.repeatCB.TabIndex = 25;
            this.repeatCB.UseSelectable = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Repeat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(559, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Reminder:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Date:";
            // 
            // toDoDateTime
            // 
            this.toDoDateTime.Location = new System.Drawing.Point(33, 229);
            this.toDoDateTime.MinimumSize = new System.Drawing.Size(0, 29);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arctik 1", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 28);
            this.button1.TabIndex = 22;
            this.button1.Text = "Tasks";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.searchBarTb);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1192, 137);
            this.panel3.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1170, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.xBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(724, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // searchBarTb
            // 
            // 
            // 
            // 
            this.searchBarTb.CustomButton.Image = null;
            this.searchBarTb.CustomButton.Location = new System.Drawing.Point(285, 1);
            this.searchBarTb.CustomButton.Name = "";
            this.searchBarTb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.searchBarTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchBarTb.CustomButton.TabIndex = 1;
            this.searchBarTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchBarTb.CustomButton.UseSelectable = true;
            this.searchBarTb.CustomButton.Visible = false;
            this.searchBarTb.Lines = new string[0];
            this.searchBarTb.Location = new System.Drawing.Point(438, 81);
            this.searchBarTb.MaxLength = 32767;
            this.searchBarTb.Name = "searchBarTb";
            this.searchBarTb.PasswordChar = '\0';
            this.searchBarTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchBarTb.SelectedText = "";
            this.searchBarTb.SelectionLength = 0;
            this.searchBarTb.SelectionStart = 0;
            this.searchBarTb.ShortcutsEnabled = true;
            this.searchBarTb.Size = new System.Drawing.Size(307, 23);
            this.searchBarTb.TabIndex = 20;
            this.searchBarTb.UseSelectable = true;
            this.searchBarTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchBarTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(505, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arctik 1", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 28);
            this.button2.TabIndex = 11;
            this.button2.Text = "Settings";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listPanel
            // 
            this.listPanel.AutoScroll = true;
            this.listPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.listPanel.Location = new System.Drawing.Point(199, 204);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(993, 402);
            this.listPanel.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel4.Controls.Add(this.animBtn);
            this.panel4.Location = new System.Drawing.Point(199, 136);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(993, 69);
            this.panel4.TabIndex = 16;
            // 
            // animBtn
            // 
            this.animBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.animBtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.animBtn.FlatAppearance.BorderSize = 0;
            this.animBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.animBtn.Font = new System.Drawing.Font("Arial Black", 8.75F, System.Drawing.FontStyle.Bold);
            this.animBtn.ForeColor = System.Drawing.Color.DimGray;
            this.animBtn.Location = new System.Drawing.Point(19, 15);
            this.animBtn.Name = "animBtn";
            this.animBtn.Size = new System.Drawing.Size(173, 36);
            this.animBtn.TabIndex = 10;
            this.animBtn.Text = "Plan your next move!";
            this.animBtn.UseVisualStyleBackColor = false;
            this.animBtn.Click += new System.EventHandler(this.animBtn_Click);
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
            this.Every1minute.Interval = 5000;
            this.Every1minute.Tick += new System.EventHandler(this.Every1minute_Tick);
            // 
            // ScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1191, 612);
            this.Controls.Add(this.panel1);
            this.Name = "ScreenForm";
            this.TransparencyKey = System.Drawing.Color.Ivory;
            this.Shown += new System.EventHandler(this.screenForm_Shown);
            this.panel1.ResumeLayout(false);
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
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
        private MetroFramework.Controls.MetroTextBox searchBarTb;
        private System.Windows.Forms.Panel panel_etc;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button curentDayBtn;
        private System.Windows.Forms.Panel groupPanel;
        private System.Windows.Forms.Button button4;

    }
}
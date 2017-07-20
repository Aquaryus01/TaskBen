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
            this.addPanel = new System.Windows.Forms.Panel();
            this.hidePanel = new System.Windows.Forms.Panel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
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
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.animBtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.xBtn = new System.Windows.Forms.Button();
            this.SubtitleLb = new System.Windows.Forms.Label();
            this.TitleLb = new System.Windows.Forms.Label();
            this.animDownTimer = new System.Windows.Forms.Timer(this.components);
            this.animUpTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Every10second = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.addPanel.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.addPanel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.listPanel);
            this.panel1.Location = new System.Drawing.Point(0, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 607);
            this.panel1.TabIndex = 0;
            // 
            // addPanel
            // 
            this.addPanel.BackColor = System.Drawing.Color.White;
            this.addPanel.Controls.Add(this.hidePanel);
            this.addPanel.Controls.Add(this.metroTabControl1);
            this.addPanel.Location = new System.Drawing.Point(223, 198);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(969, 500);
            this.addPanel.TabIndex = 7;
            // 
            // hidePanel
            // 
            this.hidePanel.Location = new System.Drawing.Point(28, 5);
            this.hidePanel.Name = "hidePanel";
            this.hidePanel.Size = new System.Drawing.Size(938, 40);
            this.hidePanel.TabIndex = 1;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(32, 5);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(889, 399);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.label4);
            this.metroTabPage1.Controls.Add(this.backBtn);
            this.metroTabPage1.Controls.Add(this.remCheck);
            this.metroTabPage1.Controls.Add(this.timeCheck);
            this.metroTabPage1.Controls.Add(this.dateHoursCB);
            this.metroTabPage1.Controls.Add(this.dateMinutesCB);
            this.metroTabPage1.Controls.Add(this.createBtn);
            this.metroTabPage1.Controls.Add(this.remHoursCB);
            this.metroTabPage1.Controls.Add(this.remMinutesCB);
            this.metroTabPage1.Controls.Add(this.repeatCB);
            this.metroTabPage1.Controls.Add(this.label3);
            this.metroTabPage1.Controls.Add(this.label2);
            this.metroTabPage1.Controls.Add(this.label1);
            this.metroTabPage1.Controls.Add(this.toDoDateTime);
            this.metroTabPage1.Controls.Add(this.descriptionTB);
            this.metroTabPage1.Controls.Add(this.editBtn);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(881, 357);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Create a new to-do";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Black", 10.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Title:";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Red;
            this.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Arial Black", 8.75F, System.Drawing.FontStyle.Bold);
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(246, 282);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(235, 23);
            this.backBtn.TabIndex = 11;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // remCheck
            // 
            this.remCheck.AutoSize = true;
            this.remCheck.Location = new System.Drawing.Point(319, 189);
            this.remCheck.Name = "remCheck";
            this.remCheck.Size = new System.Drawing.Size(99, 15);
            this.remCheck.TabIndex = 17;
            this.remCheck.Text = "Add Reminder";
            this.remCheck.UseSelectable = true;
            this.remCheck.CheckedChanged += new System.EventHandler(this.remCheck_CheckedChanged);
            // 
            // timeCheck
            // 
            this.timeCheck.AutoSize = true;
            this.timeCheck.Location = new System.Drawing.Point(7, 189);
            this.timeCheck.Name = "timeCheck";
            this.timeCheck.Size = new System.Drawing.Size(75, 15);
            this.timeCheck.TabIndex = 16;
            this.timeCheck.Text = "Add Time";
            this.timeCheck.UseSelectable = true;
            this.timeCheck.CheckedChanged += new System.EventHandler(this.timeCheck_CheckedChanged);
            // 
            // dateHoursCB
            // 
            this.dateHoursCB.DisplayMember = "12";
            this.dateHoursCB.FormattingEnabled = true;
            this.dateHoursCB.ItemHeight = 23;
            this.dateHoursCB.Location = new System.Drawing.Point(7, 215);
            this.dateHoursCB.Name = "dateHoursCB";
            this.dateHoursCB.Size = new System.Drawing.Size(91, 29);
            this.dateHoursCB.TabIndex = 14;
            this.dateHoursCB.UseSelectable = true;
            // 
            // dateMinutesCB
            // 
            this.dateMinutesCB.FormattingEnabled = true;
            this.dateMinutesCB.ItemHeight = 23;
            this.dateMinutesCB.Location = new System.Drawing.Point(113, 215);
            this.dateMinutesCB.Name = "dateMinutesCB";
            this.dateMinutesCB.Size = new System.Drawing.Size(91, 29);
            this.dateMinutesCB.TabIndex = 13;
            this.dateMinutesCB.UseSelectable = true;
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.createBtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.createBtn.FlatAppearance.BorderSize = 0;
            this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBtn.Font = new System.Drawing.Font("Arial Black", 8.75F, System.Drawing.FontStyle.Bold);
            this.createBtn.ForeColor = System.Drawing.Color.White;
            this.createBtn.Location = new System.Drawing.Point(7, 282);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(208, 23);
            this.createBtn.TabIndex = 12;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // remHoursCB
            // 
            this.remHoursCB.FormattingEnabled = true;
            this.remHoursCB.ItemHeight = 23;
            this.remHoursCB.Location = new System.Drawing.Point(319, 144);
            this.remHoursCB.Name = "remHoursCB";
            this.remHoursCB.Size = new System.Drawing.Size(91, 29);
            this.remHoursCB.TabIndex = 11;
            this.remHoursCB.UseSelectable = true;
            // 
            // remMinutesCB
            // 
            this.remMinutesCB.FormattingEnabled = true;
            this.remMinutesCB.ItemHeight = 23;
            this.remMinutesCB.Location = new System.Drawing.Point(427, 144);
            this.remMinutesCB.Name = "remMinutesCB";
            this.remMinutesCB.Size = new System.Drawing.Size(91, 29);
            this.remMinutesCB.TabIndex = 10;
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
            this.repeatCB.Location = new System.Drawing.Point(576, 144);
            this.repeatCB.Name = "repeatCB";
            this.repeatCB.Size = new System.Drawing.Size(152, 29);
            this.repeatCB.TabIndex = 8;
            this.repeatCB.UseSelectable = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Black", 10.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(572, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Repeat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 10.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(315, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Reminder:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 10.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date:";
            // 
            // toDoDateTime
            // 
            this.toDoDateTime.Location = new System.Drawing.Point(7, 144);
            this.toDoDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.toDoDateTime.Name = "toDoDateTime";
            this.toDoDateTime.Size = new System.Drawing.Size(252, 29);
            this.toDoDateTime.TabIndex = 3;
            // 
            // descriptionTB
            // 
            this.descriptionTB.Location = new System.Drawing.Point(7, 56);
            this.descriptionTB.Name = "descriptionTB";
            this.descriptionTB.Size = new System.Drawing.Size(721, 20);
            this.descriptionTB.TabIndex = 2;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Teal;
            this.editBtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Arial Black", 8.75F, System.Drawing.FontStyle.Bold);
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Location = new System.Drawing.Point(7, 282);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(208, 23);
            this.editBtn.TabIndex = 18;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.button2);
            this.metroTabPage2.Controls.Add(this.label6);
            this.metroTabPage2.Controls.Add(this.button1);
            this.metroTabPage2.Controls.Add(this.label5);
            this.metroTabPage2.Controls.Add(this.textBox2);
            this.metroTabPage2.Controls.Add(this.textBox1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(881, 357);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Create a new note";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Black", 8.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(248, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(235, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Black", 10.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(3, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Description:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SpringGreen;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Black", 8.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(7, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Black", 10.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(3, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Title:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 126);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(609, 107);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(609, 20);
            this.textBox1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.animBtn);
            this.panel2.Location = new System.Drawing.Point(223, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(969, 46);
            this.panel2.TabIndex = 3;
            // 
            // animBtn
            // 
            this.animBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.animBtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.animBtn.FlatAppearance.BorderSize = 0;
            this.animBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.animBtn.Font = new System.Drawing.Font("Arial Black", 8.75F, System.Drawing.FontStyle.Bold);
            this.animBtn.ForeColor = System.Drawing.Color.White;
            this.animBtn.Location = new System.Drawing.Point(32, 10);
            this.animBtn.Name = "animBtn";
            this.animBtn.Size = new System.Drawing.Size(235, 23);
            this.animBtn.TabIndex = 10;
            this.animBtn.Text = "Plan your next move!";
            this.animBtn.UseVisualStyleBackColor = false;
            this.animBtn.Click += new System.EventHandler(this.animBtn_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Location = new System.Drawing.Point(1, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(223, 145);
            this.panel5.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.Location = new System.Drawing.Point(0, 143);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(223, 465);
            this.panel4.TabIndex = 2;
            // 
            // listPanel
            // 
            this.listPanel.AutoScroll = true;
            this.listPanel.Location = new System.Drawing.Point(223, 198);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(969, 410);
            this.listPanel.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.xBtn);
            this.panel3.Controls.Add(this.SubtitleLb);
            this.panel3.Controls.Add(this.TitleLb);
            this.panel3.Location = new System.Drawing.Point(223, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(969, 146);
            this.panel3.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(925, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(23, 25);
            this.button4.TabIndex = 4;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // xBtn
            // 
            this.xBtn.BackColor = System.Drawing.Color.White;
            this.xBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xBtn.Location = new System.Drawing.Point(946, 0);
            this.xBtn.Name = "xBtn";
            this.xBtn.Size = new System.Drawing.Size(23, 25);
            this.xBtn.TabIndex = 3;
            this.xBtn.Text = "x";
            this.xBtn.UseVisualStyleBackColor = false;
            this.xBtn.Click += new System.EventHandler(this.xBtn_Click);
            // 
            // SubtitleLb
            // 
            this.SubtitleLb.AutoSize = true;
            this.SubtitleLb.Font = new System.Drawing.Font("Arial Black", 10.75F, System.Drawing.FontStyle.Bold);
            this.SubtitleLb.Location = new System.Drawing.Point(28, 98);
            this.SubtitleLb.Name = "SubtitleLb";
            this.SubtitleLb.Size = new System.Drawing.Size(103, 22);
            this.SubtitleLb.TabIndex = 1;
            this.SubtitleLb.Text = "Now What?";
            // 
            // TitleLb
            // 
            this.TitleLb.AutoSize = true;
            this.TitleLb.Font = new System.Drawing.Font("Arial Black", 18.75F, System.Drawing.FontStyle.Bold);
            this.TitleLb.Location = new System.Drawing.Point(26, 58);
            this.TitleLb.Name = "TitleLb";
            this.TitleLb.Size = new System.Drawing.Size(171, 36);
            this.TitleLb.TabIndex = 0;
            this.TitleLb.Text = "Now What?";
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
            // Every10second
            // 
            this.Every10second.Interval = 5000;
            this.Every10second.Tick += new System.EventHandler(this.Every1minute_Tick);
            // 
            // screenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1191, 612);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "screenForm";
            this.TransparencyKey = System.Drawing.Color.Ivory;
            this.panel1.ResumeLayout(false);
            this.addPanel.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label SubtitleLb;
        private System.Windows.Forms.Label TitleLb;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button animBtn;
        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.Timer animDownTimer;
        private System.Windows.Forms.Timer animUpTimer;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button backBtn;
        private MetroFramework.Controls.MetroCheckBox remCheck;
        private MetroFramework.Controls.MetroCheckBox timeCheck;
        private MetroFramework.Controls.MetroComboBox dateHoursCB;
        private MetroFramework.Controls.MetroComboBox dateMinutesCB;
        private System.Windows.Forms.Button createBtn;
        private MetroFramework.Controls.MetroComboBox remHoursCB;
        private MetroFramework.Controls.MetroComboBox remMinutesCB;
        private MetroFramework.Controls.MetroComboBox repeatCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroDateTime toDoDateTime;
        private System.Windows.Forms.TextBox descriptionTB;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel listPanel;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Panel hidePanel;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button xBtn;
        private System.Windows.Forms.Timer Every10second;

    }
}
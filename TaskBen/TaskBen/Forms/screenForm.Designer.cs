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
            this.backBtn = new System.Windows.Forms.Button();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.remCheck = new MetroFramework.Controls.MetroCheckBox();
            this.timeCheck = new MetroFramework.Controls.MetroCheckBox();
            this.dateHoursCB = new MetroFramework.Controls.MetroComboBox();
            this.dateMinuteCB = new MetroFramework.Controls.MetroComboBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.remHoursCB = new MetroFramework.Controls.MetroComboBox();
            this.remMinutesCB = new MetroFramework.Controls.MetroComboBox();
            this.repeatCB = new MetroFramework.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toDoDateTime = new MetroFramework.Controls.MetroDateTime();
            this.descriptionTB = new System.Windows.Forms.TextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.animBtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SubtitleLb = new System.Windows.Forms.Label();
            this.TitleLb = new System.Windows.Forms.Label();
            this.animDownTimer = new System.Windows.Forms.Timer(this.components);
            this.animUpTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.addPanel.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(0, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 607);
            this.panel1.TabIndex = 0;
            // 
            // addPanel
            // 
            this.addPanel.BackColor = System.Drawing.Color.White;
            this.addPanel.Controls.Add(this.backBtn);
            this.addPanel.Controls.Add(this.metroTabControl1);
            this.addPanel.Location = new System.Drawing.Point(223, 198);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(969, 0);
            this.addPanel.TabIndex = 7;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Red;
            this.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Arial Black", 8.75F, System.Drawing.FontStyle.Bold);
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(32, 32);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(235, 23);
            this.backBtn.TabIndex = 11;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(32, 61);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(900, 375);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.remCheck);
            this.metroTabPage1.Controls.Add(this.timeCheck);
            this.metroTabPage1.Controls.Add(this.dateHoursCB);
            this.metroTabPage1.Controls.Add(this.dateMinuteCB);
            this.metroTabPage1.Controls.Add(this.createBtn);
            this.metroTabPage1.Controls.Add(this.remHoursCB);
            this.metroTabPage1.Controls.Add(this.remMinutesCB);
            this.metroTabPage1.Controls.Add(this.repeatCB);
            this.metroTabPage1.Controls.Add(this.label3);
            this.metroTabPage1.Controls.Add(this.label2);
            this.metroTabPage1.Controls.Add(this.label1);
            this.metroTabPage1.Controls.Add(this.toDoDateTime);
            this.metroTabPage1.Controls.Add(this.descriptionTB);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(892, 333);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Create a new to-do";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // remCheck
            // 
            this.remCheck.AutoSize = true;
            this.remCheck.Location = new System.Drawing.Point(319, 150);
            this.remCheck.Name = "remCheck";
            this.remCheck.Size = new System.Drawing.Size(99, 15);
            this.remCheck.TabIndex = 17;
            this.remCheck.Text = "Add Reminder";
            this.remCheck.UseSelectable = true;
            // 
            // timeCheck
            // 
            this.timeCheck.AutoSize = true;
            this.timeCheck.Location = new System.Drawing.Point(7, 150);
            this.timeCheck.Name = "timeCheck";
            this.timeCheck.Size = new System.Drawing.Size(75, 15);
            this.timeCheck.TabIndex = 16;
            this.timeCheck.Text = "Add Time";
            this.timeCheck.UseSelectable = true;
            // 
            // dateHoursCB
            // 
            this.dateHoursCB.DisplayMember = "12";
            this.dateHoursCB.FormattingEnabled = true;
            this.dateHoursCB.ItemHeight = 23;
            this.dateHoursCB.Location = new System.Drawing.Point(7, 176);
            this.dateHoursCB.Name = "dateHoursCB";
            this.dateHoursCB.Size = new System.Drawing.Size(91, 29);
            this.dateHoursCB.TabIndex = 14;
            this.dateHoursCB.UseSelectable = true;
            // 
            // dateMinuteCB
            // 
            this.dateMinuteCB.FormattingEnabled = true;
            this.dateMinuteCB.ItemHeight = 23;
            this.dateMinuteCB.Location = new System.Drawing.Point(113, 176);
            this.dateMinuteCB.Name = "dateMinuteCB";
            this.dateMinuteCB.Size = new System.Drawing.Size(91, 29);
            this.dateMinuteCB.TabIndex = 13;
            this.dateMinuteCB.UseSelectable = true;
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.createBtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.createBtn.FlatAppearance.BorderSize = 0;
            this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBtn.Font = new System.Drawing.Font("Arial Black", 8.75F, System.Drawing.FontStyle.Bold);
            this.createBtn.ForeColor = System.Drawing.Color.White;
            this.createBtn.Location = new System.Drawing.Point(7, 243);
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
            this.remHoursCB.Location = new System.Drawing.Point(319, 105);
            this.remHoursCB.Name = "remHoursCB";
            this.remHoursCB.Size = new System.Drawing.Size(91, 29);
            this.remHoursCB.TabIndex = 11;
            this.remHoursCB.UseSelectable = true;
            // 
            // remMinutesCB
            // 
            this.remMinutesCB.FormattingEnabled = true;
            this.remMinutesCB.ItemHeight = 23;
            this.remMinutesCB.Location = new System.Drawing.Point(427, 105);
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
            this.repeatCB.Location = new System.Drawing.Point(622, 105);
            this.repeatCB.Name = "repeatCB";
            this.repeatCB.Size = new System.Drawing.Size(204, 29);
            this.repeatCB.TabIndex = 8;
            this.repeatCB.UseSelectable = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Black", 10.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(618, 62);
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
            this.label2.Location = new System.Drawing.Point(315, 62);
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
            this.label1.Location = new System.Drawing.Point(3, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date:";
            // 
            // toDoDateTime
            // 
            this.toDoDateTime.Location = new System.Drawing.Point(7, 105);
            this.toDoDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.toDoDateTime.Name = "toDoDateTime";
            this.toDoDateTime.Size = new System.Drawing.Size(252, 29);
            this.toDoDateTime.TabIndex = 3;
            // 
            // descriptionTB
            // 
            this.descriptionTB.Location = new System.Drawing.Point(0, 18);
            this.descriptionTB.Name = "descriptionTB";
            this.descriptionTB.Size = new System.Drawing.Size(892, 20);
            this.descriptionTB.TabIndex = 2;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroButton3);
            this.metroTabPage2.Controls.Add(this.metroButton2);
            this.metroTabPage2.Controls.Add(this.metroButton1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(892, 333);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Create a new note";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(307, 68);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(75, 23);
            this.metroButton3.TabIndex = 4;
            this.metroButton3.Text = "metroButton3";
            this.metroButton3.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(409, 155);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "metroButton2";
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(134, 106);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.UseSelectable = true;
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
            this.animBtn.Text = "Create a new To-do";
            this.animBtn.UseVisualStyleBackColor = false;
            this.animBtn.Click += new System.EventHandler(this.animBtn_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Location = new System.Drawing.Point(0, 1);
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
            this.panel4.Controls.Add(this.monthCalendar1);
            this.panel4.Location = new System.Drawing.Point(0, 143);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(223, 465);
            this.panel4.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.monthCalendar1.Location = new System.Drawing.Point(0, 303);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.SubtitleLb);
            this.panel3.Controls.Add(this.TitleLb);
            this.panel3.Location = new System.Drawing.Point(223, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(969, 146);
            this.panel3.TabIndex = 2;
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
            this.animDownTimer.Interval = 10;
            this.animDownTimer.Tick += new System.EventHandler(this.animTimer_Tick);
            // 
            // animUpTimer
            // 
            this.animUpTimer.Interval = 10;
            this.animUpTimer.Tick += new System.EventHandler(this.animUpTimer_Tick);
            // 
            // screenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1192, 612);
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
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label SubtitleLb;
        private System.Windows.Forms.Label TitleLb;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button animBtn;
        private System.Windows.Forms.Panel addPanel;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Timer animDownTimer;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Timer animUpTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descriptionTB;
        private MetroFramework.Controls.MetroComboBox repeatCB;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox remMinutesCB;
        private MetroFramework.Controls.MetroComboBox remHoursCB;
        private System.Windows.Forms.Button createBtn;
        private MetroFramework.Controls.MetroDateTime toDoDateTime;
        private MetroFramework.Controls.MetroCheckBox remCheck;
        private MetroFramework.Controls.MetroCheckBox timeCheck;
        private MetroFramework.Controls.MetroComboBox dateHoursCB;
        private MetroFramework.Controls.MetroComboBox dateMinuteCB;

    }
}
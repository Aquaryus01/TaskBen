namespace TaskBen.Forms
{
    partial class GroupForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.top_panel = new System.Windows.Forms.Panel();
            this.DescriptionLb = new System.Windows.Forms.Label();
            this.TitleLb = new System.Windows.Forms.Label();
            this.TaskPanel = new System.Windows.Forms.Panel();
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
            this.animBtn = new System.Windows.Forms.Button();
            this.animDownTimer = new System.Windows.Forms.Timer(this.components);
            this.animUpTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.listPanel = new System.Windows.Forms.Panel();
            this.top_panel.SuspendLayout();
            this.TaskPanel.SuspendLayout();
            this.listPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.AutoScroll = true;
            this.top_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.top_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.top_panel.Controls.Add(this.DescriptionLb);
            this.top_panel.Controls.Add(this.TitleLb);
            this.top_panel.Location = new System.Drawing.Point(-198, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(1191, 137);
            this.top_panel.TabIndex = 21;
            // 
            // DescriptionLb
            // 
            this.DescriptionLb.AutoEllipsis = true;
            this.DescriptionLb.BackColor = System.Drawing.Color.Transparent;
            this.DescriptionLb.Font = new System.Drawing.Font("Arctik 2.5", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.DescriptionLb.Location = new System.Drawing.Point(217, 75);
            this.DescriptionLb.Name = "DescriptionLb";
            this.DescriptionLb.Size = new System.Drawing.Size(948, 23);
            this.DescriptionLb.TabIndex = 23;
            // 
            // TitleLb
            // 
            this.TitleLb.AutoEllipsis = true;
            this.TitleLb.BackColor = System.Drawing.Color.Transparent;
            this.TitleLb.Font = new System.Drawing.Font("Arctik 1.5", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLb.ForeColor = System.Drawing.Color.White;
            this.TitleLb.Location = new System.Drawing.Point(214, 38);
            this.TitleLb.Name = "TitleLb";
            this.TitleLb.Size = new System.Drawing.Size(781, 37);
            this.TitleLb.TabIndex = 22;
            // 
            // TaskPanel
            // 
            this.TaskPanel.BackColor = System.Drawing.Color.White;
            this.TaskPanel.Controls.Add(this.titleTb);
            this.TaskPanel.Controls.Add(this.label6);
            this.TaskPanel.Controls.Add(this.label4);
            this.TaskPanel.Controls.Add(this.backBtn);
            this.TaskPanel.Controls.Add(this.timeCheck);
            this.TaskPanel.Controls.Add(this.dateHoursCB);
            this.TaskPanel.Controls.Add(this.dateMinutesCB);
            this.TaskPanel.Controls.Add(this.createBtn);
            this.TaskPanel.Controls.Add(this.remHoursCB);
            this.TaskPanel.Controls.Add(this.remMinutesCB);
            this.TaskPanel.Controls.Add(this.repeatCB);
            this.TaskPanel.Controls.Add(this.label3);
            this.TaskPanel.Controls.Add(this.label2);
            this.TaskPanel.Controls.Add(this.label1);
            this.TaskPanel.Controls.Add(this.toDoDateTime);
            this.TaskPanel.Controls.Add(this.descriptionTB);
            this.TaskPanel.Location = new System.Drawing.Point(1, 1);
            this.TaskPanel.Name = "TaskPanel";
            this.TaskPanel.Size = new System.Drawing.Size(993, 500);
            this.TaskPanel.TabIndex = 34;
            // 
            // titleTb
            // 
            this.titleTb.Location = new System.Drawing.Point(64, 31);
            this.titleTb.Name = "titleTb";
            this.titleTb.Size = new System.Drawing.Size(721, 20);
            this.titleTb.TabIndex = 53;
            this.titleTb.TextChanged += new System.EventHandler(this.titleTb_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Title:";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Arial Black", 8.75F, System.Drawing.FontStyle.Bold);
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(303, 346);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(235, 23);
            this.backBtn.TabIndex = 46;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // timeCheck
            // 
            this.timeCheck.AutoSize = true;
            this.timeCheck.Location = new System.Drawing.Point(363, 190);
            this.timeCheck.Name = "timeCheck";
            this.timeCheck.Size = new System.Drawing.Size(75, 15);
            this.timeCheck.TabIndex = 51;
            this.timeCheck.Text = "Add Time";
            this.timeCheck.UseSelectable = true;
            // 
            // dateHoursCB
            // 
            this.dateHoursCB.DisplayMember = "12";
            this.dateHoursCB.FormattingEnabled = true;
            this.dateHoursCB.ItemHeight = 23;
            this.dateHoursCB.Location = new System.Drawing.Point(363, 214);
            this.dateHoursCB.Name = "dateHoursCB";
            this.dateHoursCB.Size = new System.Drawing.Size(91, 29);
            this.dateHoursCB.TabIndex = 50;
            this.dateHoursCB.UseSelectable = true;
            // 
            // dateMinutesCB
            // 
            this.dateMinutesCB.FormattingEnabled = true;
            this.dateMinutesCB.ItemHeight = 23;
            this.dateMinutesCB.Location = new System.Drawing.Point(460, 214);
            this.dateMinutesCB.Name = "dateMinutesCB";
            this.dateMinutesCB.Size = new System.Drawing.Size(91, 29);
            this.dateMinutesCB.TabIndex = 49;
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
            this.createBtn.Location = new System.Drawing.Point(64, 346);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(208, 23);
            this.createBtn.TabIndex = 48;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // remHoursCB
            // 
            this.remHoursCB.FormattingEnabled = true;
            this.remHoursCB.ItemHeight = 23;
            this.remHoursCB.Location = new System.Drawing.Point(593, 214);
            this.remHoursCB.Name = "remHoursCB";
            this.remHoursCB.Size = new System.Drawing.Size(91, 29);
            this.remHoursCB.TabIndex = 47;
            this.remHoursCB.UseSelectable = true;
            // 
            // remMinutesCB
            // 
            this.remMinutesCB.FormattingEnabled = true;
            this.remMinutesCB.ItemHeight = 23;
            this.remMinutesCB.Location = new System.Drawing.Point(690, 214);
            this.remMinutesCB.Name = "remMinutesCB";
            this.remMinutesCB.Size = new System.Drawing.Size(91, 29);
            this.remMinutesCB.TabIndex = 45;
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
            this.repeatCB.Location = new System.Drawing.Point(70, 285);
            this.repeatCB.Name = "repeatCB";
            this.repeatCB.Size = new System.Drawing.Size(152, 29);
            this.repeatCB.TabIndex = 44;
            this.repeatCB.UseSelectable = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Repeat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(590, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Reminder:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Date:";
            // 
            // toDoDateTime
            // 
            this.toDoDateTime.Location = new System.Drawing.Point(64, 214);
            this.toDoDateTime.MinimumSize = new System.Drawing.Size(4, 29);
            this.toDoDateTime.Name = "toDoDateTime";
            this.toDoDateTime.Size = new System.Drawing.Size(275, 29);
            this.toDoDateTime.TabIndex = 41;
            // 
            // descriptionTB
            // 
            this.descriptionTB.Location = new System.Drawing.Point(64, 89);
            this.descriptionTB.Multiline = true;
            this.descriptionTB.Name = "descriptionTB";
            this.descriptionTB.Size = new System.Drawing.Size(721, 82);
            this.descriptionTB.TabIndex = 39;
            this.descriptionTB.TextChanged += new System.EventHandler(this.descriptionTB_TextChanged);
            // 
            // animBtn
            // 
            this.animBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.animBtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.animBtn.FlatAppearance.BorderSize = 0;
            this.animBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.animBtn.Font = new System.Drawing.Font("Arial Black", 8.75F, System.Drawing.FontStyle.Bold);
            this.animBtn.ForeColor = System.Drawing.Color.DimGray;
            this.animBtn.Location = new System.Drawing.Point(23, 147);
            this.animBtn.Name = "animBtn";
            this.animBtn.Size = new System.Drawing.Size(173, 36);
            this.animBtn.TabIndex = 37;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Black", 8.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(817, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 36);
            this.button1.TabIndex = 38;
            this.button1.Text = "Remove Group";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // listPanel
            // 
            this.listPanel.Controls.Add(this.TaskPanel);
            this.listPanel.Location = new System.Drawing.Point(0, 191);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(993, 417);
            this.listPanel.TabIndex = 38;
            // 
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listPanel);
            this.Controls.Add(this.animBtn);
            this.Controls.Add(this.top_panel);
            this.Name = "GroupForm";
            this.Size = new System.Drawing.Size(993, 608);
            this.top_panel.ResumeLayout(false);
            this.TaskPanel.ResumeLayout(false);
            this.TaskPanel.PerformLayout();
            this.listPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Label TitleLb;
        private System.Windows.Forms.Panel TaskPanel;
        private System.Windows.Forms.Button animBtn;
        private System.Windows.Forms.TextBox titleTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button backBtn;
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
        private System.Windows.Forms.Timer animDownTimer;
        private System.Windows.Forms.Timer animUpTimer;
        private System.Windows.Forms.Label DescriptionLb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel listPanel;
    }
}

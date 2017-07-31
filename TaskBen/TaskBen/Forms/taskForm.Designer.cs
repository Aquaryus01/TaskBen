namespace TaskBen.UserControls
{
    partial class TaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskForm));
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.titleLb = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateLb = new System.Windows.Forms.Label();
            this.reminderLb = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.periodLb = new System.Windows.Forms.Label();
            this.descriptionLb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(18, 14);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(15, 14);
            this.checkBox.TabIndex = 0;
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // titleLb
            // 
            this.titleLb.AutoSize = true;
            this.titleLb.BackColor = System.Drawing.Color.Transparent;
            this.titleLb.Font = new System.Drawing.Font("Arctik 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.titleLb.Location = new System.Drawing.Point(44, 10);
            this.titleLb.Name = "titleLb";
            this.titleLb.Size = new System.Drawing.Size(579, 21);
            this.titleLb.TabIndex = 2;
            this.titleLb.Text = "Mergi la magazin si cumpara mai multe sortimente de paste si capsuni mici pitici";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("DejaVu Sans Condensed", 8.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.DarkGray;
            this.label8.Location = new System.Drawing.Point(202, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Reminder:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("DejaVu Sans Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkGray;
            this.label9.Location = new System.Drawing.Point(45, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Date:";
            // 
            // dateLb
            // 
            this.dateLb.AutoSize = true;
            this.dateLb.BackColor = System.Drawing.Color.Transparent;
            this.dateLb.Font = new System.Drawing.Font("DejaVu Sans Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.dateLb.Location = new System.Drawing.Point(89, 31);
            this.dateLb.Name = "dateLb";
            this.dateLb.Size = new System.Drawing.Size(107, 15);
            this.dateLb.TabIndex = 5;
            this.dateLb.Text = "12/16/2017 12:30";
            // 
            // reminderLb
            // 
            this.reminderLb.AutoSize = true;
            this.reminderLb.BackColor = System.Drawing.Color.Transparent;
            this.reminderLb.Font = new System.Drawing.Font("DejaVu Sans Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminderLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.reminderLb.Location = new System.Drawing.Point(273, 31);
            this.reminderLb.Name = "reminderLb";
            this.reminderLb.Size = new System.Drawing.Size(39, 15);
            this.reminderLb.TabIndex = 6;
            this.reminderLb.Text = "12:30";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(940, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("DejaVu Sans Condensed", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(318, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Period:";
            // 
            // periodLb
            // 
            this.periodLb.AutoSize = true;
            this.periodLb.BackColor = System.Drawing.Color.Transparent;
            this.periodLb.Font = new System.Drawing.Font("DejaVu Sans Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.periodLb.Location = new System.Drawing.Point(371, 31);
            this.periodLb.Name = "periodLb";
            this.periodLb.Size = new System.Drawing.Size(39, 15);
            this.periodLb.TabIndex = 9;
            this.periodLb.Text = "12:30";
            // 
            // descriptionLb
            // 
            this.descriptionLb.AutoSize = true;
            this.descriptionLb.BackColor = System.Drawing.Color.Transparent;
            this.descriptionLb.Font = new System.Drawing.Font("Arctik 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLb.ForeColor = System.Drawing.Color.DimGray;
            this.descriptionLb.Location = new System.Drawing.Point(629, 9);
            this.descriptionLb.Name = "descriptionLb";
            this.descriptionLb.Size = new System.Drawing.Size(156, 18);
            this.descriptionLb.TabIndex = 10;
            this.descriptionLb.Text = "Merg la piata cu nea GIGI";
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.descriptionLb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.periodLb);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.reminderLb);
            this.Controls.Add(this.dateLb);
            this.Controls.Add(this.label8);
            this.Name = "TaskForm";
            this.Size = new System.Drawing.Size(969, 82);
            this.Click += new System.EventHandler(this.TaskForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Label titleLb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label dateLb;
        private System.Windows.Forms.Label reminderLb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label periodLb;
        private System.Windows.Forms.Label descriptionLb;


    }
}

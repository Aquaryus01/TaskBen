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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.reminderLb = new System.Windows.Forms.Label();
            this.dateLb = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textLb = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(28, 17);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Teal;
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Controls.Add(this.reminderLb);
            this.panel7.Controls.Add(this.dateLb);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.textLb);
            this.panel7.Controls.Add(this.checkBox2);
            this.panel7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(969, 46);
            this.panel7.TabIndex = 12;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // reminderLb
            // 
            this.reminderLb.AutoSize = true;
            this.reminderLb.BackColor = System.Drawing.Color.Teal;
            this.reminderLb.Font = new System.Drawing.Font("DejaVu Sans Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminderLb.ForeColor = System.Drawing.Color.Cyan;
            this.reminderLb.Location = new System.Drawing.Point(297, 23);
            this.reminderLb.Name = "reminderLb";
            this.reminderLb.Size = new System.Drawing.Size(39, 15);
            this.reminderLb.TabIndex = 6;
            this.reminderLb.Text = "12:30";
            // 
            // dateLb
            // 
            this.dateLb.AutoSize = true;
            this.dateLb.BackColor = System.Drawing.Color.Teal;
            this.dateLb.Font = new System.Drawing.Font("DejaVu Sans Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLb.ForeColor = System.Drawing.Color.Cyan;
            this.dateLb.Location = new System.Drawing.Point(101, 23);
            this.dateLb.Name = "dateLb";
            this.dateLb.Size = new System.Drawing.Size(107, 15);
            this.dateLb.TabIndex = 5;
            this.dateLb.Text = "12/16/2017 12:30";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Teal;
            this.label9.Font = new System.Drawing.Font("DejaVu Sans Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkGray;
            this.label9.Location = new System.Drawing.Point(65, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Teal;
            this.label8.Font = new System.Drawing.Font("DejaVu Sans Condensed", 8.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.DarkGray;
            this.label8.Location = new System.Drawing.Point(226, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Reminder:";
            // 
            // textLb
            // 
            this.textLb.AutoSize = true;
            this.textLb.BackColor = System.Drawing.Color.Teal;
            this.textLb.Font = new System.Drawing.Font("DejaVu Sans Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLb.ForeColor = System.Drawing.Color.White;
            this.textLb.Location = new System.Drawing.Point(65, 6);
            this.textLb.Name = "textLb";
            this.textLb.Size = new System.Drawing.Size(473, 15);
            this.textLb.TabIndex = 2;
            this.textLb.Text = "Mergi la magazin si cumpara mai multe sortimente de paste si capsuni mici pitici";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(32, 17);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(940, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.checkBox1);
            this.Name = "TaskForm";
            this.Size = new System.Drawing.Size(969, 46);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label reminderLb;
        private System.Windows.Forms.Label dateLb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label textLb;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}

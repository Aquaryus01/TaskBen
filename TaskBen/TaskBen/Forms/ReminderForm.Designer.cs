namespace TaskBen.Forms
{
    partial class reminderForm
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.okBtn = new MetroFramework.Controls.MetroButton();
            this.reminderLb = new System.Windows.Forms.Label();
            this.textLb = new System.Windows.Forms.Label();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Teal;
            this.panel7.Controls.Add(this.okBtn);
            this.panel7.Controls.Add(this.reminderLb);
            this.panel7.Controls.Add(this.textLb);
            this.panel7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel7.Location = new System.Drawing.Point(0, -1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(965, 100);
            this.panel7.TabIndex = 14;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(21, 66);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 11;
            this.okBtn.Text = "OK";
            this.okBtn.UseSelectable = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // reminderLb
            // 
            this.reminderLb.AutoSize = true;
            this.reminderLb.BackColor = System.Drawing.Color.Teal;
            this.reminderLb.Font = new System.Drawing.Font("DejaVu Sans Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminderLb.ForeColor = System.Drawing.Color.DarkGray;
            this.reminderLb.Location = new System.Drawing.Point(21, 34);
            this.reminderLb.Name = "reminderLb";
            this.reminderLb.Size = new System.Drawing.Size(339, 15);
            this.reminderLb.TabIndex = 10;
            this.reminderLb.Text = "Just 12 Hours and  46 minutes until the task start!";
            // 
            // textLb
            // 
            this.textLb.AutoSize = true;
            this.textLb.BackColor = System.Drawing.Color.Teal;
            this.textLb.Font = new System.Drawing.Font("DejaVu Sans Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLb.ForeColor = System.Drawing.Color.White;
            this.textLb.Location = new System.Drawing.Point(17, 12);
            this.textLb.Name = "textLb";
            this.textLb.Size = new System.Drawing.Size(606, 19);
            this.textLb.TabIndex = 2;
            this.textLb.Text = "Mergi la magazin si cumpara mai multe sortimente de paste si capsuni mici pitici";
            // 
            // ReminderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 100);
            this.Controls.Add(this.panel7);
            this.Name = "ReminderForm";
            this.Text = "ReminderForm";
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private MetroFramework.Controls.MetroButton okBtn;
        private System.Windows.Forms.Label reminderLb;
        private System.Windows.Forms.Label textLb;
    }
}
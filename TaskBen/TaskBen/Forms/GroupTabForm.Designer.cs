namespace TaskBen.Forms
{
    partial class GroupTabForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.TitleLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TitleLb
            // 
            this.TitleLb.AutoEllipsis = true;
            this.TitleLb.AutoSize = true;
            this.TitleLb.BackColor = System.Drawing.Color.Transparent;
            this.TitleLb.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.TitleLb.ForeColor = System.Drawing.Color.White;
            this.TitleLb.Location = new System.Drawing.Point(121, 7);
            this.TitleLb.Name = "TitleLb";
            this.TitleLb.Size = new System.Drawing.Size(52, 16);
            this.TitleLb.TabIndex = 1;
            this.TitleLb.Text = "Family";
            this.TitleLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupTabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TitleLb);
            this.Name = "GroupTabForm";
            this.Size = new System.Drawing.Size(226, 30);
            this.Click += new System.EventHandler(this.GroupSelectForm_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TitleLb;

    }
}

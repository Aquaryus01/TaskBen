namespace TaskBen.Forms
{
    partial class CurentDayForm
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
            this.listPanel = new System.Windows.Forms.Panel();
            this.dateLb = new System.Windows.Forms.Label();
            this.CurentDayLb = new System.Windows.Forms.Label();
            this.top_panel = new System.Windows.Forms.Panel();
            this.top_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // listPanel
            // 
            this.listPanel.AutoScroll = true;
            this.listPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.listPanel.Location = new System.Drawing.Point(0, 135);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(993, 473);
            this.listPanel.TabIndex = 19;
            // 
            // dateLb
            // 
            this.dateLb.AutoSize = true;
            this.dateLb.BackColor = System.Drawing.Color.Transparent;
            this.dateLb.Font = new System.Drawing.Font("Arctik 2.5", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.dateLb.Location = new System.Drawing.Point(624, 71);
            this.dateLb.Name = "dateLb";
            this.dateLb.Size = new System.Drawing.Size(0, 23);
            this.dateLb.TabIndex = 20;
            // 
            // CurentDayLb
            // 
            this.CurentDayLb.AutoSize = true;
            this.CurentDayLb.BackColor = System.Drawing.Color.Transparent;
            this.CurentDayLb.Font = new System.Drawing.Font("Arctik 1.5", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurentDayLb.ForeColor = System.Drawing.Color.White;
            this.CurentDayLb.Location = new System.Drawing.Point(598, 34);
            this.CurentDayLb.Name = "CurentDayLb";
            this.CurentDayLb.Size = new System.Drawing.Size(166, 37);
            this.CurentDayLb.TabIndex = 19;
            this.CurentDayLb.Text = "Curent day";
            // 
            // top_panel
            // 
            this.top_panel.AutoScroll = true;
            this.top_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.top_panel.BackColor = System.Drawing.Color.Gray;
            this.top_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.top_panel.Controls.Add(this.CurentDayLb);
            this.top_panel.Controls.Add(this.dateLb);
            this.top_panel.Location = new System.Drawing.Point(-198, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(1191, 137);
            this.top_panel.TabIndex = 18;
            // 
            // CurentDayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listPanel);
            this.Controls.Add(this.top_panel);
            this.Name = "CurentDayForm";
            this.Size = new System.Drawing.Size(993, 608);
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel listPanel;
        private System.Windows.Forms.Label dateLb;
        private System.Windows.Forms.Label CurentDayLb;
        private System.Windows.Forms.Panel top_panel;
    }
}

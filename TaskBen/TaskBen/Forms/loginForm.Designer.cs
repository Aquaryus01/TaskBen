namespace TaskBen
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.passTb = new MetroFramework.Controls.MetroTextBox();
            this.emailTb = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(26, 18);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(168, 41);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Get Started!";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(76, 111);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(71, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Get one now!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(26, 73);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(163, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Don\'t have an account yet?";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.metroButton1);
            this.panel1.Location = new System.Drawing.Point(247, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 148);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.metroButton2);
            this.panel2.Controls.Add(this.linkLabel2);
            this.panel2.Controls.Add(this.passTb);
            this.panel2.Controls.Add(this.emailTb);
            this.panel2.Location = new System.Drawing.Point(24, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 194);
            this.panel2.TabIndex = 6;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(25, 106);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(168, 41);
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "Login";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(81, 157);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(54, 13);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Get back!";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // passTb
            // 
            // 
            // 
            // 
            this.passTb.CustomButton.Image = null;
            this.passTb.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.passTb.CustomButton.Name = "";
            this.passTb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passTb.CustomButton.TabIndex = 1;
            this.passTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passTb.CustomButton.UseSelectable = true;
            this.passTb.CustomButton.Visible = false;
            this.passTb.Lines = new string[0];
            this.passTb.Location = new System.Drawing.Point(16, 65);
            this.passTb.MaxLength = 32767;
            this.passTb.Name = "passTb";
            this.passTb.PasswordChar = '●';
            this.passTb.PromptText = "password";
            this.passTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passTb.SelectedText = "";
            this.passTb.SelectionLength = 0;
            this.passTb.SelectionStart = 0;
            this.passTb.ShortcutsEnabled = true;
            this.passTb.Size = new System.Drawing.Size(187, 23);
            this.passTb.TabIndex = 7;
            this.passTb.UseSelectable = true;
            this.passTb.UseSystemPasswordChar = true;
            this.passTb.WaterMark = "password";
            this.passTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.passTb.TextChanged += new System.EventHandler(this.passTb_TextChanged);
            // 
            // emailTb
            // 
            // 
            // 
            // 
            this.emailTb.CustomButton.Image = null;
            this.emailTb.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.emailTb.CustomButton.Name = "";
            this.emailTb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.emailTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.emailTb.CustomButton.TabIndex = 1;
            this.emailTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.emailTb.CustomButton.UseSelectable = true;
            this.emailTb.CustomButton.Visible = false;
            this.emailTb.Lines = new string[0];
            this.emailTb.Location = new System.Drawing.Point(16, 26);
            this.emailTb.MaxLength = 32767;
            this.emailTb.Name = "emailTb";
            this.emailTb.PasswordChar = '\0';
            this.emailTb.PromptText = "email";
            this.emailTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailTb.SelectedText = "";
            this.emailTb.SelectionLength = 0;
            this.emailTb.SelectionStart = 0;
            this.emailTb.ShortcutsEnabled = true;
            this.emailTb.Size = new System.Drawing.Size(187, 23);
            this.emailTb.TabIndex = 6;
            this.emailTb.UseSelectable = true;
            this.emailTb.WaterMark = "email";
            this.emailTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.emailTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.emailTb.TextChanged += new System.EventHandler(this.emailTb_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(247, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(212, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 432);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "loginForm";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTextBox passTb;
        private MetroFramework.Controls.MetroTextBox emailTb;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.PictureBox pictureBox2;

    }
}


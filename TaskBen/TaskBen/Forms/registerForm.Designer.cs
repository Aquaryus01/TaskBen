﻿namespace TaskBen.Forms
{
    partial class registerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registerForm));
            this.nameLb = new MetroFramework.Controls.MetroLabel();
            this.surLb = new MetroFramework.Controls.MetroLabel();
            this.nameTb = new MetroFramework.Controls.MetroTextBox();
            this.surrTb = new MetroFramework.Controls.MetroTextBox();
            this.emailTb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.passTb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLb
            // 
            this.nameLb.AutoSize = true;
            this.nameLb.Location = new System.Drawing.Point(175, 211);
            this.nameLb.Name = "nameLb";
            this.nameLb.Size = new System.Drawing.Size(72, 19);
            this.nameLb.TabIndex = 3;
            this.nameLb.Text = "FirstName:";
            // 
            // surLb
            // 
            this.surLb.AutoSize = true;
            this.surLb.Location = new System.Drawing.Point(392, 211);
            this.surLb.Name = "surLb";
            this.surLb.Size = new System.Drawing.Size(70, 19);
            this.surLb.TabIndex = 4;
            this.surLb.Text = "LastName:";
            // 
            // nameTb
            // 
            // 
            // 
            // 
            this.nameTb.CustomButton.Image = null;
            this.nameTb.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.nameTb.CustomButton.Name = "";
            this.nameTb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nameTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nameTb.CustomButton.TabIndex = 1;
            this.nameTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nameTb.CustomButton.UseSelectable = true;
            this.nameTb.CustomButton.Visible = false;
            this.nameTb.Lines = new string[0];
            this.nameTb.Location = new System.Drawing.Point(175, 233);
            this.nameTb.MaxLength = 32767;
            this.nameTb.Name = "nameTb";
            this.nameTb.PasswordChar = '\0';
            this.nameTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameTb.SelectedText = "";
            this.nameTb.SelectionLength = 0;
            this.nameTb.SelectionStart = 0;
            this.nameTb.ShortcutsEnabled = true;
            this.nameTb.Size = new System.Drawing.Size(187, 23);
            this.nameTb.TabIndex = 5;
            this.nameTb.UseSelectable = true;
            this.nameTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.nameTb.TextChanged += new System.EventHandler(this.nameTb_TextChanged);
            // 
            // surrTb
            // 
            // 
            // 
            // 
            this.surrTb.CustomButton.Image = null;
            this.surrTb.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.surrTb.CustomButton.Name = "";
            this.surrTb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.surrTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.surrTb.CustomButton.TabIndex = 1;
            this.surrTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.surrTb.CustomButton.UseSelectable = true;
            this.surrTb.CustomButton.Visible = false;
            this.surrTb.Lines = new string[0];
            this.surrTb.Location = new System.Drawing.Point(392, 233);
            this.surrTb.MaxLength = 32767;
            this.surrTb.Name = "surrTb";
            this.surrTb.PasswordChar = '\0';
            this.surrTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.surrTb.SelectedText = "";
            this.surrTb.SelectionLength = 0;
            this.surrTb.SelectionStart = 0;
            this.surrTb.ShortcutsEnabled = true;
            this.surrTb.Size = new System.Drawing.Size(187, 23);
            this.surrTb.TabIndex = 6;
            this.surrTb.UseSelectable = true;
            this.surrTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.surrTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.surrTb.TextChanged += new System.EventHandler(this.surrTb_TextChanged);
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
            this.emailTb.Location = new System.Drawing.Point(175, 296);
            this.emailTb.MaxLength = 32767;
            this.emailTb.Name = "emailTb";
            this.emailTb.PasswordChar = '\0';
            this.emailTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailTb.SelectedText = "";
            this.emailTb.SelectionLength = 0;
            this.emailTb.SelectionStart = 0;
            this.emailTb.ShortcutsEnabled = true;
            this.emailTb.Size = new System.Drawing.Size(187, 23);
            this.emailTb.TabIndex = 8;
            this.emailTb.UseSelectable = true;
            this.emailTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.emailTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.emailTb.TextChanged += new System.EventHandler(this.emailTb_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(175, 274);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(44, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Email:";
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
            this.passTb.Location = new System.Drawing.Point(392, 296);
            this.passTb.MaxLength = 32767;
            this.passTb.Name = "passTb";
            this.passTb.PasswordChar = '●';
            this.passTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passTb.SelectedText = "";
            this.passTb.SelectionLength = 0;
            this.passTb.SelectionStart = 0;
            this.passTb.ShortcutsEnabled = true;
            this.passTb.Size = new System.Drawing.Size(187, 23);
            this.passTb.TabIndex = 10;
            this.passTb.UseSelectable = true;
            this.passTb.UseSystemPasswordChar = true;
            this.passTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.passTb.TextChanged += new System.EventHandler(this.passTb_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(392, 274);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Password:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(350, 398);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(49, 13);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "GetBack";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(289, 337);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(168, 41);
            this.metroButton1.TabIndex = 11;
            this.metroButton1.Text = "Register";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(261, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(218, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 431);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.passTb);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.emailTb);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.surrTb);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.surLb);
            this.Controls.Add(this.nameLb);
            this.Name = "registerForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel nameLb;
        private MetroFramework.Controls.MetroLabel surLb;
        private MetroFramework.Controls.MetroTextBox nameTb;
        private MetroFramework.Controls.MetroTextBox surrTb;
        private MetroFramework.Controls.MetroTextBox emailTb;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox passTb;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
namespace TaskBen.Forms
{
    partial class CreateGroupForm
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
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addMemberBtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupDescriptionTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupNameTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchBarTb = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.verifyLb = new System.Windows.Forms.Label();
            this.clearMembersBtn = new System.Windows.Forms.Button();
            this.membersLb = new System.Windows.Forms.Label();
            this.createGroupBtn = new System.Windows.Forms.Button();
            this.top_panel = new System.Windows.Forms.Panel();
            this.dateLb = new System.Windows.Forms.Label();
            this.CurentDayLb = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.top_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(130)))), ((int)(((byte)(28)))));
            this.label10.Location = new System.Drawing.Point(59, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 20);
            this.label10.TabIndex = 41;
            this.label10.Text = "Members:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(130)))), ((int)(((byte)(28)))));
            this.label6.Location = new System.Drawing.Point(59, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "About Group:";
            // 
            // addMemberBtn
            // 
            this.addMemberBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(130)))), ((int)(((byte)(28)))));
            this.addMemberBtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.addMemberBtn.FlatAppearance.BorderSize = 0;
            this.addMemberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberBtn.Font = new System.Drawing.Font("Arial Black", 8.75F, System.Drawing.FontStyle.Bold);
            this.addMemberBtn.ForeColor = System.Drawing.Color.White;
            this.addMemberBtn.Location = new System.Drawing.Point(386, 26);
            this.addMemberBtn.Name = "addMemberBtn";
            this.addMemberBtn.Size = new System.Drawing.Size(208, 23);
            this.addMemberBtn.TabIndex = 30;
            this.addMemberBtn.Text = "Add member";
            this.addMemberBtn.UseVisualStyleBackColor = false;
            this.addMemberBtn.Click += new System.EventHandler(this.addMemberBtn_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.groupDescriptionTb);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(0, 215);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(993, 40);
            this.panel5.TabIndex = 37;
            // 
            // groupDescriptionTb
            // 
            this.groupDescriptionTb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupDescriptionTb.Font = new System.Drawing.Font("Arial", 10F);
            this.groupDescriptionTb.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupDescriptionTb.Location = new System.Drawing.Point(187, 9);
            this.groupDescriptionTb.Name = "groupDescriptionTb";
            this.groupDescriptionTb.Size = new System.Drawing.Size(284, 23);
            this.groupDescriptionTb.TabIndex = 7;
            this.groupDescriptionTb.TextChanged += new System.EventHandler(this.groupDescriptionTb_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(60, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Description:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.groupNameTb);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 40);
            this.panel2.TabIndex = 36;
            // 
            // groupNameTb
            // 
            this.groupNameTb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupNameTb.Font = new System.Drawing.Font("Arial", 10F);
            this.groupNameTb.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupNameTb.Location = new System.Drawing.Point(187, 11);
            this.groupNameTb.Name = "groupNameTb";
            this.groupNameTb.Size = new System.Drawing.Size(284, 23);
            this.groupNameTb.TabIndex = 6;
            this.groupNameTb.TextChanged += new System.EventHandler(this.groupNameTb_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(60, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name:";
            // 
            // searchBarTb
            // 
            // 
            // 
            // 
            this.searchBarTb.CustomButton.Image = null;
            this.searchBarTb.CustomButton.Location = new System.Drawing.Point(285, 1);
            this.searchBarTb.CustomButton.Name = "";
            this.searchBarTb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.searchBarTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchBarTb.CustomButton.TabIndex = 1;
            this.searchBarTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchBarTb.CustomButton.UseSelectable = true;
            this.searchBarTb.CustomButton.Visible = false;
            this.searchBarTb.Lines = new string[0];
            this.searchBarTb.Location = new System.Drawing.Point(63, 26);
            this.searchBarTb.MaxLength = 32767;
            this.searchBarTb.Name = "searchBarTb";
            this.searchBarTb.PasswordChar = '\0';
            this.searchBarTb.PromptText = "Write the full member name or email address";
            this.searchBarTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchBarTb.SelectedText = "";
            this.searchBarTb.SelectionLength = 0;
            this.searchBarTb.SelectionStart = 0;
            this.searchBarTb.ShortcutsEnabled = true;
            this.searchBarTb.Size = new System.Drawing.Size(307, 23);
            this.searchBarTb.TabIndex = 42;
            this.searchBarTb.UseSelectable = true;
            this.searchBarTb.WaterMark = "Write the full member name or email address";
            this.searchBarTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchBarTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.verifyLb);
            this.panel1.Controls.Add(this.clearMembersBtn);
            this.panel1.Controls.Add(this.membersLb);
            this.panel1.Controls.Add(this.addMemberBtn);
            this.panel1.Controls.Add(this.searchBarTb);
            this.panel1.Location = new System.Drawing.Point(0, 301);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 91);
            this.panel1.TabIndex = 38;
            // 
            // verifyLb
            // 
            this.verifyLb.AutoSize = true;
            this.verifyLb.BackColor = System.Drawing.Color.Transparent;
            this.verifyLb.Font = new System.Drawing.Font("Arctik 2.5", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.verifyLb.Location = new System.Drawing.Point(64, 7);
            this.verifyLb.Name = "verifyLb";
            this.verifyLb.Size = new System.Drawing.Size(0, 14);
            this.verifyLb.TabIndex = 44;
            // 
            // clearMembersBtn
            // 
            this.clearMembersBtn.BackColor = System.Drawing.Color.Maroon;
            this.clearMembersBtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.clearMembersBtn.FlatAppearance.BorderSize = 0;
            this.clearMembersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearMembersBtn.Font = new System.Drawing.Font("Arial Black", 8.75F, System.Drawing.FontStyle.Bold);
            this.clearMembersBtn.ForeColor = System.Drawing.Color.White;
            this.clearMembersBtn.Location = new System.Drawing.Point(611, 26);
            this.clearMembersBtn.Name = "clearMembersBtn";
            this.clearMembersBtn.Size = new System.Drawing.Size(208, 23);
            this.clearMembersBtn.TabIndex = 43;
            this.clearMembersBtn.Text = "Clear Members";
            this.clearMembersBtn.UseVisualStyleBackColor = false;
            this.clearMembersBtn.Click += new System.EventHandler(this.clearMembersBtn_Click);
            // 
            // membersLb
            // 
            this.membersLb.AutoSize = true;
            this.membersLb.BackColor = System.Drawing.Color.Transparent;
            this.membersLb.Font = new System.Drawing.Font("Arctik 2.5", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membersLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.membersLb.Location = new System.Drawing.Point(60, 63);
            this.membersLb.Name = "membersLb";
            this.membersLb.Size = new System.Drawing.Size(0, 14);
            this.membersLb.TabIndex = 24;
            // 
            // createGroupBtn
            // 
            this.createGroupBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(130)))), ((int)(((byte)(28)))));
            this.createGroupBtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.createGroupBtn.FlatAppearance.BorderSize = 0;
            this.createGroupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createGroupBtn.Font = new System.Drawing.Font("Arial Black", 8.75F, System.Drawing.FontStyle.Bold);
            this.createGroupBtn.ForeColor = System.Drawing.Color.White;
            this.createGroupBtn.Location = new System.Drawing.Point(67, 537);
            this.createGroupBtn.Name = "createGroupBtn";
            this.createGroupBtn.Size = new System.Drawing.Size(208, 23);
            this.createGroupBtn.TabIndex = 43;
            this.createGroupBtn.Text = "Create Group";
            this.createGroupBtn.UseVisualStyleBackColor = false;
            this.createGroupBtn.Click += new System.EventHandler(this.createGroupBtn_Click);
            // 
            // top_panel
            // 
            this.top_panel.AutoScroll = true;
            this.top_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.top_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.top_panel.Controls.Add(this.dateLb);
            this.top_panel.Controls.Add(this.CurentDayLb);
            this.top_panel.Location = new System.Drawing.Point(-198, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(1191, 137);
            this.top_panel.TabIndex = 20;
            // 
            // dateLb
            // 
            this.dateLb.AutoSize = true;
            this.dateLb.BackColor = System.Drawing.Color.Transparent;
            this.dateLb.Font = new System.Drawing.Font("Arctik 2.5", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.dateLb.Location = new System.Drawing.Point(460, 75);
            this.dateLb.Name = "dateLb";
            this.dateLb.Size = new System.Drawing.Size(304, 23);
            this.dateLb.TabIndex = 23;
            this.dateLb.Text = "Connect easily with your friends!";
            // 
            // CurentDayLb
            // 
            this.CurentDayLb.AutoSize = true;
            this.CurentDayLb.BackColor = System.Drawing.Color.Transparent;
            this.CurentDayLb.Font = new System.Drawing.Font("Arctik 1.5", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurentDayLb.ForeColor = System.Drawing.Color.White;
            this.CurentDayLb.Location = new System.Drawing.Point(492, 36);
            this.CurentDayLb.Name = "CurentDayLb";
            this.CurentDayLb.Size = new System.Drawing.Size(218, 37);
            this.CurentDayLb.TabIndex = 22;
            this.CurentDayLb.Text = "Create a group";
            // 
            // CreateGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.createGroupBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.top_panel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Name = "CreateGroupForm";
            this.Size = new System.Drawing.Size(993, 608);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Label CurentDayLb;
        private System.Windows.Forms.Label dateLb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addMemberBtn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox groupDescriptionTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox groupNameTb;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox searchBarTb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label membersLb;
        private System.Windows.Forms.Button createGroupBtn;
        private System.Windows.Forms.Button clearMembersBtn;
        private System.Windows.Forms.Label verifyLb;
    }
}

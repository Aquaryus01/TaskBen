using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskBen.Class;
using MetroFramework;

namespace TaskBen.Forms
{
    public partial class NewGroupForm : UserControl
    {
        public NewGroupForm()
        {
            InitializeComponent();
            Settings.group.groupMembers = new List<string>();
        }

        private void groupNameTb_TextChanged(object sender, EventArgs e)
        {
            Settings.group.Name = groupNameTb.Text;
        }

        private void groupDescriptionTb_TextChanged(object sender, EventArgs e)
        {
            Settings.group.Description = groupDescriptionTb.Text;
        }

        private void addMemberBtn_Click(object sender, EventArgs e)
        {
            Settings.group.MemberEmail = searchBarTb.Text;
            searchBarTb.Text = "";
            if(Settings.group.VerifyMember())
            {
                

                if(Settings.group.SameMember())
                {
                    if (Settings.user.Email != Settings.group.MemberEmail)
                    {
                        Settings.group.groupMembers.Add(Settings.group.MemberEmail);

                        if (membersLb.Text == "")
                            membersLb.Text += Settings.group.MemberEmail;
                        else
                            membersLb.Text += ", " + Settings.group.MemberEmail;

                        verifyLb.ForeColor = Color.Green;
                        verifyLb.Text = "Member successfully added!";
                    }
                    else
                    {
                        verifyLb.ForeColor = Color.Red;
                        verifyLb.Text = "You are already on the list!";
                    }

                }
                else
                {
                    verifyLb.ForeColor = Color.Red;
                    verifyLb.Text = "The member is already on the list!";
                }
                
            }
            else
            {
                verifyLb.ForeColor = Color.Red;
                verifyLb.Text = "Member not found!";
            }
        }

        private void clearMembersBtn_Click(object sender, EventArgs e)
        {
            var dialogResult = MetroMessageBox.Show(this, "Are you sure you want to remove all members from list?", "Clear all members",MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dialogResult == DialogResult.Yes)
            {
                Settings.group.groupMembers = new List<string>();
                membersLb.Text = "";
                verifyLb.ForeColor = Color.Green;
                verifyLb.Text = "All members have been successfully deleted";
            }
        }
    }
}

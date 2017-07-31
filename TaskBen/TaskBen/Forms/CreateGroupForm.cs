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
    public partial class CreateGroupForm : UserControl
    {
        public ScreenForm ParentForm { get; set; }

        public CreateGroupForm()
        {
            InitializeComponent();
            Settings.group = new Group();
            Settings.group.groupMembers = new List<string>();
        }

        public CreateGroupForm(Group _group)
        {
            InitializeComponent();
            Settings.group = _group;
            Settings.group.load_members();
            createGroupBtn.Text = "Save Group";
            groupDescriptionTb.Text = Settings.group.Description;
            groupNameTb.Text = Settings.group.Name;

            membersLb.Text = "";
            foreach (string x in Settings.group.groupMembers)
                membersLb.Text += x; 
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

        private void createGroupBtn_Click(object sender, EventArgs e)
        {
            string broken_rule = "";
            if(!Settings.group.save(ref broken_rule))
                MetroMessageBox.Show(this, broken_rule, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(Settings.group.IsNew)
            {
                MetroMessageBox.Show(this, "Succes", "Group created succesful!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Settings.groupList.Add(Settings.group); ///Add group in the list
                this.ParentForm.add_group_form(); ///Add gorup in the screenForm
            }
            else
            {
                MetroMessageBox.Show(this, "Succes", "The Group was saved succesful!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ParentForm.add_groups_form(); ///Add gorup in the screenForm
            }
            
        }
    }
}

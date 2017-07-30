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

namespace TaskBen.Forms
{
    public partial class GroupTabForm : UserControl
    {
        //public screenForm ParentForm { get; set; }
        Group group = new Group();
        public GroupTabForm()
        {
            InitializeComponent();
        }

        internal void Init_group(Group item)
        {
            group = item;
            button1.Text = group.Name;

        }

        private void GroupSelectForm_Click(object sender, EventArgs e)
        {

        }
    }
}

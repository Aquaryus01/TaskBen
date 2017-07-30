using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskBen.Forms;

namespace TaskBen.Class
{
    public static class Settings
    {
        public static ScreenForm screenForm;

        public static User user = new User();
        public static Group group = new Group();
        public static Todo task = new Todo();
        public static List<Todo> taskList = new List<Todo>();
        public static List<Group> groupList = new List<Group>();
       
        public static int poz_x_task = 0;
        public static int poz_y_task = 0;
        public static int poz_x_group = 0;
        public static int poz_y_group = 0;
        public static string jwt_token { get; set; }

        public static void new_instance_taks()
        {
            task = new Todo();
        }
    }
}

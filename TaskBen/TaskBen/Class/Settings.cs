using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBen.Class
{
    public static class Settings
    {
        public static User user = new User();
        public static Task task = new Task();

        public static void new_instance_taks()
        {
            task = new Task();
        }
    }
}

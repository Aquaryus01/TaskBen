using TaskBen.Forms;
using TaskBen.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TaskBen
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /*
            using (FileStream stream = File.OpenWrite(Application.UserAppDataPath + "\\Preference.conf"))
            {
                Preference prf = new Preference("http://localhost/api");
                prf.SaveToStream(stream);
            }
            */

            User user = new User();
            Application.Run(new loginForm());

    
        }
    }
}

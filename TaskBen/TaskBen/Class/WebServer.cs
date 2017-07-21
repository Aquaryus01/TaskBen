using MetroFramework;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskBen.Class;

namespace TaskBen
{
    class WebServer
    {
        private static  string URI = "http://localhost/api2/index.php";

        public static string post_get(string json)
        {
            using (WebClient wc = new WebClient())
            {
                try
                {
                    wc.Headers[HttpRequestHeader.ContentType] = "application/json";
                    return wc.UploadString(URI, json);
                }
                catch (Exception e)
                {
                    MetroMessageBox.Show(new loginForm(), e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "";
                    //Console.WriteLine("{0} Exception caught.", e);
                }
            }
        }

        public static void post(string json)
        {
            using (WebClient wc = new WebClient())
            {
                try
                {
                    wc.Headers[HttpRequestHeader.ContentType] = "application/json";
                    wc.UploadString(URI, json);
                }
                catch (Exception e)
                {
                    MetroMessageBox.Show(new loginForm(), e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

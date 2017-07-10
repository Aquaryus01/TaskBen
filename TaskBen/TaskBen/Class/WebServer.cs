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

        public static string PUSH(string json)
        {
            using (WebClient wc = new WebClient())
            {
                wc.Headers[HttpRequestHeader.ContentType] = "application/json";
                return wc.UploadString(URI, json);
            }
        }

        public static string user_register(string Email, string Password, string FirstName, string LastName)
        {
            Dictionary<string, string> json = new Dictionary<string, string>();
            json.Add("email", Email);
            json.Add("password", Password);
            json.Add("firstname", FirstName);
            json.Add("lastname", LastName);
            json.Add("action", "register");
            return WebServer.PUSH(JsonConvert.SerializeObject(json));
        }

        public static string user_login(string Email, string Password)
        {
            Dictionary<string, string> json = new Dictionary<string, string>();
            json.Add("email", Email);
            json.Add("password", Password);
            json.Add("action", "login");
            return WebServer.PUSH(JsonConvert.SerializeObject(json));
        }

        public static string task_add(string _description, string _date, string _dateHH, string _dateMM, string _remHH, string _remMM, string _repeat)
        {
            Dictionary<string, string> json = new Dictionary<string, string>();
            json.Add("description", _description);
            json.Add("idUser", Settings.user.ID.ToString());
            json.Add("api", Settings.user.Api.ToString());
            json.Add("date", _date);
            json.Add("dateHours", _dateHH);
            json.Add("dateMinutes", _dateMM);
            json.Add("reminderHours", _remHH);
            json.Add("reminderMinutes", _remMM);
            json.Add("repeat", _repeat);
            json.Add("action", "add_task");
            return WebServer.PUSH(JsonConvert.SerializeObject(json));
        }


    }
}

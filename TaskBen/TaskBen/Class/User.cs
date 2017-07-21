using MetroFramework;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskBen.Forms;

namespace TaskBen.Class
{
    public class User
    {
        private string api;
        private int Id;
        private string _FirstName;
        private string _LastName;
        private string _Email;
        private string _Password;
        Dictionary<string, string> json;

        public void compress_data()
        {
            json = new Dictionary<string, string>();
            json.Add("email", Email);
            json.Add("password", Password);
            json.Add("firstname", FirstName);
            json.Add("lastname", LastName);
            
        }

        public bool register()
        {
            compress_data();
            json.Add("action", "register");
            
            string raspuns = WebServer.post_get(JsonConvert.SerializeObject(json));
            if (raspuns == "")
                return true;
            else
                MetroMessageBox.Show(new loginForm(), raspuns, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public bool login()
        {
            compress_data();
            json.Add("action", "login");

            string raspuns = WebServer.post_get(JsonConvert.SerializeObject(json));
            dynamic d = JsonConvert.DeserializeObject<dynamic>(raspuns);
            //MessageBox.Show(a);
            if (raspuns.IndexOf("Error") != -1)
            {
                MetroMessageBox.Show(new loginForm(), d.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(raspuns=="")
            {

            }
            else
            {
                
                Settings.user = JsonConvert.DeserializeObject<User>(raspuns);
                return true;
            }
            return false;
        }

        public string Api
        {
            set { api = value; }
            get { return api; }
        }

        public int ID
        {
            set { Id = value; }
            get { return Id; }
        }

        public string FirstName
        {
            set { _FirstName = value; }
            get { return _FirstName; }
        }

        public string LastName
        {
            set { _LastName = value; }
            get { return _LastName; }
        }

        public string Email
        {
            set { _Email = value; }
            get { return _Email; }
        }

        public string Password
        {
            set { _Password = value; }
            get { return _Password; }
        }
    }
}

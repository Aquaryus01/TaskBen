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

        public bool register()
        {
            string rasp = WebServer.user_register(_Email, _Password, _FirstName, _LastName);
            dynamic d = JsonConvert.DeserializeObject<dynamic>(rasp);
            if (d == null)
                return true;
            else
                MetroMessageBox.Show(new loginForm(), d.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public bool login()
        {
            var a = WebServer.user_login(_Email, _Password);
            MessageBox.Show(a);
            if (a.IndexOf("Error") != -1)
            {
                dynamic d = JsonConvert.DeserializeObject<dynamic>(a);
                MetroMessageBox.Show(new loginForm(), "The username and password didn't match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                Settings.user = JsonConvert.DeserializeObject<User>(a);
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

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskBen.Class
{
    public class Todo
    {
        private int _id;
        private string _date;
        private string _dateHH;
        private string _dateMM;
        private string _remHH;
        private string _remMM;
        private string _repeat;
        private string _description;
        private int _checked;


        public string Date
        {
            set { _date = value; }
            get { return _date; }
        }
        public int Checked
        {
            set { _checked = value; }
            get { return _checked; }
        }
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        public string Description
        {
            set { _description = value; }
            get { return _description; }
        }
        public string DateHours
        {
            set { _dateHH = value; }
            get { return _dateHH; }
        }
        public string DateMinutes
        {
            set { _dateMM = value; }
            get { return _dateMM; }
        }
        public string ReminderHours
        {
            set { _remHH = value; }
            get { return _remHH; }
        }
        public string ReminderMinutes
        {
            set { _remMM = value; }
            get { return _remMM; }
        }
        public string Schedule
        {
            set { _repeat = value; }
            get { return _repeat; }
        }

        public void remove_web()
        {
            Dictionary<string, string> json = new Dictionary<string, string>();
            json.Add("id", _id.ToString());
            json.Add("idUser", Settings.user.ID.ToString());
            json.Add("action", "remove_task");
            WebServer.post(JsonConvert.SerializeObject(json));
        }
        public void task_get_list()
        {
            Dictionary<string, string> json = new Dictionary<string, string>();
            json.Add("idUser", Settings.user.ID.ToString());
            json.Add("action", "get_tasks");

            string list_todo = WebServer.post_get(JsonConvert.SerializeObject(json));

            if (list_todo != "")
                Settings.taskList = JsonConvert.DeserializeObject<List<Todo>>(list_todo);

        }
       
        public void add_web()
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
            json.Add("checked", _checked.ToString());
            json.Add("action", "add_task");
            string rasp = WebServer.post_get(JsonConvert.SerializeObject(json));
            _id = Convert.ToInt32(rasp);
        }

        public void update_web()
        {
            Dictionary<string, string> json = new Dictionary<string, string>();
            json.Add("description", _description);
            json.Add("idUser", Settings.user.ID.ToString());
            json.Add("id", _id.ToString());
            json.Add("api", Settings.user.Api.ToString());
            json.Add("date", _date);
            json.Add("dateHours", _dateHH);
            json.Add("dateMinutes", _dateMM);
            json.Add("reminderHours", _remHH);
            json.Add("reminderMinutes", _remMM);
            json.Add("repeat", _repeat);
            json.Add("checked", _checked.ToString());
            json.Add("action", "update_task");
            string rasp = WebServer.post_get(JsonConvert.SerializeObject(json));

            if (_id == 0)
                _id = Convert.ToInt32(rasp);
        }
        

        
    }
}

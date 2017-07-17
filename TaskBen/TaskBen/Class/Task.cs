using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskBen.Class
{
    public class Task
    {
        private string _date;
        private string _dateHH;
        private string _dateMM;
        private string _remHH;
        private string _remMM;
        private string _repeat;
        private string _description;

        public string Date
        {
            set { _date = value; }
            get { return _date; }
        }

        public void task_add()
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
            string rasp = WebServer.task_add(JsonConvert.SerializeObject(json));
            MessageBox.Show(rasp);
            //return true;
        }

        public string Description
        {
            set { _description = value; }
            get { return _description; }
        }
        public string DateHH
        {
            set { _dateHH = value; }
            get { return _dateHH; }
        }
        public string DateMM
        {
            set { _dateMM = value; }
            get { return _dateMM; }
        }
        public string RemHH
        {
            set { _remHH = value; }
            get { return _remHH; }
        }
        public string RemMM
        {
            set { _remMM = value; }
            get { return _remMM; }
        }
        
        public string repeat
        {
            set { _repeat = value; }
            get { return _repeat; }
        }
    }
}

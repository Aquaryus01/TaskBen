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
            string rasp = WebServer.task_add(_description, _date, _dateHH, _dateMM, _remHH, _remMM, _repeat);
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

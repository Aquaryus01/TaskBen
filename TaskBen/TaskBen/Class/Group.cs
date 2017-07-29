using MetroFramework;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskBen.Forms;

namespace TaskBen.Class
{
    public class Group
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> groupMembers { get; set; } 
        public string MemberEmail { get; set; }

        public bool VerifyMember()
        {
            Dictionary<string, string> json = new Dictionary<string, string>();
            json.Add("memberName", MemberEmail);
            json.Add("action", "member_existence");
            string rasp = WebServer.post_get(JsonConvert.SerializeObject(json));

            try
            {
                json = JsonConvert.DeserializeObject<Dictionary<string, string>>(rasp);
                if (json["Error"].ToString() == "" && json["Answer"].ToString() == "1")
                    return true;
                else 
                    return false;
            }
            catch
            {
                MessageBox.Show(rasp);
            }

            return false;
        }

        public bool SameMember()
        {
            foreach (string name in groupMembers)
            {
                if (name == this.MemberEmail)
                    return false;
            }
            return true;
        }

        public void AddMember()
        {

        }
    }
}

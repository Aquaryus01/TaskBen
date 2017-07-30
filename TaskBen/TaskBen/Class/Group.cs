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
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> groupMembers { get; set; } 
        public string MemberEmail { get; set; }

        public Group()
        {
            Id = 0;
        }

        public bool validate_data(ref string broken_rule)
        {
            if (Name == "" || Name == null)
            {
                broken_rule = "The Name is empty!";
                return false;
            }
            return true;
        }

        public bool save(ref string broken_rule)
        {
            if (validate_data(ref broken_rule))
            {
                try{
                    Dictionary<string, string> json = new Dictionary<string, string>();
                    json.Add("Name",Name);
                    json.Add("Id", Id.ToString());
                    json.Add("Description", Description);
                    json.Add("action", "save_group");
                    
                    string rasp = WebServer.post_get(JsonConvert.SerializeObject(json));
                    json = JsonConvert.DeserializeObject<Dictionary<string, string>>(rasp);

                    if (json["Error"].ToString() == "")
                    {
                        Id = Convert.ToInt32(json["Id"]);
                        return true;
                    }
                    else
                    {
                        broken_rule = json["Error"].ToString();
                        return false;
                    }
                }
                catch(Exception ex){
                    broken_rule = ex.Message;
                    return false;
                }
            }
            else
                return false;
        }

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

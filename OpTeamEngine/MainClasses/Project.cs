using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OpTeamEngine.MainClasses
{
    [Serializable]
    public class Project
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Topic> Topics { get; set;  }
        public List<Participant> Participants { get; set; }
        public Participant Owner { get; set; }
        public Participant Assignee { get; set; }
    }
}

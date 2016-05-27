using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OpTeamEngine.MainClasses
{
    [Serializable]
    public class Topic
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Attachment> Attachments { get; set; }
        public string Owner { get; set; }
        public string Assignee { get; set; }
    }
}

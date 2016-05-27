using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OpTeamEngine.MainClasses
{
    [Serializable]
    public class Participant
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; } //Bad practice =(. Needed for chat.

        enum Role
        {
            PARTICIPANT,
            MANAGER,
            DIRECTOR
        }
    }
}

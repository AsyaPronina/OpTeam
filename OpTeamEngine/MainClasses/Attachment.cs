using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OpTeamEngine.MainClasses
{
    [Serializable]
    public class Attachment
    {
        public string FileName { get; set; }
        public string Link { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpTeamUI.Interfaces
{
    interface IProjectView : IView
    {
        string LoggedAs { get; set; }
        string AssignedTo { get; set; }
    }
}

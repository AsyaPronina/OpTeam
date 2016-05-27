using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpTeamUI.Interfaces
{
    interface IAuthorizationView: IView
    {
        string User { get; set; }
        string Password { get; set; }

        event EventHandler SignedIn;

        void ShowError(string message);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpTeamUI.Interfaces;
using OpTeamEngine.Interfaces;
using OpTeamEngine.MainClasses;
using OpTeamEngine.Infrastructure;

namespace OpTeamUI
{
    class AuthorizationPresenter
    {
        public AuthorizationPresenter(IAuthorizationView view)
        {
            this.view = view;
            this.view.SignedIn += OnUserSignedIn;
        }

        public void OnUserSignedIn(object sender, EventArgs e)
        {
            model.AuthorizeUser(view.User, view.Password);
        }

        static public int value = 4;
        static private AuthorizationPresenter backUP = new AuthorizationPresenter(new AutorizationView());
        private IEngine model = Infrastructure.Instance.GetEngine();
        private IAuthorizationView view;
    }
}

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
            this.view.AuthorizationRequested += OnAuthorizationRequested;

            this.model.UserAuthorized += OnUserAuthorized;
        }

        public void OnAuthorizationRequested(object sender, EventArgs e)
        {
            model.AuthorizeUser(view.User, view.Password);
        }

        public void OnUserAuthorized()
        {
            view.Update("Yeah!", "You are authorized!");
        }

        private IEngine model = Infrastructure.Instance.GetEngine();
        private IAuthorizationView view;
    }
}

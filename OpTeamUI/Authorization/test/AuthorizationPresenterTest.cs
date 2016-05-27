using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpTeamUI.Interfaces;

namespace OpTeamUI.Authorization.test
{
    [TestFixture]
    class AuthorizationPresenterTest
    {
        private IAuthorizationView _view;

        [SetUp]
        private void SetUP()
        {
        //    _view = Substitute.For<IAuthorizationView>();          
        //    service.Login(Arg.Any<User>()).Returns(info => info.Arg<User>().Name == "admin" && info.Arg<User>().Password == "password");
        //    var presenter = new AuthorizationPresenter(_view);
        //    presenter.Run();
        }
    }
}

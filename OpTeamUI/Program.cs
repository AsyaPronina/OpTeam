using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpTeamEngine.Infrastructure;

namespace OpTeamUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var insfrastructure = Infrastructure.Instance;
            insfrastructure.Start();
            var mainView = new AutorizationView();
            var presenter = new AuthorizationPresenter(mainView);
            Application.Run(mainView);
        }
    }
}

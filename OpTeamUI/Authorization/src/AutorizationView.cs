using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpTeamUI.Interfaces;

namespace OpTeamUI
{
    public partial class AutorizationView : Form, IAuthorizationView
    {
        public AutorizationView()
        {
            InitializeComponent();
        }

        public string User
        {
            get
            {
                return user;
            }
            set
            {
                this.user = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                this.password = value;
            }
        }

        public event EventHandler SignedIn;

        public void ShowError(string message)
        {
            MessageBox.Show(message);
        }

        private string user;
        private string password;

        private void button1_Click(object sender, EventArgs e)
        {
            if (((textBox1.Text != null) && (textBox1.Text != String.Empty)
                && (textBox2.Text != null) && (textBox2.Text != String.Empty)))
            {
                User = textBox1.Text;
                Password = textBox2.Text;

                SignedIn(sender, e);
            }
        }
    }
}

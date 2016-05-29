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
        public delegate void UpdateCallBack(string userName, string password);

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

        public event EventHandler AuthorizationRequested;

        public void ShowError(string message)
        {
            MessageBox.Show(message);
        }

        public void Update(string userName, string password)
        {
            if (textBox1.InvokeRequired && textBox2.InvokeRequired)
            {
                this.Invoke(new UpdateCallBack(Update), new object[] {"Yeah!!!!", "You are authorized"});
            }
            else
            {
                textBox1.Text = userName;
                textBox2.Text = password;
            }
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

                AuthorizationRequested(sender, e);
            }
        }
    }
}

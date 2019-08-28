using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDPLibrary.Banking;
using EDPLibrary.Database;
using EDPLibrary.Password;

namespace EdpAssignment
{
    public partial class AccountScreen : UserControl
    {
        private Customer client;
        public AccountScreen(Customer tclient) : this()
        {
            this.client = tclient;
            LblFName.Text = client.FirstName;
            LblSName.Text = client.LastName;
            LblActiveBalance.Text= "43234";
        }

        public AccountScreen()
        {
            InitializeComponent();
        }

        private void OnLogoutClick(object sender, EventArgs e)
        {
            LoginHandler.Logout(this.client);
        }

        private void OnExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}

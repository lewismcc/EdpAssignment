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
    public partial class LoginScreen : UserControl
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void OnExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnSubmitClick(object sender, EventArgs e)
        {
            string email = TxtBoxEmail.Text;
            string password = TxtBoxPassword.Text;
            Customer client = LoginHandler.Login(email, password);
            MessageBox.Show("Log in successful");
           
            AccountScreen accountsScreen = new AccountScreen(client);
            MainWindow.GetInstance().ContentPanel.Controls.Remove(this);
            MainWindow.GetInstance().ContentPanel.Controls.Add(accountsScreen);


        }
    }
}

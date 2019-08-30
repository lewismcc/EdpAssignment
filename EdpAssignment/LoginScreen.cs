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
        /// <summary>
        /// The OnExitClick exits the program and makes no changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// The OnSubmitClick takes the users email and password
        /// makes sure both fields are valid and if they are sends them to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSubmitClick(object sender, EventArgs e)
        {
            string email = TxtBoxEmail.Text;
            string password = TxtBoxPassword.Text;
            try
            {
                Customer client = LoginHandler.Login(email, password);
                MessageBox.Show("Log in successful");

                AccountScreen accountsScreen = new AccountScreen(client);
                MainWindow.GetInstance().ContentPanel.Controls.Remove(this);
                MainWindow.GetInstance().ContentPanel.Controls.Add(accountsScreen);
            }
            catch (ArgumentException ae)
            {
                TxtBoxEmail.Text = "";
                TxtBoxPassword.Text = "";
                LblLoginWarning.Text = ae.ParamName;
                LblLoginWarning.Visible = true;
            }
        }
        /// <summary>
        /// Currently unimplemented 
        /// 30/08/2019
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHelpClick(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// The OnCancelClick clears the email field and password field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCancelClick(object sender, EventArgs e)
        {
            TxtBoxEmail.Text = "";
            TxtBoxPassword.Text = "";
        }
       
    }
}

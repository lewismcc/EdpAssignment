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
        public Customer client;
        TransactionMenu transactionMenu;

        public AccountScreen()
        {
            InitializeComponent();
        }
        /// <summary>
        /// The AccountScreen constructor builds the screen
        /// it creates a local instance of the client
        /// it displays the account, first and last name
        /// and the current balance of the account
        /// </summary>
        /// <param name="client"></param>
        public AccountScreen(Customer client) : this()
        {
            this.client = client;
            LblTitleAccount.Text += this.client.GetAccounts()[0].AccountNumber;
            LblFName.Text = this.client.FirstName + " " + this.client.LastName;
            LblActiveBalance.Text = this.client.GetAccounts()[0].Balance.ToString();
        }
        /// <summary>
        /// The OnLogoutClick logs the user out 
        /// it closes the account window and opens the login window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnLogoutClick(object sender, EventArgs e)
        {
            LoginHandler.Logout(this.client);

            LoginScreen login = new LoginScreen();
            MainWindow.GetInstance().ContentPanel.Controls.Remove(this);
            MainWindow.GetInstance().ContentPanel.Controls.Add(login);  
        }
        /// <summary>
        /// The OnexitClick logs the user out and closes the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnExitClick(object sender, EventArgs e)
        {
            LoginHandler.Logout(this.client);
            Application.Exit();
        }

        /// <summary>
        /// The OnTransactionMenuClick opens the transaction menu 
        /// it passes the client to the transaction menu 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTransactionMenuClick(object sender, EventArgs e)
        {
            if (transactionMenu == null)
            {
                transactionMenu = new TransactionMenu(client);
                this.TransactionPanel.Controls.Add(transactionMenu);
            }
            else
            {
                this.TransactionPanel.Controls.Add(transactionMenu);
            }
        }

        /// <summary>
        /// The OnCloseBtnClicked takes the client in from the transaction menu
        /// it updates the balance to reflect any changes made with transactions
        /// it closes the transaction menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCloseBtnClicked(object sender, EventArgs e)
        {
            if (transactionMenu != null)
            {
                this.client = transactionMenu.Client;
                LblActiveBalance.Text = this.client.GetAccounts().ElementAt(0).Balance.ToString();
                this.TransactionPanel.Controls.Remove(transactionMenu);
            }   
        }

        
    }
}

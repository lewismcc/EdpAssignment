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
        public AccountScreen(Customer client) : this()
        {
            this.client = client;
            LblTitleAccount.Text += this.client.GetAccounts()[0].AccountNumber;
            LblFName.Text = this.client.FirstName + " " + this.client.LastName;
            LblActiveBalance.Text = this.client.GetAccounts()[0].Balance.ToString();
        }

        private void OnLogoutClick(object sender, EventArgs e)
        {
            LoginHandler.Logout(this.client);

            LoginScreen login = new LoginScreen();
            MainWindow.GetInstance().ContentPanel.Controls.Remove(this);
            MainWindow.GetInstance().ContentPanel.Controls.Add(login);  
        }

        private void OnExitClick(object sender, EventArgs e)
        {
            LoginHandler.Logout(this.client);
            Application.Exit();
        }

        private void OnTransactionMenuClicked(object sender, EventArgs e)
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

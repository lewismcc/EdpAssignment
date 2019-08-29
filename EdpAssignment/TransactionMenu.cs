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

namespace EdpAssignment
{
    public partial class TransactionMenu : UserControl
    {
        private Customer client;
        public Customer Client
        {
            get => this.client;
        }

        private int deposit;
        private int withdraw;    
        public TransactionMenu()
        {
            InitializeComponent();
        }
        public TransactionMenu(Customer incomingClient): this()
        {
            this.client = incomingClient;
            
        }
        private void OnDepositMoneyClicked(object sender, EventArgs e)
        {
            deposit = Int32.Parse(TxtBoxDeposit.Text);
            this.client.GetAccounts().ElementAt(0).Deposit(deposit);

        }

        private void OnWithdrawMoneyClicked(object sender, EventArgs e)
        {
            withdraw = Int32.Parse(TxtBoxWithdraw.Text);
            this.client.GetAccounts().ElementAt(0).Withdraw(withdraw);

        }

       
    }
}

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
        private decimal temp;
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
            if (deposit < 0)
            {
                LblDepositBox.Text = "Cannot deposit negative amount";
                LblDepositBox.Visible = true;
                LblWithdrawBox.Visible = false;
            }
            else
            {
                LblDepositBox.Text = "Deposit successful";
                LblDepositBox.Visible = true;
                LblWithdrawBox.Visible = false; 
                this.client.GetAccounts()[0].Deposit(deposit);
            }
        }

        private void OnWithdrawMoneyClicked(object sender, EventArgs e)
        {   
            withdraw = Int32.Parse(TxtBoxWithdraw.Text);
            temp = this.client.GetAccounts()[0].Balance;
            if (withdraw > 0)
            {
                if (withdraw > temp)
                {
                    LblWithdrawBox.Text = "Insifficient funds!";
                    LblWithdrawBox.Visible = true;
                    LblDepositBox.Visible = false;
                }
                else
                {
                    this.client.GetAccounts()[0].Withdraw(withdraw);
                    LblWithdrawBox.Text = "Withdraw successful";
                    LblWithdrawBox.Visible = true;
                    LblDepositBox.Visible = false;
                }
            }
            else
            {
                LblWithdrawBox.Text = "Cannot withdraw negative amount";
                LblWithdrawBox.Visible = true;
                LblDepositBox.Visible = false;
            }            
        }
    }
}

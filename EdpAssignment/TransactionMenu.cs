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

        private int deposit = 0;
        private int withdraw = 0 ;
        private decimal temp;
        public TransactionMenu()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This constructor builds the transaction menu 
        /// and takes in an incoming client and makes a local instance 
        /// </summary>
        /// <param name="incomingClient"></param>
        public TransactionMenu(Customer incomingClient) : this()
        {
            this.client = incomingClient;
        }
        /// <summary>
        /// The OnDepositMoneyClicked takes in user input
        /// if the value entered isnt negative the deposit will be successful
        /// if they try to deposit a negative amount they will get an appropriate error
        /// message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDepositMoneyClicked(object sender, EventArgs e)
        {
            try
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
            catch (FormatException fe)
            {
                LblDepositBox.Text = fe.Message;
                LblDepositBox.Visible = true;
                LblWithdrawBox.Visible = false;
            }
        }
        
        /// <summary>
        /// The OnWithdrawMoneyClicked method takes in user input
        /// if the value entered isnt a negative amount and the user has enough money 
        /// in their account the withdrawal will be successful
        /// if not they will get an appropriate error message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnWithdrawMoneyClicked(object sender, EventArgs e)
        {
            try
            {
                withdraw = Int32.Parse(TxtBoxWithdraw.Text);
                temp = this.client.GetAccounts()[0].Balance;

                if (withdraw > 0)
                {
                    if (withdraw > temp)
                    {
                        LblWithdrawBox.Text = "Insufficient funds!";
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
            catch (FormatException fe)
            {
                LblWithdrawBox.Text =fe.Message;
                LblWithdrawBox.Visible = true;
                LblDepositBox.Visible = false;
            }
        
        }
    }
}

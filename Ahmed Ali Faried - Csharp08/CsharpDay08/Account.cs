using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay08
{
    #region Problem06
    internal struct Account
    {
        private int accountId;
        private string accountHolder;
        private double balance;
        public int AccountId { get; set; }

        public string AccountHolder { get; set; }

        public double Balance
        {
            get { return balance; }
            set
            {
                if (value >= 0)
                    balance = value;
            }
        }
        public void Display()
        {
            Console.WriteLine($"ID: {AccountId}, Holder: {AccountHolder}, Balance: {Balance}");
        }
    } 
    #endregion
}

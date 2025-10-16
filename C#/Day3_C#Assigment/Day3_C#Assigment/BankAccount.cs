using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_C_Assigment
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolder { get; set; }    
        public double Balance { get; set; }

        public BankAccount():this(00,"a",0.0) {
        
        }
        public BankAccount(int accountNumber, string accountHolder, double balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;

        }
        public double Deposit(int Amount)
        {
            Balance = Balance + Amount;
            return Balance;
        }
        public void DisplayBalance()
        {
            Console.WriteLine("Account Details");
            Console.WriteLine("Account Number "+AccountNumber);
            Console.WriteLine("Account Holder Name " + AccountHolder);
            Console.WriteLine("Account Balance " + Balance);
        }
    }
}

using System;

namespace Day3_C_Assignment
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public double Balance { get; set; }

        public BankAccount() : this(0, "Unknown", 0.0)
        {
        }

        public BankAccount(int accountNumber, string accountHolder, double balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public double Deposit(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return Balance;
            }

            Balance += amount;
            Console.WriteLine($"Successfully deposited {amount}. New balance: {Balance:C}");
            return Balance;
        }

        public bool Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return false;
            }

            if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance.");
                return false;
            }

            Balance -= amount;
            Console.WriteLine($"Successfully withdrew {amount}. New balance: {Balance:C}");
            return true;
        }

        public void DisplayBalance()
        {
            Console.WriteLine("\n=== Account Details ===");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Holder: {AccountHolder}");
            Console.WriteLine($"Balance: {Balance:C}");
            Console.WriteLine("========================\n");
        }
    }
}

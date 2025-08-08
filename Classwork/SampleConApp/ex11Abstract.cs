using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingDemo
{
    abstract class Account
    {
        public string AccountHolder { get; set; }
        public double Balance { get; private set; } = 2000;

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }
            Balance +=amount;
            Console.WriteLine($"Deposited {amount}. New balance is {Balance}.");
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return;
            }
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds for withdrawal.");
                return;
            }
            Balance =Balance- amount;
            Console.WriteLine($"Withdrew {amount}. New balance is {Balance}.");
        }

        public abstract void CalculateInterest();

    }

    class SavingsAccount : Account
    {
        public double InterestRate { get; set; } = .025;
        public SavingsAccount(string accountHolder)
        {
            AccountHolder = accountHolder;
        }
        public override void CalculateInterest()
        {
            double interest = Balance * InterestRate / 100;
            Deposit(interest); // Adding interest to the balance
            Console.WriteLine($"Interest earned on Savings Account: {interest}");
            Console.WriteLine("Withdrawing 50 from Savings Account");
            Withdraw(50); 
        }
    }

    class RecurringDepositAccount : Account
    {
        public double InterestRate { get; set; } = 0.05;
        public double MonthlyDeposit { get; set; }
        public int Months { get; set; }
        public RecurringDepositAccount(string accountHolder, double monthlyDeposit, int months)
        {
            AccountHolder = accountHolder;
            MonthlyDeposit = monthlyDeposit;
            Months = months;
        }
        public override void CalculateInterest()
        {
            double r = 5.0;
            double interest = (MonthlyDeposit * Months * (Months + 1) * r) / (2 * 12 * 100);
            Deposit(interest); // Adding interest to the balance

            Console.WriteLine($"Interest earned on Recurring Deposit Account: {interest}");
        }
    }
    class FixedDepositAccount : Account
    {
        public double InterestRate  = 0.07;
        public int Month; // in months
        public FixedDepositAccount(string accountHolder, int month)
        {
            AccountHolder = accountHolder;
            Month = month;
        }
        public override void CalculateInterest()
        {
            double interest = Balance * InterestRate * Month / 12 / 100;
            Deposit(interest); // Adding interest to the balance
            Console.WriteLine($"Interest earned on Fixed Deposit Account: {interest}");
        }
    }
}
namespace SampleConApp
{
    using BankingDemo; //To use the class of another namespace...
    internal class Ex11AbstractClasses
    {
        static void Main(string[] args)
        {
            //Account acc = new SavingsAccount("John Doe");

            Console.Write("Enter account holder name: ");
            string accountHolder = Console.ReadLine();
            Console.Write("Enter type of account: ");
            string accountType = Console.ReadLine().ToLower();
            if(accountType == "recurring")
            {
                Console.Write("Enter monthly deposit amount: ");
                double monthlyDeposit = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter number of months: ");
                int months = Convert.ToInt32(Console.ReadLine());
                Account acc = new RecurringDepositAccount(accountHolder, monthlyDeposit, months);
                acc.Deposit(monthlyDeposit * months); // Initial deposit for recurring account
                acc.CalculateInterest();
            }
            else if(accountType == "savings")
            {
                // Default to Savings Account if not specified
                Account acc = new SavingsAccount(accountHolder);
                Console.WriteLine("Enter deposit:");
                int depositAmount = Convert.ToInt32(Console.ReadLine());
                acc.Deposit(depositAmount); // Initial deposit for savings account
                acc.CalculateInterest();
            }
            else
            {
                Account account = new FixedDepositAccount(accountHolder, 12);
                Console.WriteLine("Enter deposit:");
                int depositAmount = Convert.ToInt32(Console.ReadLine());
                account.Deposit(depositAmount); // Initial deposit for fixed deposit account
                account.CalculateInterest();

            }
            
        }
    }
}

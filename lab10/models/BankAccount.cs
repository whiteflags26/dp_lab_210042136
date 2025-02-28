using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    public class BankAccount
    {
        public string Id { get; }
        public string AccountHolder { get; }
        public decimal Balance { get; set; }
        public List<Transaction> Transactions { get; set; }

        public BankAccount(string id, string accountHolder, decimal intilaDeposit)
        {
            Id = id;
            AccountHolder = accountHolder;
            Balance = 0;

            List<Transaction> transactions = new List<Transaction>();

            transactions.Add(
                new Transaction
                {
                    Amount = intilaDeposit,
                    Type = TransactionType.Deposit,
                    Date = DateTime.Now,
                    Notes = "Initial Deposit"
                }
            );
        }

        public void ShowAccountDetails()
        {
            Console.WriteLine($"Account ID: {Id}");
            Console.WriteLine($"Account Holder: {AccountHolder}");
            Console.WriteLine($"Balance: {Balance}");
        }

        public void ShowAllTransactions()
        {
            foreach (Transaction transaction in Transactions)
            {
                Console.WriteLine($"Amount: {transaction.Amount}");
                Console.WriteLine($"Type: {transaction.Type}");
                Console.WriteLine($"Date: {transaction.Date}");
                Console.WriteLine($"Notes: {transaction.Notes}");
            }
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            Transactions.Add(
                new Transaction
                {
                    Amount = amount,
                    Type = TransactionType.Deposit,
                    Date = DateTime.Now,
                    Notes = "Deposit"
                }
            );
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
            Transactions.Add(
                new Transaction
                {
                    Amount = amount,
                    Type = TransactionType.Withdrawal,
                    Date = DateTime.Now,
                    Notes = "Withdrawal"
                }
            );
        }
    }
}

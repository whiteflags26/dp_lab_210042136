using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    public class DepositCommand : ICommand
    {
        public BankHistory BankHistory { get; set; }
        public string AccountId { get; set; }
        public decimal Amount { get; set; }

        public DepositCommand(BankHistory bankHistory, string accountId, decimal amount)
        {
            BankHistory = bankHistory;
            AccountId = accountId;
            Amount = amount;
        }

        public void Do()
        {
            BankHistory.GetAccountById(AccountId).Deposit(Amount);
        }
    }
}

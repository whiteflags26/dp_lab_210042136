using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    public class CreateAccountCommand : ICommand
    {
        public BankHistory BankHistory { get; set; }
        public string AccountId { get; set; }
        public string AccountHolder { get; set; }
        public decimal InitialDeposit { get; set; }

        public CreateAccountCommand(BankHistory bankHistory, string accountHolder, decimal initialDeposit)
        {
            BankHistory = bankHistory;
            AccountId = Guid.NewGuid().ToString();
            AccountHolder = accountHolder;
            InitialDeposit = initialDeposit;
        }

        public void Do()
        {
            BankHistory.AddAccount(AccountId, new BankAccount(AccountId, AccountHolder, InitialDeposit));
        }
    }
}

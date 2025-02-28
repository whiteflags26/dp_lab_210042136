using lab10.commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    public class Query
    {
        public BankHistory BankHistory { get; set; }
        public CommandHistory CommandHistory { get; set; }

        public Query(BankHistory bankHistory, CommandHistory commandHistory)
        {
            BankHistory = bankHistory;
            CommandHistory = commandHistory;
        }
        
        public void CreateAccount(string accountHolder, decimal initialDeposit)
        {
            ICommand command = new CreateAccountCommand(BankHistory, accountHolder, initialDeposit);
            CommandHistory.ProcessCommand(command);
        }

        public void Deposit(string accountId, decimal amount)
        {
            ICommand command = new DepositCommand(BankHistory, accountId, amount);
            CommandHistory.ProcessCommand(command);
        }

        public void Withdraw(string accountId, decimal amount)
        {
            ICommand command = new WithdrawCommand(BankHistory, accountId, amount);
            CommandHistory.ProcessCommand(command);
        }

        public void ShowAccountDetails(string accountId)
        {
            BankHistory.GetAccountById(accountId).ShowAccountDetails();
        }

        public void ShowAllAccountDetails()
        {
            throw new NotImplementedException();
        }
    }
}

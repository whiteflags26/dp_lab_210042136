using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    public class BankHistory
    {
        private Dictionary<string, BankAccount> history = new Dictionary<string, BankAccount>();
        
        public BankAccount GetAccountById(string id)
        {
            return history[id];
        }

        public void AddAccount(string id, BankAccount bankAccount)
        {
            history.Add(id, bankAccount);
        }

        public void RemoveAccount(string id)
        {
            history.Remove(id);
        }

        public List<BankAccount> GetAllAccounts()
        {
            return history.Values.ToList();
        }
    }
}

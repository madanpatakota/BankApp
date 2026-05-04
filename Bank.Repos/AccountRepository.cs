using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Repos
{
    public class AccountRepository : IAccountRepository
    {
        public string GetBalance(string accountNumber)
        {
            if (accountNumber == "HDFC1234")
            {
                return "You are having 10000 rupees balance";
            }
            else
            {
                return "You don't have an account";
            }
        }
    }
}

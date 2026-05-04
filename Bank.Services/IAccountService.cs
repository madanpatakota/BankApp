using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Services
{
    public interface IAccountService
    {
        string GetBalance(string accountNumber);
    }

   
}

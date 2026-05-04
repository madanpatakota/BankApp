using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Repos;
using Bank.Services;

namespace Bank.Controllers
{

    //User Request from Here.
     class EntryPoint
    {
        static void Main()
        {
            string accountNum = "HDFC1234";

            // DI manually
            IAccountRepository repo = new AccountRepository();
            IAccountService service = new AccountService(repo);

            string result = service.GetBalance(accountNum);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

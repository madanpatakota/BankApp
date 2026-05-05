using Microsoft.Extensions.DependencyInjection;
using System;
using Bank.Services;
using Bank.Repos;
using Bank.Controllers;



namespace EntryPoint
{

    class UserRequest
    {
        public static void Main()
        {

            //Lets call to the method from controller




            //IServiceProvider provider = ServicesConfiguration.SetupServices();
            //IAccountService service = provider.GetService<IAccountService>();




            //Console.WriteLine("User having the Account number : HDFC1234");
            //string balance =  service.GetBalance("HDFC1234"); // GEtBalanace
            //Console.WriteLine(balance);
            //Console.ReadLine();


            string accountNum = "HDFC1234";

            // DI manually
            IAccountRepository repo = new AccountRepository();
            IAccountService service = new AccountService(repo);


            AccountController controller = new AccountController(service);
            string result = controller.GetBalance(accountNum);

            Console.WriteLine(result);
            Console.ReadLine();


        }
    }

    //User Request from Here.
   
}

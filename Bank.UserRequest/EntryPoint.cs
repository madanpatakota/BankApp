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


            string accountNum = "HDFC1234";


            var services = new ServiceCollection();

            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<AccountController>();


            IServiceProvider serviceProvider = services.BuildServiceProvider();
            IAccountService service = serviceProvider.GetService<IAccountService>();


            // DI manually
            //IAccountRepository repo = new AccountRepository();
            //IAccountService service = new AccountService(repo);

            AccountController controller = new AccountController(service);
            string result = controller.GetBalance(accountNum);

            Console.WriteLine(result);
            Console.ReadLine();


        }
    }

    //User Request from Here.

}

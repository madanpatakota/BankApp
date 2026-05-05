using Bank.Repos;
using Bank.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Controllers
{

    //User Request from Here.
    internal class EntryPoint
    {
        //static void Main()
        //{
        //    string accountNum = "HDFC1234";

        //    // DI manually
        //    IAccountRepository repo = new AccountRepository();
        //    IAccountService service = new AccountService(repo);

        //    string result = service.GetBalance(accountNum);

        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //}

        static void Main()
        {
            string accountNum = "HDFC1234";

            // DI manually
            //IAccountRepository repo = new AccountRepository();
            //IAccountService service = new AccountService(repo);

            //Lets Assign DI assignment to the Csharp Code. Lets it handle the DI
            //LIke create the object while Project Starts

            // Step 3.1: Create a service collection and configure 
            ServiceCollection serviceCollection = new ServiceCollection();

            // Step 3.2: Register services with their implementations
            serviceCollection.AddTransient<IAccountService, AccountService>();
            serviceCollection.AddTransient<IAccountRepository, AccountRepository>();

            // Step 3.3: Build the service provider
            IServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

            // Resolve and use the AccountService
            IAccountService accountService =  serviceProvider.GetService<IAccountService>();

            string getBalance = accountService.GetBalance(accountNum);

            // Step 4: Use the services
            //UseServices(serviceProvider);

            //string result = service.GetBalance(accountNum);

            //Console.WriteLine(result);
            Console.ReadLine();
        }


        //static void UseServices(IServiceProvider serviceProvider)
        //{
        //    // Step 4.1: Resolve services from the service provider
        //    IAccountService acccountService = serviceProvider.GetService<IAccountService>();
        //    AccountRepository accountRepo = serviceProvider.GetService<AccountRepository>();

        //    // Step 4.2: Use the services
        //    acccountService = new AccountService(accountRepo);

        //    // The services are automatically disposed of when the scope is disposed

        //    Console.ReadLine();
        //}
    }
}

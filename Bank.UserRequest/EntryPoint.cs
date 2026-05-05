using Bank.Controllers;
using Bank.Services;
using Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;



namespace EntryPoint
{

    class UserRequest
    {
        public static void Main1()
        {

            //Lets call to the method from controller


            IServiceProvider provider = ServicesConfiguration.SetupServices();
            IAccountService service = provider.GetService<IAccountService>();



            Console.WriteLine("User having the Account number : HDFC1234");
            string balance =  service.GetBalance("HDFC1234"); // GEtBalanace
            Console.WriteLine(balance);
            Console.ReadLine();


        }


        public static void Main()
        {

            IServiceProvider provider = ServicesConfiguration.SetupServices();

            // 👉 Get Controller instead of Service
            AccountController controller = provider.GetService<AccountController>();

            Console.WriteLine("User having the Account number : HDFC1234");

            // 👉 Call Controller  // User Request here  For Get the Balance here 
            string balance = controller.GetBalance("HDFC1234");



            Console.WriteLine(balance);
            Console.ReadLine();


        }
    }

    //User Request from Here.
   
}

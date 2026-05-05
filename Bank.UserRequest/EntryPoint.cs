using Microsoft.Extensions.DependencyInjection;
using System;
using Bank.Controllers;
using Bank.Services;
using Configuration;
using System.IO.Ports;




namespace EntryPoint
{

    class UserRequest
    {
        public static void Main()
        {

            //Lets call to the method from controller


            IServiceProvider provider = ServicesConfiguration.SetupServices();
            IAccountService service = provider.GetService<IAccountService>();




            Console.WriteLine("User having the Account number : HDFC1234");
            string balance =  service.GetBalance("HDFC1234"); // GEtBalanace
            Console.WriteLine(balance);
            Console.ReadLine();


        }
    }

    //User Request from Here.
   
}

using Microsoft.Extensions.DependencyInjection;
using System;
using Bank.Services;
using Bank.Repos;
using Bank.Controllers;

namespace Configuration
{
  
        public static class ServicesConfiguration
        {

            public static IServiceProvider SetupServices()
            {
                var services = new ServiceCollection();

                services.AddTransient<IAccountService, AccountService>();
                services.AddTransient<IAccountRepository, AccountRepository>();
                services.AddTransient<AccountController>();

            return services.BuildServiceProvider();
            }

        }
    
}

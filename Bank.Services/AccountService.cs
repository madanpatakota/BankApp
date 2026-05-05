using Bank.Repos;
using System;
using System.IO;

namespace Bank.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _repo;

        public AccountService(IAccountRepository repo)
        {
            _repo = repo;
        }

        public string GetBalance(string accountNumber)
        {
            return _repo.GetBalance(accountNumber);
        }
    }


    //public class AccountService1 : IAccountService
    //{
        
    //    public string GetBalance(string accountNumber)
    //    {
    //        AccountRepository _repo = new AccountRepository();
    //        return _repo.GetBalance(accountNumber);
    //    }
    //}
}

//“Here, in the first version of the code, the service class is directly creating the repository object.

//So the high-level module, which is the service, is depending on the low-level module, which is the repository. This creates tight coupling.

//According to the Dependency Inversion Principle, high-level modules should not depend on low-level modules. Both should depend on abstractions.

//So instead of directly creating the repository object, we introduce an interface.

//Now, the service depends on the interface, not on the concrete class.

//And the actual repository implementation is provided from outside using dependency injection.

//Because of this, the dependency is inverted, and the code becomes loosely coupled and more flexible.”

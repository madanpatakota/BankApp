using System;
using Bank.Repos;

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
}

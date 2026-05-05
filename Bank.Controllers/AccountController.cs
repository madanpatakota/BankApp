using Bank.Services;


namespace Bank.Controllers
{
   public  class AccountController
    {
        IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public string GetBalance(string AccNo)
        {
            return _accountService.GetBalance(AccNo);
        }
    }


}

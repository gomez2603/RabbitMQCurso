using MicroRabbit.Backing.Domain.Interfaces;
using MicroRabbit.Backing.Domain.Models;
using MicrroRabbit.Banking.Application.Interfaces;

namespace MicrroRabbit.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public IEnumerable<Account> GetAccounts()
        {
             return _accountRepository.GetAccounts();
        }
    }
}

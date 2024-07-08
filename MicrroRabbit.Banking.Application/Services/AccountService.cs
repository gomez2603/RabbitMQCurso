using MicroRabbit.Backing.Domain.Commands;
using MicroRabbit.Backing.Domain.Interfaces;
using MicroRabbit.Backing.Domain.Models;
using MicroRabbit.Domain.Core.Bus;
using MicrroRabbit.Banking.Application.Interfaces;
using MicrroRabbit.Banking.Application.Models;

namespace MicrroRabbit.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IEventBus _eventBus;

        public AccountService(IAccountRepository accountRepository, IEventBus eventBus)
        {
            _accountRepository = accountRepository;
            _eventBus = eventBus;
        }

        public IEnumerable<Account> GetAccounts()
        {
             return _accountRepository.GetAccounts();
        }

        public void Transfer(AccountTransfer accountTransfer)
        {

            var createTransferCommand = new CreateTransferCommand(
                accountTransfer.FromAccount, 
                accountTransfer.ToAccount, 
                accountTransfer.TransferAmmount
                );
            _eventBus.SendCommand(createTransferCommand);

        }
    }



}

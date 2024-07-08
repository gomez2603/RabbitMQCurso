using MicroRabbit.Backing.Domain.Models;
using MicrroRabbit.Banking.Application.Models;


namespace MicrroRabbit.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();

        void Transfer(AccountTransfer accountTransfer);
    }
}

using MicroRabbit.Backing.Domain.Models;


namespace MicroRabbit.Backing.Domain.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccounts();

    }
}

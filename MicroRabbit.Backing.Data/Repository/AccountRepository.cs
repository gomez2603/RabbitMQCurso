using MicroRabbit.Backing.Data.Context;
using MicroRabbit.Backing.Domain.Interfaces;
using MicroRabbit.Backing.Domain.Models;

namespace MicroRabbit.Backing.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankingDbContext _context;
        public AccountRepository(BankingDbContext context)
        {
                _context = context;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _context.Accounts;
        }
    }
}



using MicroRabbit.Backing.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.Backing.Data.Context
{
    public class BankingDbContext :DbContext
    {
        public BankingDbContext(DbContextOptions options) :base (options)
        {


        }

        public DbSet<Account> Accounts { get; set; }
    }
}

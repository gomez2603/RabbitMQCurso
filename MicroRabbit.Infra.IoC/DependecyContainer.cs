using MicroRabbit.Backing.Data.Context;
using MicroRabbit.Backing.Data.Repository;
using MicroRabbit.Backing.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MicrroRabbit.Banking.Application.Interfaces;
using MicrroRabbit.Banking.Application.Services;

namespace MicroRabbit.Infra.IoC
{
    public class DependecyContainer
    {
        public static void RegisterServices(IServiceCollection services,IConfiguration configuration)
        {
            //Domain bus
            services.AddTransient<IEventBus, RabbitMQBus>();
            services.Configure<RabbitMQSettings>(c => configuration.GetSection("RabbitMQSettings"));


            //Application Services

            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<BankingDbContext>();
                
                }
    }
}

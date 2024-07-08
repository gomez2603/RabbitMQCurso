using MediatR;
using MicroRabbit.Backing.Data.Context;
using MicroRabbit.Backing.Data.Repository;
using MicroRabbit.Backing.Domain.CommandHandlers;
using MicroRabbit.Backing.Domain.Commands;
using MicroRabbit.Backing.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Application.Services;
using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Data.Repository;
using MicroRabbit.Transfer.Domain.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MicrroRabbit.Banking.Application.Interfaces;
using MicrroRabbit.Banking.Application.Services;
using System.Reflection;

namespace MicroRabbit.Infra.IoC
{
    public static class DependecyContainer
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services,  IConfiguration configuration)
        {


            //services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();
            //MediaTR

            services.AddMediatR(Assembly.GetExecutingAssembly());

            //Domain bus
            services.AddTransient<IEventBus, RabbitMQBus>();
            services.Configure<RabbitMQSettings>(c => configuration.GetSection("RabbitMQSettings"));


            //Application Services Banking

            //services.AddTransient<IAccountService, AccountService>();
            //services.AddTransient<IAccountRepository, AccountRepository>();
            //services.AddTransient<BankingDbContext>();


            ////Application Services Banking
            //services.AddTransient<ITransferService, TransferService>();
            //services.AddTransient<ITransferRepository, TransferRepository>();
            //services.AddTransient<TransferDbContext>();


            return services;
                }
    }
}

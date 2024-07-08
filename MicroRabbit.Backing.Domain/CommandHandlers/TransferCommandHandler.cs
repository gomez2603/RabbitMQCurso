using MediatR;
using MicroRabbit.Backing.Domain.Commands;
using MicroRabbit.Backing.Domain.Events;
using MicroRabbit.Domain.Core.Bus;

namespace MicroRabbit.Backing.Domain.CommandHandlers
{
    public class TransferCommandHandler : IRequestHandler<CreateTransferCommand, bool>
    {

        private readonly IEventBus _eventBus;

        public TransferCommandHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public Task<bool> Handle(CreateTransferCommand request, CancellationToken cancellationToken)
        {
            _eventBus.Publish(new TransferCreateEvent(request.From, request.To, request.Ammount));


            return Task.FromResult(true);
        }
    }
}

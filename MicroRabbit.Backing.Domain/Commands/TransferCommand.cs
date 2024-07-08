

using MicroRabbit.Domain.Core.Commands;

namespace MicroRabbit.Backing.Domain.Commands
{
    public abstract class TransferCommand :Command
    {

        public int From { get;  protected set; }
        public int To { get; protected set; }
        public decimal Ammount { get;  protected set; }

    }
}

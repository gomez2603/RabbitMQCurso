
using MicroRabbit.Domain.Core.Events;

namespace MicroRabbit.Backing.Domain.Events
{
    public class TransferCreateEvent : Event
    {
     

        public int From { get; set; }
        public int To { get; set; }
        public decimal Ammount { get; set; }

        public TransferCreateEvent(int from, int to, decimal ammount)
        {
            From = from;
            To = to;
            Ammount = ammount;
        }

    }
}

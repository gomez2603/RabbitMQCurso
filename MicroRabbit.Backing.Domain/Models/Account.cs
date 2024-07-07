
namespace MicroRabbit.Backing.Domain.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string AccoutnType { get; set; } = string.Empty;
        public decimal AccountBalance { get; set; }
    }
}

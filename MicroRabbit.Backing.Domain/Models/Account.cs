
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MicroRabbit.Backing.Domain.Models
{
    public class Account
    {
     
        public int Id { get; set; }
        public string AccoutnType { get; set; } = string.Empty;
        [Column(TypeName ="decimal(5,2)")]
        public decimal AccountBalance { get; set; }
    }
}

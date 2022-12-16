using System.ComponentModel.DataAnnotations;

namespace Pubs.Models
{
    public class Order
    {
        public uint Id { get; set; }

        [Required] public uint Quantity { get; set; }

        [Required] public ulong Price { get; set; }

        //relations
        public uint TitelId { get; set; }
        public Title? Title { get; set; }

        public uint CustomerId { get; set; }
        public Customer? Customer { get; set; }
    }
}

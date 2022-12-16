using System.ComponentModel.DataAnnotations;

namespace Pubs.Models
{
    public class Customer
    {
        public uint Id { get; set; }

        [Required(ErrorMessage = "The Name Is Required")]
        public string Name { get; set; } = string.Empty;
        
        [Required(ErrorMessage ="The Emaill Address Is Required")]
        [EmailAddress]
        public string EmailAddress { get; set; } = string.Empty;

        //relations
        public List<Order>? Orders { get; set; }
    }
}

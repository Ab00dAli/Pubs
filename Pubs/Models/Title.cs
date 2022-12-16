using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pubs.Models
{
    public class Title
    {
        
        public uint Id { get; set; }

        [Required] public string Name { get; set; } = string.Empty;
        
        [Required] public string Type { get; set; } = string.Empty;
        
        [Required] public ulong Price { get; set; }
        
        //relations
        public uint PublisherId { get; set; }

        public Publisher? Publisher { get; set; }
        public List<Order>? Orders { get; set; }

        public List<AuthorTitle>? AuthorTitles { get; set; }

    }
}

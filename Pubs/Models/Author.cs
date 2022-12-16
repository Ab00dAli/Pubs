using System.ComponentModel.DataAnnotations;

namespace Pubs.Models
{
    public class Author
    {
        public uint Id { get; set; }
        [Required] public string Name { get; set; } = string.Empty;

        [Required] public string City { get; set; } = string.Empty;

        [Required] 
        [StringLength(10)] 
        public string Phone { get; set; } = string.Empty;

        //relations
        public List<AuthorTitle>? AuthorTitles { get; set; }
    }
}

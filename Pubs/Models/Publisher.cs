using System.ComponentModel.DataAnnotations;

namespace Pubs.Models
{
    public class Publisher
    {
        public uint Id { get; set; }
        [Required] public string Name { get; set; } = string.Empty;
        [Required] public string City { get; set; } = string.Empty;

        //relations
        public List<Title>? Titles { get; set; }
    }
}

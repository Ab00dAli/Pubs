namespace Pubs.Models
{
    public class AuthorTitle
    {
        public uint AuthorId { get; set; }
        public Author? Author { get; set; }
        public uint TitleId { get; set; }
        public Title? Title { get; set; }
    }
}

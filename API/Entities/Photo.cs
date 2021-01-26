namespace API.Entities
{
    public class Photo
    {

        public int Id { get; set; }
        public string Url { get; set; }
        public bool Ismain { get; set; }

        public string PublicId { get; set; }
    }
}
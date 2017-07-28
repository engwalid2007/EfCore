namespace SamuraiApp.Domains
{
    public class Quote
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SamuraiId { get; set; }
        public Samurai Samurai { get; set; }
    }
}

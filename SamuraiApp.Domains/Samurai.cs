using System;
using System.Collections.Generic;

namespace SamuraiApp.Domains
{
    public class Samurai
    {
        public Samurai()
        {
            Quotes = new List<Quote>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }    
        public List<Quote> Quotes { get; set; }
        public int ButtleId { get; set; }
    }
}

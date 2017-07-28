using System;
using System.Collections.Generic;

namespace SamuraiApp.Domains
{
    public class Buttle
    {
        public Buttle()
        {
            Samurais = new List<Samurai>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Samurai> Samurais { get; set; }
    }
}

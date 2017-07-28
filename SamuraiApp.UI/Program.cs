using SamuraiApp.Data;
using SamuraiApp.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiApp.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SamuraiDataContext conetx = new SamuraiDataContext())
            {
                conetx.Buttles.Add(new Buttle()
                {
                    Name = "New Buttle",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(7),
                    Samurais = new List<Samurai>() {
                        new Samurai(){
                            Name = "New Samurai",
                        }
                    }
                });
                conetx.SaveChanges();
            }

        }
    }
}

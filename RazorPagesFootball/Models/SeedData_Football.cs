using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace RazorPagesFootball.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesFootballContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesFootballContext>>()))
            {
                // Look for any Football club.
                if (context.Football.Any())
                {
                    return;   // DB has been seeded
                }

                context.Football.AddRange(
                    new Football
                    {
                        TeamName = "Real Madrid",
                        EstablishedDate = DateTime.Parse("1902-03-06"),
                        Country = "Spain",
                        WinningTimes = 35,
                        BestPlayer = "Karim Benzima",
                        CoachName = "Zidan"


                    },

                    new Football
                    {
                        TeamName = "Barcelona",
                        EstablishedDate = DateTime.Parse("1899-11-29"),
                        Country = "Spain",
                        WinningTimes = 0,
                        BestPlayer = "Ousman Dembele",
                        CoachName = "Xavi"
                    },

                    new Football
                    {
                        TeamName = "Paris Saint German",
                        EstablishedDate = DateTime.Parse("1970-08-12"),
                        Country = "France",
                        WinningTimes = 1,
                        BestPlayer = "Messi",
                        CoachName = "Christophe Galtier"
                    },

                    new Football
                    {
                        TeamName = "Manchester United",
                        EstablishedDate = DateTime.Parse("1894-04-16"),
                        Country = "United Kingdom",
                        WinningTimes = 5,
                        BestPlayer = "Mehrez",
                        CoachName = "Pep Guardiola"
                    },

                       new Football
                    {
                        TeamName = "Borussia Dortmund",
                        EstablishedDate = DateTime.Parse("1909-12-19"),
                        Country = "Germany",
                        WinningTimes = 6,
                        BestPlayer = "Erling Haaland",
                        CoachName = "Edin Terzić"
                    }

                    

                );
                context.SaveChanges();
            }
        }
    }
}
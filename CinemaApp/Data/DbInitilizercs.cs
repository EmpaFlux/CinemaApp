using CinemaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaApp.Data
{
    public class DbInitializer
    {
        public static void Initialize(CinemaContext context)
        {
            if (context.Screenings.Any())
            {
                return;
            }
            else
            {
                var audi1 = new Auditorium { NumberOfSeats = 50, Name = "Astute Auditorium" };
                var audi2 = new Auditorium { NumberOfSeats = 100, Name = "Plebian Parlor" };
                context.Auditoriums.AddRange(
                    audi1,
                    audi2
                    );
                context.SaveChanges();

                var movie1 = new Screening
                {
                    Title = "Excalibur",
                    Time = DateTime.Parse("2020-05-03 21:00:00"),
                    BookedTickets = 49,
                    Description = "The legend wizards, knights and monsters in Arthurian England",
                    Auditorium = audi1,
                    ImageUrl = "/images/Excalibur.jpg"
                };
                var movie2 = new Screening
                {
                    Title = "Jurassic Park",
                    Time = DateTime.Parse("2020-05-03 21:00:00"),
                    BookedTickets = 48,
                    Description = "Industrialist John Hammond has created a theme park of cloned dinosaurs, Jurassic Park, on Isla Nublar, an island off the Costa Rican coast",
                    Auditorium = audi2,
                    ImageUrl = "/images/Jurasic.jpg"
                };
                var movie3 = new Screening
                {
                    Title = "Grave of the Fireflies",
                    Time = DateTime.Parse("2020-05-03 21:00:00"),
                    BookedTickets = 22,
                    Description = "Follows the events around two children in WW2 Japan",
                    Auditorium = audi1,
                    ImageUrl = "/images/Fireflies.jpg"
                };
                
                context.Screenings.AddRange(
                    movie1,
                    movie2,
                    movie3
                    );
                context.SaveChanges();
            }
        }
    }
}
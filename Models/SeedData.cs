using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MovieApi.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider sp)
        {
            using (var context = new MovieContext(sp.GetRequiredService<DbContextOptions<MovieContext>>()))
            {
                // If database exists, don't seed
                if (context.Movie.Any())
                {
                    return;
                }

                context.Movie.AddRange(
                    new Movie{
                        Name = "The Dark Knight",
                        HaveWatched = true
                    },

                    new Movie{
                        Name = "Star Wars Episdode V - The Empire Strikes Back",
                        HaveWatched = false
                    },

                    new Movie{
                        Name = "The Usual Suspects",
                        HaveWatched = true
                    },

                    new Movie{
                        Name = "Star Trek: The Wrath of Khan",
                        HaveWatched = false
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
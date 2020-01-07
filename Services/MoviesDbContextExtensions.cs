using System.Collections.Generic;
using System.Linq;
using MoviesAPI.Entities;
namespace MoviesAPI.Services
{
     public static class MoviesDbContextExtensions
     {
          public static void CreateSeedData (this MoviesDbContext2 context)
          {
               if (context.Movies.Any())
                    return;
               var movies = new List<Movie>()
               {
                    new Movie()
                    {
                         Name = "Avengers: Endgame",
                         Year = 2019
                    },
                    new Movie()
                    {
                         Name = "Avengers: Infinity War",
                         Year = 2018
                    },
                    new Movie()
                    {
                         Name = "Black Panther",
                         Year = 2018
                    },
                    new Movie()
                    {
                         Name = "Thor: Ragnarock",
                         Year = 2017
                    }
               };
               context.AddRange(movies);
               context.SaveChanges();
          }
     }
}
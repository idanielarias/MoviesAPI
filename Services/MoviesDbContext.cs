using Microsoft.EntityFrameworkCore;
using MoviesAPI.Entities;
namespace MoviesAPI.Services
{
    public class MoviesDbContext2 : DbContext
     {
          public DbSet<Movie> Movies { get; set; }
          public MoviesDbContext2(DbContextOptions<MoviesDbContext2> options) : base(options)
          {
               Database.EnsureCreated();
          }
     }
     
}
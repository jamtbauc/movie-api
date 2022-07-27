using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using Npgsql.EntityFrameworkCore;

namespace MovieApi.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql("Host=localhost;Database=jamtbauc;Username=jamtbauc;Password=postgresql");
    }
}
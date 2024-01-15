using GharKiAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GharKiAPI.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { }
        public DbSet<NationalPark> nationalParks { get; set; }
        public DbSet<Trail> trails { get; set; }
    }
}

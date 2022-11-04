using CustomilyNetCoreApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomilyNetCoreApi.DataLayer
{
    public class CustomilyDbContext : DbContext
    {
        public CustomilyDbContext(DbContextOptions options)
            :base(options)
        {}
        public CustomilyDbContext()
        {}
        
        public DbSet<Page> Pages { get; init; }

    }
}

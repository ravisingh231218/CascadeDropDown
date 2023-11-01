using DROPDOWN.Models.Cascade;
using Microsoft.EntityFrameworkCore;

namespace DROPDOWN.Data
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }

    }
}

using CS.Domain;
using Microsoft.EntityFrameworkCore;

namespace CS.Data
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions options) 
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}

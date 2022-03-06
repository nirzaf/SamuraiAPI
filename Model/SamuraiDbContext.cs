using System.Threading;
using Microsoft.EntityFrameworkCore;

namespace SamuraiAPI.Model
{
    public class SamuraiDbContext : DbContext 
    {
        public SamuraiDbContext(DbContextOptions<SamuraiDbContext> options) : base(options)
        {

        }

        private DbSet<Samurai> Samurai { get; set; }
    }
}

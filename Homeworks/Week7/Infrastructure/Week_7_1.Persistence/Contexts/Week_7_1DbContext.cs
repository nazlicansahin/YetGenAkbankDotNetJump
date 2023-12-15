using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_7__1.Domain.Entities;

namespace Week_7_1.Persistence.Contexts
{
    public class Week_7_1DbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarPost> CarPosts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server= 91.151.83.102 ;Port= 5432 ; Database= dBNazlican;User Id= yunusemresenteam;Password= *ZM44j3bgIBULDrlsyjKB595;");
        }
    }
}
 
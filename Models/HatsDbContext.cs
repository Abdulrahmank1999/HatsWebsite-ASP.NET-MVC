using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HatSelling.Models
{
    public class HatsDbContext: DbContext
    {
        public HatsDbContext(DbContextOptions<HatsDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Buy> Buys { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Hat> Hats { get; set; }



    }
}

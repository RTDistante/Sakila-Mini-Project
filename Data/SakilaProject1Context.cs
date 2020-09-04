using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SakilaProject1.Models;

namespace SakilaProject1.Data
{
    public class SakilaProject1Context : DbContext
    {
        public SakilaProject1Context (DbContextOptions<SakilaProject1Context> options)
            : base(options)
        {
        }

        public DbSet<SakilaProject1.Models.Payment> Payment { get; set; }

        public DbSet<SakilaProject1.Models.Inventory> Inventory { get; set; }

        public DbSet<SakilaProject1.Models.Rental> Rental { get; set; }

        public DbSet<SakilaProject1.Models.Film> Film { get; set; }
    }
}

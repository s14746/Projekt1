using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Projekt1.Models
{
    public class Projekt1Context : DbContext
    {
        public Projekt1Context (DbContextOptions<Projekt1Context> options)
            : base(options)
        {
        }

        public DbSet<Projekt1.Models.Book> Book { get; set; }
    }
}

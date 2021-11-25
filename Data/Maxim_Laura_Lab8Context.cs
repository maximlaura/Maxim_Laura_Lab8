using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Maxim_Laura_Lab8.Models;

namespace Maxim_Laura_Lab8.Data
{
    public class Maxim_Laura_Lab8Context : DbContext
    {
        public Maxim_Laura_Lab8Context (DbContextOptions<Maxim_Laura_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Maxim_Laura_Lab8.Models.Book> Book { get; set; }

        public DbSet<Maxim_Laura_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Maxim_Laura_Lab8.Models.Category> Category { get; set; }
    }
}

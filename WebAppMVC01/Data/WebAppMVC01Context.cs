using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppMVC01.Models;

namespace WebAppMVC01.Data
{
    public class WebAppMVC01Context : DbContext
    {
        public WebAppMVC01Context (DbContextOptions<WebAppMVC01Context> options)
            : base(options)
        {
        }

        public DbSet<WebAppMVC01.Models.Car> Car { get; set; } = default!;
        public DbSet<Customer> Customers { get; set; }
    }
}

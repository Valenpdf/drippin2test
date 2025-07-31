using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Drippin.Models;

namespace Drippin.Data
{
    public class DrippinContext : DbContext
    {
        public DrippinContext (DbContextOptions<DrippinContext> options)
            : base(options)
        {
        }

        public DbSet<Drippin.Models.Producto> Producto { get; set; } = default!;
    }
}

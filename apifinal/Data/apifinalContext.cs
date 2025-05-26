using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using apifinal.Models;

namespace apifinal.Data
{
    public class apifinalContext : DbContext
    {
        public apifinalContext (DbContextOptions<apifinalContext> options)
            : base(options)
        {
        }

        public DbSet<apifinal.Models.Produtos> Produtos { get; set; } = default!;
    }
}

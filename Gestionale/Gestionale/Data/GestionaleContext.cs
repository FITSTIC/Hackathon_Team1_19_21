using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Gestionale.Data
{
    public class GestionaleContext : DbContext
    {
        public GestionaleContext (DbContextOptions<GestionaleContext> options)
            : base(options)
        {
        }

        public DbSet<Gestionale.Data.Corsi> Corsi { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Gestionale.Data.Control
{
    public class DipendenteDbService
    {
        public ApplicationDbContext db;

        public DipendenteDbService()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlite("Data Source=mydb.db");
            db = new ApplicationDbContext(optionsBuilder.Options);
        }

        public async Task<string> Create(Dipendente d)
        {   

            db.Dipendente.Add(d);
            await db.SaveChangesAsync();

            return "inserito";
        }
    }
}

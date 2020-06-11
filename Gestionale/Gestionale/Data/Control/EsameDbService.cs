using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Gestionale.Data.Control
{
    public class EsameDbService
    {
        public ApplicationDbContext db;
        public EsameDbService()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlite("Data Source=mydb.db");
            db = new ApplicationDbContext(optionsBuilder.Options);
        }
        public async Task Create(ApplicationDbContext db, Esame e)
        {
            db.Esami.Add(e);
            await db.SaveChangesAsync();
        }
        public async Task Read(ApplicationDbContext db, int id)
        {
            db.Esami.Find(id);
            await db.SaveChangesAsync();
        }
        public async Task Update(ApplicationDbContext db, Esame e)
        {
            db.Esami.Update(e);
            await db.SaveChangesAsync();
        }
        public async Task Delete(ApplicationDbContext db, Esame e)
        {
            db.Esami.Remove(e);
            await db.SaveChangesAsync();
        }
    }

   
}

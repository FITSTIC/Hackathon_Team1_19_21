using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Gestionale.Data.Control
{
    public class PunteggioDbService
    {
        public ApplicationDbContext db;
        public PunteggioDbService()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlite("Data Source=mydb.db");
            db = new ApplicationDbContext(optionsBuilder.Options);
        }
        public async Task Create(ApplicationDbContext db, Punteggio p)
        {
            db.Punteggi.Add(p);
            await db.SaveChangesAsync();
        }
        public async Task Read(ApplicationDbContext db, int id)
        {
            db.Punteggi.Find(id);
            await db.SaveChangesAsync();
        }
        public async Task Update(ApplicationDbContext db, Punteggio p)
        {
            db.Punteggi.Update(p);
            await db.SaveChangesAsync();
        }
        public async Task Delete(ApplicationDbContext db, Punteggio p)
        {
            db.Punteggi.Remove(p);
            await db.SaveChangesAsync();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Gestionale.Data.Control
{
    public class PartecipanteDbService
    {
        public ApplicationDbContext db;
        public PartecipanteDbService()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlite("Data Source=mydb.db");
            db = new ApplicationDbContext(optionsBuilder.Options);
        }
        public async Task Create(ApplicationDbContext db, Partecipante p)
        {
            db.Partecipanti.Add(p);
            await db.SaveChangesAsync();
        }
        public async Task<Partecipante> Read(ApplicationDbContext db, int id)
        {
            return db.Partecipanti.Find(id);
        }
        public async Task Update(ApplicationDbContext db, Partecipante p)
        {
            db.Partecipanti.Update(p);
            await db.SaveChangesAsync();
        }
        public async Task Delete(ApplicationDbContext db, Partecipante p)
        {
            db.Partecipanti.Remove(p);
            await db.SaveChangesAsync();
        }
    }
}

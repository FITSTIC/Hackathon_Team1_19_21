using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Gestionale.Data.Control
{
    public class CorsoDbService
    {
        public ApplicationDbContext db;

        public CorsoDbService()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlite("Data Source=mydb.db");
            db = new ApplicationDbContext(optionsBuilder.Options);
        }

        public async Task Create(ApplicationDbContext db, Corso c)
        {
            db.Corsi.Add(c);
            await db.SaveChangesAsync();
        }
        public async Task Read(ApplicationDbContext db, int id)
        {
            db.Corsi.Find(id);
            await db.SaveChangesAsync();
        }
        public async Task Read(ApplicationDbContext db, string nome)
        {
            db.Corsi.First(x => x.Nome == nome);
            await db.SaveChangesAsync();
        }
        public async Task Update(ApplicationDbContext db, Corso c)
        {
            db.Corsi.Update(c);
            await db.SaveChangesAsync();
        }
        public async Task Delete(ApplicationDbContext db, Corso c)
        {
            db.Corsi.Remove(c);
            await db.SaveChangesAsync();
        }
    }
}

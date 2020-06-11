using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Gestionale.Data.Control
{
    public class IscrizioneDbService
    {
        
        public ApplicationDbContext db;
        public IscrizioneDbService()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlite("Data Source=mydb.db");
            db = new ApplicationDbContext(optionsBuilder.Options);
        }
        public async Task Create(ApplicationDbContext db, Iscrizione i)
        {
            db.Iscrizioni.Add(i);
            await db.SaveChangesAsync();
        }
        public async Task Read(ApplicationDbContext db, int id)
        {
            db.Iscrizioni.Find(id);
            await db.SaveChangesAsync();
        }
        public async Task Update(ApplicationDbContext db, Iscrizione i)
        {
            db.Iscrizioni.Update(i);
            await db.SaveChangesAsync();
        }
        public async Task Delete(ApplicationDbContext db, Iscrizione i)
        {
            db.Iscrizioni.Remove(i);
            await db.SaveChangesAsync();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public async Task<Corso> Read(ApplicationDbContext db, int? id)
        {
            var s = await db.Corsi
           .Include(c => c.Moduli)
           .Where(c => c.Id == id).FirstOrDefaultAsync();
           return s;


        }
        public async Task<Corso>Read(ApplicationDbContext db, string nome)
        {
            var s = await db.Corsi
                .Include(c => c.Moduli)
                .Where(c => c.Nome == nome).FirstOrDefaultAsync();
            return s; 
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

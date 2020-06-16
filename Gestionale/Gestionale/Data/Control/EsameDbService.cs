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
        public async Task<Esame> Read(ApplicationDbContext db, int id)
        {
            var s = await db.Esami
                .Include(d => d.Punteggi)
                .Where(d => d.Id == id)
                .FirstOrDefaultAsync();
            return s;
        }
        public async Task<List<Esame>> Read(ApplicationDbContext db, Modulo m)
        {
            var s = new List<Esame>();
            s = await db.Esami
            .Include(d => d.Punteggi)
            .Where(d => d.ModuliId == m.Id).ToListAsync();
            return s;
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

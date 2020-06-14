using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Gestionale.Data.Control
{
    public class ModuloDbService
    {
        public ApplicationDbContext db;

        public ModuloDbService()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlite("Data Source=mydb.db");
            db = new ApplicationDbContext(optionsBuilder.Options);
        }

        public async Task Create(ApplicationDbContext db, Modulo m)
        {
            db.Moduli.Add(m);
            await db.SaveChangesAsync();
        }
        
        public async Task<Modulo> Read(ApplicationDbContext db, int id)
        {
            return db.Moduli.Find(id);
        }
        public async Task Read(ApplicationDbContext db, string materia)
        {
            db.Moduli.First(x => x.Materia == materia);
            await db.SaveChangesAsync();
        }
        public async Task Update(ApplicationDbContext db, Modulo m)
        {
                db.Moduli.Update(m);
                await db.SaveChangesAsync();
        }
        public async Task Delete(ApplicationDbContext db, Modulo m)
        {
            db.Moduli.Remove(m);
            await db.SaveChangesAsync();
        }

    }
}

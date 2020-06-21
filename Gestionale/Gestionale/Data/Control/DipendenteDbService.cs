﻿using System;
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
        public async Task Create(ApplicationDbContext db, Insegnante d)
        {

            db.Insegnanti.Add(d);
            await db.SaveChangesAsync();
        }
        public async Task Create(ApplicationDbContext db, Tutor d)
        {
            db.Tutor.Add(d);
            await db.SaveChangesAsync();
        }
        public async Task Create(ApplicationDbContext db, Coordinatore d)
        {
            db.Coordinatori.Add(d);
            await db.SaveChangesAsync();
        }
        public async Task<Dipendente> Read(ApplicationDbContext db, int? id)
        {
            var s = await db.Dipendente
                .Include(d => d.Moduli)
                .Where(d => d.Id == id)
                .FirstOrDefaultAsync();
            return s;
        }
        public async Task<Dipendente> Read(ApplicationDbContext db, string nome)
        {
            var s = await db.Dipendente
               .Include(d => d.Moduli)
               .Where(d => d.Nome == nome).FirstOrDefaultAsync();
            return s;
        }
       
        public async Task Update(ApplicationDbContext db, Dipendente d)
        {
            db.Dipendente.Update(d);
            await db.SaveChangesAsync();
        }
        public async Task Delete(ApplicationDbContext db, Dipendente d )
        {
            db.Dipendente.Remove(d);
            await db.SaveChangesAsync();
        }
    }
}

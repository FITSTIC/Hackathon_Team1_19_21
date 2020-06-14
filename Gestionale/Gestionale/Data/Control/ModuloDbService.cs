﻿using System;
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
        public async Task<Modulo> Read(ApplicationDbContext db, string materia)
        {
           return db.Moduli.First(x => x.Materia == materia);
        }
        public async Task<List<Modulo>> Read(ApplicationDbContext db, Dipendente dip)
        {
            var s = new List<Modulo>();
            if (dip.Categoria == "Tutor")
            {
                s = db.Moduli
               .Include(i => i.Tutor)
               .Where(m => m.TutorId == dip.Id).ToList();
                return s;
            }
            else if (dip.Categoria == "Insegnante")
            {
                s =  db.Moduli
               .Include(i => i.Insegnanti)
               .Where(m => m.InsegnanteId == dip.Id).ToList();
                return s;
            }
            return s;

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

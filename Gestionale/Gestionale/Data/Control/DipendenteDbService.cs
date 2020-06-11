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

        public async Task Create(ApplicationDbContext db, Dipendente d)
        {

            db.Dipendente.Add(d);
            await db.SaveChangesAsync();
        }
        public async Task Create(ApplicationDbContext db, Insegnante d)
        {

            db.Dipendente.Add(d);
            await db.SaveChangesAsync();
        }
        public async Task Create(ApplicationDbContext db, Tutor d)
        {

            db.Dipendente.Add(d);
            await db.SaveChangesAsync();
        }
        public async Task Read(ApplicationDbContext db, int id)
        {
            db.Dipendente.Find(id);
            await db.SaveChangesAsync();
        }
        public async Task Read(ApplicationDbContext db, string nome)
        {
            db.Dipendente.First(x => x.Nome == nome);
            await db.SaveChangesAsync();
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

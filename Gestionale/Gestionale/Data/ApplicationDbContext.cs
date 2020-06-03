using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Gestionale.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Personale> Personale { get; set; }
        public DbSet<Partecipanti> Partecipanti { get; set; }
        public DbSet<Corsi> Corsi { get; set; }
        public DbSet<Moduli> Moduli { get; set; }
        public DbSet<Esami> Esami { get; set; }
        public DbSet<Iscrizioni> Iscrizioni { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Corsi>().HasData(
                new Corsi
                {
                    Id = 1,
                    Nome = "Turing",
                    AnnoAccademico = "21/23",
                    AnnoInizioCorso = DateTime.Parse("01/01/2021"),
                    AnnoFineCorso = DateTime.Parse("01/01/2023"),
                    Sede = "Bologna"
                });

                builder.Entity<Moduli>().HasData(
                new Moduli
                {
                    Id = 1,
                    Materia = "Programmazione OOP",
                    DataInizio= DateTime.Parse("02/01/2021"),
                    DataFine = DateTime.Parse("02/02/2021"),
                });
        }



        }
}

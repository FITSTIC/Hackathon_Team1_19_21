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
                    Nome = "Alan Turing",
                    AnnoAccademico = "21/23",
                    AnnoInizioCorso = DateTime.Parse("01/01/2021"),
                    AnnoFineCorso = DateTime.Parse("01/01/2023"),
                    Sede = "Cesena",
                },
                new Corsi
                {
                    Id = 2,
                    Nome = "Marshall McLuhan",
                    AnnoAccademico = "21/23",
                    AnnoInizioCorso = DateTime.Parse("01/01/2021"),
                    AnnoFineCorso = DateTime.Parse("01/01/2023"),
                    Sede = "Bologna",
                },
                new Corsi
                {
                    Id = 3,
                    Nome = "Grace Hopper",
                    AnnoAccademico = "21/23",
                    AnnoInizioCorso = DateTime.Parse("01/01/2021"),
                    AnnoFineCorso = DateTime.Parse("01/01/2023"),
                    Sede = "Modena"
                },
                new Corsi
                {
                    Id = 4,
                    Nome = "Product Manager Fashion",
                    AnnoAccademico = "21/23",
                    AnnoInizioCorso = DateTime.Parse("01/01/2021"),
                    AnnoFineCorso = DateTime.Parse("01/01/2023"),
                    Sede = "Carpi"
                },
                new Corsi
                {
                    Id = 5,
                    Nome = "Expert Mixed Reality",
                    AnnoAccademico = "21/23",
                    AnnoInizioCorso = DateTime.Parse("01/01/2021"),
                    AnnoFineCorso = DateTime.Parse("01/01/2023"),
                    Sede = "Casalecchio"
                }
                );
                
                builder.Entity<Moduli>().HasData(
                new Moduli
                {
                    Id = 1,
                    CorsiId = 1,                 
                    DataFine = DateTime.Parse("02/02/2021"),
                    DataInizio = DateTime.Parse("02/01/2021"),
                    Materia = "Programmazione OOP",
                    PersonaleId = null,

                });
        }



        }
}

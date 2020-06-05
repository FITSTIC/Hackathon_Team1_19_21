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
                });
            builder.Entity<Iscrizioni>().HasData(
               new Iscrizioni
               {
                   Id = 1,
                   DataIscrizione = DateTime.Parse(DateTime.Now.ToString()),
                   CorsiId = 4,

               },
               new Iscrizioni
               {
                   Id = 2,
                   DataIscrizione = DateTime.Parse(DateTime.Now.ToString()),
                   CorsiId = 5,

               },
               new Iscrizioni
               {
                   Id = 3,
                   DataIscrizione = DateTime.Parse(DateTime.Now.ToString()),
                   CorsiId = 1,

               },
               new Iscrizioni
               {
                   Id = 4,
                   DataIscrizione = DateTime.Parse(DateTime.Now.ToString()),
                   CorsiId = 3,

               },
               new Iscrizioni
               {
                   Id = 5,
                   DataIscrizione = DateTime.Parse(DateTime.Now.ToString()),
                   CorsiId = 2,

               });
            builder.Entity<Partecipanti>().HasData(
                 new Partecipanti
                 {
                     Id = 1,
                     Nome = "Marco",
                     Cognome = "Polo",
                     DataNascita = DateTime.Parse("05/09/1990"),
                     Email = "MarcoPolo@gmail.com",
                     Indirizzo = "Via Polo 29°",
                     Citta = "Cesena",
                     Telefono = "3338614937",
                     Diploma = "Tecnico",
                     AnnoDiploma = DateTime.Parse("17/06/2010"),
                     IscrizioniId = 3,
                     CorsiId = 1,   
                 },
                 new Partecipanti
                 {
                     Id = 2,
                     Nome = "Giorgia",
                     Cognome = "Venere",
                     DataNascita = DateTime.Parse("15/02/1995"),
                     Email = "GiorgiaVenere@gmail.com",
                     Indirizzo = "Via Venere 219°",
                     Citta = "Bologna",
                     Telefono = "3338895937",
                     Diploma = "Sociale",
                     AnnoDiploma = DateTime.Parse("17/06/2016"),
                     IscrizioniId = 5,
                     CorsiId = 2,
                 },
                 new Partecipanti
                 {
                     Id = 3,
                     Nome = "Luigi",
                     Cognome = "Deandrè",
                     DataNascita = DateTime.Parse("02/08/2000"),
                     Email = "LuigiDeandè@gmail.com",
                     Indirizzo = "Via Deandè 5°",
                     Citta = "Rimini",
                     Telefono = "3338678437",
                     Diploma = "Tecnico",
                     AnnoDiploma = DateTime.Parse("17/06/2019"),
                     IscrizioniId = 4,
                     CorsiId = 3,
                 },
                 new Partecipanti
                 {
                     Id = 4,
                     Nome = "Marta",
                     Cognome = "Pane",
                     DataNascita = DateTime.Parse("02/08/1999"),
                     Email = "MartaPane@gmail.com",
                     Indirizzo = "Via Pane 15°",
                     Citta = "Forlì",
                     Telefono = "3458684937",
                     Diploma = "Tecnico",
                     AnnoDiploma = DateTime.Parse("17/06/2018"),
                     IscrizioniId = 1,
                     CorsiId = 4,
                 },
                 new Partecipanti
                 {
                     Id = 5,
                     Nome = "Giorgia",
                     Cognome = "Telo",
                     DataNascita = DateTime.Parse("02/08/1998"),
                     Email = "GiorgiaTelo@gmail.com",
                     Indirizzo = "Via Telo 78°",
                     Citta = "Faenza",
                     Telefono = "3338614937",
                     Diploma = "Tecnico",
                     AnnoDiploma = DateTime.Parse("17/06/2017"),
                     IscrizioniId = 2,
                     CorsiId = 5,
                 });
 
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

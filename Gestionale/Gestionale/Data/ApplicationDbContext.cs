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
            builder.Entity<Personale>().HasData(
                 new Personale
                 {
                     Id = 1,
                     Nome = "Matteo",
                     Cognome = "Frasulli",
                     DataNascita = DateTime.Parse("05/09/1989"),
                     Email = "MatteoFrasulli@gmail.com",
                     Telefono = "3458614787",
                     Assunzione = DateTime.Parse(DateTime.Now.ToString()),
                     Categorie = Data.Personale.Professioni.Coordinatore,
                     CorsiId = 1,
                 },
                 new Personale
                 {
                     Id = 2,
                     Nome = "Paola",
                     Cognome = "Grud",
                     DataNascita = DateTime.Parse("05/09/1988"),
                     Email = "PaolaGrud@gmail.com",
                     Telefono = "3458775787",
                     Assunzione = DateTime.Parse(DateTime.Now.ToString()),
                     Categorie = Data.Personale.Professioni.Coordinatore,
                     CorsiId = 2,
                 },
                 new Personale
                 {
                     Id = 3,
                     Nome = "Giorgia",
                     Cognome = "Stella",
                     DataNascita = DateTime.Parse("05/09/1987"),
                     Email = "GiorgiaStella@gmail.com",
                     Telefono = "3458618787",
                     Assunzione = DateTime.Parse(DateTime.Now.ToString()),
                     Categorie = Data.Personale.Professioni.Coordinatore,
                     CorsiId = 3,
                 },
                 new Personale
                 {
                     Id = 4,
                     Nome = "Dario",
                     Cognome = "Dadi",
                     DataNascita = DateTime.Parse("05/09/1989"),
                     Email = "DarioDadi@gmail.com",
                     Telefono = "3457914787",
                     Assunzione = DateTime.Parse(DateTime.Now.ToString()),
                     Categorie = Data.Personale.Professioni.Coordinatore,
                     CorsiId = 4,
                 },
                 new Personale
                 {
                     Id = 5,
                     Nome = "Mattia",
                     Cognome = "Raro",
                     DataNascita = DateTime.Parse("05/09/1980"),
                     Email = "MattiaRaro@gmail.com",
                     Telefono = "3458614787",
                     Assunzione = DateTime.Parse(DateTime.Now.ToString()),
                     Categorie = Data.Personale.Professioni.Coordinatore,
                     CorsiId = 5,
                 },
                 new Personale
                 {
                     Id = 6,
                     Nome = "Mauro",
                     Cognome = "Giuseppa",
                     DataNascita = DateTime.Parse("05/09/1989"),
                     Email = "MauroGiuseppa@gmail.com",
                     Telefono = "3228614787",
                     Assunzione = DateTime.Parse(DateTime.Now.ToString()),
                     Categorie = Data.Personale.Professioni.Tutor,
                     CorsiId = 1,
                 }, new Personale
                 {
                     Id = 7,
                     Nome = "Giulia",
                     Cognome = "Frafra",
                     DataNascita = DateTime.Parse("05/09/1989"),
                     Email = "GiuliaFrafra@gmail.com",
                     Telefono = "3248614787",
                     Assunzione = DateTime.Parse(DateTime.Now.ToString()),
                     Categorie = Data.Personale.Professioni.Tutor,
                     CorsiId = 2
                 },
                 new Personale
                 {
                     Id = 8,
                     Nome = "Carmine",
                     Cognome = "Del Mio",
                     DataNascita = DateTime.Parse("05/09/1989"),
                     Email = "CarmineDelMio@gmail.com",
                     Telefono = "3278614787",
                     Assunzione = DateTime.Parse(DateTime.Now.ToString()),
                     Categorie = Data.Personale.Professioni.Tutor,
                     CorsiId = 3,
                 },
                 new Personale
                 {
                     Id = 9,
                     Nome = "Francesca",
                     Cognome = "Del Capo",
                     DataNascita = DateTime.Parse("05/09/1989"),
                     Email = "FrancescaDelCapo@gmail.com",
                     Telefono = "3298614787",
                     Assunzione = DateTime.Parse(DateTime.Now.ToString()),
                     Categorie = Data.Personale.Professioni.Tutor,
                     CorsiId = 4,
                 },
                 new Personale
                 {
                     Id = 10,
                     Nome = "Alessandro",
                     Cognome = "Ortè",
                     DataNascita = DateTime.Parse("05/09/1989"),
                     Email = "AlessandroOrtè@gmail.com",
                     Telefono = "3258614787",
                     Assunzione = DateTime.Parse(DateTime.Now.ToString()),
                     Categorie = Data.Personale.Professioni.Tutor,
                     CorsiId = 5,
                 },
                 new Personale
                 {
                     Id = 11,
                     Nome = "Rosalia",
                     Cognome = "Telepatia",
                     DataNascita = DateTime.Parse("05/09/1979"),
                     Email = "RosaliaTelepatia@gmail.com",
                     Telefono = "3278614787",
                     Assunzione = DateTime.Parse(DateTime.Now.ToString()),
                     Categorie = Data.Personale.Professioni.Insegnante,
                     CorsiId = 1,
                 },
                 new Personale
                 {
                     Id = 12,
                     Nome = "Alessandro",
                     Cognome = "De'Martino",
                     DataNascita = DateTime.Parse("05/09/1978"),
                     Email = "AlessandroDeMartino@gmail.com",
                     Telefono = "3258174787",
                     Assunzione = DateTime.Parse(DateTime.Now.ToString()),
                     Categorie = Data.Personale.Professioni.Insegnante,
                     CorsiId = 2,
                 },
                 new Personale
                 {
                     Id = 13,
                     Nome = "Sara",
                     Cognome = "Martin",
                     DataNascita = DateTime.Parse("05/09/1990"),
                     Email = "SaraMartin@gmail.com",
                     Telefono = "3258614977",
                     Assunzione = DateTime.Parse(DateTime.Now.ToString()),
                     Categorie = Data.Personale.Professioni.Insegnante,
                     CorsiId = 3,
                 },
                 new Personale
                 {
                     Id = 14,
                     Nome = "Marco",
                     Cognome = "Terra",
                     DataNascita = DateTime.Parse("05/09/1988"),
                     Email = "MarcoTerra@gmail.com",
                     Telefono = "3258610787",
                     Assunzione = DateTime.Parse(DateTime.Now.ToString()),
                     Categorie = Data.Personale.Professioni.Insegnante,
                     CorsiId = 4,
                 },
                 new Personale
                 {
                     Id = 15,
                     Nome = "Francesca",
                     Cognome = "Rosa",
                     DataNascita = DateTime.Parse("05/09/1987"),
                     Email = "FrancescaRosa@gmail.com",
                     Telefono = "3258414787",
                     Assunzione = DateTime.Parse(DateTime.Now.ToString()),
                     Categorie = Data.Personale.Professioni.Insegnante,
                     CorsiId = 5,
                 });

             builder.Entity<Moduli>().HasData(
                new Moduli
                {
                    Id = 1,
                    CorsiId = 1,                 
                    DataFine = DateTime.Parse("02/03/2021"),
                    DataInizio = DateTime.Parse("02/01/2021"),
                    Materia = "Programmazione OOP",
                    PersonaleId = 11,
                },
                new Moduli
                {
                    Id = 2,
                    CorsiId = 2,
                    DataFine = DateTime.Parse("02/10/2021"),
                    DataInizio = DateTime.Parse("02/01/2021"),
                    Materia = "C#",
                    PersonaleId = 1,
                },
                new Moduli
                {
                    Id = 3,
                    CorsiId = 3,
                    DataFine = DateTime.Parse("02/09/2021"),
                    DataInizio = DateTime.Parse("02/01/2021"),
                    Materia = "Inglese",
                    PersonaleId = 5,
                },
                new Moduli
                {
                    Id = 4,
                    CorsiId = 4,
                    DataFine = DateTime.Parse("02/05/2021"),
                    DataInizio = DateTime.Parse("02/01/2021"),
                    Materia = "Lavorare in team",
                    PersonaleId = 12,
                },
                new Moduli
                {
                    Id = 5,
                    CorsiId = 5,
                    DataFine = DateTime.Parse("02/11/2021"),
                    DataInizio = DateTime.Parse("02/01/2021"),
                    Materia = "Relazione con il Cliente",
                    PersonaleId = 15,
                });
            
        }



    }
}

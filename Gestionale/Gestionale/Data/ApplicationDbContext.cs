using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Gestionale.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Dipendente> Dipendente { get; set; }
        public DbSet<Coordinatore> Coordinatori { get; set; }
        public DbSet<Insegnante> Insegnanti { get; set; }
        public DbSet<Tutor> Tutor { get; set; }
        public DbSet<Partecipante> Partecipanti { get; set; }
        public DbSet<Corso> Corsi { get; set; }
        public DbSet<Modulo> Moduli { get; set; }
        public DbSet<Esame> Esami { get; set; }
        public DbSet<Iscrizione> Iscrizioni { get; set; }
        public DbSet<Punteggio> Punteggi { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            base.OnModelCreating(builder);
            builder.Entity<Corso>().HasData(
            new Corso
            {
                Id = 1,
                Nome = "Alan Turing",
                AnnoAccademico = "21/23",
                AnnoInizioCorso = new DateTime(2021, 01, 01),
                AnnoFineCorso = new DateTime(2023, 01, 01),
                Sede = "Cesena",
            },
            new Corso
            {
                Id = 2,
                Nome = "Marshall McLuhan",
                AnnoAccademico = "21/23",
                AnnoInizioCorso = new DateTime(2021, 01, 01),
                AnnoFineCorso = new DateTime(2023, 01, 01),
                Sede = "Bologna",
            },
            new Corso
            {
                Id = 3,
                Nome = "Grace Hopper",
                AnnoAccademico = "21/23",
                AnnoInizioCorso = new DateTime(2021, 01, 01),
                AnnoFineCorso = new DateTime(2023, 01, 01),
                Sede = "Modena",
            },
            new Corso
            {
                Id = 4,
                Nome = "Product Manager Fashion",
                AnnoAccademico = "21/23",
                AnnoInizioCorso = new DateTime(2021, 01, 01),
                AnnoFineCorso = new DateTime(2023, 01, 01),
                Sede = "Carpi",
            },
            new Corso
            {
                Id = 5,
                Nome = "Expert Mixed Reality",
                AnnoAccademico = "21/23",
                AnnoInizioCorso = new DateTime(2021, 01, 01),
                AnnoFineCorso = new DateTime(2023, 01, 01),
                Sede = "Casalecchio",
            });

            builder.Entity<Iscrizione>().HasData(
            new Iscrizione
            {
                Id = 1,
                DataIscrizione = DateTime.Parse(DateTime.Now.ToString()),
                CorsiId = 1,

            },
            new Iscrizione
            {
                Id = 2,
                DataIscrizione = DateTime.Parse(DateTime.Now.ToString()),
                CorsiId = 2,

            },
            new Iscrizione
            {
                Id = 3,
                DataIscrizione = DateTime.Parse(DateTime.Now.ToString()),
                CorsiId = 3,


            },
            new Iscrizione
            {
                Id = 4,
                DataIscrizione = DateTime.Parse(DateTime.Now.ToString()),
                CorsiId = 4,

            },
            new Iscrizione
            {
                Id = 5,
                DataIscrizione = DateTime.Parse(DateTime.Now.ToString()),
                CorsiId = 5,

            });
            
            builder.Entity<Partecipante>().HasData(
            new Partecipante
            {
                Id = 1,
                Nome = "Marco",
                Cognome = "Polo",
                DataNascita = new DateTime(2010, 06, 17),
                Email = "MarcoPolo@gmail.com",
                Indirizzo = "Via Polo 29°",
                Citta = "Cesena",
                Telefono = "3338614937",
                Diploma = "Tecnico",
                AnnoDiploma = new DateTime(2010, 06, 17),
                CorsiId = 1,
                IscrizioneId = 1 

                
            },
            new Partecipante
            {
                Id = 2,
                Nome = "Giorgia",
                Cognome = "Venere",
                DataNascita = new DateTime(1995, 02, 15),
                Email = "GiorgiaVenere@gmail.com",
                Indirizzo = "Via Venere 219°",
                Citta = "Bologna",
                Telefono = "3338895937",
                Diploma = "Sociale",
                AnnoDiploma = new DateTime(2016, 06, 17),
                CorsiId = 2,
                IscrizioneId = 2
            },
            new Partecipante
            {
                Id = 3,
                Nome = "Luigi",
                Cognome = "Deandrè",
                DataNascita = new DateTime(2000, 08, 02),
                Email = "LuigiDeandè@gmail.com",
                Indirizzo = "Via Deandè 5°",
                Citta = "Rimini",
                Telefono = "3338678437",
                Diploma = "Tecnico",
                AnnoDiploma = new DateTime(2019, 06, 17),
                CorsiId = 3,
                IscrizioneId = 3
            },
            new Partecipante
            {
                Id = 4,
                Nome = "Marta",
                Cognome = "Pane",
                DataNascita = new DateTime(1999, 08, 02),
                Email = "MartaPane@gmail.com",
                Indirizzo = "Via Pane 15°",
                Citta = "Forlì",
                Telefono = "3458684937",
                Diploma = "Tecnico",
                AnnoDiploma = new DateTime(2018, 06, 17),
                CorsiId = 4,
                IscrizioneId = 4
            },
            new Partecipante
            {
                Id = 5,
                Nome = "Giorgia",
                Cognome = "Telo",
                DataNascita = new DateTime(1998, 08, 02),
                Email = "GiorgiaTelo@gmail.com",
                Indirizzo = "Via Telo 78°",
                Citta = "Faenza",
                Telefono = "3338614937",
                Diploma = "Tecnico",
                AnnoDiploma = new DateTime(2017, 06, 17),
                CorsiId = 5,
                IscrizioneId = 5
            });

            builder.Entity<Coordinatore>().HasData(
            new Coordinatore
            {
                Id = 1,
                Nome = "Matteo",
                Cognome = "Frasulli",
                DataNascita = new DateTime(1989, 09, 05),
                Email = "MatteoFrasulli@gmail.com",
                Telefono = "3458614787",
                Assunzione = DateTime.Parse(DateTime.Now.ToString()),
                Categoria = "Coordinatore",
                CorsiId = 1,
            },
            new Coordinatore
            {
                Id = 2,
                Nome = "Paola",
                Cognome = "Grud",
                DataNascita = new DateTime(1988, 09, 05),
                Email = "PaolaGrud@gmail.com",
                Telefono = "3458775787",
                Assunzione = DateTime.Parse(DateTime.Now.ToString()),
                Categoria = "Coordinatore",
                CorsiId = 2,
            },
            new Coordinatore
            {
                Id = 3,
                Nome = "Giorgia",
                Cognome = "Stella",
                DataNascita = new DateTime(1987, 09, 05),
                Email = "GiorgiaStella@gmail.com",
                Telefono = "3458618787",
                Assunzione = DateTime.Parse(DateTime.Now.ToString()),
                Categoria = "Coordinatore",
                CorsiId = 3,
            },
            new Coordinatore
            {
                Id = 4,
                Nome = "Dario",
                Cognome = "Dadi",
                DataNascita = new DateTime(1989, 09, 05),
                Email = "DarioDadi@gmail.com",
                Telefono = "3457914787",
                Assunzione = DateTime.Parse(DateTime.Now.ToString()),
                Categoria = "Coordinatore",
                CorsiId = 4,
            },
            new Coordinatore
            {
                Id = 5,
                Nome = "Mattia",
                Cognome = "Raro",
                DataNascita = new DateTime(1990, 09, 05),
                Email = "MattiaRaro@gmail.com",
                Telefono = "3458614787",
                Assunzione = DateTime.Parse(DateTime.Now.ToString()),
                Categoria = "Coordinatore",
                CorsiId = 5,
            });
            builder.Entity<Tutor>().HasData(
            new Tutor
            {
                Id = 6,
                Nome = "Mauro",
                Cognome = "Giuseppa",
                DataNascita = new DateTime(1989, 09, 05),
                Email = "MauroGiuseppa@gmail.com",
                Telefono = "3228614787",
                Assunzione = DateTime.Parse(DateTime.Now.ToString()),
                Categoria = "Tutor",
                CorsiId = 1,
            },
            new Tutor
            {
                Id = 7,
                Nome = "Giulia",
                Cognome = "Frafra",
                DataNascita = new DateTime(1989, 09, 05),
                Email = "GiuliaFrafra@gmail.com",
                Telefono = "3248614787",
                Assunzione = DateTime.Parse(DateTime.Now.ToString()),
                Categoria = "Tutor",
                CorsiId = 2
            },
            new Tutor
            {
                Id = 8,
                Nome = "Carmine",
                Cognome = "Del Mio",
                DataNascita = new DateTime(1989, 09, 05),
                Email = "CarmineDelMio@gmail.com",
                Telefono = "3278614787",
                Assunzione = DateTime.Parse(DateTime.Now.ToString()),
                Categoria = "Tutor",
                CorsiId = 3,
            },
            new Tutor
            {
                Id = 9,
                Nome = "Francesca",
                Cognome = "Del Capo",
                DataNascita = new DateTime(1989, 09, 05),
                Email = "FrancescaDelCapo@gmail.com",
                Telefono = "3298614787",
                Assunzione = DateTime.Parse(DateTime.Now.ToString()),
                Categoria = "Tutor",
                CorsiId = 4,
            },
            new Tutor
            {
                Id = 10,
                Nome = "Alessandro",
                Cognome = "Ortè",
                DataNascita = new DateTime(1989, 09, 05),
                Email = "AlessandroOrtè@gmail.com",
                Telefono = "3258614787",
                Assunzione = DateTime.Parse(DateTime.Now.ToString()),
                Categoria = "Tutor",
                CorsiId = 5,
            });
            builder.Entity<Insegnante>().HasData(
            new Insegnante
            {
                Id = 11,
                Nome = "Rosalia",
                Cognome = "Telepatia",
                DataNascita = new DateTime(1979, 09, 05),
                Email = "RosaliaTelepatia@gmail.com",
                Telefono = "3278614787",
                Assunzione = DateTime.Parse(DateTime.Now.ToString()),
                Categoria = "Insegnante",
                CorsiId = 1,
            },
            new Insegnante
            {
                Id = 12,
                Nome = "Alessandro",
                Cognome = "De'Martino",
                DataNascita = new DateTime(1979, 09, 05),
                Email = "AlessandroDeMartino@gmail.com",
                Telefono = "3258174787",
                Assunzione = DateTime.Parse(DateTime.Now.ToString()),
                Categoria = "Insegnante",
                CorsiId = 2,
            },
            new Insegnante
            {
                Id = 13,
                Nome = "Sara",
                Cognome = "Martin",
                DataNascita = new DateTime(1990, 09, 05),
                Email = "SaraMartin@gmail.com",
                Telefono = "3258614977",
                Assunzione = DateTime.Parse(DateTime.Now.ToString()),
                Categoria = "Insegnante",
                CorsiId = 3,
            },
            new Insegnante
            {
                Id = 14,
                Nome = "Marco",
                Cognome = "Terra",
                DataNascita = new DateTime(1988, 09, 05),
                Email = "MarcoTerra@gmail.com",
                Telefono = "3258610787",
                Assunzione = DateTime.Parse(DateTime.Now.ToString()),
                Categoria = "Insegnante",
                CorsiId = 4,
            },
            new Insegnante
            {
                Id = 15,
                Nome = "Francesca",
                Cognome = "Rosa",
                DataNascita = new DateTime(1987, 09, 05),
                Email = "FrancescaRosa@gmail.com",
                Telefono = "3258414787",
                Assunzione = DateTime.Parse(DateTime.Now.ToString()),
                Categoria = "Insegnante",
                CorsiId = 5,
            });

        builder.Entity<Modulo>().HasData(
            new Modulo
            {
                Id = 1,
                CorsiId = 1,
                DataFine = new DateTime(2021, 03, 02),
                DataInizio = new DateTime(2021, 01, 02),
                Materia = "Programmazione OOP",
                InsegnanteId = 15,
                TutorId = 9
            },
            new Modulo
            {
                Id = 2,
                CorsiId = 2,
                DataFine = new DateTime(2021, 10, 02),
                DataInizio = new DateTime(2021, 01, 02),
                Materia = "C#",
                InsegnanteId = 11,
                TutorId = 10

            },
            new Modulo
            {
                Id = 3,
                CorsiId = 3,
                DataFine = new DateTime(2021, 09, 02),
                DataInizio = new DateTime(2021, 01, 02),
                Materia = "Inglese",
                InsegnanteId = 12,
                TutorId = 8
            },
            new Modulo
            {
                Id = 4,
                CorsiId = 4,
                DataFine = new DateTime(2021, 05, 02),
                DataInizio = new DateTime(2021, 01, 02),
                Materia = "Lavorare in team",
                InsegnanteId = 13,
                TutorId = 7
            },
            new Modulo
            {
                Id = 5,
                CorsiId = 5,
                DataFine = new DateTime(2021, 02, 11),
                DataInizio = new DateTime(2021, 01, 02),
                Materia = "Relazione con il Cliente",
                InsegnanteId = 14,
                TutorId = 6
            });
        builder.Entity<Esame>().HasData(
            new Esame
            {
                Id = 1,
                ModuliId = 5,
                DataEsame = new DateTime(2021, 02, 11),
                Punteggio = null,
            },
            new Esame
            {
                Id = 2,
                ModuliId = 4,
                DataEsame = new DateTime(2021, 05, 02),
                Punteggio = null,
            },
            new Esame
            {
                Id = 3,
                ModuliId = 3,
                DataEsame = new DateTime(2021, 09, 02),
                Punteggio = null,
            },
            new Esame
            {
                Id = 4,
                ModuliId = 2,
                DataEsame = new DateTime(2021, 10, 02),
                Punteggio = null,
            },
            new Esame
            {
                Id = 5,
                ModuliId = 1,
                DataEsame = new DateTime(2021, 03, 02),
                Punteggio = null,
            });
        }
    }
}

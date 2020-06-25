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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gestionale.Data
{
    public class Partecipanti
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cognome { get; set; }
        [Required]
        public DateTime DataNascita { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Indirizzo { get; set; }
        [Required]
        public string Citta { get; set; }
        [Required]
        public string Telefono { get; set; }
        public string Diploma { get; set; }
        public DateTime AnnoDiploma { get; set; }
        public int IscrizioniId { get; set; }
        public Iscrizioni Iscrizioni { get; set; }//FK
        public int CorsiId { get; set; }
        public Corsi Corsi { get; set; }//FK
        public int? EsamiId { get; set; }
        public Esami Esami { get; set; }//FK
        [NotMapped]
        public List<double?> Punteggi { get; set; }
        public Partecipanti() { }
    }

}

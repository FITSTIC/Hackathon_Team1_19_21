using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gestionale.Data
{
    public class Partecipante
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
        public int CorsiId { get; set; }
        public Corso Corsi { get; set; }//FK
        public virtual ICollection<Iscrizione> Iscrizioni { get; set; }
        public Partecipante() { }
    }

}

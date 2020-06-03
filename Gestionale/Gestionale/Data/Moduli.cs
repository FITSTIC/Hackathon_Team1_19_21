using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gestionale.Data
{
    public class Moduli
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Materia { get; set; }
        public Corsi Corsi { get; set; }//FK
        public DateTime DataInizio { get; set; }
        public DateTime DataFine { get; set; }
        public Personale Personale { get; set; }//FK
        public List<Partecipanti> Partecipanti { get; set; }
        public List<Esami> Esami { get; set; }
        public Moduli() { }
    }
}

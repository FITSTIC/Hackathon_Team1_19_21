using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gestionale.Data
{
    public class Iscrizioni
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataIscrizione { get; set; }
        public int CorsiId { get; set; }
        public Corsi Corsi { get; set; }//FK
        public List<Partecipanti> Partecipanti { get; set; }
        public Iscrizioni() { }
    }
}

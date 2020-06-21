using Gestionale.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gestionale.Data
{
    public class Iscrizione
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataIscrizione { get; set; }
        public int? CorsiId { get; set; }
        public Corso Corsi { get; set; }//FK
        public virtual ICollection<Partecipante> Partecipanti { get; set; }
        public Iscrizione() { }
        public Iscrizione(  int? corsiid )
        {

            DataIscrizione = DateTime.Now;
            CorsiId = corsiid;
        }

    }
    
}

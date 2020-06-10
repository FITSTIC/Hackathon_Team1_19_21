using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gestionale.Data
{
    public class Corso
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string AnnoAccademico { get; set; }
        public DateTime AnnoInizioCorso { get; set; }
        public DateTime AnnoFineCorso { get; set; }
        [Required]
        public string Sede { get; set; }
        public virtual ICollection<Partecipante> Partecipanti { get; set; }
        public virtual ICollection<Modulo> Moduli { get; set; }
        public virtual ICollection<Dipendente> Personale { get; set; }
        public virtual ICollection<Iscrizione> Iscrizioni { get; set; }
        public Corso() {}
    }
}

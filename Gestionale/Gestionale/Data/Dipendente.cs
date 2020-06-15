using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gestionale.Data
{
    public class Dipendente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cognome { get; set; }
        [Required]
        public DateTime DataNascita { get; set; }
        public string Email { get; set; }
        [Required]
        public string Telefono { get; set; }
        public DateTime Assunzione { get; set; }
        [Required]
        public virtual ICollection<Modulo> Moduli { get; set; }
        public string Categoria { get; set; }
        public int CorsiId { get; set; }
        public Corso Corsi { get; set; }
        public Dipendente()
        {
            Assunzione = DateTime.Now;
            DataNascita = DateTime.Now;
        }
    }
}
 
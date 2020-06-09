using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gestionale.Data
{
    public class Modulo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Materia { get; set; }
        public int CorsiId { get; set; }
        public Corso Corsi { get; set; }//FK
        public DateTime DataInizio { get; set; }
        public DateTime DataFine { get; set; }
        public int? InsegnanteId { get; set; }
        public Insegnante Insegnanti{ get; set; }//FK
        public int? TutorId { get; set; }
        public Tutor Tutor { get; set; }//FK
        public List<Esame> Esami { get; set; }
        public Modulo() { }
    }
}

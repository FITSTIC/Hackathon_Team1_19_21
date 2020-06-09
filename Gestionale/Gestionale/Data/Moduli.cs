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
        public int CorsiId { get; set; }
        public Corsi Corsi { get; set; }//FK
        public DateTime DataInizio { get; set; }
        public DateTime DataFine { get; set; }
        public int CoordinatoriId { get; set; }
        public Coordinatori Coordinatori { get; set; }//FK
        public int? InsegnantiId { get; set; }
        public Insegnanti Insegnanti { get; set; }//FK
        public int? TutorId { get; set; }
        public Tutor Tutor { get; set; }//FK
        public List<Esami> Esami { get; set; }
        public Moduli() { }
    }
}

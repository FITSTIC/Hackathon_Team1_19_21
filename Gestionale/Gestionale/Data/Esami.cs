using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gestionale.Data
{
    public class Esami
    {
        [Key]
        public int Id { get; set; }
        public int ModuliId { get; set; }
        public Moduli Moduli { get; set; }//FK
        public DateTime DataEsame { get; set; }
        public double? Punteggio { get; set; }
        public Esami() { }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Gestionale.Data
{
    public class Esame
    {
        [Key]
        public int Id { get; set; }
        public int ModuliId { get; set; }
        public Modulo Moduli { get; set; }//FK
        public DateTime DataEsame { get; set; }
        public List<Partecipante> Partecipanti { get; set; }
        public Esame() 
        {
            
        }
    }
}

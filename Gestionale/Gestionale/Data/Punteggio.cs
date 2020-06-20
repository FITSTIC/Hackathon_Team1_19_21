using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gestionale.Data
{

    public class Punteggio
    {
        [Key]
        public int Id { get; set; }
        public double? Voto { get; set; }
        public int PartecipanteId { get; set; }
        public Partecipante Partecipanti { get; set; }//FK
        public int EsameId { get; set; }
        public Esame Esami { get; set; }//FK
        public Punteggio() { }
    }
}

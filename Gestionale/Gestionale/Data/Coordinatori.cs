using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestionale.Data
{
    public class Coordinatori : Personale
    {
        public new int Id { get; set; }
        public Coordinatori() : base()
        {

        }
    }
}

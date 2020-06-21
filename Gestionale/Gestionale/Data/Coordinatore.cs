using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestionale.Data
{

    public class Coordinatore : Dipendente
    {        
        public Coordinatore() { }
        public Coordinatore(Dipendente d)
        {
            Nome = d.Nome;
            Cognome = d.Cognome;
            DataNascita = d.DataNascita;
            Email = d.Email;
            Telefono = d.Telefono;
            Assunzione = d.Assunzione;
            Categoria = d.Categoria;
            CorsiId = d.CorsiId;

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gestionale.Data
{
    public class Personale
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
        public List<Moduli> Moduli { get; set; }
        public string Categoria { get; set; }
        public int CorsiId { get; set; }
        public Corsi Corsi { get; set; }
        public Personale() { }
    }
    public class Insegnanti : Personale
    { 
        public int Id { get; set; }
        public Insegnanti() : base()
        {

        }
    }
    public class Tutor : Personale
    {
        public int Id { get; set; }
        public Tutor() : base()
        {

        }
    }
    public class Coordinatore : Personale
    {
        public int Id { get; set; }
        public Coordinatore() : base()
        {

        }
    }


}
 
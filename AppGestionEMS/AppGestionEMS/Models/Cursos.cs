using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEMS.Models
{
    public class Cursos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Cupo { get; set; }
        public float NotaCorte { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEMS.Models
{
    public class GrupoClases
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int MaxAlumnos { get; set; }
        public string Aula{ get; set; }

    }
}
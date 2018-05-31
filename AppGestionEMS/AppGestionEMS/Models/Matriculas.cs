using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppGestionEMS.Models
{
    public class Matriculas
    {
        public int id { get; set; }
        public string Fecha { get; set; }

        [Display(Name = "Curso")]
        public int CursoId { get; set; }
        public virtual Cursos Curso { get; set; }

        [Display(Name = "Docente")]
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        [Display(Name = "GrupoClases")]
        public int GrupoId { get; set; }
        public virtual GrupoClases Grupo { get; set; }
    }
}
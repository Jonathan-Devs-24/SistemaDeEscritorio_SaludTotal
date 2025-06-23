using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultoria_SaludTotal.Models
{
    public class ProfesionalEspecialidad
    {
        public int Id_ProfesionalEspecialidad { get; set; }
        public int Id_Profesional { get; set; }
        public int Id_Especialidad { get; set; }
        private Profesional? profesional { get; set; }
        private Especialidad? especialidad { get; set; }
    }
}

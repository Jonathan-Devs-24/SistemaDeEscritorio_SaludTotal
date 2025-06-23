using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultoria_SaludTotal.Models.Views
{
    public class VistaTurnoDetallado
    {
        public int IdTurno { get; set; }
        public string NombrePaciente { get; set; }
        public string NombreProfesional { get; set; }
        public string Especialidad { get; set; }
        public string Estado { get; set; }
        public DateOnly FechaTurno { get; set;  }
    }
}

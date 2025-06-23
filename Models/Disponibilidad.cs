using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultoria_SaludTotal.Models
{
    public class Disponibilidad
    {
        public int id_disponibilidad { get; set; }
        public int id_profesional { get; set; }
        public int max_turnos { get; set; } // Máximo de turnos por día
        public int dia_semana { get; set; } // 1: Lunes, 2: Martes, ..., 7: Domingo

        private Profesional? profesional { get; set; }
    }
}

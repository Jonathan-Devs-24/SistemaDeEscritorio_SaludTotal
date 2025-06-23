using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Para deserializar JSON a objetos C# y viceversa

namespace Consultoria_SaludTotal.Models
{
    public class Turno
    {
        public int id_Turno { get; set; }
        public int id_Paciente { get; set; }
        public int id_especialidad { get; set; }
        public int id_Profesional { get; set; }
        public DateTime fecha_turno { get; set; }
        public string? observaciones { get; set; }
        public string estado_turno { get; set; } // "Pendiente", "Confirmado", "Cancelado", etc.

        private Paciente? paciente { get; set; }
        private Especialidad? especialidad { get; set; }
        private Profesional? profesional { get; set; }

    }
}

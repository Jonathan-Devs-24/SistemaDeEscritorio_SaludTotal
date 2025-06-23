using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultoria_SaludTotal.Models
{
    public class TurnoOnline
    {
        public int id_TurnoOnline { get; set; }
        public string nombre_pacienteOnline { get; set; }
        public string apellido_pacienteOnline { get; set; }
        public int dnI_pacienteOnline { get; set; }
        public string fechaNacimiento_pacienteOnline { get; set; }
        public string correo_pacienteOnline { get; set; }
        public long telefono_pacienteOnline { get; set; }
        public string especialidad_Seleccionada { get; set; }
        public string estado_TurnoOnline { get; set; } = "En Proceso";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultoria_SaludTotal.Models.DTOs
{
    public class TurnosAtendidosPorProfesionalDTO
    {
        public string nombreProfesional { get; set; }
        public string fechaInicio { get; set; }
        public string fechaFin { get; set; }
        public int cantidadTurnosAtendidos { get; set; }

    }
}

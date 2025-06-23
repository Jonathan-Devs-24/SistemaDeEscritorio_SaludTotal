using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultoria_SaludTotal.Models.DTOs
{
    public class TurnosCanceladosYReprogramadosDTO
    {
        public string nombreProfesional { get; set; }
        public string fechaInicio { get; set; }
        public string fechaFin { get; set; }
        public int cantidadCancelados { get; set; }
        public int cantidadReprogramados { get; set; }
    }
}

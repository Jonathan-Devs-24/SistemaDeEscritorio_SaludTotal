using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultoria_SaludTotal.Models.Views
{
    public class TurnoOnlineRecibido
    {
        public int id_TurnoOnline { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dni { get; set; }
        public string correo { get; set; }
        public string especialidad { get; set; }
        public string estado { get; set; }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Para deserializar JSON a objetos C# y viceversa

namespace Consultoria_SaludTotal.Models
{
    public class Paciente
    {
        public int id { get; set; }

        public string nombre { get; set; } = null!;

        public string apellido { get; set; } = null!;

        public int dni { get; set; }

        public DateTime? fechaNacimiento { get; set; }

        public string correo { get; set; } = null!;

        public long? telefono { get; set; }
    }
}

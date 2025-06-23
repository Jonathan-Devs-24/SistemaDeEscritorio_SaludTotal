using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Para deserializar JSON a objetos C# y viceversa

namespace Consultoria_SaludTotal.Models
{
    internal class Profesional
    {
        public int id_Profesional { get; set; }
        public string nombre_Profesional{ get; set; }
        public string apellido_Profesional { get; set; }
        public string correo_Profesional { get; set; }
        public long? telefono_Profesional { get; set; }


        public string NombreCompleto => $"{nombre_Profesional} {apellido_Profesional}";

    }
}

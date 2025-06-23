using Consultoria_SaludTotal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Consultoria_SaludTotal.Services
{
    public static class NotificadorTurno
    {
        public static async Task EnviarCorreoNotificacionAsync(TurnoOnline turno, string estado)
        {
            string asunto = "Estado de tu turno en Salud Total";
            string mensaje;

            if (estado == "Aceptado")
            {
                mensaje = $"Hola {turno.nombre_pacienteOnline}, tu solicitud de turno fue aceptada. Nos vemos pronto.";
            }
            else if (estado == "Cancelado")
            {
                mensaje = $"Hola {turno.nombre_pacienteOnline}, lamentablemente tu turno fue cancelado. Podés reprogramarlo desde la web.";
            }
            else
            {
                mensaje = $"Tu solicitud está siendo procesada.";
            }

            using (var smtp = new SmtpClient("smtp.tuservidor.com"))
            {
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential("tuCorreo@dominio.com", "tuClave");
                smtp.EnableSsl = true;

                var correo = new MailMessage(
                    from: "tuCorreo@dominio.com",
                    to: turno.correo_pacienteOnline,
                    subject: asunto,
                    body: mensaje
                );

                await smtp.SendMailAsync(correo);
            }
        }
    }
}

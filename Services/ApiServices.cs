using Consultoria_SaludTotal.Models;
using Consultoria_SaludTotal.Models.DTOs;
using Consultoria_SaludTotal.Models.Views;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace Consultoria_SaludTotal.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiBaseUrl = "http://localhost:5036/api";

        public ApiService()
        {
            _httpClient = new HttpClient();
        }

        // Constructor que permite especificar si se usa HTTPS o HTTP
        public ApiService(bool usarHttps = false)
        {
            string baseUrl = usarHttps ? "https://localhost:7024" : "http://localhost:5036";

            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(baseUrl)
            };
        }


        // Método para obtener datos (GET)
        public async Task<T?> GetAsync<T>(string endpoint)
        {
            var response = await _httpClient.GetAsync($"{_apiBaseUrl}/{endpoint}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<T>(json, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            }
            return default;
        }

        // Método para enviar datos (POST)
        public async Task<bool> PostAsync<T>(string endpoint, T data)
        {
            var json = JsonSerializer.Serialize(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync($"{_apiBaseUrl}/{endpoint}", content);
            return response.IsSuccessStatusCode;
        }

        // Método para actualizar datos (PUT)
        public async Task<bool> PutAsync<T>(string endpoint, T data)
        {
            var json = JsonSerializer.Serialize(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync($"{_apiBaseUrl}/{endpoint}", content);
            return response.IsSuccessStatusCode;
        }

        // Método para eliminar datos (DELETE)
        public async Task<bool> DeleteAsync(string endpoint)
        {
            var response = await _httpClient.DeleteAsync($"{_apiBaseUrl}/{endpoint}");
            return response.IsSuccessStatusCode;
        }

        public async Task<T?> PostAndGetResponseAsync<T>(string endpoint, object data)
        {
            var json = JsonSerializer.Serialize(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync($"{_apiBaseUrl}/{endpoint}", content);
            if (!response.IsSuccessStatusCode)
                return default;

            var responseContent = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseContent);
        }

        // Método para verificar si un profesional tiene turnos disponibles XXX (BORRAR)
        public async Task<bool> TieneTurnosDisponibles(int idProfesional)
        {
            var bloques = await GetAsync<List<Models.Disponibilidad>>($"TurnoBloque/disponibles/profesional/{idProfesional}");
            return bloques != null && bloques.Count > 0;
        }

        // Método para obtener los turnos por dia
        public async Task<int> ObtenerCantidadTurnosPorDia(int idProfesional, DateTime fecha)
        {
            string url = $"Turno/contador?idProfesional={idProfesional}&fecha={fecha:yyyy-MM-dd}";
            return await GetAsync<int>(url);
        }

        // Método para obtener la vista detallada de turnos
        public async Task<List<VistaTurnoDetallado>> ObtenerVistaTurnosAsync()
        {
            var response = await _httpClient.GetAsync($"{_apiBaseUrl}/VistaTurnoDetallado");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            var opciones = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            opciones.Converters.Add(new DateOnlyJsonConverter());

            return JsonSerializer.Deserialize<List<VistaTurnoDetallado>>(json, opciones)!;
        }

        // Metdodo para cambiar el esatdo de un turno
        public async Task<bool> CambiarEstadoTurnoAsync(int idTurno, string nuevoEstado)
        {
            try
            {
                // 1. Obtener el turno actual
                var turnoActual = await GetAsync<Turno>($"Turno/{idTurno}");
                if (turnoActual == null) return false;

                // 2. Modificar solo el estado
                turnoActual.estado_turno = nuevoEstado;

                // 3. Enviar el objeto completo
                return await PutAsync($"Turno/{idTurno}", turnoActual);
            }
            catch
            {
                return false;
            }
        }

        // Método para obtener la cantidad de turnos por día de un paciente
        public async Task<List<VistaTurnoDetallado>> ObtenerHistorialTurnosPorPacienteAsync(int idPaciente)
        {
            var response = await _httpClient.GetAsync($"{_apiBaseUrl}/VistaTurnoDetallado/paciente/{idPaciente}");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            var opciones = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            opciones.Converters.Add(new DateOnlyJsonConverter()); // si usás DateOnly

            return JsonSerializer.Deserialize<List<VistaTurnoDetallado>>(json, opciones)!;
        }

        // Método para obtener los turnos online
        public async Task<List<TurnoOnline>> ObtenerTurnosOnlineAsync()
        {
            return await GetAsync<List<TurnoOnline>>("TurnoOnline");
        }

        // Método para cambiar el estado de un turno online
        public async Task<bool> CambiarEstadoTurnoOnlineAsync(int idTurnoOnline, string nuevoEstado)
        {
            var json = JsonSerializer.Serialize(new { Estado = nuevoEstado });
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync($"{_apiBaseUrl}/TurnoOnline/actualizar-estado/{idTurnoOnline}", content);
            return response.IsSuccessStatusCode;
        }
        
        // Crea paciente si no existe (cuando se acepta un turno online)
        public async Task<bool> CrearPacienteAsync(Paciente paciente)
        {
            return await PostAsync("Paciente", paciente);
        }


        // Método para obtener los turnos online recibidos
        public async Task<List<TurnoOnlineRecibido>> ObtenerTurnosOnlineRecibidosAsync()
        {
            return await GetAsync<List<TurnoOnlineRecibido>>("TurnoOnlineRecibido/recibidos");
        }

        public async Task<Especialidad?> ObtenerEspecialidadPorNombreAsync(string nombre)
        {
            var especialidades = await GetAsync<List<Especialidad>>("Especialidad");
            return especialidades?.FirstOrDefault(e =>
                string.Equals(e.nombre_Especialidad.Trim(), nombre.Trim(), StringComparison.OrdinalIgnoreCase));
        }


        // Metodo para crear un paciente y devolver el objeto creado
        public async Task<Paciente> CrearPacienteTOAsync(Paciente paciente)
        {
            var response = await _httpClient.PostAsJsonAsync($"{_apiBaseUrl}/Paciente", paciente);
            if (response.IsSuccessStatusCode)
            {
                var pacienteCreado = await response.Content.ReadFromJsonAsync<Paciente>();
                return pacienteCreado;
            }
            return null;
        }

        public async Task<bool> CrearTurnoAsync(Turno turno)
        {
            return await PostAsync("Turno", turno);
        }

        public async Task<List<TurnosAtendidosPorProfesionalDTO>> ObtenerTurnosAtendidosAsync(DateTime desde, DateTime hasta)
        {
            string url = $"Reportes/turnos-atendidos?fechaInicio={desde:yyyy-MM-dd}&fechaFin={hasta:yyyy-MM-dd}";
            return await GetAsync<List<TurnosAtendidosPorProfesionalDTO>>(url);
        }

        public async Task<List<TurnosCanceladosYReprogramadosDTO>> ObtenerCanceladosYReprogramadosAsync(DateTime desde, DateTime hasta)
        {
            var url = $"api/reportes/turnos-cancelados-reprogramados?fechaInicio={desde:yyyy-MM-dd}&fechaFin={hasta:yyyy-MM-dd}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<TurnosCanceladosYReprogramadosDTO>>(json);
        }
    }
}

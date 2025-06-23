using Consultoria_SaludTotal.Models;
using Consultoria_SaludTotal.Models.Views;
using Consultoria_SaludTotal.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Consultoria_SaludTotal.Views.EntidadesForm
{
    public partial class TurnoOnlineForm : Form
    {
        private readonly ApiService _apiService = new ApiService();

        public TurnoOnlineForm()
        {
            InitializeComponent();
            CargarEspecialidades();

            txtIdPaciente.ReadOnly = true;
            txtNombre.ReadOnly = true;
            txtApellido.ReadOnly = true;
            txtDNI.ReadOnly = true;
            txtEspecialidad.ReadOnly = true;
            txtCantidadTurnos.ReadOnly = true;

            cbEspecialidades.SelectedIndexChanged += cbEspecialidades_SelectedIndexChanged;
            cbProfesionales.SelectedIndexChanged += cbProfesionales_SelectedIndexChanged;

            StartPosition = FormStartPosition.Manual;
            Location = new Point(200, 100);


            // dgvListaTurnOnline.CellContentClick += dgvListaTurnOnline_CellContentClick;
        }

        // Método para cargar especialidades
        private async void CargarEspecialidades()
        {
            var especialidades = await _apiService.GetAsync<List<Models.Especialidad>>("Especialidad");

            if (especialidades != null)
            {
                especialidades.Insert(0, new Models.Especialidad
                {
                    id_Especialidad = -1,
                    nombre_Especialidad = "-- Seleccionar especialidad --"
                });

                cbEspecialidades.DataSource = especialidades;
                cbEspecialidades.DisplayMember = "nombre_Especialidad";
                cbEspecialidades.ValueMember = "id_Especialidad";
                cbEspecialidades.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Error al cargar las especialidades.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para cargar profesionales por especialidad
        private async void CargarProfesionalesPorEspecialidad(int idEspecialidad)
        {
            var profesionales = await _apiService.GetAsync<List<Models.Profesional>>($"ProfesionalEspecialidad/especialidad/{idEspecialidad}");

            if (profesionales != null && profesionales.Count > 0)
            {
                cbProfesionales.DataSource = profesionales;
                cbProfesionales.DisplayMember = "Nombre_Profesional";
                cbProfesionales.ValueMember = "Id_Profesional";
            }
            else
            {
                cbProfesionales.DataSource = null;
                MessageBox.Show("No hay profesionales para esta especialidad.");
            }
        }

        // Método para verificar disponibilidad de turnos
        private async Task<bool> VerificarDisponibilidadDeTurnos(int idProfesional, DateTime fechaTurno)
        {
            int cantidadTurnos = await _apiService.ObtenerCantidadTurnosPorDia(idProfesional, fechaTurno);
            return cantidadTurnos < 4;
        }

        // Método para agendar un turno
        private async void AgendarTurnoSiDisponible()
        {
            if (cbProfesionales.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un profesional.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtIdPaciente.Text))
            {
                MessageBox.Show("Debe seleccionar un paciente.");
                return;
            }

            int idProfesional = ((Models.Profesional)cbProfesionales.SelectedItem).id_Profesional;
            DateTime fechaTurno = dtpFechaTurno.Value.Date;

            if (fechaTurno < DateTime.Today)
            {
                MessageBox.Show("No se pueden agendar turnos en fechas pasadas.");
                return;
            }

            if (fechaTurno.DayOfWeek == DayOfWeek.Saturday || fechaTurno.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Solo se pueden agendar turnos de lunes a viernes.");
                return;
            }

            int turnosAgendados = await _apiService.ObtenerCantidadTurnosPorDia(idProfesional, fechaTurno);
            if (turnosAgendados >= 4)
            {
                MessageBox.Show("Este profesional ya tiene 4 turnos para ese día. Por favor seleccione otra fecha.");
                return;
            }

            var nuevoTurno = new Turno
            {
                id_Paciente = int.Parse(txtIdPaciente.Text),  // o el valor del txtIdPaciente.Text
                id_especialidad = (int)cbEspecialidades.SelectedValue,
                id_Profesional = idProfesional,
                fecha_turno = dtpFechaTurno.Value.Date,
                estado_turno = "Reservado",
                observaciones = "Solicitado online"
            };

            bool creado = await _apiService.CrearTurnoAsync(nuevoTurno);

            if (creado)
            {
                MessageBox.Show("Turno agendado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hubo un problema al agendar el turno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

      
       
        private async Task CargarTurnosEnProcesoAsync()
        {
            try
            {
                var turnos = await _apiService.ObtenerTurnosOnlineAsync();
                var enProceso = turnos?.Where(t => t.estado_TurnoOnline == "En Proceso").ToList();

                dgvListaTurnOnline.Columns.Clear();
                dgvListaTurnOnline.AutoGenerateColumns = true;

                if (enProceso != null && enProceso.Any())
                {
                    dgvListaTurnOnline.DataSource = enProceso;

                    // Botón Aceptar
                    var btnAceptar = new DataGridViewButtonColumn
                    {
                        Name = "Aceptar",
                        HeaderText = "Aceptar",
                        Text = "✅",
                        UseColumnTextForButtonValue = true
                    };
                    dgvListaTurnOnline.Columns.Add(btnAceptar);

                    // Botón Cancelar
                    var btnCancelar = new DataGridViewButtonColumn
                    {
                        Name = "Cancelar",
                        HeaderText = "Cancelar",
                        Text = "❌",
                        UseColumnTextForButtonValue = true
                    };
                    dgvListaTurnOnline.Columns.Add(btnCancelar);
                }
                else
                {
                    dgvListaTurnOnline.DataSource = null;
                    MessageBox.Show("No hay turnos en proceso.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los turnos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void dgvListaTurnOnline_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string columnName = dgvListaTurnOnline.Columns[e.ColumnIndex].Name;
            if (columnName != "Aceptar" && columnName != "Cancelar") return;

            var item = dgvListaTurnOnline.Rows[e.RowIndex].DataBoundItem as TurnoOnline;
            if (item == null) return;

            string accion = columnName == "Aceptar" ? "Aceptado" : "Cancelado";

            var confirmacion = MessageBox.Show(
                $"¿Confirmás que querés marcar el turno de {item.nombre_pacienteOnline} {item.apellido_pacienteOnline} como {accion.ToLower()}?",
                "Confirmar acción",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                bool exito = await _apiService.CambiarEstadoTurnoOnlineAsync(item.id_TurnoOnline, accion);

                if (exito)
                {

                    MessageBox.Show($"Turno {accion.ToLower()} con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await CargarTurnosEnProcesoAsync();
                }
                else
                {
                    MessageBox.Show("Hubo un error al actualizar el turno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (accion == "Aceptado")
            {
                var nuevoPaciente = new Paciente
                {
                    nombre = item.nombre_pacienteOnline,
                    apellido = item.apellido_pacienteOnline,
                    dni = item.dnI_pacienteOnline,
                    correo = item.correo_pacienteOnline,
                    telefono = item.telefono_pacienteOnline,
                    fechaNacimiento = DateTime.TryParse(item.fechaNacimiento_pacienteOnline, out var fecha) ? fecha : null
                };

                var pacienteCreado = await _apiService.CrearPacienteTOAsync(nuevoPaciente);

                if (pacienteCreado != null)
                {
                    MessageBox.Show("El paciente aceptado se registro con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtIdPaciente.Text = pacienteCreado.id.ToString();
                    txtNombre.Text = pacienteCreado.nombre;
                    txtApellido.Text = pacienteCreado.apellido;
                    txtDNI.Text = pacienteCreado.dni.ToString();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el paciente. Puede que ya exista o hubo un error.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                var especialidad = await _apiService.ObtenerEspecialidadPorNombreAsync(item.especialidad_Seleccionada);
                if (especialidad == null)
                {
                    MessageBox.Show("No se encontró la especialidad seleccionada por el paciente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                txtEspecialidad.Text = especialidad.nombre_Especialidad;
                cbEspecialidades.SelectedValue = especialidad.id_Especialidad;
            }
        }

        private async void TurnoOnlineForm_Load(object sender, EventArgs e)
        {
            await CargarTurnosEnProcesoAsync();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            AgendarTurnoSiDisponible();
        }

        private void cbEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEspecialidades.SelectedIndex > 0 && cbEspecialidades.SelectedValue is int idEspecialidad)
            {
                CargarProfesionalesPorEspecialidad(idEspecialidad);
            }
            else
            {
                cbProfesionales.DataSource = null;
            }
        }

        private async void cbProfesionales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProfesionales.SelectedIndex >= 0 && cbProfesionales.SelectedValue is int idProfesional)
            {
                DateTime fechaSeleccionada = dtpFechaTurno.Value.Date;

                if (fechaSeleccionada < DateTime.Today)
                {
                    txtCantidadTurnos.Text = "N/A";
                    return;
                }

                bool tieneDisponibilidad = await VerificarDisponibilidadDeTurnos(idProfesional, fechaSeleccionada);

                if (!tieneDisponibilidad)
                {
                    MessageBox.Show("Este profesional no tiene turnos disponibles en esta fecha.",
                                    "Sin disponibilidad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                int cantidadTurnos = await _apiService.ObtenerCantidadTurnosPorDia(idProfesional, fechaSeleccionada);
                int cuposDisponibles = 4 - cantidadTurnos;
                txtCantidadTurnos.Text = cuposDisponibles.ToString();
            }
        }

        private async void dtpFechaTurno_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dtpFechaTurno.Value.Date;

            if (fechaSeleccionada < DateTime.Today)
            {
                txtCantidadTurnos.Text = "N/A";
                MessageBox.Show("No se permiten turnos en fechas pasadas.");
                return;
            }

            if (cbProfesionales.SelectedItem != null)
            {
                int idProfesional = ((Models.Profesional)cbProfesionales.SelectedItem).id_Profesional;
                int turnosAgendados = await _apiService.ObtenerCantidadTurnosPorDia(idProfesional, fechaSeleccionada);
                int turnosDisponibles = 4 - turnosAgendados;
                txtCantidadTurnos.Text = turnosDisponibles.ToString();
            }
            else
            {
                txtCantidadTurnos.Text = "N/A";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm();
            menu.Show();
            this.Close();
        }
    }
}

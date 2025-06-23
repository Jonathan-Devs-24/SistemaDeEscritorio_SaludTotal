using Consultoria_SaludTotal.Services;
using Consultoria_SaludTotal.Views.EntidadesForm.PacienteForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultoria_SaludTotal.Views.EntidadesForm.TurnoForm
{
    public partial class AgendarTurnoForm : Form
    {
        private readonly ApiService _apiService = new ApiService();

        public AgendarTurnoForm()
        {
            InitializeComponent();

            txtIDPacienteSeleccionado.ReadOnly = true;
            txtNombrePacienteSelec.ReadOnly = true;
            txtApellidoPacienteSelect.ReadOnly = true;
            txtDNIPacienteSelect.ReadOnly = true;
            txtCantidadTurnos.ReadOnly = true;

            cbEspecialidades.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProfesionales.DropDownStyle = ComboBoxStyle.DropDownList;

            StartPosition = FormStartPosition.Manual;
            Location = new Point(200, 100);

        }


        private void AgendarTurnoForm2_Load(object sender, EventArgs e)
        {
            CargarPacientes();
            CargarEspecialidades();
            // CargarProfesionalesPorEspecialidad(-1);
        }


        // Método para cargar pacientes en el DataGrieView
        private async void CargarPacientes()
        {
            var pacientes = await _apiService.GetAsync<List<Models.Paciente>>("paciente");

            if (pacientes != null && pacientes.Count > 0)
            {
                dgvListaPacientesRegistrados.AutoGenerateColumns = true;
                dgvListaPacientesRegistrados.DataSource = pacientes;

                DataGridViewButtonColumn colAgendar = new DataGridViewButtonColumn
                {
                    HeaderText = "Agendar",
                    Name = "Agendar",
                    Text = "📅 Agendar",
                    UseColumnTextForButtonValue = true,
                    Width = 75
                };

                dgvListaPacientesRegistrados.Columns.Add(colAgendar);
            }
            else
            {
                dgvListaPacientesRegistrados.DataSource = null;
                MessageBox.Show("No se encontraron pacientes.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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



        // Método que verifica la disponibilidad considerando el límite de 4 turnos diarios:
        private async Task<bool> VerificarDisponibilidadDeTurnos(int idProfesional, DateTime fechaTurno)
        {
            int cantidadTurnos = await _apiService.ObtenerCantidadTurnosPorDia(idProfesional, fechaTurno);
            return cantidadTurnos < 4;
        }



        // Este es el método que agenda el turno, tomando los datos requeridos.
        private async void AgendarTurnoSiDisponible()
        {
            if (cbProfesionales.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un profesional.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtIDPacienteSeleccionado.Text))
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

            var nuevoTurno = new
            {
                id_paciente = int.Parse(txtIDPacienteSeleccionado.Text),
                id_profesional = idProfesional,
                id_especialidad = (int)cbEspecialidades.SelectedValue,
                fecha_turno = fechaTurno,
                estado_turno = "Reservado",
                observaciones = txtObservaciones.Text.Trim()
            };

            bool exito = await _apiService.PostAsync("Turno", nuevoTurno);
            if (exito)
            {
                MessageBox.Show("Turno agendado correctamente.");

                txtIDPacienteSeleccionado.Clear();
                txtNombrePacienteSelec.Clear();
                txtApellidoPacienteSelect.Clear();
                txtDNIPacienteSelect.Clear();
                txtCantidadTurnos.Clear();
                txtObservaciones.Clear();

                cbEspecialidades.SelectedIndex = 0;

            }
            else
            {
                MessageBox.Show("Ocurrió un error al agendar el turno.");
            }
        }




        // CONTROLES DE PANTALLA

        private void btnResgistrarPaciente2_Click(object sender, EventArgs e)
        {
            RegistrarPacienteForm pasar = new RegistrarPacienteForm();
            pasar.Show();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            AgendarTurnoSiDisponible();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void dgvListaPacientesRegistrados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListaPacientesRegistrados.Columns.Contains("Agendar"))
            {
                if (e.ColumnIndex == dgvListaPacientesRegistrados.Columns["Agendar"].Index && e.RowIndex >= 0)
                {
                    var cellValue = dgvListaPacientesRegistrados.Rows[e.RowIndex].Cells["id"].Value;
                    var cellNombre = dgvListaPacientesRegistrados.Rows[e.RowIndex].Cells["nombre"].Value;
                    var cellApellido = dgvListaPacientesRegistrados.Rows[e.RowIndex].Cells["apellido"].Value;
                    var cellDNI = dgvListaPacientesRegistrados.Rows[e.RowIndex].Cells["dni"].Value;

                    if (cellValue != null)
                    {
                        int idPaciente = Convert.ToInt32(cellValue);
                        txtIDPacienteSeleccionado.Text = idPaciente.ToString();
                        txtNombrePacienteSelec.Text = cellNombre?.ToString() ?? string.Empty;
                        txtApellidoPacienteSelect.Text = cellApellido?.ToString() ?? string.Empty;
                        txtDNIPacienteSelect.Text = cellDNI?.ToString() ?? string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo obtener el ID del paciente.");
                    }
                }
            }
            else
            {
                MessageBox.Show("La columna 'Agendar' no existe en el DataGridView.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

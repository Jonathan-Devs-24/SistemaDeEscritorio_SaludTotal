using Consultoria_SaludTotal.Models;
using Consultoria_SaludTotal.Services;
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
    public partial class ReprogramarTurnoForm : Form
    {
        private readonly ApiService _apiService = new ApiService();
        private int _idTurno;
        private Turno _turnoActual;


        public ReprogramarTurnoForm(int idTurno)
        {
            _idTurno = idTurno;
            InitializeComponent();

            cbEspecialidades.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProfesionales.DropDownStyle = ComboBoxStyle.DropDownList;

            cbEspecialidades.SelectedIndexChanged += cbEspecialidades_SelectedIndexChanged;
            cbProfesionales.SelectedIndexChanged += (s, e) => MostrarCantidadTurnos();
            dtpFechaTurno.ValueChanged += (s, e) => MostrarCantidadTurnos();

            CargarDatosTurno();

            StartPosition = FormStartPosition.Manual;
            Location = new Point(200, 100);
        }

        private void ReprogramarTurnoForm_Load(object sender, EventArgs e)
        {
            txtIDPacienteSeleccionado.ReadOnly = true;
            txtNombrePacienteSelec.ReadOnly = true;
            txtApellidoPacienteSelect.ReadOnly = true;
            txtDNIPacienteSelect.ReadOnly = true;
            txtCantidadTurnos.ReadOnly = true;

            cbEspecialidades.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProfesionales.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private async void CargarDatosTurno()
        {
            _turnoActual = await _apiService.GetAsync<Turno>($"Turno/{_idTurno}");
            if (_turnoActual == null)
            {
                MessageBox.Show("No se pudo cargar la información del turno.");
                this.Close();
                return;
            }

            // Cargar paciente
            var paciente = await _apiService.GetAsync<Paciente>($"Paciente/{_turnoActual.id_Paciente}");
            if (paciente != null)
            {
                txtIDPacienteSeleccionado.Text = paciente.id.ToString();
                txtNombrePacienteSelec.Text = paciente.nombre;
                txtApellidoPacienteSelect.Text = paciente.apellido;
                txtDNIPacienteSelect.Text = paciente.dni.ToString();
            }

            // Cargar especialidades
            var especialidades = await _apiService.GetAsync<List<Especialidad>>("Especialidad");
            cbEspecialidades.DisplayMember = "nombre_especialidad";
            cbEspecialidades.ValueMember = "id_especialidad";
            cbEspecialidades.DataSource = especialidades;

            // Establecer valor seleccionado
            cbEspecialidades.SelectedValue = _turnoActual.id_especialidad;

            // Cargar profesionales iniciales (por especialidad actual)
            await CargarProfesionalesPorEspecialidad(_turnoActual.id_especialidad);

            cbProfesionales.SelectedValue = _turnoActual.id_Profesional;

            // Resto de campos
            dtpFechaTurno.Value = _turnoActual.fecha_turno;
            txtObservaciones.Text = _turnoActual.observaciones;

            MostrarCantidadTurnos();
        }

        private async Task CargarProfesionalesPorEspecialidad(int idEspecialidad)
        {
            var profesionales = await _apiService.GetAsync<List<Profesional>>(
                $"Profesional/especialidad/{idEspecialidad}");

            cbProfesionales.DisplayMember = "NombreCompleto";
            cbProfesionales.ValueMember = "id_Profesional";
            cbProfesionales.DataSource = profesionales;


        }


        private async void MostrarCantidadTurnos()
        {
            if (cbProfesionales.SelectedValue is int idProfesional)
            {
                DateTime fecha = dtpFechaTurno.Value.Date;
                int cantidad = await _apiService.ObtenerCantidadTurnosPorDia(idProfesional, fecha);
            }
        }


        private async void btnReprogramar_Click(object sender, EventArgs e)
        {
            var turnoActualizado = new Turno
            {
                id_Turno = _idTurno,
                id_Paciente = int.Parse(txtIDPacienteSeleccionado.Text),
                id_especialidad = (int)cbEspecialidades.SelectedValue,
                id_Profesional = (int)cbProfesionales.SelectedValue,
                fecha_turno = dtpFechaTurno.Value.Date,
                observaciones = txtObservaciones.Text,
                estado_turno = "Reservado (Reprogramado)"
            };

            var exito = await _apiService.PutAsync($"Turno/{_idTurno}", turnoActualizado);

            if (exito)
            {
                MessageBox.Show("Turno reprogramado correctamente.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al reprogramar el turno.");
            }
        }

        private async void cbEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEspecialidades.SelectedItem == null) return;

            int idEspecialidad = (int)cbEspecialidades.SelectedValue;
            var profesionales = await _apiService.GetAsync<List<Profesional>>($"Profesional/especialidad/{idEspecialidad}");

            cbProfesionales.DisplayMember = "NombreCompleto";
            cbProfesionales.ValueMember = "id_profesional";
            cbProfesionales.DataSource = profesionales;

            cbProfesionales.SelectedValue = _turnoActual.id_Profesional;
            MostrarCantidadTurnos();
        }

        private void cbProfesionales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

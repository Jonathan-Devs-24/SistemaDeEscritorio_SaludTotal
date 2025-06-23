using Consultoria_SaludTotal.Models;
using Consultoria_SaludTotal.Services;
using System;
using System.Windows.Forms;

namespace Consultoria_SaludTotal.Views.EntidadesForm.PacienteForm
{
    public partial class EditarPacienteForm : Form
    {
        private Paciente _paciente;
        private readonly ApiService _apiService = new ApiService();


        public EditarPacienteForm(Paciente paciente)
        {
            InitializeComponent();
            _paciente = paciente;
            StartPosition = FormStartPosition.Manual;
            Location = new Point(200, 100);
        }


        private void EditarPacienteForm_Load(object sender, EventArgs e)
        {
            txtNombreR.Text = _paciente.nombre;
            txtApellidoR.Text = _paciente.apellido;
            txtDNIR.Text = _paciente.dni.ToString();
            txtCorreoR.Text = _paciente.correo;
            txtTelefonoR.Text = _paciente.telefono?.ToString();
            txtFechaNacimientoR.Text = _paciente.fechaNacimiento?.ToString("dd/MM/yyyy");
        }

        private async void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            _paciente.nombre = txtNombreR.Text;
            _paciente.apellido = txtApellidoR.Text;
            _paciente.dni = int.Parse(txtDNIR.Text);
            _paciente.correo = txtCorreoR.Text;
            _paciente.telefono = long.TryParse(txtTelefonoR.Text, out long tel) ? tel : null;

            // Parsear la fecha escrita en el textbox y guardarla
            if (DateTime.TryParse(txtFechaNacimientoR.Text, out DateTime fecha))
            {
                _paciente.fechaNacimiento = fecha;
            }
            else
            {
                MessageBox.Show("La fecha ingresada no es válida (usa el formato dd/MM/yyyy)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // No continúa si la fecha es inválida
            }

            var exito = await _apiService.PutAsync($"paciente/{_paciente.id}", _paciente);
            if (exito)
            {
                MessageBox.Show("Paciente actualizado correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ocurrió un error al actualizar.");
            }
        }

        private void EditarPacienteForm_Load_1(object sender, EventArgs e)
        {
            txtNombreR.Text = _paciente.nombre;
            txtApellidoR.Text = _paciente.apellido;
            txtDNIR.Text = _paciente.dni.ToString();
            txtCorreoR.Text = _paciente.correo;
            txtTelefonoR.Text = _paciente.telefono?.ToString();
            txtFechaNacimientoR.Text = _paciente.fechaNacimiento?.ToString("dd/MM/yyyy");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No se realizaron cambios.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }

}

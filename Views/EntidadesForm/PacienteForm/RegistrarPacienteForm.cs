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

namespace Consultoria_SaludTotal.Views.EntidadesForm.PacienteForm
{
    public partial class RegistrarPacienteForm : Form
    {
       
        private readonly ApiService _apiServices = new ApiService();

        public RegistrarPacienteForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(200, 100);

        }

        private async Task RegistrarPaciente()
        {
            var paciente = new
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                DNI = txtDNI.Text,
                FechaNacimiento = txtFechaNacimiento.Text,
                Correo = txtCorreo.Text,
                Telefono = txtTelefono.Text
            };

            bool registrado = await _apiServices.PostAsync("paciente", paciente);

            if (registrado)
            {
                MessageBox.Show("Paciente registrado");

                txtNombre.Clear();
                txtApellido.Clear();
                txtDNI.Clear();
                txtFechaNacimiento.Clear();
                txtCorreo.Clear();
                txtTelefono.Clear();

            }
            else
            {
                MessageBox.Show("Erro. No se registro Paciente");
            }

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFechaNacimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            await RegistrarPaciente();
            this.Hide();
        }

        

        private void btnAtrasMenuP_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void RegistrarPacienteForm_Load(object sender, EventArgs e)
        {

        }
    }
}

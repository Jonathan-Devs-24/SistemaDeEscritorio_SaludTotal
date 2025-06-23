using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Consultoria_SaludTotal.Models;
using Consultoria_SaludTotal.Services;

namespace Consultoria_SaludTotal.Views.EntidadesForm.PacienteForm
{
    public partial class HistorialPacienteForm : Form
    {
        private readonly ApiService _apiService = new ApiService();
        private readonly Paciente _paciente;
        public HistorialPacienteForm(Paciente paciente)
        {
            _paciente = paciente;
            InitializeComponent();
            Text = $"Historial de Paciente: {_paciente.nombre} {_paciente.apellido}"; // Título del formulario con el nombre del paciente
            StartPosition = FormStartPosition.Manual;
            Location = new Point(200, 100);
        }


        private async void HistorialPacienteForm_Load(object sender, EventArgs e)
        {
            var historial = await _apiService.ObtenerHistorialTurnosPorPacienteAsync(_paciente.id);
            dgvHistorialTurno.DataSource = historial;
        }

        private void dgvHistorialTurno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

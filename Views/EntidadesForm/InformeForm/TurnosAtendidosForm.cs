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

namespace Consultoria_SaludTotal.Views.EntidadesForm.InformeForm
{


    public partial class TurnosAtendidosForm : Form
    {
        private readonly ApiService _apiService = new ApiService();
        public TurnosAtendidosForm()
        {
            InitializeComponent();
            dateTimePickerDesde.Format = DateTimePickerFormat.Custom;
            dateTimePickerDesde.CustomFormat = "yyyy-MM-dd";

            dateTimePickerHasta.Format = DateTimePickerFormat.Custom;
            dateTimePickerHasta.CustomFormat = "yyyy-MM-dd";

            dvgInfomes.AutoGenerateColumns = true;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm();
            menu.Show();
            this.Hide();
        }

        private async void btnTurnosAtendidos_Click(object sender, EventArgs e)
        {
            var desde = dateTimePickerDesde.Value;
            var hasta = dateTimePickerHasta.Value;

            var datos = await _apiService.ObtenerTurnosAtendidosAsync(desde, hasta);

            if (datos != null && datos.Any())
            {
                dvgInfomes.DataSource = datos;
            }
            else
            {
                MessageBox.Show("No se encontraron turnos completados en el rango seleccionado.");
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDesde_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerHasta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void InformeMenuForm_Load(object sender, EventArgs e)
        {

        }

        private async void btnCanceladoReprogramado_Click(object sender, EventArgs e)
        {
            DateTime desde = dateTimePickerDesde.Value.Date;
            DateTime hasta = dateTimePickerHasta.Value.Date;

            try
            {
                var api = new ApiService(usarHttps: true);
                var datos = await api.ObtenerCanceladosYReprogramadosAsync(desde, hasta);

                dvgInfomes.DataSource = datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

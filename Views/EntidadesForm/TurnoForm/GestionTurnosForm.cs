using Consultoria_SaludTotal.Services;
using Consultoria_SaludTotal.Views.EntidadesForm.PacienteForm;
using Newtonsoft.Json;
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
    public partial class GestionTurnosForm : Form
    {
        private readonly ApiService _apiService = new ApiService();

        public GestionTurnosForm()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.Manual;
            Location = new Point(200, 100);

        }


        private async void CargarTurnosDetallados()
        {
            // Desuscribís el evento para evitar múltiples asignaciones
            dgvTurno.CellContentClick -= dgvTurno_CellContentClick;

            var turnos = await _apiService.ObtenerVistaTurnosAsync();

            dgvTurno.Columns.Clear();
            dgvTurno.DataSource = turnos;

            // Agregar columna de botones al final
            var colBoton = new DataGridViewButtonColumn();
            colBoton.Name = "Accion";
            colBoton.HeaderText = "Acción";
            colBoton.UseColumnTextForButtonValue = false; // vamos a poner el texto por celda
            dgvTurno.Columns.Add(colBoton);

            // Columna para completar un turno
            /*var colButton = new DataGridViewButtonColumn
            {
                Name = "Completar",     
                HeaderText = "Completae",
                UseColumnTextForButtonValue = true
            };*/

            // Ajustar el ancho de las columnas
            dgvTurno.Columns["Accion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // dgvTurno.Columns["Completar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Ajustar los textos de los botones según el estado
            foreach (DataGridViewRow fila in dgvTurno.Rows)
            {
                string estado = fila.Cells["Estado"].Value?.ToString() ?? "";

                if (estado == "Reservado")
                {
                    fila.Cells["Accion"].Value = "Cancelar";
                    // fila.Cells["Completar"].Value = "Completo";
                }
                else if (estado == "Cancelado")
                {
                    fila.Cells["Accion"].Value = "Reprogramar";
                }
                else if (estado == "Reservado (Reprogramado)")
                {
                    fila.Cells["Accion"].Value = "Cancelar";
                }
                else
                {
                    fila.Cells["Accion"].Value = ""; // No acción para "Completo"
                }
            }
            // Volvés a suscribir después de configurar todo
            dgvTurno.CellContentClick += dgvTurno_CellContentClick;
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAtrasMenuPac_Click(object sender, EventArgs e)
        {
            MenuForm pasarMenu = new MenuForm();
            pasarMenu.Show();
            this.Hide();
        }

        private void btnRegistrarP_Click(object sender, EventArgs e)
        {
            AgendarTurnoForm pasarAgendar = new AgendarTurnoForm();
            pasarAgendar.Show();
        }

        private async void dgvTurno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvTurno.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                string accion = dgvTurno.Rows[e.RowIndex].Cells["Accion"].Value?.ToString() ?? "";
                string estado = dgvTurno.Rows[e.RowIndex].Cells["Estado"].Value?.ToString() ?? "";
                int idTurno = Convert.ToInt32(dgvTurno.Rows[e.RowIndex].Cells["IdTurno"].Value);

                if (accion == "Cancelar" && estado == "Reservado" || estado == "Reservado (Reprogramado)")
                {
                    var confirmar = MessageBox.Show("¿Seguro que deseas cancelar este turno?", "Confirmar", MessageBoxButtons.YesNo);
                    if (confirmar == DialogResult.Yes)
                    {
                        var exito = await _apiService.CambiarEstadoTurnoAsync(idTurno, "Cancelado");
                        if (exito)
                        {
                            MessageBox.Show("Turno cancelado.");
                            CargarTurnosDetallados();
                        }
                        else
                        {
                            MessageBox.Show("Error al cancelar.");
                        }
                    }
                }
                else if (accion == "Reprogramar" && estado == "Cancelado")
                { 
                    new ReprogramarTurnoForm(idTurno).ShowDialog();
                }
            }
        }

        private async void GestionTurnosForm_Load(object sender, EventArgs e)
        {
            CargarTurnosDetallados();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarTurnosDetallados();
        }
    }
}


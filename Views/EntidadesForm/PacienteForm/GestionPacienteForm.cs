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
    public partial class GestionPacienteForm : Form
    {

        private readonly ApiService _apiService = new ApiService();
        public GestionPacienteForm()
        {
            InitializeComponent();
            dvgPacienteID.AllowUserToAddRows = false;
            StartPosition = FormStartPosition.Manual;
            Location = new Point(200, 100);
        }

        // Buscar por ID
        private async Task BuscarPacientePorID(int idPaciente)
        {
            try
            {
                var paciente = await _apiService.GetAsync<Paciente>($"paciente/{idPaciente}");

                if (paciente != null)
                {
                    dvgPacienteID.AutoGenerateColumns = true;
                    dvgPacienteID.DataSource = new List<Paciente> { paciente };
                    dvgPacienteID.AutoGenerateColumns = true; // Permite que se generen automáticamente
                    AgregarColumnasDeAccion();
                    dvgPacienteID.Refresh(); // Asegura que se actualicen los datos
                }
                else
                {
                    MessageBox.Show("Paciente no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dvgPacienteID.DataSource = null;
                    QuitarColumnasDeAccion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar paciente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        // Obtiene todo
        public async Task ObtenerTodosLosPacientes()
        {
            try
            {
                var pacientes = await _apiService.GetAsync<List<Paciente>>("paciente");

                if (pacientes != null && pacientes.Count > 0)
                {

                    dvgPacienteID.AutoGenerateColumns = true; // Asegurar generación automática
                    dvgPacienteID.DataSource = pacientes;
                    AgregarColumnasDeAccion();
                    dvgPacienteID.Refresh();
                }
                else
                {
                    MessageBox.Show("No se encontraron pacientes.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dvgPacienteID.DataSource = null;
                    QuitarColumnasDeAccion(); // Elimina las columnas de acción si no hay pacientes
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener los pacientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        //Agrega Botones a las columnas del dvg
        private void AgregarColumnasDeAccion()
        {
            // Verifica si ya existen las columnas para no duplicarlas
            if (!dvgPacienteID.Columns.Contains("Editar") && !dvgPacienteID.Columns.Contains("Eliminar"))
            {
                // Botón Editar
                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
                btnEditar.Name = "Editar";
                btnEditar.HeaderText = "Editar";
                btnEditar.Text = "✏ Editar";
                btnEditar.UseColumnTextForButtonValue = true;
                dvgPacienteID.Columns.Add(btnEditar);

                // Botón Eliminar
                DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
                btnEliminar.Name = "Eliminar";
                btnEliminar.HeaderText = "Eliminar";
                btnEliminar.Text = "❌ Eliminar";
                btnEliminar.UseColumnTextForButtonValue = true;
                dvgPacienteID.Columns.Add(btnEliminar);

                // Botón Historial
                DataGridViewButtonColumn  btnHistorial = new DataGridViewButtonColumn();
                btnHistorial.Name = "Historial";
                btnHistorial.HeaderText = "Historial";
                btnHistorial.Text = "📜 Historial";
                btnHistorial.UseColumnTextForButtonValue = true;    
                dvgPacienteID.Columns.Add(btnHistorial);
            }
        }
        // Quita las columnas de acción del DataGridView
        public void QuitarColumnasDeAccion()
        {
            if (dvgPacienteID.Columns.Contains("Editar"))
            {
                dvgPacienteID.Columns.Remove("Editar");
            }

            if (dvgPacienteID.Columns.Contains("Eliminar"))
            {
                dvgPacienteID.Columns.Remove("Eliminar");
            }


        }


        private void PacienteVerIDForm_Load(object sender, EventArgs e)
        {

        }


        private async void dvgPacienteID_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedPaciente = (Paciente)dvgPacienteID.Rows[e.RowIndex].DataBoundItem;

                if (dvgPacienteID.Columns[e.ColumnIndex].Name == "Editar")
                {

                    var editarForm = new EditarPacienteForm(selectedPaciente);

                    editarForm.ShowDialog();
                    await ObtenerTodosLosPacientes(); // refrescá después de editar
                }

                if (dvgPacienteID.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    var confirm = MessageBox.Show("¿Seguro que querés eliminar este paciente?", "Confirmar", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        await _apiService.DeleteAsync($"paciente/{selectedPaciente.id}");
                        await ObtenerTodosLosPacientes(); // refrescá después de eliminar
                    }
                }

                if (dvgPacienteID.Columns[e.ColumnIndex].Name == "Historial")
                {
                    // Aquí puedes abrir el formulario de historial del paciente
                    HistorialPacienteForm historialForm = new HistorialPacienteForm(selectedPaciente);
                    historialForm.ShowDialog();
                }
            }
        }


        private async void btnBuscarP_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIDBuscarP.Text, out int id))
            {
                await BuscarPacientePorID(id);
            }
            else
            {
                MessageBox.Show("Ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtIDBuscarP_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnVerTodo_Click(object sender, EventArgs e)
        {
            await ObtenerTodosLosPacientes();

        }

        private void btnAtrasMenuPac_Click(object sender, EventArgs e)
        {
            MenuForm atras = new MenuForm();
            atras.Show();
            this.Hide();
        }

        private void btnRegistrarP_Click(object sender, EventArgs e)
        {
            RegistrarPacienteForm registrarPacForm = new RegistrarPacienteForm();
            registrarPacForm.Show();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dvgPacienteID.DataSource = null; // Limpia el DataGridView
            QuitarColumnasDeAccion(); // Elimina las columnas de acción
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
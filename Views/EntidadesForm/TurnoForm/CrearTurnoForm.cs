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
    public partial class CrearTurnoForm : Form
    {
        public CrearTurnoForm()
        {
            InitializeComponent();

            // Deshabilitar campos de texto para evitar edición manual
            txtIDProfSelect.ReadOnly = true;
            txtNombreProfSelect.ReadOnly = true;
            txtApellidoProfSelect.ReadOnly = true;
            txtEspecialidadProfSelect.ReadOnly = true;

            StartPosition = FormStartPosition.Manual;
            Location = new Point(200, 100);


        }

        private void CrearTurnoForm_Load(object sender, EventArgs e)
        {

        }
    }
}

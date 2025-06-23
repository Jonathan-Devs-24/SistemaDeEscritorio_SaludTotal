using Consultoria_SaludTotal.Views.EntidadesForm;
using Consultoria_SaludTotal.Views.EntidadesForm.InformeForm;
using Consultoria_SaludTotal.Views.EntidadesForm.PacienteForm;
using Consultoria_SaludTotal.Views.EntidadesForm.TurnoForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultoria_SaludTotal.Views
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(200, 100);
        }

        private void btnPaciente_Click_1(object sender, EventArgs e)
        {
            GestionPacienteForm gestionP = new GestionPacienteForm();
            gestionP.Show();
            this.Hide();
        }

        private void btnTurno_Click_1(object sender, EventArgs e)
        {
            GestionTurnosForm pasarTurno = new GestionTurnosForm();
            pasarTurno.Show();
            this.Hide();
        }

        private void btnSolicitud_Click(object sender, EventArgs e)
        {
            TurnoOnlineForm turnoOnline = new TurnoOnlineForm();
            turnoOnline.Show();
            this.Hide();
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            TurnosAtendidosForm informeMenu = new TurnosAtendidosForm();
            informeMenu.Show();
            this.Hide();

        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}

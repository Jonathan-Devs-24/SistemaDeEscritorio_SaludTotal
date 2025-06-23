using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Consultoria_SaludTotal.Services;

namespace Consultoria_SaludTotal.Views
{
    public partial class LoginForm : Form
    {
        private readonly ApiService _apiService = new ApiService();
        public LoginForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(200, 100);
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnIniciar_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;

            var loginResult = await _apiService.PostAndGetResponseAsync<bool>("Usuario/login", new
            {
                Nombre_Usuario = user,
                Contrasenia = pass
            });

            if (loginResult)
            {
                MessageBox.Show("Inicio de sesión exitoso", "Bienvenido/a", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MenuForm mainForm = new MenuForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}

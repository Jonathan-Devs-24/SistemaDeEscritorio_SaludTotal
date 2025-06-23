namespace Consultoria_SaludTotal.Views.EntidadesForm.TurnoForm
{
    partial class AgendarTurnoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnCancelar = new Button();
            btnResgistrarPaciente2 = new Button();
            btnAgendar = new Button();
            groupBox3 = new GroupBox();
            txtCantidadTurnos = new TextBox();
            label6 = new Label();
            txtObservaciones = new TextBox();
            label12 = new Label();
            label4 = new Label();
            dtpFechaTurno = new DateTimePicker();
            label1 = new Label();
            label5 = new Label();
            cbProfesionales = new ComboBox();
            cbEspecialidades = new ComboBox();
            groupBox2 = new GroupBox();
            txtDNIPacienteSelect = new TextBox();
            label10 = new Label();
            txtIDPacienteSeleccionado = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label2 = new Label();
            txtNombrePacienteSelec = new TextBox();
            txtApellidoPacienteSelect = new TextBox();
            label3 = new Label();
            dgvListaPacientesRegistrados = new DataGridView();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaPacientesRegistrados).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnResgistrarPaciente2);
            groupBox1.Controls.Add(btnAgendar);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dgvListaPacientesRegistrados);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1295, 656);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(658, 581);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(139, 45);
            btnCancelar.TabIndex = 32;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnResgistrarPaciente2
            // 
            btnResgistrarPaciente2.Location = new Point(1082, 30);
            btnResgistrarPaciente2.Name = "btnResgistrarPaciente2";
            btnResgistrarPaciente2.Size = new Size(207, 35);
            btnResgistrarPaciente2.TabIndex = 37;
            btnResgistrarPaciente2.Text = "Registrar paciente";
            btnResgistrarPaciente2.UseVisualStyleBackColor = true;
            btnResgistrarPaciente2.Click += btnResgistrarPaciente2_Click;
            // 
            // btnAgendar
            // 
            btnAgendar.Location = new Point(385, 581);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(139, 45);
            btnAgendar.TabIndex = 33;
            btnAgendar.Text = "Agendar";
            btnAgendar.UseVisualStyleBackColor = true;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Honeydew;
            groupBox3.Controls.Add(txtCantidadTurnos);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtObservaciones);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(dtpFechaTurno);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(cbProfesionales);
            groupBox3.Controls.Add(cbEspecialidades);
            groupBox3.Location = new Point(87, 313);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1084, 253);
            groupBox3.TabIndex = 39;
            groupBox3.TabStop = false;
            groupBox3.Text = "Turno por especialidad/profesional/disponibilidad";
            // 
            // txtCantidadTurnos
            // 
            txtCantidadTurnos.Location = new Point(479, 94);
            txtCantidadTurnos.Name = "txtCantidadTurnos";
            txtCantidadTurnos.Size = new Size(33, 31);
            txtCantidadTurnos.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(407, 100);
            label6.Name = "label6";
            label6.Size = new Size(70, 25);
            label6.TabIndex = 33;
            label6.Text = "Turnos:";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(615, 55);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(429, 147);
            txtObservaciones.TabIndex = 32;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(615, 27);
            label12.Name = "label12";
            label12.Size = new Size(132, 25);
            label12.TabIndex = 31;
            label12.Text = "Observaciones:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 46);
            label4.Name = "label4";
            label4.Size = new Size(113, 25);
            label4.TabIndex = 15;
            label4.Text = "Especialidad:";
            // 
            // dtpFechaTurno
            // 
            dtpFechaTurno.CustomFormat = "dd/MM/yy";
            dtpFechaTurno.Format = DateTimePickerFormat.Custom;
            dtpFechaTurno.Location = new Point(219, 155);
            dtpFechaTurno.MaxDate = new DateTime(2810, 12, 31, 0, 0, 0, 0);
            dtpFechaTurno.MinDate = new DateTime(2000, 9, 24, 0, 0, 0, 0);
            dtpFechaTurno.Name = "dtpFechaTurno";
            dtpFechaTurno.Size = new Size(209, 31);
            dtpFechaTurno.TabIndex = 27;
            dtpFechaTurno.Value = new DateTime(2025, 6, 16, 0, 0, 0, 0);
            dtpFechaTurno.ValueChanged += dtpFechaTurno_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 100);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 16;
            label1.Text = "Profesional:";
            label1.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 161);
            label5.Name = "label5";
            label5.Size = new Size(175, 25);
            label5.TabIndex = 26;
            label5.Text = "Fechas para el turno:";
            // 
            // cbProfesionales
            // 
            cbProfesionales.FormattingEnabled = true;
            cbProfesionales.Location = new Point(219, 92);
            cbProfesionales.Name = "cbProfesionales";
            cbProfesionales.Size = new Size(182, 33);
            cbProfesionales.TabIndex = 20;
            cbProfesionales.SelectedIndexChanged += cbProfesionales_SelectedIndexChanged;
            // 
            // cbEspecialidades
            // 
            cbEspecialidades.FormattingEnabled = true;
            cbEspecialidades.Location = new Point(219, 38);
            cbEspecialidades.Name = "cbEspecialidades";
            cbEspecialidades.Size = new Size(251, 33);
            cbEspecialidades.TabIndex = 20;
            cbEspecialidades.SelectedIndexChanged += cbEspecialidades_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLightLight;
            groupBox2.Controls.Add(txtDNIPacienteSelect);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtIDPacienteSeleccionado);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtNombrePacienteSelec);
            groupBox2.Controls.Add(txtApellidoPacienteSelect);
            groupBox2.Location = new Point(46, 231);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1137, 76);
            groupBox2.TabIndex = 38;
            groupBox2.TabStop = false;
            groupBox2.Text = "Info. del paciente seleccionado";
            // 
            // txtDNIPacienteSelect
            // 
            txtDNIPacienteSelect.Location = new Point(641, 30);
            txtDNIPacienteSelect.Name = "txtDNIPacienteSelect";
            txtDNIPacienteSelect.Size = new Size(192, 31);
            txtDNIPacienteSelect.TabIndex = 31;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(588, 33);
            label10.Name = "label10";
            label10.Size = new Size(47, 25);
            label10.TabIndex = 30;
            label10.Text = "DNI:";
            // 
            // txtIDPacienteSeleccionado
            // 
            txtIDPacienteSeleccionado.Location = new Point(53, 30);
            txtIDPacienteSeleccionado.Name = "txtIDPacienteSeleccionado";
            txtIDPacienteSeleccionado.Size = new Size(44, 31);
            txtIDPacienteSeleccionado.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(350, 33);
            label9.Name = "label9";
            label9.Size = new Size(82, 25);
            label9.TabIndex = 29;
            label9.Text = "Apellido:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(103, 33);
            label8.Name = "label8";
            label8.Size = new Size(82, 25);
            label8.TabIndex = 29;
            label8.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 33);
            label2.Name = "label2";
            label2.Size = new Size(34, 25);
            label2.TabIndex = 14;
            label2.Text = "ID:";
            // 
            // txtNombrePacienteSelec
            // 
            txtNombrePacienteSelec.Location = new Point(191, 30);
            txtNombrePacienteSelec.Name = "txtNombrePacienteSelec";
            txtNombrePacienteSelec.Size = new Size(153, 31);
            txtNombrePacienteSelec.TabIndex = 24;
            // 
            // txtApellidoPacienteSelect
            // 
            txtApellidoPacienteSelect.Location = new Point(437, 30);
            txtApellidoPacienteSelect.Name = "txtApellidoPacienteSelect";
            txtApellidoPacienteSelect.Size = new Size(145, 31);
            txtApellidoPacienteSelect.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1, 40);
            label3.Name = "label3";
            label3.Size = new Size(245, 25);
            label3.TabIndex = 36;
            label3.Text = "Lista de pacientes registrados";
            // 
            // dgvListaPacientesRegistrados
            // 
            dgvListaPacientesRegistrados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaPacientesRegistrados.Location = new Point(1, 68);
            dgvListaPacientesRegistrados.Name = "dgvListaPacientesRegistrados";
            dgvListaPacientesRegistrados.RowHeadersWidth = 62;
            dgvListaPacientesRegistrados.Size = new Size(1288, 157);
            dgvListaPacientesRegistrados.TabIndex = 35;
            dgvListaPacientesRegistrados.CellContentClick += dgvListaPacientesRegistrados_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(495, -17);
            label7.Name = "label7";
            label7.Size = new Size(262, 52);
            label7.TabIndex = 34;
            label7.Text = "Agendar Turno";
            // 
            // AgendarTurnoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1319, 680);
            Controls.Add(groupBox1);
            Name = "AgendarTurnoForm";
            Text = "Agendar Turnos";
            Load += AgendarTurnoForm2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaPacientesRegistrados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCancelar;
        private Button btnResgistrarPaciente2;
        private Button btnAgendar;
        private GroupBox groupBox3;
        private Label label12;
        private Label label4;
        private DateTimePicker dtpFechaTurno;
        private Label label1;
        private Label label5;
        private ComboBox cbProfesionales;
        private ComboBox cbEspecialidades;
        private GroupBox groupBox2;
        private TextBox txtDNIPacienteSelect;
        private Label label10;
        private TextBox txtIDPacienteSeleccionado;
        private Label label9;
        private Label label8;
        private Label label2;
        private TextBox txtNombrePacienteSelec;
        private TextBox txtApellidoPacienteSelect;
        private Label label3;
        private DataGridView dgvListaPacientesRegistrados;
        private Label label7;
        private TextBox txtObservaciones;
        private TextBox txtCantidadTurnos;
        private Label label6;
    }
}
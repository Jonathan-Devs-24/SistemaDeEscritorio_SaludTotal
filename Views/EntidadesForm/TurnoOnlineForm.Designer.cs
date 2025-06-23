namespace Consultoria_SaludTotal.Views.EntidadesForm
{
    partial class TurnoOnlineForm
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
            dgvListaTurnOnline = new DataGridView();
            label1 = new Label();
            btnCancelar = new Button();
            btnAgendar = new Button();
            groupBox3 = new GroupBox();
            txtCantidadTurnos = new TextBox();
            label6 = new Label();
            txtObservaciones = new TextBox();
            label12 = new Label();
            btnAgendar1 = new Button();
            label4 = new Label();
            dtpFechaTurno = new DateTimePicker();
            label2 = new Label();
            label5 = new Label();
            cbProfesionales = new ComboBox();
            cbEspecialidades = new ComboBox();
            groupBox2 = new GroupBox();
            txtDNI = new TextBox();
            txtEspecialidad = new TextBox();
            label7 = new Label();
            label10 = new Label();
            txtIdPaciente = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListaTurnOnline).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvListaTurnOnline
            // 
            dgvListaTurnOnline.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaTurnOnline.Location = new Point(12, 37);
            dgvListaTurnOnline.Name = "dgvListaTurnOnline";
            dgvListaTurnOnline.RowHeadersWidth = 62;
            dgvListaTurnOnline.Size = new Size(1234, 243);
            dgvListaTurnOnline.TabIndex = 0;
            dgvListaTurnOnline.CellContentClick += dgvListaTurnOnline_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(255, 25);
            label1.TabIndex = 1;
            label1.Text = "Solicitudes de turnos recibidos";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(683, 656);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(139, 45);
            btnCancelar.TabIndex = 40;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgendar
            // 
            btnAgendar.Location = new Point(410, 656);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(139, 45);
            btnAgendar.TabIndex = 41;
            btnAgendar.Text = "Agendar";
            btnAgendar.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Honeydew;
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(txtCantidadTurnos);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtObservaciones);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(btnAgendar1);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(dtpFechaTurno);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(cbProfesionales);
            groupBox3.Controls.Add(cbEspecialidades);
            groupBox3.Location = new Point(98, 368);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1084, 253);
            groupBox3.TabIndex = 43;
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
            txtObservaciones.Location = new Point(637, 55);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(429, 147);
            txtObservaciones.TabIndex = 32;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(637, 27);
            label12.Name = "label12";
            label12.Size = new Size(132, 25);
            label12.TabIndex = 31;
            label12.Text = "Observaciones:";
            // 
            // btnAgendar1
            // 
            btnAgendar1.Location = new Point(361, 185);
            btnAgendar1.Name = "btnAgendar1";
            btnAgendar1.Size = new Size(132, 51);
            btnAgendar1.TabIndex = 2;
            btnAgendar1.Text = "Agendar";
            btnAgendar1.UseVisualStyleBackColor = true;
            btnAgendar1.Click += btnVolver_Click;
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
            dtpFechaTurno.Location = new Point(219, 148);
            dtpFechaTurno.MaxDate = new DateTime(2810, 12, 31, 0, 0, 0, 0);
            dtpFechaTurno.MinDate = new DateTime(2000, 9, 24, 0, 0, 0, 0);
            dtpFechaTurno.Name = "dtpFechaTurno";
            dtpFechaTurno.Size = new Size(209, 31);
            dtpFechaTurno.TabIndex = 27;
            dtpFechaTurno.Value = new DateTime(2025, 6, 16, 0, 0, 0, 0);
            dtpFechaTurno.ValueChanged += dtpFechaTurno_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 100);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 16;
            label2.Text = "Profesional:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 153);
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
            groupBox2.Controls.Add(txtDNI);
            groupBox2.Controls.Add(txtEspecialidad);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtIdPaciente);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(txtApellido);
            groupBox2.Location = new Point(70, 286);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1137, 76);
            groupBox2.TabIndex = 42;
            groupBox2.TabStop = false;
            groupBox2.Text = "Info. del paciente online";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(641, 30);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(126, 31);
            txtDNI.TabIndex = 31;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new Point(892, 27);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(192, 31);
            txtEspecialidad.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(773, 33);
            label7.Name = "label7";
            label7.Size = new Size(109, 25);
            label7.TabIndex = 30;
            label7.Text = "Especialidad";
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
            // txtIdPaciente
            // 
            txtIdPaciente.Location = new Point(53, 30);
            txtIdPaciente.Name = "txtIdPaciente";
            txtIdPaciente.Size = new Size(44, 31);
            txtIdPaciente.TabIndex = 12;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 33);
            label3.Name = "label3";
            label3.Size = new Size(34, 25);
            label3.TabIndex = 14;
            label3.Text = "ID:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(191, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(153, 31);
            txtNombre.TabIndex = 24;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(437, 30);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(145, 31);
            txtApellido.TabIndex = 24;
            // 
            // button1
            // 
            button1.Location = new Point(499, 185);
            button1.Name = "button1";
            button1.Size = new Size(132, 51);
            button1.TabIndex = 35;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TurnoOnlineForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 644);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgendar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(dgvListaTurnOnline);
            Name = "TurnoOnlineForm";
            Text = "TurnoOnlineForm";
            Load += TurnoOnlineForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaTurnOnline).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvListaTurnOnline;
        private Label label1;
        private Button btnCancelar;
        private Button btnAgendar;
        private GroupBox groupBox3;
        private TextBox txtCantidadTurnos;
        private Label label6;
        private TextBox txtObservaciones;
        private Label label12;
        private Label label4;
        private DateTimePicker dtpFechaTurno;
        private Label label2;
        private Label label5;
        private ComboBox cbProfesionales;
        private ComboBox cbEspecialidades;
        private GroupBox groupBox2;
        private TextBox txtEspecialidad;
        private Label label10;
        private TextBox txtIdPaciente;
        private Label label9;
        private Label label8;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Button btnAgendar1;
        private TextBox txtDNI;
        private Label label7;
        private Button button1;
    }
}
namespace Consultoria_SaludTotal.Views.EntidadesForm.TurnoForm
{
    partial class CrearTurnoForm
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
            label1 = new Label();
            dgvProfesionales = new DataGridView();
            label2 = new Label();
            cbDiaSemana = new ComboBox();
            txtHoraInicio = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtHoraFin = new TextBox();
            btnCrearTurno = new Button();
            btnCancelar = new Button();
            label5 = new Label();
            txtIDProfSelect = new TextBox();
            groupBox2 = new GroupBox();
            label6 = new Label();
            txtNombreProfSelect = new TextBox();
            label7 = new Label();
            txtApellidoProfSelect = new TextBox();
            label8 = new Label();
            txtEspecialidadProfSelect = new TextBox();
            label9 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProfesionales).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnCrearTurno);
            groupBox1.Controls.Add(txtHoraFin);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtHoraInicio);
            groupBox1.Controls.Add(cbDiaSemana);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dgvProfesionales);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(902, 383);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 36);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 0;
            label1.Text = "Profesional";
            // 
            // dgvProfesionales
            // 
            dgvProfesionales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProfesionales.Location = new Point(19, 64);
            dgvProfesionales.Name = "dgvProfesionales";
            dgvProfesionales.RowHeadersWidth = 62;
            dgvProfesionales.Size = new Size(377, 225);
            dgvProfesionales.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(402, 86);
            label2.Name = "label2";
            label2.Size = new Size(147, 25);
            label2.TabIndex = 2;
            label2.Text = "Dia de la semana";
            // 
            // cbDiaSemana
            // 
            cbDiaSemana.FormattingEnabled = true;
            cbDiaSemana.Location = new Point(555, 86);
            cbDiaSemana.Name = "cbDiaSemana";
            cbDiaSemana.Size = new Size(162, 33);
            cbDiaSemana.TabIndex = 3;
            // 
            // txtHoraInicio
            // 
            txtHoraInicio.Location = new Point(555, 146);
            txtHoraInicio.Name = "txtHoraInicio";
            txtHoraInicio.Size = new Size(73, 31);
            txtHoraInicio.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(402, 149);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 5;
            label3.Text = "Hora de inicio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(664, 149);
            label4.Name = "label4";
            label4.Size = new Size(76, 25);
            label4.TabIndex = 6;
            label4.Text = "Hora fin";
            // 
            // txtHoraFin
            // 
            txtHoraFin.Location = new Point(746, 146);
            txtHoraFin.Name = "txtHoraFin";
            txtHoraFin.Size = new Size(85, 31);
            txtHoraFin.TabIndex = 7;
            // 
            // btnCrearTurno
            // 
            btnCrearTurno.Location = new Point(495, 228);
            btnCrearTurno.Name = "btnCrearTurno";
            btnCrearTurno.Size = new Size(114, 46);
            btnCrearTurno.TabIndex = 8;
            btnCrearTurno.Text = "Crear";
            btnCrearTurno.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(694, 228);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(111, 46);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 36);
            label5.Name = "label5";
            label5.Size = new Size(34, 25);
            label5.TabIndex = 10;
            label5.Text = "ID:";
            // 
            // txtIDProfSelect
            // 
            txtIDProfSelect.Location = new Point(56, 33);
            txtIDProfSelect.Name = "txtIDProfSelect";
            txtIDProfSelect.Size = new Size(44, 31);
            txtIDProfSelect.TabIndex = 11;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtEspecialidadProfSelect);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtApellidoProfSelect);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtNombreProfSelect);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtIDProfSelect);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(19, 295);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(867, 70);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Info. del profesional seleccionado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(106, 36);
            label6.Name = "label6";
            label6.Size = new Size(82, 25);
            label6.TabIndex = 12;
            label6.Text = "Nombre:";
            // 
            // txtNombreProfSelect
            // 
            txtNombreProfSelect.Location = new Point(183, 33);
            txtNombreProfSelect.Name = "txtNombreProfSelect";
            txtNombreProfSelect.Size = new Size(150, 31);
            txtNombreProfSelect.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(350, 36);
            label7.Name = "label7";
            label7.Size = new Size(82, 25);
            label7.TabIndex = 14;
            label7.Text = "Apellido:";
            // 
            // txtApellidoProfSelect
            // 
            txtApellidoProfSelect.Location = new Point(430, 33);
            txtApellidoProfSelect.Name = "txtApellidoProfSelect";
            txtApellidoProfSelect.Size = new Size(150, 31);
            txtApellidoProfSelect.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(586, 36);
            label8.Name = "label8";
            label8.Size = new Size(113, 25);
            label8.TabIndex = 16;
            label8.Text = "Especialidad:";
            // 
            // txtEspecialidadProfSelect
            // 
            txtEspecialidadProfSelect.Location = new Point(701, 33);
            txtEspecialidadProfSelect.Name = "txtEspecialidadProfSelect";
            txtEspecialidadProfSelect.Size = new Size(150, 31);
            txtEspecialidadProfSelect.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(321, 0);
            label9.Name = "label9";
            label9.Size = new Size(217, 52);
            label9.TabIndex = 14;
            label9.Text = "Crear Turno";
            // 
            // CrearTurnoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 407);
            Controls.Add(groupBox1);
            Name = "CrearTurnoForm";
            Text = "CrearTurnoForm";
            Load += CrearTurnoForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProfesionales).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtHoraFin;
        private Label label4;
        private Label label3;
        private TextBox txtHoraInicio;
        private ComboBox cbDiaSemana;
        private Label label2;
        private DataGridView dgvProfesionales;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtApellidoProfSelect;
        private Label label7;
        private TextBox txtNombreProfSelect;
        private Label label6;
        private TextBox txtIDProfSelect;
        private Label label5;
        private Button btnCancelar;
        private Button btnCrearTurno;
        private TextBox txtEspecialidadProfSelect;
        private Label label8;
        private Label label9;
    }
}
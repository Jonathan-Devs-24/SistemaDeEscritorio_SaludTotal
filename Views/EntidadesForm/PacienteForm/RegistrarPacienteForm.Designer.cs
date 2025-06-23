namespace Consultoria_SaludTotal.Views.EntidadesForm.PacienteForm
{
    partial class RegistrarPacienteForm
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
            btnGuardar = new Button();
            groupBox1 = new GroupBox();
            label6 = new Label();
            btnAtrasMenuP = new Button();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            label7 = new Label();
            txtNombre = new TextBox();
            label5 = new Label();
            txtFechaNacimiento = new TextBox();
            txtApellido = new TextBox();
            txtTelefono = new TextBox();
            txtDNI = new TextBox();
            txtCorreo = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(213, 475);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(139, 45);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnAtrasMenuP);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtFechaNacimiento);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(txtDNI);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Location = new Point(79, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(831, 557);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(504, 359);
            label6.Name = "label6";
            label6.Size = new Size(79, 25);
            label6.TabIndex = 18;
            label6.Text = "Teléfono";
            // 
            // btnAtrasMenuP
            // 
            btnAtrasMenuP.Location = new Point(519, 475);
            btnAtrasMenuP.Name = "btnAtrasMenuP";
            btnAtrasMenuP.Size = new Size(139, 45);
            btnAtrasMenuP.TabIndex = 0;
            btnAtrasMenuP.Text = "Cancelar";
            btnAtrasMenuP.UseVisualStyleBackColor = true;
            btnAtrasMenuP.Click += btnAtrasMenuP_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(504, 231);
            label3.Name = "label3";
            label3.Size = new Size(174, 25);
            label3.TabIndex = 17;
            label3.Text = "Fecha de nacimiento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 231);
            label1.Name = "label1";
            label1.Size = new Size(43, 25);
            label1.TabIndex = 16;
            label1.Text = "DNI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(502, 120);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 15;
            label4.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195, 120);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 14;
            label2.Text = "Nombre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(271, 27);
            label7.Name = "label7";
            label7.Size = new Size(310, 52);
            label7.TabIndex = 13;
            label7.Text = "Registrar Paciente";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(195, 148);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(176, 31);
            txtNombre.TabIndex = 12;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(195, 359);
            label5.Name = "label5";
            label5.Size = new Size(71, 25);
            label5.TabIndex = 9;
            label5.Text = "Correo ";
            // 
            // txtFechaNacimiento
            // 
            txtFechaNacimiento.Location = new Point(502, 259);
            txtFechaNacimiento.Name = "txtFechaNacimiento";
            txtFechaNacimiento.Size = new Size(176, 31);
            txtFechaNacimiento.TabIndex = 2;
            txtFechaNacimiento.TextChanged += txtFechaNacimiento_TextChanged;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(502, 148);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(176, 31);
            txtApellido.TabIndex = 3;
            txtApellido.TextChanged += txtApellido_TextChanged;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(502, 387);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(176, 31);
            txtTelefono.TabIndex = 4;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(195, 259);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(176, 31);
            txtDNI.TabIndex = 5;
            txtDNI.TextChanged += txtDNI_TextChanged;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(195, 387);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(176, 31);
            txtCorreo.TabIndex = 6;
            txtCorreo.TextChanged += txtCorreo_TextChanged;
            // 
            // RegistrarPacienteForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 712);
            Controls.Add(groupBox1);
            Name = "RegistrarPacienteForm";
            Text = "RegistrarPacienteForm";
            Load += RegistrarPacienteForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGuardar;
        private GroupBox groupBox1;
        private TextBox txtFechaNacimiento;
        private TextBox txtApellido;
        private TextBox txtTelefono;
        private TextBox txtDNI;
        private TextBox txtCorreo;
        private Label label5;
        private Button btnAtrasMenuP;
        private TextBox txtNombre;
        private Label label4;
        private Label label2;
        private Label label7;
        private Label label1;
        private Label label3;
        private Label label6;
    }
}
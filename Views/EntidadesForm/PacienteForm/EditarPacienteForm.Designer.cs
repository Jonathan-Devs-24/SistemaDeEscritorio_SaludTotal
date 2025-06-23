namespace Consultoria_SaludTotal.Views.EntidadesForm.PacienteForm
{
    partial class EditarPacienteForm
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
            btnCancelar = new Button();
            txtCorreoR = new TextBox();
            txtDNIR = new TextBox();
            txtTelefonoR = new TextBox();
            txtApellidoR = new TextBox();
            txtFechaNacimientoR = new TextBox();
            label5 = new Label();
            txtNombreR = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            btnGuardarCambios = new Button();
            label7 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(519, 481);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(139, 45);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtCorreoR
            // 
            txtCorreoR.Location = new Point(195, 387);
            txtCorreoR.Name = "txtCorreoR";
            txtCorreoR.Size = new Size(176, 31);
            txtCorreoR.TabIndex = 6;
            // 
            // txtDNIR
            // 
            txtDNIR.Location = new Point(195, 259);
            txtDNIR.Name = "txtDNIR";
            txtDNIR.Size = new Size(176, 31);
            txtDNIR.TabIndex = 5;
            // 
            // txtTelefonoR
            // 
            txtTelefonoR.Location = new Point(502, 387);
            txtTelefonoR.Name = "txtTelefonoR";
            txtTelefonoR.Size = new Size(176, 31);
            txtTelefonoR.TabIndex = 4;
            // 
            // txtApellidoR
            // 
            txtApellidoR.Location = new Point(502, 148);
            txtApellidoR.Name = "txtApellidoR";
            txtApellidoR.Size = new Size(176, 31);
            txtApellidoR.TabIndex = 3;
            // 
            // txtFechaNacimientoR
            // 
            txtFechaNacimientoR.Location = new Point(502, 259);
            txtFechaNacimientoR.Name = "txtFechaNacimientoR";
            txtFechaNacimientoR.Size = new Size(176, 31);
            txtFechaNacimientoR.TabIndex = 2;
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
            // txtNombreR
            // 
            txtNombreR.Location = new Point(195, 148);
            txtNombreR.Name = "txtNombreR";
            txtNombreR.Size = new Size(176, 31);
            txtNombreR.TabIndex = 12;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(502, 120);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 15;
            label4.Text = "Apellido";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(504, 231);
            label3.Name = "label3";
            label3.Size = new Size(174, 25);
            label3.TabIndex = 17;
            label3.Text = "Fecha de nacimiento";
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
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGuardarCambios);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNombreR);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtFechaNacimientoR);
            groupBox1.Controls.Add(txtApellidoR);
            groupBox1.Controls.Add(txtTelefonoR);
            groupBox1.Controls.Add(txtDNIR);
            groupBox1.Controls.Add(txtCorreoR);
            groupBox1.Location = new Point(86, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(831, 557);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Location = new Point(215, 481);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(139, 45);
            btnGuardarCambios.TabIndex = 20;
            btnGuardarCambios.Text = "Guardar";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(291, 27);
            label7.Name = "label7";
            label7.Size = new Size(262, 52);
            label7.TabIndex = 19;
            label7.Text = "Editar Paciente";
            // 
            // EditarPacienteForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 697);
            Controls.Add(groupBox1);
            Name = "EditarPacienteForm";
            Text = "EditarPacienteForm";
            Load += EditarPacienteForm_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnCancelar;
        private TextBox txtCorreoR;
        private TextBox txtDNIR;
        private TextBox txtTelefonoR;
        private TextBox txtApellidoR;
        private TextBox txtFechaNacimientoR;
        private Label label5;
        private TextBox txtNombreR;
        private Label label2;
        private Label label4;
        private Label label1;
        private Label label3;
        private Label label6;
        private GroupBox groupBox1;
        private Label label7;
        private Button btnGuardarCambios;
    }
}
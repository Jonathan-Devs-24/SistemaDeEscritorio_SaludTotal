namespace Consultoria_SaludTotal.Views
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            groupBox1 = new GroupBox();
            pictureBox4 = new PictureBox();
            btnSolicitud = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnTurno = new Button();
            btnInforme = new Button();
            btnPaciente = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(btnSolicitud);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnTurno);
            groupBox1.Controls.Add(btnInforme);
            groupBox1.Controls.Add(btnPaciente);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(828, 283);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.agregar_usuario_1_;
            pictureBox4.Location = new Point(642, 92);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(132, 73);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // btnSolicitud
            // 
            btnSolicitud.Location = new Point(615, 173);
            btnSolicitud.Name = "btnSolicitud";
            btnSolicitud.Size = new Size(181, 48);
            btnSolicitud.TabIndex = 10;
            btnSolicitud.Text = "Solicitud de turno";
            btnSolicitud.UseVisualStyleBackColor = true;
            btnSolicitud.Click += btnSolicitud_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.maletin;
            pictureBox3.Location = new Point(430, 92);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(150, 75);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.calendario;
            pictureBox2.Location = new Point(231, 87);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(37, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(350, -3);
            label1.Name = "label1";
            label1.Size = new Size(118, 43);
            label1.TabIndex = 6;
            label1.Text = "Menú";
            // 
            // btnTurno
            // 
            btnTurno.Location = new Point(214, 173);
            btnTurno.Name = "btnTurno";
            btnTurno.Size = new Size(181, 48);
            btnTurno.TabIndex = 2;
            btnTurno.Text = "Turnos";
            btnTurno.UseVisualStyleBackColor = true;
            btnTurno.Click += btnTurno_Click_1;
            // 
            // btnInforme
            // 
            btnInforme.Location = new Point(411, 173);
            btnInforme.Name = "btnInforme";
            btnInforme.Size = new Size(181, 48);
            btnInforme.TabIndex = 3;
            btnInforme.Text = "Informes";
            btnInforme.UseVisualStyleBackColor = true;
            btnInforme.Click += btnInforme_Click;
            // 
            // btnPaciente
            // 
            btnPaciente.ImageAlign = ContentAlignment.TopLeft;
            btnPaciente.Location = new Point(21, 173);
            btnPaciente.Name = "btnPaciente";
            btnPaciente.Size = new Size(179, 48);
            btnPaciente.TabIndex = 5;
            btnPaciente.Text = "Pacientes";
            btnPaciente.UseVisualStyleBackColor = true;
            btnPaciente.Click += btnPaciente_Click_1;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(855, 308);
            Controls.Add(groupBox1);
            Name = "MenuForm";
            Text = "MenuForm";
            Load += MenuForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnTurno;
        private Button btnInforme;
        private Button btnPaciente;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private Button btnSolicitud;
    }
}
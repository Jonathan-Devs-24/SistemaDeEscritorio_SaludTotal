namespace Consultoria_SaludTotal.Views.EntidadesForm.InformeForm
{
    partial class TurnosAtendidosForm
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
            label5 = new Label();
            label4 = new Label();
            btnCanceladoReprogramado = new Button();
            btnTurnosAtendidos = new Button();
            label3 = new Label();
            dateTimePickerHasta = new DateTimePicker();
            dateTimePickerDesde = new DateTimePicker();
            dvgInfomes = new DataGridView();
            label2 = new Label();
            btnVolver = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgInfomes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnCanceladoReprogramado);
            groupBox1.Controls.Add(btnTurnosAtendidos);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dateTimePickerHasta);
            groupBox1.Controls.Add(dateTimePickerDesde);
            groupBox1.Controls.Add(dvgInfomes);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnVolver);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(15, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(864, 587);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 450);
            label5.Name = "label5";
            label5.Size = new Size(399, 25);
            label5.TabIndex = 14;
            label5.Text = "Cantidad de turnos cancelados y reprogramados";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 396);
            label4.Name = "label4";
            label4.Size = new Size(375, 25);
            label4.TabIndex = 13;
            label4.Text = "Cantidad de turnos atendidos por profesional";
            // 
            // btnCanceladoReprogramado
            // 
            btnCanceladoReprogramado.Location = new Point(412, 443);
            btnCanceladoReprogramado.Name = "btnCanceladoReprogramado";
            btnCanceladoReprogramado.Size = new Size(89, 38);
            btnCanceladoReprogramado.TabIndex = 12;
            btnCanceladoReprogramado.Text = "Ver";
            btnCanceladoReprogramado.UseVisualStyleBackColor = true;
            btnCanceladoReprogramado.Click += btnCanceladoReprogramado_Click;
            // 
            // btnTurnosAtendidos
            // 
            btnTurnosAtendidos.Location = new Point(412, 389);
            btnTurnosAtendidos.Name = "btnTurnosAtendidos";
            btnTurnosAtendidos.Size = new Size(89, 38);
            btnTurnosAtendidos.TabIndex = 2;
            btnTurnosAtendidos.Text = "Ver";
            btnTurnosAtendidos.UseVisualStyleBackColor = true;
            btnTurnosAtendidos.Click += btnTurnosAtendidos_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(351, 59);
            label3.Name = "label3";
            label3.Size = new Size(119, 25);
            label3.TabIndex = 11;
            label3.Text = "hasta la fecha";
            // 
            // dateTimePickerHasta
            // 
            dateTimePickerHasta.Format = DateTimePickerFormat.Custom;
            dateTimePickerHasta.Location = new Point(476, 51);
            dateTimePickerHasta.Name = "dateTimePickerHasta";
            dateTimePickerHasta.Size = new Size(137, 31);
            dateTimePickerHasta.TabIndex = 10;
            dateTimePickerHasta.Value = new DateTime(2025, 6, 22, 0, 0, 0, 0);
            dateTimePickerHasta.ValueChanged += dateTimePickerHasta_ValueChanged;
            // 
            // dateTimePickerDesde
            // 
            dateTimePickerDesde.Format = DateTimePickerFormat.Custom;
            dateTimePickerDesde.Location = new Point(204, 51);
            dateTimePickerDesde.Name = "dateTimePickerDesde";
            dateTimePickerDesde.Size = new Size(141, 31);
            dateTimePickerDesde.TabIndex = 9;
            dateTimePickerDesde.Value = new DateTime(2025, 6, 22, 0, 0, 0, 0);
            dateTimePickerDesde.ValueChanged += dateTimePickerDesde_ValueChanged;
            // 
            // dvgInfomes
            // 
            dvgInfomes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgInfomes.Location = new Point(14, 88);
            dvgInfomes.Name = "dvgInfomes";
            dvgInfomes.RowHeadersWidth = 62;
            dvgInfomes.Size = new Size(831, 289);
            dvgInfomes.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 58);
            label2.Name = "label2";
            label2.Size = new Size(184, 25);
            label2.TabIndex = 6;
            label2.Text = "Turnos desde la fecha";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(746, 547);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(112, 34);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.reloj;
            pictureBox1.Location = new Point(178, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 0);
            label1.Name = "label1";
            label1.Size = new Size(166, 44);
            label1.TabIndex = 1;
            label1.Text = "Informes";
            // 
            // TurnosAtendidosForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 611);
            Controls.Add(groupBox1);
            Name = "TurnosAtendidosForm";
            Text = "InformeMenuForm";
            Load += InformeMenuForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgInfomes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnTurnosAtendidos;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnVolver;
        private Label label2;
        private DataGridView dvgInfomes;
        private DateTimePicker dateTimePickerHasta;
        private DateTimePicker dateTimePickerDesde;
        private Label label3;
        private Button btnCanceladoReprogramado;
        private Label label4;
        private Label label5;
    }
}
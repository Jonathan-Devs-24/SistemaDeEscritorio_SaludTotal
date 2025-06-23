namespace Consultoria_SaludTotal.Views.EntidadesForm.PacienteForm
{
    partial class HistorialPacienteForm
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
            dgvHistorialTurno = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialTurno).BeginInit();
            SuspendLayout();
            // 
            // dgvHistorialTurno
            // 
            dgvHistorialTurno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorialTurno.Location = new Point(12, 78);
            dgvHistorialTurno.Name = "dgvHistorialTurno";
            dgvHistorialTurno.RowHeadersWidth = 62;
            dgvHistorialTurno.Size = new Size(776, 321);
            dgvHistorialTurno.TabIndex = 0;
            dgvHistorialTurno.CellContentClick += dgvHistorialTurno_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(293, 9);
            label1.Name = "label1";
            label1.Size = new Size(207, 25);
            label1.TabIndex = 1;
            label1.Text = "HISTORIAL DE PACIENTE";
            // 
            // HistorialPacienteForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dgvHistorialTurno);
            Name = "HistorialPacienteForm";
            Text = "HistorialPacienteForm";
            Load += HistorialPacienteForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistorialTurno).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvHistorialTurno;
        private Label label1;
    }
}
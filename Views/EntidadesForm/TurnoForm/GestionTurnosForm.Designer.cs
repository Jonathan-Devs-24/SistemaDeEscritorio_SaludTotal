namespace Consultoria_SaludTotal.Views.EntidadesForm.TurnoForm
{
    partial class GestionTurnosForm
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
            btnAtrasMenuTurno = new Button();
            btnRegistrarP = new Button();
            btnActualizar = new Button();
            dgvTurno = new DataGridView();
            button1 = new Button();
            label3 = new Label();
            txtIDBuscarT = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTurno).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAtrasMenuTurno);
            groupBox1.Controls.Add(btnRegistrarP);
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(dgvTurno);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtIDBuscarT);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(14, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1558, 688);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnAtrasMenuTurno
            // 
            btnAtrasMenuTurno.Location = new Point(7, 617);
            btnAtrasMenuTurno.Name = "btnAtrasMenuTurno";
            btnAtrasMenuTurno.Size = new Size(108, 44);
            btnAtrasMenuTurno.TabIndex = 17;
            btnAtrasMenuTurno.Text = "Atrás";
            btnAtrasMenuTurno.UseVisualStyleBackColor = true;
            btnAtrasMenuTurno.Click += btnAtrasMenuPac_Click;
            // 
            // btnRegistrarP
            // 
            btnRegistrarP.Location = new Point(6, 153);
            btnRegistrarP.Name = "btnRegistrarP";
            btnRegistrarP.Size = new Size(210, 44);
            btnRegistrarP.TabIndex = 19;
            btnRegistrarP.Text = "Agendar Nuevo Turno";
            btnRegistrarP.UseVisualStyleBackColor = true;
            btnRegistrarP.Click += btnRegistrarP_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(1437, 150);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(110, 47);
            btnActualizar.TabIndex = 18;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dgvTurno
            // 
            dgvTurno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTurno.Location = new Point(7, 205);
            dgvTurno.Name = "dgvTurno";
            dgvTurno.RowHeadersWidth = 62;
            dgvTurno.Size = new Size(1546, 406);
            dgvTurno.TabIndex = 16;
            dgvTurno.CellContentClick += dgvTurno_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(234, 153);
            button1.Name = "button1";
            button1.Size = new Size(108, 44);
            button1.TabIndex = 15;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(359, 132);
            label3.Name = "label3";
            label3.Size = new Size(119, 25);
            label3.TabIndex = 14;
            label3.Text = "Buscar por ID";
            label3.Click += label3_Click;
            // 
            // txtIDBuscarT
            // 
            txtIDBuscarT.Location = new Point(359, 160);
            txtIDBuscarT.Name = "txtIDBuscarT";
            txtIDBuscarT.Size = new Size(206, 31);
            txtIDBuscarT.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(562, 27);
            label1.Name = "label1";
            label1.Size = new Size(372, 53);
            label1.TabIndex = 12;
            label1.Text = "Gestión de Turnos";
            // 
            // GestionTurnosForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 712);
            Controls.Add(groupBox1);
            Name = "GestionTurnosForm";
            Text = "GestionTurnosForm";
            Load += GestionTurnosForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTurno).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnLimpiar;
        private Button button2;
        private Button btnAtrasMenuTurno;
        private Button btnRegistrarP;
        private Button btnActualizar;
        private DataGridView dgvTurno;
        private Button button1;
        private Label label3;
        private TextBox txtIDBuscarT;
        private Label label1;
    }
}
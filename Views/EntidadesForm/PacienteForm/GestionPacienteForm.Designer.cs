namespace Consultoria_SaludTotal.Views.EntidadesForm.PacienteForm
{
    partial class GestionPacienteForm
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
            btnLimpiar = new Button();
            btnAtrasMenuPac = new Button();
            btnRegistrarP = new Button();
            btnVerTodo = new Button();
            dvgPacienteID = new DataGridView();
            button1 = new Button();
            label3 = new Label();
            txtIDBuscarP = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgPacienteID).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnAtrasMenuPac);
            groupBox1.Controls.Add(btnRegistrarP);
            groupBox1.Controls.Add(btnVerTodo);
            groupBox1.Controls.Add(dvgPacienteID);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtIDBuscarP);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1558, 688);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(1442, 163);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(110, 47);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnAtrasMenuPac
            // 
            btnAtrasMenuPac.Location = new Point(6, 638);
            btnAtrasMenuPac.Name = "btnAtrasMenuPac";
            btnAtrasMenuPac.Size = new Size(108, 44);
            btnAtrasMenuPac.TabIndex = 8;
            btnAtrasMenuPac.Text = "Atrás";
            btnAtrasMenuPac.UseVisualStyleBackColor = true;
            btnAtrasMenuPac.Click += btnAtrasMenuPac_Click;
            // 
            // btnRegistrarP
            // 
            btnRegistrarP.Location = new Point(6, 166);
            btnRegistrarP.Name = "btnRegistrarP";
            btnRegistrarP.Size = new Size(108, 44);
            btnRegistrarP.TabIndex = 9;
            btnRegistrarP.Text = "Registrar";
            btnRegistrarP.UseVisualStyleBackColor = true;
            btnRegistrarP.Click += btnRegistrarP_Click;
            // 
            // btnVerTodo
            // 
            btnVerTodo.Location = new Point(1310, 163);
            btnVerTodo.Name = "btnVerTodo";
            btnVerTodo.Size = new Size(110, 47);
            btnVerTodo.TabIndex = 8;
            btnVerTodo.Text = "Ver Todo";
            btnVerTodo.UseVisualStyleBackColor = true;
            btnVerTodo.Click += btnVerTodo_Click;
            // 
            // dvgPacienteID
            // 
            dvgPacienteID.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgPacienteID.Location = new Point(6, 216);
            dvgPacienteID.Name = "dvgPacienteID";
            dvgPacienteID.RowHeadersWidth = 62;
            dvgPacienteID.Size = new Size(1546, 406);
            dvgPacienteID.TabIndex = 7;
            dvgPacienteID.CellContentClick += dvgPacienteID_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(188, 166);
            button1.Name = "button1";
            button1.Size = new Size(108, 44);
            button1.TabIndex = 5;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnBuscarP_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(313, 151);
            label3.Name = "label3";
            label3.Size = new Size(143, 25);
            label3.TabIndex = 4;
            label3.Text = "Buscar por fecha";
            // 
            // txtIDBuscarP
            // 
            txtIDBuscarP.Location = new Point(313, 179);
            txtIDBuscarP.Name = "txtIDBuscarP";
            txtIDBuscarP.Size = new Size(206, 31);
            txtIDBuscarP.TabIndex = 3;
            txtIDBuscarP.TextChanged += txtIDBuscarP_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(587, 27);
            label1.Name = "label1";
            label1.Size = new Size(418, 53);
            label1.TabIndex = 1;
            label1.Text = "Gestión de Pacientes";
            // 
            // GestionPacienteForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 712);
            Controls.Add(groupBox1);
            Name = "GestionPacienteForm";
            Text = "PacienteVerIDForm";
            Load += PacienteVerIDForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgPacienteID).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button btnLimpiar;
        private Button btnAtrasMenuPac;
        private Button btnRegistrarP;
        private Button btnVerTodo;
        private DataGridView dvgPacienteID;
        private Button button1;
        private TextBox txtIDBuscarP;
        private Label label1;
        private Label label3;
    }
}
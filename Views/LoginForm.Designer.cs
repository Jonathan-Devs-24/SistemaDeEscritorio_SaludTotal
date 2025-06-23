namespace Consultoria_SaludTotal.Views
{
    partial class LoginForm
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
            txtUser = new TextBox();
            txtPass = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnIniciar = new Button();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Location = new Point(95, 216);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(225, 31);
            txtUser.TabIndex = 0;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(95, 296);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(225, 31);
            txtPass.TabIndex = 0;
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 268);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 25);
            label3.Name = "label3";
            label3.Size = new Size(298, 44);
            label3.TabIndex = 2;
            label3.Text = "Iniciar Sesión";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(95, 188);
            label4.Name = "label4";
            label4.Size = new Size(72, 25);
            label4.TabIndex = 1;
            label4.Text = "Usuario";
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.FromArgb(192, 255, 192);
            btnIniciar.Location = new Point(77, 362);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(255, 45);
            btnIniciar.TabIndex = 3;
            btnIniciar.Text = "INICIAR";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(77, 507);
            label6.Name = "label6";
            label6.Size = new Size(276, 25);
            label6.TabIndex = 5;
            label6.Text = "Metodología de Sistemas I - TPI  ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.SaludTotalTPI;
            pictureBox1.Location = new Point(131, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 541);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(btnIniciar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private TextBox txtPass;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnIniciar;
        private Label label6;
        private PictureBox pictureBox1;
    }
}
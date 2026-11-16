namespace Presentación
{
    partial class FormLogin
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            textUsuario = new TextBox();
            textContraseña = new TextBox();
            BotonIngresar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(241, 244, 248);
            panel1.Controls.Add(BotonIngresar);
            panel1.Controls.Add(textContraseña);
            panel1.Controls.Add(textUsuario);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(125, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(574, 379);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(18, 59, 101);
            label2.Location = new Point(87, 28);
            label2.Name = "label2";
            label2.Size = new Size(408, 50);
            label2.TabIndex = 1;
            label2.Text = "Sistema de Salud AHG";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(18, 59, 101);
            label1.Location = new Point(189, 78);
            label1.Name = "label1";
            label1.Size = new Size(205, 41);
            label1.TabIndex = 2;
            label1.Text = "Iniciar Sesión";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(47, 176);
            label3.Name = "label3";
            label3.Size = new Size(94, 31);
            label3.TabIndex = 3;
            label3.Text = "Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(47, 236);
            label4.Name = "label4";
            label4.Size = new Size(131, 31);
            label4.TabIndex = 4;
            label4.Text = "Contraseña";
            // 
            // textUsuario
            // 
            textUsuario.Location = new Point(208, 180);
            textUsuario.Name = "textUsuario";
            textUsuario.Size = new Size(311, 27);
            textUsuario.TabIndex = 5;
            // 
            // textContraseña
            // 
            textContraseña.Location = new Point(208, 240);
            textContraseña.Name = "textContraseña";
            textContraseña.PasswordChar = '*';
            textContraseña.Size = new Size(311, 27);
            textContraseña.TabIndex = 6;
            // 
            // BotonIngresar
            // 
            BotonIngresar.BackColor = Color.FromArgb(40, 120, 184);
            BotonIngresar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonIngresar.ForeColor = Color.White;
            BotonIngresar.Location = new Point(219, 291);
            BotonIngresar.Name = "BotonIngresar";
            BotonIngresar.Size = new Size(160, 60);
            BotonIngresar.TabIndex = 7;
            BotonIngresar.Text = "Ingresar";
            BotonIngresar.UseVisualStyleBackColor = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 59, 101);
            ClientSize = new Size(839, 512);
            Controls.Add(panel1);
            Name = "FormLogin";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button BotonIngresar;
        private TextBox textContraseña;
        private TextBox textUsuario;
        private Label label4;
        private Label label3;
        private Label label1;
    }
}
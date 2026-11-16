namespace Presentación
{
    partial class FormMenu
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
            BotonCerrarSesion = new Button();
            BotonUsuarios = new Button();
            BotonEstablecimientos = new Button();
            labelUsuario = new Label();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(241, 244, 248);
            panel1.Controls.Add(BotonCerrarSesion);
            panel1.Controls.Add(BotonUsuarios);
            panel1.Controls.Add(BotonEstablecimientos);
            panel1.Controls.Add(labelUsuario);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(95, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(610, 360);
            panel1.TabIndex = 0;
            // 
            // BotonCerrarSesion
            // 
            BotonCerrarSesion.BackColor = Color.FromArgb(192, 57, 43);
            BotonCerrarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonCerrarSesion.ForeColor = Color.White;
            BotonCerrarSesion.Location = new Point(205, 282);
            BotonCerrarSesion.Name = "BotonCerrarSesion";
            BotonCerrarSesion.Size = new Size(200, 50);
            BotonCerrarSesion.TabIndex = 5;
            BotonCerrarSesion.Text = "Cerrar Sesión";
            BotonCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // BotonUsuarios
            // 
            BotonUsuarios.BackColor = Color.FromArgb(40, 120, 184);
            BotonUsuarios.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonUsuarios.ForeColor = Color.White;
            BotonUsuarios.Location = new Point(205, 216);
            BotonUsuarios.Name = "BotonUsuarios";
            BotonUsuarios.Size = new Size(200, 50);
            BotonUsuarios.TabIndex = 4;
            BotonUsuarios.Text = "Usuarios";
            BotonUsuarios.UseVisualStyleBackColor = false;
            // 
            // BotonEstablecimientos
            // 
            BotonEstablecimientos.BackColor = Color.FromArgb(40, 120, 184);
            BotonEstablecimientos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonEstablecimientos.ForeColor = Color.White;
            BotonEstablecimientos.Location = new Point(205, 150);
            BotonEstablecimientos.Name = "BotonEstablecimientos";
            BotonEstablecimientos.Size = new Size(200, 50);
            BotonEstablecimientos.TabIndex = 3;
            BotonEstablecimientos.Text = "Establecimientos";
            BotonEstablecimientos.UseVisualStyleBackColor = false;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsuario.ForeColor = Color.Black;
            labelUsuario.Location = new Point(52, 108);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(79, 28);
            labelUsuario.TabIndex = 2;
            labelUsuario.Text = "Usuario";
            labelUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(18, 59, 101);
            label1.Location = new Point(205, 64);
            label1.Name = "label1";
            label1.Size = new Size(231, 41);
            label1.TabIndex = 1;
            label1.Text = "Menú Principal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(18, 59, 101);
            label2.Location = new Point(101, 14);
            label2.Name = "label2";
            label2.Size = new Size(408, 50);
            label2.TabIndex = 0;
            label2.Text = "Sistema de Salud AHG";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 59, 101);
            ClientSize = new Size(800, 480);
            Controls.Add(panel1);
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label labelUsuario;
        private Button BotonEstablecimientos;
        private Button BotonUsuarios;
        private Button BotonCerrarSesion;
    }
}
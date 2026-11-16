namespace Presentación
{
    partial class FormUsuarios
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
            dataGridView1 = new DataGridView();
            BotonVolver = new Button();
            BotonActualizarLista = new Button();
            textBoxIdProvincia = new TextBox();
            textBoxRol = new TextBox();
            textBoxUsuario = new TextBox();
            textBoxNombre = new TextBox();
            textBoxId = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(241, 244, 248);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(BotonVolver);
            panel1.Controls.Add(BotonActualizarLista);
            panel1.Controls.Add(textBoxIdProvincia);
            panel1.Controls.Add(textBoxRol);
            panel1.Controls.Add(textBoxUsuario);
            panel1.Controls.Add(textBoxNombre);
            panel1.Controls.Add(textBoxId);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(25, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 560);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 300);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(900, 235);
            dataGridView1.TabIndex = 14;
            // 
            // BotonVolver
            // 
            BotonVolver.BackColor = Color.FromArgb(18, 59, 101);
            BotonVolver.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonVolver.ForeColor = Color.White;
            BotonVolver.Location = new Point(780, 245);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(145, 40);
            BotonVolver.TabIndex = 13;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = false;
            // 
            // BotonActualizarLista
            // 
            BotonActualizarLista.BackColor = Color.FromArgb(40, 120, 184);
            BotonActualizarLista.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonActualizarLista.ForeColor = Color.White;
            BotonActualizarLista.Location = new Point(595, 245);
            BotonActualizarLista.Name = "BotonActualizarLista";
            BotonActualizarLista.Size = new Size(145, 40);
            BotonActualizarLista.TabIndex = 12;
            BotonActualizarLista.Text = "Actualizar";
            BotonActualizarLista.UseVisualStyleBackColor = false;
            // 
            // textBoxIdProvincia
            // 
            textBoxIdProvincia.Location = new Point(645, 190);
            textBoxIdProvincia.Name = "textBoxIdProvincia";
            textBoxIdProvincia.ReadOnly = true;
            textBoxIdProvincia.Size = new Size(260, 27);
            textBoxIdProvincia.TabIndex = 11;
            // 
            // textBoxRol
            // 
            textBoxRol.Location = new Point(645, 145);
            textBoxRol.Name = "textBoxRol";
            textBoxRol.ReadOnly = true;
            textBoxRol.Size = new Size(260, 27);
            textBoxRol.TabIndex = 10;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(150, 190);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.ReadOnly = true;
            textBoxUsuario.Size = new Size(300, 27);
            textBoxUsuario.TabIndex = 9;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(150, 145);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.ReadOnly = true;
            textBoxNombre.Size = new Size(300, 27);
            textBoxNombre.TabIndex = 8;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(150, 100);
            textBoxId.Name = "textBoxId";
            textBoxId.ReadOnly = true;
            textBoxId.Size = new Size(120, 27);
            textBoxId.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(500, 188);
            label7.Name = "label7";
            label7.Size = new Size(123, 28);
            label7.TabIndex = 6;
            label7.Text = "Id Provincia";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(500, 143);
            label6.Name = "label6";
            label6.Size = new Size(43, 28);
            label6.TabIndex = 5;
            label6.Text = "Rol";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(40, 188);
            label5.Name = "label5";
            label5.Size = new Size(82, 28);
            label5.TabIndex = 4;
            label5.Text = "Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(40, 143);
            label4.Name = "label4";
            label4.Size = new Size(87, 28);
            label4.TabIndex = 3;
            label4.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(40, 98);
            label3.Name = "label3";
            label3.Size = new Size(30, 28);
            label3.TabIndex = 2;
            label3.Text = "Id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(18, 59, 101);
            label1.Location = new Point(350, 45);
            label1.Name = "label1";
            label1.Size = new Size(252, 41);
            label1.TabIndex = 1;
            label1.Text = "Gestión Usuarios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(18, 59, 101);
            label2.Location = new Point(271, 0);
            label2.Name = "label2";
            label2.Size = new Size(408, 50);
            label2.TabIndex = 0;
            label2.Text = "Sistema de Salud AHG";
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 59, 101);
            ClientSize = new Size(1000, 610);
            Controls.Add(panel1);
            Name = "FormUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuarios";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxId;
        private TextBox textBoxNombre;
        private TextBox textBoxUsuario;
        private TextBox textBoxRol;
        private TextBox textBoxIdProvincia;
        private Button BotonActualizarLista;
        private Button BotonVolver;
        private DataGridView dataGridView1;
    }
}
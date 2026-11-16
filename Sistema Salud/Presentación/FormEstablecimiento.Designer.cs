namespace Presentación
{
    partial class FormEstablecimiento
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
            comboBoxProvincia = new ComboBox();
            comboBoxTipo = new ComboBox();
            dataGridView1 = new DataGridView();
            BotonVolver = new Button();
            BotonLimpiar = new Button();
            BotonEliminar = new Button();
            BotonActualizar = new Button();
            BotonRegistrar = new Button();
            textBoxTelefono = new TextBox();
            textBoxDireccion = new TextBox();
            textBoxNombre = new TextBox();
            textBoxId = new TextBox();
            label8 = new Label();
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
            panel1.Controls.Add(comboBoxProvincia);
            panel1.Controls.Add(comboBoxTipo);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(BotonVolver);
            panel1.Controls.Add(BotonLimpiar);
            panel1.Controls.Add(BotonEliminar);
            panel1.Controls.Add(BotonActualizar);
            panel1.Controls.Add(BotonRegistrar);
            panel1.Controls.Add(textBoxTelefono);
            panel1.Controls.Add(textBoxDireccion);
            panel1.Controls.Add(textBoxNombre);
            panel1.Controls.Add(textBoxId);
            panel1.Controls.Add(label8);
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
            // comboBoxProvincia
            // 
            comboBoxProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProvincia.FormattingEnabled = true;
            comboBoxProvincia.Location = new Point(645, 190);
            comboBoxProvincia.Name = "comboBoxProvincia";
            comboBoxProvincia.Size = new Size(260, 28);
            comboBoxProvincia.TabIndex = 10;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Location = new Point(645, 145);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(260, 28);
            comboBoxTipo.TabIndex = 9;
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
            dataGridView1.TabIndex = 17;
            // 
            // BotonVolver
            // 
            BotonVolver.BackColor = Color.FromArgb(18, 59, 101);
            BotonVolver.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonVolver.ForeColor = Color.White;
            BotonVolver.Location = new Point(780, 245);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(145, 40);
            BotonVolver.TabIndex = 16;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = false;
            // 
            // BotonLimpiar
            // 
            BotonLimpiar.BackColor = Color.FromArgb(40, 120, 184);
            BotonLimpiar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonLimpiar.ForeColor = Color.White;
            BotonLimpiar.Location = new Point(595, 245);
            BotonLimpiar.Name = "BotonLimpiar";
            BotonLimpiar.Size = new Size(145, 40);
            BotonLimpiar.TabIndex = 15;
            BotonLimpiar.Text = "Limpiar";
            BotonLimpiar.UseVisualStyleBackColor = false;
            // 
            // BotonEliminar
            // 
            BotonEliminar.BackColor = Color.FromArgb(192, 57, 43);
            BotonEliminar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonEliminar.ForeColor = Color.White;
            BotonEliminar.Location = new Point(410, 245);
            BotonEliminar.Name = "BotonEliminar";
            BotonEliminar.Size = new Size(145, 40);
            BotonEliminar.TabIndex = 14;
            BotonEliminar.Text = "Eliminar";
            BotonEliminar.UseVisualStyleBackColor = false;
            // 
            // BotonActualizar
            // 
            BotonActualizar.BackColor = Color.FromArgb(40, 120, 184);
            BotonActualizar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonActualizar.ForeColor = Color.White;
            BotonActualizar.Location = new Point(225, 245);
            BotonActualizar.Name = "BotonActualizar";
            BotonActualizar.Size = new Size(145, 40);
            BotonActualizar.TabIndex = 13;
            BotonActualizar.Text = "Actualizar";
            BotonActualizar.UseVisualStyleBackColor = false;
            // 
            // BotonRegistrar
            // 
            BotonRegistrar.BackColor = Color.FromArgb(40, 120, 184);
            BotonRegistrar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonRegistrar.ForeColor = Color.White;
            BotonRegistrar.Location = new Point(40, 245);
            BotonRegistrar.Name = "BotonRegistrar";
            BotonRegistrar.Size = new Size(145, 40);
            BotonRegistrar.TabIndex = 12;
            BotonRegistrar.Text = "Registrar";
            BotonRegistrar.UseVisualStyleBackColor = false;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(150, 190);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(300, 27);
            textBoxTelefono.TabIndex = 8;
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Location = new Point(150, 145);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(300, 27);
            textBoxDireccion.TabIndex = 7;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(150, 100);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(300, 27);
            textBoxNombre.TabIndex = 6;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(645, 100);
            textBoxId.Name = "textBoxId";
            textBoxId.ReadOnly = true;
            textBoxId.Size = new Size(120, 27);
            textBoxId.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(500, 188);
            label8.Name = "label8";
            label8.Size = new Size(97, 28);
            label8.TabIndex = 5;
            label8.Text = "Provincia";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(500, 143);
            label7.Name = "label7";
            label7.Size = new Size(52, 28);
            label7.TabIndex = 4;
            label7.Text = "Tipo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(40, 188);
            label6.Name = "label6";
            label6.Size = new Size(90, 28);
            label6.TabIndex = 3;
            label6.Text = "Teléfono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(40, 143);
            label5.Name = "label5";
            label5.Size = new Size(95, 28);
            label5.TabIndex = 2;
            label5.Text = "Dirección";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(40, 98);
            label4.Name = "label4";
            label4.Size = new Size(87, 28);
            label4.TabIndex = 1;
            label4.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(500, 98);
            label3.Name = "label3";
            label3.Size = new Size(30, 28);
            label3.TabIndex = 18;
            label3.Text = "Id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(18, 59, 101);
            label1.Location = new Point(300, 45);
            label1.Name = "label1";
            label1.Size = new Size(347, 41);
            label1.TabIndex = 0;
            label1.Text = "Gestión Establecimientos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(18, 59, 101);
            label2.Location = new Point(271, 0);
            label2.Name = "label2";
            label2.Size = new Size(408, 50);
            label2.TabIndex = 19;
            label2.Text = "Sistema de Salud AHG";
            // 
            // FormEstablecimiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 59, 101);
            ClientSize = new Size(1000, 610);
            Controls.Add(panel1);
            Name = "FormEstablecimiento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Establecimientos";
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
        private Label label8;
        private TextBox textBoxId;
        private TextBox textBoxNombre;
        private TextBox textBoxDireccion;
        private TextBox textBoxTelefono;
        private ComboBox comboBoxTipo;
        private ComboBox comboBoxProvincia;
        private Button BotonRegistrar;
        private Button BotonActualizar;
        private Button BotonEliminar;
        private Button BotonLimpiar;
        private Button BotonVolver;
        private DataGridView dataGridView1;
    }
}
namespace CapaPresentacion
{
    partial class FrmTransacciones
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
            label1 = new Label();
            btnEliminar = new Button();
            dgvTransacciones = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            btnFiltrar = new Button();
            dtpFecha = new DateTimePicker();
            comboCategoria = new ComboBox();
            panel6 = new Panel();
            panel1 = new Panel();
            checkUsarFecha = new CheckBox();
            panel2 = new Panel();
            btnAgregar = new Button();
            panel3 = new Panel();
            comboMetodoPago = new ComboBox();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboCategorias = new ComboBox();
            comboTipo = new ComboBox();
            panel4 = new Panel();
            label7 = new Label();
            txtMonto = new NumericUpDown();
            label8 = new Label();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtNota = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvTransacciones).BeginInit();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtMonto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(225, 46);
            label1.TabIndex = 0;
            label1.Text = "Transacciones";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(137, 36);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvTransacciones
            // 
            dgvTransacciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransacciones.Location = new Point(300, 207);
            dgvTransacciones.Name = "dgvTransacciones";
            dgvTransacciones.RowHeadersWidth = 51;
            dgvTransacciones.Size = new Size(626, 293);
            dgvTransacciones.TabIndex = 5;
            dgvTransacciones.CellClick += dgvTransacciones_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(20, 30);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 6;
            label2.Text = "Fecha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(502, 27);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 7;
            label3.Text = "Categoria";
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(797, 26);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(94, 29);
            btnFiltrar.TabIndex = 8;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(104, 23);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(250, 27);
            dtpFecha.TabIndex = 9;
            // 
            // comboCategoria
            // 
            comboCategoria.FormattingEnabled = true;
            comboCategoria.Location = new Point(603, 23);
            comboCategoria.Name = "comboCategoria";
            comboCategoria.Size = new Size(161, 28);
            comboCategoria.TabIndex = 10;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(50, 50, 50);
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label1);
            panel6.Location = new Point(-5, 1);
            panel6.Name = "panel6";
            panel6.Size = new Size(946, 81);
            panel6.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 50, 50);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(checkUsarFecha);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dtpFecha);
            panel1.Controls.Add(btnFiltrar);
            panel1.Controls.Add(comboCategoria);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-5, 109);
            panel1.Name = "panel1";
            panel1.Size = new Size(946, 81);
            panel1.TabIndex = 13;
            // 
            // checkUsarFecha
            // 
            checkUsarFecha.AutoSize = true;
            checkUsarFecha.ForeColor = SystemColors.Control;
            checkUsarFecha.Location = new Point(360, 25);
            checkUsarFecha.Name = "checkUsarFecha";
            checkUsarFecha.Size = new Size(102, 24);
            checkUsarFecha.TabIndex = 11;
            checkUsarFecha.Text = "Usar Fecha";
            checkUsarFecha.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 50, 50);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnAgregar);
            panel2.Controls.Add(btnEliminar);
            panel2.Location = new Point(360, 510);
            panel2.Name = "panel2";
            panel2.Size = new Size(291, 94);
            panel2.TabIndex = 14;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(26, 36);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 17;
            btnAgregar.Text = "Guardar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(50, 50, 50);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(comboMetodoPago);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(comboCategorias);
            panel3.Controls.Add(comboTipo);
            panel3.Location = new Point(12, 207);
            panel3.Name = "panel3";
            panel3.Size = new Size(282, 293);
            panel3.TabIndex = 15;
            // 
            // comboMetodoPago
            // 
            comboMetodoPago.FormattingEnabled = true;
            comboMetodoPago.Location = new Point(15, 225);
            comboMetodoPago.Name = "comboMetodoPago";
            comboMetodoPago.Size = new Size(233, 28);
            comboMetodoPago.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(15, 188);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 11;
            label6.Text = "Metodo de pago";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(15, 19);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 8;
            label4.Text = "Tipo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(15, 101);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 9;
            label5.Text = "Categoria";
            // 
            // comboCategorias
            // 
            comboCategorias.FormattingEnabled = true;
            comboCategorias.Location = new Point(15, 137);
            comboCategorias.Name = "comboCategorias";
            comboCategorias.Size = new Size(233, 28);
            comboCategorias.TabIndex = 0;
            // 
            // comboTipo
            // 
            comboTipo.FormattingEnabled = true;
            comboTipo.Location = new Point(15, 57);
            comboTipo.Name = "comboTipo";
            comboTipo.Size = new Size(233, 28);
            comboTipo.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(50, 50, 50);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label7);
            panel4.Controls.Add(txtMonto);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(dateTimePicker1);
            panel4.Controls.Add(txtNota);
            panel4.Location = new Point(8, 510);
            panel4.Name = "panel4";
            panel4.Size = new Size(346, 166);
            panel4.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(15, 108);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 14;
            label7.Text = "Fecha";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(83, 19);
            txtMonto.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(181, 27);
            txtMonto.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(15, 19);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 8;
            label8.Text = "Monto";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(15, 60);
            label9.Name = "label9";
            label9.Size = new Size(42, 20);
            label9.TabIndex = 9;
            label9.Text = "Nota";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(83, 101);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(249, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // txtNota
            // 
            txtNota.Location = new Point(83, 60);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(181, 27);
            txtNota.TabIndex = 6;
            // 
            // FrmTransacciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(943, 687);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel6);
            Controls.Add(dgvTransacciones);
            Name = "FrmTransacciones";
            Text = "Transacciones";
            Load += FrmTransacciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTransacciones).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtMonto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnEliminar;
        private DataGridView dgvTransacciones;
        private Label label2;
        private Label label3;
        private Button btnFiltrar;
        private DateTimePicker dtpFecha;
        private ComboBox comboCategoria;
        private Panel panel6;
        private Panel panel1;
        private Panel panel2;
        private CheckBox checkUsarFecha;
        private Panel panel3;
        private ComboBox comboMetodoPago;
        private Label label6;
        private Label label4;
        private Label label5;
        private ComboBox comboCategorias;
        private ComboBox comboTipo;
        private Panel panel4;
        private Label label7;
        private NumericUpDown txtMonto;
        private Label label8;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private TextBox txtNota;
        private Button btnAgregar;
    }
}
namespace CapaPresentacion
{
    partial class FrmPresupuestos
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
            nuevo = new Button();
            editar = new Button();
            eliminar = new Button();
            dataGridView1 = new DataGridView();
            progressBar1 = new ProgressBar();
            dgvPresupuestos = new DataGridView();
            btnGuardar = new Button();
            btnEliminar = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label2 = new Label();
            cmbCategoria = new ComboBox();
            panel6 = new Panel();
            dtpFin = new DateTimePicker();
            dtpInicio = new DateTimePicker();
            nudMonto = new NumericUpDown();
            cmbPeriodo = new ComboBox();
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPresupuestos).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMonto).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(376, 46);
            label1.TabIndex = 0;
            label1.Text = "Gestión de presupuesto";
            // 
            // nuevo
            // 
            nuevo.Location = new Point(12, 74);
            nuevo.Name = "nuevo";
            nuevo.Size = new Size(94, 29);
            nuevo.TabIndex = 1;
            nuevo.Text = "Nuevo";
            nuevo.UseVisualStyleBackColor = true;
            // 
            // editar
            // 
            editar.Location = new Point(131, 74);
            editar.Name = "editar";
            editar.Size = new Size(94, 29);
            editar.TabIndex = 2;
            editar.Text = "Editar";
            editar.UseVisualStyleBackColor = true;
            // 
            // eliminar
            // 
            eliminar.Location = new Point(245, 74);
            eliminar.Name = "eliminar";
            eliminar.Size = new Size(94, 29);
            eliminar.TabIndex = 3;
            eliminar.Text = "Eliminar";
            eliminar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 124);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(763, 188);
            dataGridView1.TabIndex = 4;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 350);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(286, 29);
            progressBar1.TabIndex = 5;
            // 
            // dgvPresupuestos
            // 
            dgvPresupuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPresupuestos.Location = new Point(429, 101);
            dgvPresupuestos.Name = "dgvPresupuestos";
            dgvPresupuestos.RowHeadersWidth = 51;
            dgvPresupuestos.Size = new Size(567, 309);
            dgvPresupuestos.TabIndex = 0;
            dgvPresupuestos.CellClick += dgvPresupuestos_CellClick;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(16, 263);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Nuevo";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(128, 263);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(15, 12);
            label2.Name = "label2";
            label2.Size = new Size(219, 46);
            label2.TabIndex = 4;
            label2.Text = "Presupuestos";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(114, 200);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(151, 28);
            cmbCategoria.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(50, 50, 50);
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label2);
            panel6.Location = new Point(0, 1);
            panel6.Name = "panel6";
            panel6.Size = new Size(1020, 81);
            panel6.TabIndex = 12;
            // 
            // dtpFin
            // 
            dtpFin.Location = new Point(114, 57);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(250, 27);
            dtpFin.TabIndex = 13;
            // 
            // dtpInicio
            // 
            dtpInicio.Location = new Point(114, 17);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(250, 27);
            dtpInicio.TabIndex = 14;
            // 
            // nudMonto
            // 
            nudMonto.Location = new Point(114, 100);
            nudMonto.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudMonto.Name = "nudMonto";
            nudMonto.Size = new Size(150, 27);
            nudMonto.TabIndex = 15;
            // 
            // cmbPeriodo
            // 
            cmbPeriodo.FormattingEnabled = true;
            cmbPeriodo.Location = new Point(113, 146);
            cmbPeriodo.Name = "cmbPeriodo";
            cmbPeriodo.Size = new Size(151, 28);
            cmbPeriodo.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 50, 50);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(cmbPeriodo);
            panel1.Controls.Add(dtpFin);
            panel1.Controls.Add(nudMonto);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(cmbCategoria);
            panel1.Controls.Add(dtpInicio);
            panel1.Location = new Point(12, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 309);
            panel1.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 208);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 21;
            label7.Text = "Categoria";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 154);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 20;
            label6.Text = "Periodo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 100);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 19;
            label5.Text = "Monto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 57);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 18;
            label4.Text = "Fecha Fin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 22);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 17;
            label3.Text = "Fecha Inicio";
            // 
            // FrmPresupuestos
            // 
            BackColor = Color.Black;
            ClientSize = new Size(1006, 422);
            Controls.Add(panel1);
            Controls.Add(panel6);
            Controls.Add(dgvPresupuestos);
            Name = "FrmPresupuestos";
            Text = "b";
            Load += FrmPresupuestos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPresupuestos).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMonto).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            // 
            // presupuestos

        }

        #endregion

        private Label label1;
        private Button nuevo;
        private Button editar;
        private Button eliminar;
        private DataGridView dataGridView1;
        private ProgressBar progressBar1;
        private DataGridView dgvPresupuestos;
        private Button btnGuardar;
        private Button btnEliminar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label2;
        private ComboBox cmbCategoria;
        private Panel panel6;
        private DateTimePicker dtpFin;
        private DateTimePicker dtpInicio;
        private NumericUpDown nudMonto;
        private ComboBox cmbPeriodo;
        private Panel panel1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}
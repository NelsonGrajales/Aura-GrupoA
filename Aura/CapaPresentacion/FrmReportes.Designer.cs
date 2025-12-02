namespace CapaPresentacion
{
    partial class FrmReportes
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
            dgvTransacciones = new DataGridView();
            dgvPresupuestos = new DataGridView();
            lblGastos = new Label();
            lblIngresos = new Label();
            lblSaldo = new Label();
            btnGenerarPDF = new Button();
            panel4 = new Panel();
            label4 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTransacciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPresupuestos).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTransacciones
            // 
            dgvTransacciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransacciones.Location = new Point(12, 12);
            dgvTransacciones.Name = "dgvTransacciones";
            dgvTransacciones.RowHeadersWidth = 51;
            dgvTransacciones.Size = new Size(435, 270);
            dgvTransacciones.TabIndex = 0;
            // 
            // dgvPresupuestos
            // 
            dgvPresupuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPresupuestos.Location = new Point(460, 12);
            dgvPresupuestos.Name = "dgvPresupuestos";
            dgvPresupuestos.RowHeadersWidth = 51;
            dgvPresupuestos.Size = new Size(456, 270);
            dgvPresupuestos.TabIndex = 1;
            // 
            // lblGastos
            // 
            lblGastos.AutoSize = true;
            lblGastos.Font = new Font("Segoe UI", 15F);
            lblGastos.ForeColor = SystemColors.Control;
            lblGastos.Location = new Point(75, 49);
            lblGastos.Name = "lblGastos";
            lblGastos.Size = new Size(81, 35);
            lblGastos.TabIndex = 2;
            lblGastos.Text = "label1";
            lblGastos.Click += lblGastos_Click;
            // 
            // lblIngresos
            // 
            lblIngresos.AutoSize = true;
            lblIngresos.Font = new Font("Segoe UI", 15F);
            lblIngresos.ForeColor = SystemColors.Control;
            lblIngresos.Location = new Point(59, 50);
            lblIngresos.Name = "lblIngresos";
            lblIngresos.Size = new Size(81, 35);
            lblIngresos.TabIndex = 3;
            lblIngresos.Text = "label2";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Segoe UI", 15F);
            lblSaldo.ForeColor = SystemColors.Control;
            lblSaldo.Location = new Point(68, 50);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(81, 35);
            lblSaldo.TabIndex = 4;
            lblSaldo.Text = "label3";
            // 
            // btnGenerarPDF
            // 
            btnGenerarPDF.Location = new Point(773, 333);
            btnGenerarPDF.Name = "btnGenerarPDF";
            btnGenerarPDF.Size = new Size(143, 77);
            btnGenerarPDF.TabIndex = 5;
            btnGenerarPDF.Text = "Generar Reporte";
            btnGenerarPDF.UseVisualStyleBackColor = true;
            btnGenerarPDF.Click += btnGenerarPDF_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(50, 50, 50);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label4);
            panel4.Controls.Add(lblSaldo);
            panel4.Location = new Point(538, 298);
            panel4.Name = "panel4";
            panel4.Size = new Size(229, 129);
            panel4.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.ForeColor = Color.FromArgb(64, 201, 71);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(67, 30);
            label4.TabIndex = 13;
            label4.Text = "Saldo";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(50, 50, 50);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(lblGastos);
            panel3.Location = new Point(272, 299);
            panel3.Name = "panel3";
            panel3.Size = new Size(240, 129);
            panel3.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.ForeColor = Color.FromArgb(64, 201, 71);
            label3.Location = new Point(3, -1);
            label3.Name = "label3";
            label3.Size = new Size(77, 30);
            label3.TabIndex = 12;
            label3.Text = "Gastos";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 50, 50);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(lblIngresos);
            panel2.Location = new Point(12, 298);
            panel2.Name = "panel2";
            panel2.Size = new Size(242, 129);
            panel2.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F);
            label6.ForeColor = Color.FromArgb(64, 201, 71);
            label6.Location = new Point(-1, 0);
            label6.Name = "label6";
            label6.Size = new Size(95, 30);
            label6.TabIndex = 11;
            label6.Text = "Ingresos";
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(928, 450);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(btnGenerarPDF);
            Controls.Add(dgvPresupuestos);
            Controls.Add(dgvTransacciones);
            Name = "FrmReportes";
            Text = "FrmReportes";
            Load += FrmReportes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTransacciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPresupuestos).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTransacciones;
        private DataGridView dgvPresupuestos;
        private Label lblGastos;
        private Label lblIngresos;
        private Label lblSaldo;
        private Button btnGenerarPDF;
        private Panel panel4;
        private Label label4;
        private Panel panel3;
        private Label label3;
        private Panel panel2;
        private Label label6;
    }
}
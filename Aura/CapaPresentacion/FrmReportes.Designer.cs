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
            ((System.ComponentModel.ISupportInitialize)dgvTransacciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPresupuestos).BeginInit();
            SuspendLayout();
            // 
            // dgvTransacciones
            // 
            dgvTransacciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransacciones.Location = new Point(12, 12);
            dgvTransacciones.Name = "dgvTransacciones";
            dgvTransacciones.RowHeadersWidth = 51;
            dgvTransacciones.Size = new Size(393, 270);
            dgvTransacciones.TabIndex = 0;
            // 
            // dgvPresupuestos
            // 
            dgvPresupuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPresupuestos.Location = new Point(411, 12);
            dgvPresupuestos.Name = "dgvPresupuestos";
            dgvPresupuestos.RowHeadersWidth = 51;
            dgvPresupuestos.Size = new Size(377, 270);
            dgvPresupuestos.TabIndex = 1;
            // 
            // lblGastos
            // 
            lblGastos.AutoSize = true;
            lblGastos.Location = new Point(82, 305);
            lblGastos.Name = "lblGastos";
            lblGastos.Size = new Size(50, 20);
            lblGastos.TabIndex = 2;
            lblGastos.Text = "label1";
            // 
            // lblIngresos
            // 
            lblIngresos.AutoSize = true;
            lblIngresos.Location = new Point(12, 305);
            lblIngresos.Name = "lblIngresos";
            lblIngresos.Size = new Size(50, 20);
            lblIngresos.TabIndex = 3;
            lblIngresos.Text = "label2";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(152, 305);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(50, 20);
            lblSaldo.TabIndex = 4;
            lblSaldo.Text = "label3";
            // 
            // btnGenerarPDF
            // 
            btnGenerarPDF.Location = new Point(276, 301);
            btnGenerarPDF.Name = "btnGenerarPDF";
            btnGenerarPDF.Size = new Size(154, 29);
            btnGenerarPDF.TabIndex = 5;
            btnGenerarPDF.Text = "Generar Reporte";
            btnGenerarPDF.UseVisualStyleBackColor = true;
            btnGenerarPDF.Click += btnGenerarPDF_Click;
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGenerarPDF);
            Controls.Add(lblSaldo);
            Controls.Add(lblIngresos);
            Controls.Add(lblGastos);
            Controls.Add(dgvPresupuestos);
            Controls.Add(dgvTransacciones);
            Name = "FrmReportes";
            Text = "FrmReportes";
            Load += FrmReportes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTransacciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPresupuestos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTransacciones;
        private DataGridView dgvPresupuestos;
        private Label lblGastos;
        private Label lblIngresos;
        private Label lblSaldo;
        private Button btnGenerarPDF;
    }
}
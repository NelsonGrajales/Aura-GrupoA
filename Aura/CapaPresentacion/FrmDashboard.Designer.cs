namespace CapaPresentacion
{
    partial class FrmDashboard
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
            btnReportes = new Button();
            btnTransacciones = new Button();
            btnPresupuestos = new Button();
            btnCategoria = new Button();
            panel2 = new Panel();
            lblIngresos = new Label();
            label2 = new Label();
            panel3 = new Panel();
            lblGastos = new Label();
            label3 = new Label();
            panel4 = new Panel();
            lblSaldo = new Label();
            label4 = new Label();
            dgvTransacciones = new DataGridView();
            panel5 = new Panel();
            label1 = new Label();
            panel6 = new Panel();
            lblBienvenida = new Label();
            label6 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransacciones).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 50, 50);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnReportes);
            panel1.Controls.Add(btnTransacciones);
            panel1.Controls.Add(btnPresupuestos);
            panel1.Controls.Add(btnCategoria);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(276, 559);
            panel1.TabIndex = 6;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.DarkGray;
            btnReportes.ForeColor = SystemColors.ControlText;
            btnReportes.Location = new Point(49, 339);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(170, 49);
            btnReportes.TabIndex = 4;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnTransacciones
            // 
            btnTransacciones.BackColor = Color.DarkGray;
            btnTransacciones.ForeColor = Color.Black;
            btnTransacciones.Location = new Point(49, 104);
            btnTransacciones.Name = "btnTransacciones";
            btnTransacciones.Size = new Size(170, 50);
            btnTransacciones.TabIndex = 1;
            btnTransacciones.Text = "Transacciones";
            btnTransacciones.UseVisualStyleBackColor = false;
            btnTransacciones.Click += btnTransacciones_Click;
            // 
            // btnPresupuestos
            // 
            btnPresupuestos.BackColor = Color.DarkGray;
            btnPresupuestos.ForeColor = SystemColors.ControlText;
            btnPresupuestos.Location = new Point(49, 264);
            btnPresupuestos.Name = "btnPresupuestos";
            btnPresupuestos.Size = new Size(170, 49);
            btnPresupuestos.TabIndex = 3;
            btnPresupuestos.Text = "Presupuestos";
            btnPresupuestos.UseVisualStyleBackColor = false;
            btnPresupuestos.Click += btnPresupuestos_Click;
            // 
            // btnCategoria
            // 
            btnCategoria.BackColor = Color.DarkGray;
            btnCategoria.ForeColor = SystemColors.ActiveCaptionText;
            btnCategoria.Location = new Point(49, 186);
            btnCategoria.Name = "btnCategoria";
            btnCategoria.Size = new Size(170, 47);
            btnCategoria.TabIndex = 2;
            btnCategoria.Text = "Categorias";
            btnCategoria.UseVisualStyleBackColor = false;
            btnCategoria.Click += btnCategoria_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 50, 50);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblIngresos);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(296, 152);
            panel2.Name = "panel2";
            panel2.Size = new Size(242, 129);
            panel2.TabIndex = 7;
            // 
            // lblIngresos
            // 
            lblIngresos.AutoSize = true;
            lblIngresos.Font = new Font("Segoe UI", 18F);
            lblIngresos.Location = new Point(50, 44);
            lblIngresos.Name = "lblIngresos";
            lblIngresos.Size = new Size(97, 41);
            lblIngresos.TabIndex = 12;
            lblIngresos.Text = "label7";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.ForeColor = Color.FromArgb(64, 201, 71);
            label2.Location = new Point(-1, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 30);
            label2.TabIndex = 11;
            label2.Text = "Ingresos";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(50, 50, 50);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblGastos);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(578, 152);
            panel3.Name = "panel3";
            panel3.Size = new Size(240, 129);
            panel3.TabIndex = 8;
            // 
            // lblGastos
            // 
            lblGastos.AutoSize = true;
            lblGastos.Font = new Font("Segoe UI", 18F);
            lblGastos.Location = new Point(68, 44);
            lblGastos.Name = "lblGastos";
            lblGastos.Size = new Size(97, 41);
            lblGastos.TabIndex = 13;
            lblGastos.Text = "label8";
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
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(50, 50, 50);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lblSaldo);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(860, 152);
            panel4.Name = "panel4";
            panel4.Size = new Size(229, 129);
            panel4.TabIndex = 8;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Segoe UI", 18F);
            lblSaldo.Location = new Point(63, 44);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(97, 41);
            lblSaldo.TabIndex = 14;
            lblSaldo.Text = "label9";
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
            // dgvTransacciones
            // 
            dgvTransacciones.CausesValidation = false;
            dgvTransacciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransacciones.Location = new Point(30, 63);
            dgvTransacciones.Name = "dgvTransacciones";
            dgvTransacciones.RowHeadersWidth = 51;
            dgvTransacciones.Size = new Size(730, 158);
            dgvTransacciones.TabIndex = 9;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(50, 50, 50);
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label1);
            panel5.Controls.Add(dgvTransacciones);
            panel5.Location = new Point(296, 322);
            panel5.Name = "panel5";
            panel5.Size = new Size(793, 226);
            panel5.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(3, 17);
            label1.Name = "label1";
            label1.Size = new Size(222, 30);
            label1.TabIndex = 10;
            label1.Text = "Ultimas Transacciones";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(50, 50, 50);
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(lblBienvenida);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(label5);
            panel6.Location = new Point(296, 34);
            panel6.Name = "panel6";
            panel6.Size = new Size(793, 81);
            panel6.TabIndex = 11;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 10F);
            lblBienvenida.Location = new Point(643, 26);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(64, 23);
            lblBienvenida.TabIndex = 12;
            lblBienvenida.Text = "label10";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(584, 29);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 11;
            label6.Text = "Usuario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(18, 17);
            label5.Name = "label5";
            label5.Size = new Size(176, 35);
            label5.TabIndex = 10;
            label5.Text = "Panel Principal";
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1101, 560);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = SystemColors.Control;
            Name = "FrmDashboard";
            Text = "Dashboard";
            Load += FrmDashboard_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransacciones).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnPresupuestos;
        private Button btnCategoria;
        private Button btnTransacciones;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private DataGridView dgvTransacciones;
        private Panel panel5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel6;
        private Label label5;
        private Button btnReportes;
        private Label lblIngresos;
        private Label lblGastos;
        private Label lblSaldo;
        private Label lblBienvenida;
        private Label label6;
    }
}
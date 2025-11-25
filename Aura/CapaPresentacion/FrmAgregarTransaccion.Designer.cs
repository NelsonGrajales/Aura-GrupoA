namespace CapaPresentacion
{
    partial class FrmAgregarTransaccion
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
            comboCategoria = new ComboBox();
            comboTipo = new ComboBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtNota = new TextBox();
            dtpFecha = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            panel6 = new Panel();
            label5 = new Label();
            txtMonto = new NumericUpDown();
            panel1 = new Panel();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            comboMetodoPago = new ComboBox();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtMonto).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // comboCategoria
            // 
            comboCategoria.FormattingEnabled = true;
            comboCategoria.Location = new Point(15, 137);
            comboCategoria.Name = "comboCategoria";
            comboCategoria.Size = new Size(233, 28);
            comboCategoria.TabIndex = 0;
            // 
            // comboTipo
            // 
            comboTipo.FormattingEnabled = true;
            comboTipo.Location = new Point(15, 57);
            comboTipo.Name = "comboTipo";
            comboTipo.Size = new Size(233, 28);
            comboTipo.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(168, 36);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(35, 39);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNota
            // 
            txtNota.Location = new Point(83, 60);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(181, 27);
            txtNota.TabIndex = 6;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(83, 101);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(249, 27);
            dtpFecha.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(15, 19);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 8;
            label1.Text = "Monto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(15, 60);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 9;
            label2.Text = "Nota";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(50, 50, 50);
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label5);
            panel6.Controls.Add(txtMonto);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(dtpFecha);
            panel6.Controls.Add(txtNota);
            panel6.Location = new Point(27, 12);
            panel6.Name = "panel6";
            panel6.Size = new Size(346, 166);
            panel6.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(15, 108);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 14;
            label5.Text = "Fecha";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(83, 19);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(181, 27);
            txtMonto.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 50, 50);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(comboMetodoPago);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboCategoria);
            panel1.Controls.Add(comboTipo);
            panel1.Location = new Point(408, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(282, 293);
            panel1.TabIndex = 14;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(15, 19);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 8;
            label3.Text = "Tipo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(15, 101);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 9;
            label4.Text = "Categoria";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 50, 50);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(btnCancelar);
            panel2.Location = new Point(27, 201);
            panel2.Name = "panel2";
            panel2.Size = new Size(317, 104);
            panel2.TabIndex = 14;
            // 
            // comboMetodoPago
            // 
            comboMetodoPago.FormattingEnabled = true;
            comboMetodoPago.Location = new Point(15, 225);
            comboMetodoPago.Name = "comboMetodoPago";
            comboMetodoPago.Size = new Size(233, 28);
            comboMetodoPago.TabIndex = 16;
            // 
            // FrmAgregarTransaccion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(718, 328);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel6);
            Name = "FrmAgregarTransaccion";
            Text = "Form1";
            Load += FrmAgregarTransaccion_Load;
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtMonto).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboCategoria;
        private ComboBox comboTipo;
        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtNota;
        private DateTimePicker dtpFecha;
        private Label label1;
        private Label label2;
        private Panel panel6;
        private NumericUpDown txtMonto;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel2;
        private ComboBox comboMetodoPago;
    }
}
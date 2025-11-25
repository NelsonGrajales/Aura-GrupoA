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
            btnAgregar = new Button();
            button2 = new Button();
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
            ((System.ComponentModel.ISupportInitialize)dgvTransacciones).BeginInit();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnAgregar.Location = new Point(13, 34);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Nueva";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(13, 123);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(13, 215);
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
            dgvTransacciones.Location = new Point(150, 214);
            dgvTransacciones.Name = "dgvTransacciones";
            dgvTransacciones.RowHeadersWidth = 51;
            dgvTransacciones.Size = new Size(776, 286);
            dgvTransacciones.TabIndex = 5;
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
            panel2.Controls.Add(button2);
            panel2.Controls.Add(btnEliminar);
            panel2.Location = new Point(2, 214);
            panel2.Name = "panel2";
            panel2.Size = new Size(128, 297);
            panel2.TabIndex = 14;
            // 
            // FrmTransacciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(938, 512);
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
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnAgregar;
        private Button button2;
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
    }
}
namespace CapaPresentacion
{
    partial class FrmCategorias
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
            textBox1 = new TextBox();
            saveFileDialog1 = new SaveFileDialog();
            buscar = new Button();
            btnAgregar = new Button();
            editar = new Button();
            eliminar = new Button();
            dgvCategorias = new DataGridView();
            txtNombre = new TextBox();
            txtColor = new TextBox();
            cmbTipo = new ComboBox();
            Nombre = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(344, 46);
            label1.TabIndex = 0;
            label1.Text = "Gestion de categorias";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(344, 27);
            textBox1.TabIndex = 1;
            // 
            // buscar
            // 
            buscar.Location = new Point(362, 70);
            buscar.Name = "buscar";
            buscar.Size = new Size(94, 29);
            buscar.TabIndex = 2;
            buscar.Text = "Buscar";
            buscar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(661, 85);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Nueva";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // editar
            // 
            editar.Location = new Point(12, 134);
            editar.Name = "editar";
            editar.Size = new Size(94, 29);
            editar.TabIndex = 4;
            editar.Text = "Editar";
            editar.UseVisualStyleBackColor = true;
            // 
            // eliminar
            // 
            eliminar.Location = new Point(12, 183);
            eliminar.Name = "eliminar";
            eliminar.Size = new Size(94, 29);
            eliminar.TabIndex = 5;
            eliminar.Text = "Eliminar";
            eliminar.UseVisualStyleBackColor = true;
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(21, 259);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.Size = new Size(776, 188);
            dgvCategorias.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(482, 108);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(151, 27);
            txtNombre.TabIndex = 7;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(482, 226);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(151, 27);
            txtColor.TabIndex = 9;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Gasto", "Ingreso" });
            cmbTipo.Location = new Point(482, 167);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(151, 28);
            cmbTipo.TabIndex = 10;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(482, 85);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(64, 20);
            Nombre.TabIndex = 11;
            Nombre.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(482, 143);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 12;
            label2.Text = "Tipo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(482, 203);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 13;
            label3.Text = "Color";
            // 
            // FrmCategorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Nombre);
            Controls.Add(cmbTipo);
            Controls.Add(txtColor);
            Controls.Add(txtNombre);
            Controls.Add(dgvCategorias);
            Controls.Add(eliminar);
            Controls.Add(editar);
            Controls.Add(btnAgregar);
            Controls.Add(buscar);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "FrmCategorias";
            Text = "Categorias";
            Load += FrmCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private SaveFileDialog saveFileDialog1;
        private Button buscar;
        private Button btnAgregar;
        private Button editar;
        private Button eliminar;
        private DataGridView dgvCategorias;
        private TextBox txtNombre;
        private TextBox txtColor;
        private ComboBox cmbTipo;
        private Label Nombre;
        private Label label2;
        private Label label3;
    }
}
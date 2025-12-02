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
            saveFileDialog1 = new SaveFileDialog();
            btnAgregar = new Button();
            btnEliminar = new Button();
            dgvCategorias = new DataGridView();
            txtNombre = new TextBox();
            Nombre = new Label();
            label3 = new Label();
            panel6 = new Panel();
            panel1 = new Panel();
            btnColor = new Button();
            panelColor = new Panel();
            colorDialog1 = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(16, 17);
            label1.Name = "label1";
            label1.Size = new Size(344, 46);
            label1.TabIndex = 0;
            label1.Text = "Gestion de categorias";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(8, 276);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Nueva";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(108, 276);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(236, 99);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.Size = new Size(463, 320);
            dgvCategorias.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(8, 52);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(151, 27);
            txtNombre.TabIndex = 7;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.ForeColor = SystemColors.Control;
            Nombre.Location = new Point(8, 20);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(64, 20);
            Nombre.TabIndex = 11;
            Nombre.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(8, 111);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 13;
            label3.Text = "Color";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(50, 50, 50);
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label1);
            panel6.Location = new Point(4, 1);
            panel6.Name = "panel6";
            panel6.Size = new Size(793, 81);
            panel6.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 50, 50);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnColor);
            panel1.Controls.Add(panelColor);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(Nombre);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnAgregar);
            panel1.Location = new Point(12, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 320);
            panel1.TabIndex = 15;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(8, 134);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(151, 29);
            btnColor.TabIndex = 0;
            btnColor.Text = "Seleccionar Color";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // panelColor
            // 
            panelColor.Location = new Point(13, 189);
            panelColor.Name = "panelColor";
            panelColor.Size = new Size(59, 43);
            panelColor.TabIndex = 14;
            // 
            // FrmCategorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(711, 450);
            Controls.Add(panel1);
            Controls.Add(panel6);
            Controls.Add(dgvCategorias);
            Name = "FrmCategorias";
            Text = "Categorias";
            Load += FrmCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private SaveFileDialog saveFileDialog1;
        private Button btnAgregar;
        private Button btnEliminar;
        private DataGridView dgvCategorias;
        private TextBox txtNombre;
        private Label Nombre;
        private Label label3;
        private Panel panel6;
        private Panel panel1;
        private ColorDialog colorDialog1;
        private Button btnColor;
        private Panel panelColor;
    }
}
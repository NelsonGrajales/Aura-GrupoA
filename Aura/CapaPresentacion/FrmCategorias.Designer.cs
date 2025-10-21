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
            nueva = new Button();
            editar = new Button();
            eliminar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // nueva
            // 
            nueva.Location = new Point(12, 143);
            nueva.Name = "nueva";
            nueva.Size = new Size(94, 29);
            nueva.TabIndex = 3;
            nueva.Text = "Nueva";
            nueva.UseVisualStyleBackColor = true;
            // 
            // editar
            // 
            editar.Location = new Point(143, 143);
            editar.Name = "editar";
            editar.Size = new Size(94, 29);
            editar.TabIndex = 4;
            editar.Text = "Editar";
            editar.UseVisualStyleBackColor = true;
            // 
            // eliminar
            // 
            eliminar.Location = new Point(277, 143);
            eliminar.Name = "eliminar";
            eliminar.Size = new Size(94, 29);
            eliminar.TabIndex = 5;
            eliminar.Text = "Eliminar";
            eliminar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 210);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 6;
            // 
            // Categorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(eliminar);
            Controls.Add(editar);
            Controls.Add(nueva);
            Controls.Add(buscar);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Categorias";
            Text = "Categorias";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private SaveFileDialog saveFileDialog1;
        private Button buscar;
        private Button nueva;
        private Button editar;
        private Button eliminar;
        private DataGridView dataGridView1;
    }
}
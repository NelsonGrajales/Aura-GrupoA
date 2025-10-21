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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // presupuestos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar1);
            Controls.Add(dataGridView1);
            Controls.Add(eliminar);
            Controls.Add(editar);
            Controls.Add(nuevo);
            Controls.Add(label1);
            Name = "presupuestos";
            Text = "presupuestos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button nuevo;
        private Button editar;
        private Button eliminar;
        private DataGridView dataGridView1;
        private ProgressBar progressBar1;
    }
}
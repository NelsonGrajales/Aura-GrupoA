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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label2 = new Label();
            cmbCategoria = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPresupuestos).BeginInit();
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
            dgvPresupuestos.Location = new Point(12, 184);
            dgvPresupuestos.Name = "dgvPresupuestos";
            dgvPresupuestos.RowHeadersWidth = 51;
            dgvPresupuestos.Size = new Size(767, 188);
            dgvPresupuestos.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 111);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Nuevo";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(158, 111);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(311, 111);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 3;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(12, 29);
            label2.Name = "label2";
            label2.Size = new Size(219, 46);
            label2.TabIndex = 4;
            label2.Text = "Presupuestos";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(845, 112);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(151, 28);
            cmbCategoria.TabIndex = 5;
            // 
            // FrmPresupuestos
            // 
            ClientSize = new Size(1020, 422);
            Controls.Add(cmbCategoria);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvPresupuestos);
            Name = "FrmPresupuestos";
            Text = "b";
            Load += FrmPresupuestos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPresupuestos).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Button button1;
        private Button button2;
        private Button button3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label2;
        private ComboBox cmbCategoria;
    }
}
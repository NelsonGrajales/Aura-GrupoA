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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dgvTransacciones = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            filtrar = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvTransacciones).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(225, 46);
            label1.TabIndex = 0;
            label1.Text = "Transacciones";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 8.25F);
            button1.Location = new Point(12, 135);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Nueva";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(143, 135);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(530, 236);
            button3.Name = "button3";
            button3.Size = new Size(8, 8);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(269, 135);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 4;
            button4.Text = "Eliminar";
            button4.UseVisualStyleBackColor = true;
            // 
            // dgvTransacciones
            // 
            dgvTransacciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransacciones.Location = new Point(12, 189);
            dgvTransacciones.Name = "dgvTransacciones";
            dgvTransacciones.RowHeadersWidth = 51;
            dgvTransacciones.Size = new Size(776, 188);
            dgvTransacciones.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 6;
            label2.Text = "Fecha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(189, 88);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 7;
            label3.Text = "Categoria";
            // 
            // filtrar
            // 
            filtrar.Location = new Point(397, 79);
            filtrar.Name = "filtrar";
            filtrar.Size = new Size(94, 29);
            filtrar.TabIndex = 8;
            filtrar.Text = "Filtrar";
            filtrar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(65, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(109, 41);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(269, 88);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(106, 38);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // FrmTransacciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(filtrar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvTransacciones);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "FrmTransacciones";
            Text = "Transacciones";
            Load += FrmTransacciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTransacciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dgvTransacciones;
        private Label label2;
        private Label label3;
        private Button filtrar;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}
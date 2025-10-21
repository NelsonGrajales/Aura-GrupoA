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
            btnTransacciones = new Button();
            btnCategoria = new Button();
            btnPresupuestos = new Button();
            lblBienvenida = new Label();
            SuspendLayout();
            // 
            // btnTransacciones
            // 
            btnTransacciones.Location = new Point(677, 12);
            btnTransacciones.Name = "btnTransacciones";
            btnTransacciones.Size = new Size(111, 41);
            btnTransacciones.TabIndex = 1;
            btnTransacciones.Text = "Transacciones";
            btnTransacciones.UseVisualStyleBackColor = true;
            btnTransacciones.Click += btnTransacciones_Click;
            // 
            // btnCategoria
            // 
            btnCategoria.Location = new Point(677, 59);
            btnCategoria.Name = "btnCategoria";
            btnCategoria.Size = new Size(111, 42);
            btnCategoria.TabIndex = 2;
            btnCategoria.Text = "Categorias";
            btnCategoria.UseVisualStyleBackColor = true;
            btnCategoria.Click += btnCategoria_Click;
            // 
            // btnPresupuestos
            // 
            btnPresupuestos.Location = new Point(677, 107);
            btnPresupuestos.Name = "btnPresupuestos";
            btnPresupuestos.Size = new Size(111, 40);
            btnPresupuestos.TabIndex = 3;
            btnPresupuestos.Text = "Presupuestos";
            btnPresupuestos.UseVisualStyleBackColor = true;
            btnPresupuestos.Click += btnPresupuestos_Click;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 15F);
            lblBienvenida.Location = new Point(12, 12);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(81, 35);
            lblBienvenida.TabIndex = 4;
            lblBienvenida.Text = "label1";
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblBienvenida);
            Controls.Add(btnPresupuestos);
            Controls.Add(btnCategoria);
            Controls.Add(btnTransacciones);
            Name = "FrmDashboard";
            Text = "Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTransacciones;
        private Button btnCategoria;
        private Button btnPresupuestos;
        private Label lblBienvenida;
    }
}
namespace CapaPresentacion
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            button2 = new Button();
            ll = new Label();
            label2 = new Label();
            panel2 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(97, 75);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(180, 27);
            txtEmail.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(97, 147);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(180, 27);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(97, 200);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(180, 29);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Iniciar Sesión";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // button2
            // 
            button2.Location = new Point(97, 246);
            button2.Name = "button2";
            button2.Size = new Size(180, 29);
            button2.TabIndex = 3;
            button2.Text = "Registrarse";
            button2.UseVisualStyleBackColor = true;
            // 
            // ll
            // 
            ll.AutoSize = true;
            ll.ForeColor = SystemColors.Control;
            ll.Location = new Point(155, 43);
            ll.Name = "ll";
            ll.Size = new Size(57, 20);
            ll.TabIndex = 5;
            ll.Text = "Correo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(144, 115);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 6;
            label2.Text = "Contraseña";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 50, 50);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(ll);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(txtPassword);
            panel2.Location = new Point(227, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(370, 309);
            panel2.TabIndex = 15;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Name = "FrmLogin";
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button button2;
        private Label ll;
        private Label label2;
        private Panel panel2;
    }
}

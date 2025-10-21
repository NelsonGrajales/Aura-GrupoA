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
            linkLabel1 = new LinkLabel();
            ll = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(301, 140);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(180, 27);
            txtEmail.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(301, 217);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(180, 27);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(301, 274);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(180, 29);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Iniciar Sesión";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // button2
            // 
            button2.Location = new Point(301, 309);
            button2.Name = "button2";
            button2.Size = new Size(180, 29);
            button2.TabIndex = 3;
            button2.Text = "Registrarse";
            button2.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(301, 341);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(180, 20);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "¿Olvidaste tu Contraseña?";
            // 
            // ll
            // 
            ll.AutoSize = true;
            ll.Location = new Point(301, 117);
            ll.Name = "ll";
            ll.Size = new Size(57, 20);
            ll.TabIndex = 5;
            ll.Text = "Correo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(301, 194);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 6;
            label2.Text = "Contraseña";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(ll);
            Controls.Add(linkLabel1);
            Controls.Add(button2);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Name = "FrmLogin";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button button2;
        private LinkLabel linkLabel1;
        private Label ll;
        private Label label2;
    }
}

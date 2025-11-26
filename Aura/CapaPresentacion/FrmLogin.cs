using System;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                CN_Usuario cn = new CN_Usuario();
                CE_Usuario usuario = cn.Login(txtEmail.Text.Trim(), txtPassword.Text.Trim());

                MessageBox.Show("Bienvenido: " + usuario.Nombre);

                FrmDashboard frm = new FrmDashboard(usuario);
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text.Trim();
                string email = txtEmail.Text.Trim();
                string password = txtPassword.Text.Trim();

                if (nombre == "" || email == "" || password == "")
                {
                    MessageBox.Show("Todos los campos son obligatorios.");
                    return;
                }

                CN_Usuario cn = new CN_Usuario();
                bool registrado = cn.Registrar(nombre, email, password);

                if (registrado)
                {
                    MessageBox.Show("Usuario registrado con éxito. Ahora puede iniciar sesión.");
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el usuario.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

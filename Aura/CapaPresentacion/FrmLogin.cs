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

                // Login exitoso
                MessageBox.Show("Bienvenido: " + usuario.Nombre);

                // Abrir Dashboard pasando el usuario
                FrmDashboard frm = new FrmDashboard(usuario);
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

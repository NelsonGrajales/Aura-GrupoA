using CapaEntidad;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmDashboard : Form
    {
        private CE_Usuario usuarioActual;

        public FrmDashboard(CE_Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
            lblBienvenida.Text = $"Bienvenido, {usuario.Nombre}";
        }

        private void btnTransacciones_Click(object sender, EventArgs e)
        {
            FrmTransacciones frm = new FrmTransacciones(usuarioActual);
            frm.Show();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            FrmCategorias frm = new FrmCategorias(usuarioActual);
            frm.Show();
        }

        private void btnPresupuestos_Click(object sender, EventArgs e)
        {
            FrmPresupuestos frm = new FrmPresupuestos(usuarioActual);
            frm.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el dashboard
            FrmLogin login = new FrmLogin();
            login.Show();
        }

    }
}

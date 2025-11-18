using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmTransacciones : Form
    {
        private CE_Usuario usuarioActual;
        private CN_Transaccion cnTransaccion = new CN_Transaccion();

        public FrmTransacciones(CE_Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void FrmTransacciones_Load(object sender, EventArgs e)
        {
            CargarTransacciones();
        }

        private void CargarTransacciones()
        {
            dgvTransacciones.DataSource = cnTransaccion.Listar(usuarioActual.IdUsuario);
        }

    }
}

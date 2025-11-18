using CapaDatos;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmPresupuestos : Form
    {
        private CE_Usuario usuarioActual;
        private CN_Presupuesto cnPresupuesto = new CN_Presupuesto();
        private CN_Categoria cnCategoria = new CN_Categoria();

        public FrmPresupuestos(CE_Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }


        private void FrmPresupuestos_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            CargarPresupuestos();
        }

        private void CargarCategorias()
        {
            cmbCategoria.DataSource = cnCategoria.Listar(usuarioActual.IdUsuario);
            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "IdCategoria";
        }

        private void CargarPresupuestos()
        {
            dgvPresupuestos.DataSource = cnPresupuesto.Listar(usuarioActual.IdUsuario);
        }

    }
}

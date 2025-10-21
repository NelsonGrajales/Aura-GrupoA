using CapaEntidad;

namespace CapaPresentacion
{
    public partial class FrmPresupuestos : Form
    {
        private CE_Usuario usuarioActual;

        public FrmPresupuestos(CE_Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }
    }
}

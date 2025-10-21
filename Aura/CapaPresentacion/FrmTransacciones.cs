using CapaEntidad;

namespace CapaPresentacion
{
    public partial class FrmTransacciones : Form
    {
        private CE_Usuario usuarioActual;

        public FrmTransacciones(CE_Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }
    }
}

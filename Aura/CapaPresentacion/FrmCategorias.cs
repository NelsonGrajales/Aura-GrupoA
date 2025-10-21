using CapaEntidad;

namespace CapaPresentacion
{
    public partial class FrmCategorias : Form
    {
        private CE_Usuario usuarioActual;

        public FrmCategorias(CE_Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

    }
}

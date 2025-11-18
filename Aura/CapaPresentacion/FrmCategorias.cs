using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmCategorias : Form
    {
        private CE_Usuario usuarioActual;
        private CN_Categoria cnCategoria = new CN_Categoria();

        public FrmCategorias(CE_Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void CargarCategorias()
        {
            dgvCategorias.DataSource = cnCategoria.Listar(usuarioActual.IdUsuario);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                CE_Categoria nueva = new CE_Categoria
                {
                    Nombre = txtNombre.Text,
                    Tipo = cmbTipo.Text,
                    Color = txtColor.Text
                };

                cnCategoria.Agregar(nueva, usuarioActual.IdUsuario);
                MessageBox.Show("Categoría agregada correctamente");
                CargarCategorias();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }


        }
    }
}
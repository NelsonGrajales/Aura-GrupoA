using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmTransacciones : Form
    {
        private CE_Usuario usuarioActual;
        private CN_Transaccion cnTransaccion = new CN_Transaccion();
        private CN_Categoria cnCategoria = new CN_Categoria();


        public FrmTransacciones(CE_Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
            CargarCategorias();
            CargarTransacciones();
        }

        private void FrmTransacciones_Load(object sender, EventArgs e)
        {
            CargarTransacciones();
            dgvTransacciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransacciones.MultiSelect = false;

        }

        private void CargarTransacciones()
        {
            CN_Transaccion cn = new CN_Transaccion();
            DataTable dt = cn.ListarDT(usuarioActual.IdUsuario);

            dgvTransacciones.DataSource = dt;

        }


        private void CargarCategorias()
        {
            var categorias = cnCategoria.Listar(usuarioActual.IdUsuario);

            comboCategoria.DataSource = categorias;
            comboCategoria.DisplayMember = "Nombre";   // Lo que se muestra
            comboCategoria.ValueMember = "IdCategoria"; // Valor interno

            comboCategoria.SelectedIndex = -1;  // Para que salga vacío al inicio
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime? fecha = checkUsarFecha.Checked ? dtpFecha.Value.Date : (DateTime?)null;
            int? idCategoria = comboCategoria.SelectedIndex >= 0 ?
                               (int?)comboCategoria.SelectedValue : null;

            var tabla = cnTransaccion.ListarFiltrado(usuarioActual.IdUsuario, fecha, idCategoria);

            dgvTransacciones.DataSource = tabla;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarTransaccion frm = new FrmAgregarTransaccion(usuarioActual.IdUsuario);

            frm.ShowDialog(); // Ventana modal

            // Si se añadió una nueva transacción, recargar tabla
            if (frm.TransaccionAgregada)
            {
                CargarTransacciones();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTransacciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una transacción para eliminar.");
                return;
            }

            // Obtener ID de la fila seleccionada
            int idTransaccion = Convert.ToInt32(dgvTransacciones.SelectedRows[0].Cells["id_transaccion"].Value);

            // Confirmación
            DialogResult result = MessageBox.Show("¿Está seguro de eliminar esta transacción?",
                                                 "Confirmar eliminación",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Llamar a la capa de negocio
                bool eliminado = cnTransaccion.Eliminar(idTransaccion);

                if (eliminado)
                {
                    MessageBox.Show("Transacción eliminada correctamente.");
                    CargarTransacciones(); // refrescar grid
                }
                else
                {
                    MessageBox.Show("Error al eliminar la transacción.");
                }
            }
        }



    }
}

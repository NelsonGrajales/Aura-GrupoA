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

        // 🔥 Evento para notificar al Dashboard
        public event Action OnTransaccionesActualizadas;

        // 🔥 Controla si estamos editando (null = agregar)
        private int? idTransaccionEditando = null;

        public FrmTransacciones(CE_Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void FrmTransacciones_Load(object sender, EventArgs e)
        {
            CargarTransacciones();

            dgvTransacciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransacciones.MultiSelect = false;

            // 🔹 Combo de filtro
            comboCategoria.DataSource = cnCategoria.Listar(usuarioActual.IdUsuario);
            comboCategoria.DisplayMember = "Nombre";
            comboCategoria.ValueMember = "IdCategoria";
            comboCategoria.SelectedIndex = -1;

            // 🔹 Combo del formulario (agregar/editar)
            comboCategorias.DataSource = cnCategoria.Listar(usuarioActual.IdUsuario);
            comboCategorias.DisplayMember = "Nombre";
            comboCategorias.ValueMember = "IdCategoria";
            comboCategorias.SelectedIndex = -1;

            // Tipo
            comboTipo.Items.Clear();
            comboTipo.Items.Add("Ingreso");
            comboTipo.Items.Add("Gasto");
            comboTipo.SelectedIndex = -1;

            // Método de pago
            comboMetodoPago.Items.Clear();
            comboMetodoPago.Items.Add("Efectivo");
            comboMetodoPago.Items.Add("Transferencia");
            comboMetodoPago.Items.Add("Tarjeta");
            comboMetodoPago.SelectedIndex = -1;

            dgvTransacciones.ClearSelection();
        }

        private void CargarTransacciones()
        {
            DataTable dt = cnTransaccion.ListarDT(usuarioActual.IdUsuario);
            dgvTransacciones.DataSource = dt;

            // Ocultamos columnas internas
            if (dgvTransacciones.Columns.Contains("id_transaccion"))
                dgvTransacciones.Columns["id_transaccion"].Visible = false;

            if (dgvTransacciones.Columns.Contains("id_categoria"))
                dgvTransacciones.Columns["id_categoria"].Visible = false;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime? fecha = checkUsarFecha.Checked ? dtpFecha.Value.Date : (DateTime?)null;
            int? idCategoria = comboCategoria.SelectedIndex >= 0 ?
                                (int?)comboCategoria.SelectedValue : null;

            dgvTransacciones.DataSource =
                cnTransaccion.ListarFiltrado(usuarioActual.IdUsuario, fecha, idCategoria);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validar
            if (comboCategorias.SelectedIndex == -1 ||
                comboTipo.SelectedIndex == -1 ||
                comboMetodoPago.SelectedIndex == -1)
            {
                MessageBox.Show("Debe completar todos los campos.");
                return;
            }

            CE_Transaccion t = new CE_Transaccion()
            {
                IdUsuario = usuarioActual.IdUsuario,
                IdCategoria = (int)comboCategorias.SelectedValue,
                Monto = txtMonto.Value,
                Fecha = dtpFecha.Value.Date,
                Tipo = comboTipo.SelectedItem.ToString(),
                MetodoPago = comboMetodoPago.SelectedItem.ToString(),
                Nota = txtNota.Text
            };

            // 🔥 MODO EDITAR
            if (idTransaccionEditando != null)
            {
                t.IdTransaccion = idTransaccionEditando.Value;

                bool ok = cnTransaccion.Editar(t);

                if (ok)
                    MessageBox.Show("Transacción actualizada satisfactoriamente.");
                else
                    MessageBox.Show("Error al actualizar la transacción.");

                idTransaccionEditando = null; // reset
            }
            else
            {
                // 🔥 MODO AGREGAR
                cnTransaccion.Agregar(t);
                MessageBox.Show("Transacción agregada correctamente.");
            }

            CargarTransacciones();
            LimpiarFormulario();

            // 🔥 Notificar al Dashboard
            OnTransaccionesActualizadas?.Invoke();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTransacciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una transacción para eliminar.");
                return;
            }

            int id = Convert.ToInt32(
                dgvTransacciones.SelectedRows[0].Cells["id_transaccion"].Value);

            if (MessageBox.Show("¿Eliminar esta transacción?",
                                "Confirmación",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool ok = cnTransaccion.Eliminar(id);

                if (ok)
                    MessageBox.Show("Transacción eliminada.");
                else
                    MessageBox.Show("No se pudo eliminar.");

                CargarTransacciones();
                LimpiarFormulario();

                // 🔥 Notificar al Dashboard
                OnTransaccionesActualizadas?.Invoke();
            }
        }

        private void dgvTransacciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvTransacciones.Rows[e.RowIndex];

            idTransaccionEditando = Convert.ToInt32(
                fila.Cells["id_transaccion"].Value);

            txtMonto.Value = Convert.ToDecimal(fila.Cells["monto"].Value);
            dtpFecha.Value = Convert.ToDateTime(fila.Cells["fecha"].Value);
            comboTipo.SelectedItem = fila.Cells["tipo"].Value.ToString();
            comboMetodoPago.SelectedItem = fila.Cells["metodo_pago"].Value.ToString();
            txtNota.Text = fila.Cells["nota"].Value.ToString();

            comboCategorias.SelectedValue = Convert.ToInt32(
                fila.Cells["id_categoria"].Value);
        }

        private void LimpiarFormulario()
        {
            comboCategorias.SelectedIndex = -1;
            comboTipo.SelectedIndex = -1;
            comboMetodoPago.SelectedIndex = -1;
            txtMonto.Value = 0;
            txtNota.Clear();
            dgvTransacciones.ClearSelection();
        }
    }
}

using CapaEntidad;
using CapaNegocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmPresupuestos : Form
    {
        private CE_Usuario usuarioActual;
        private CN_Presupuesto cnPresupuesto = new CN_Presupuesto();
        private CN_Categoria cnCategoria = new CN_Categoria();

        // Para editar
        private int idPresupuestoSeleccionado = 0;

        public FrmPresupuestos(CE_Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void FrmPresupuestos_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            CargarPresupuestos();
            CargarPeriodos();
        }

        private void CargarCategorias()
        {
            cmbCategoria.DataSource = cnCategoria.Listar(usuarioActual.IdUsuario);
            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "IdCategoria";
            cmbCategoria.SelectedIndex = -1;
        }

        private void CargarPresupuestos()
        {
            DataTable dt = cnPresupuesto.ListarConGasto(usuarioActual.IdUsuario);
            dgvPresupuestos.DataSource = dt;

            if (dgvPresupuestos.Columns["id_presupuesto"] != null)
                dgvPresupuestos.Columns["id_presupuesto"].Visible = false;

            if (dgvPresupuestos.Columns["id_categoria"] != null)
                dgvPresupuestos.Columns["id_categoria"].Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (cmbCategoria.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione una categoría.");
                return;
            }

            if (cmbPeriodo.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un periodo.");
                return;
            }

            CE_Presupuesto p = new CE_Presupuesto
            {
                IdPresupuesto = idPresupuestoSeleccionado, // 0 si es nuevo
                IdCategoria = (int)cmbCategoria.SelectedValue,
                MontoLimite = nudMonto.Value,
                FechaInicio = dtpInicio.Value.Date,
                FechaFin = dtpFin.Value.Date,
                Periodo = cmbPeriodo.SelectedItem.ToString()
            };

            try
            {
                if (idPresupuestoSeleccionado == 0)
                {
                    // Agregar
                    cnPresupuesto.Agregar(p, usuarioActual.IdUsuario);
                    MessageBox.Show("Presupuesto agregado correctamente.");
                }
                else
                {
                    // Editar
                    cnPresupuesto.Editar(p);
                    MessageBox.Show("Presupuesto editado correctamente.");
                }

                // Limpiar
                idPresupuestoSeleccionado = 0;
                cmbCategoria.SelectedIndex = -1;
                cmbPeriodo.SelectedIndex = -1;
                nudMonto.Value = 0;
                dtpInicio.Value = DateTime.Today;
                dtpFin.Value = DateTime.Today;

                CargarPresupuestos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void dgvPresupuestos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvPresupuestos.Rows[e.RowIndex];
                idPresupuestoSeleccionado = Convert.ToInt32(fila.Cells["id_presupuesto"].Value);
                cmbCategoria.SelectedValue = fila.Cells["id_categoria"].Value;
                nudMonto.Value = Convert.ToDecimal(fila.Cells["monto_limite"].Value);
                dtpInicio.Value = Convert.ToDateTime(fila.Cells["fecha_inicio"].Value);
                dtpFin.Value = Convert.ToDateTime(fila.Cells["fecha_fin"].Value);
                cmbPeriodo.SelectedItem = fila.Cells["periodo"].Value.ToString();
            }
        }

        private void CargarPeriodos()
        {
            cmbPeriodo.Items.Clear();

            cmbPeriodo.Items.Add("Diario");
            cmbPeriodo.Items.Add("Semanal");
            cmbPeriodo.Items.Add("Mensual");
            cmbPeriodo.Items.Add("Anual");

            cmbPeriodo.SelectedIndex = -1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idPresupuestoSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un presupuesto para eliminar.");
                return;
            }

            DialogResult confirm = MessageBox.Show("¿Eliminar presupuesto?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                cnPresupuesto.Eliminar(idPresupuestoSeleccionado);
                idPresupuestoSeleccionado = 0;
                CargarPresupuestos();
            }
        }

    }
}

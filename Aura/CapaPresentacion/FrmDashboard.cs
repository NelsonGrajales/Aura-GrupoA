using CapaEntidad;
using CapaNegocio;
using System.Data;
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
            lblBienvenida.Text = $"{usuario.Nombre}";
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

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                CN_SaldoUsuario negocioSaldo = new CN_SaldoUsuario();
                var saldo = negocioSaldo.ObtenerSaldo(usuarioActual.IdUsuario);

                if (saldo != null)
                {
                    lblIngresos.Text = saldo.TotalIngresos.ToString("C2");
                    lblGastos.Text = saldo.TotalGastos.ToString("C2");
                    lblSaldo.Text = saldo.SaldoFinal.ToString("C2");
                }
                else
                {
                    lblIngresos.Text = "0.00";
                    lblGastos.Text = "0.00";
                    lblSaldo.Text = "0.00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el saldo: " + ex.Message);
            }

            CargarTransacciones();

        }
        private void CargarTransacciones()
        {
            CN_Transaccion cn = new CN_Transaccion();
            DataTable dt = cn.ListarDT(usuarioActual.IdUsuario);

            dgvTransacciones.DataSource = dt;

            ColorearFilas();
        }

        private void ColorearFilas()
        {
            foreach (DataGridViewRow row in dgvTransacciones.Rows)
            {
                // Evitar fila vacía del DataGridView
                if (row.IsNewRow) continue;

                // Validar que exista la columna "tipo"
                if (!dgvTransacciones.Columns.Contains("tipo"))
                    return;

                var valor = row.Cells["tipo"].Value;

                // Validar que no sea null ni DBNull
                if (valor == null || valor == DBNull.Value)
                    continue;

                string tipo = valor.ToString();

                if (tipo.Equals("Ingreso", StringComparison.OrdinalIgnoreCase))
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else if (tipo.Equals("Gasto", StringComparison.OrdinalIgnoreCase))
                {
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                }
            }
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FrmReportes frm = new FrmReportes(usuarioActual);
            frm.ShowDialog();
        }


    }
}

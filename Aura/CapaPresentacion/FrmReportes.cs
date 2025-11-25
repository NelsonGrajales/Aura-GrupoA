using CapaEntidad;
using CapaNegocio;
using System.Data;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font; // Esto resuelve la ambigüedad

namespace CapaPresentacion
{
    public partial class FrmReportes : Form
    {
        private CE_Usuario usuarioActual;
        private CN_Transaccion cnTransaccion = new CN_Transaccion();
        private CN_Presupuesto cnPresupuesto = new CN_Presupuesto();
        private CN_SaldoUsuario cnSaldo = new CN_SaldoUsuario();

        public FrmReportes(CE_Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            CargarTransacciones();
            CargarPresupuestos();
            CargarSaldos();
        }

        private void CargarTransacciones()
        {
            DataTable dtTransacciones = cnTransaccion.ListarDT(usuarioActual.IdUsuario);
            dgvTransacciones.DataSource = dtTransacciones;
        }

        private void CargarPresupuestos()
        {
            DataTable dtPresupuestos = cnPresupuesto.ListarConGasto(usuarioActual.IdUsuario);
            dgvPresupuestos.DataSource = dtPresupuestos;
        }

        private void CargarSaldos()
        {
            var saldo = cnSaldo.ObtenerSaldo(usuarioActual.IdUsuario);
            lblIngresos.Text = saldo.TotalIngresos.ToString("C");
            lblGastos.Text = saldo.TotalGastos.ToString("C");
            lblSaldo.Text = saldo.SaldoFinal.ToString("C");
        }

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
        }

    }      
}
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmAgregarTransaccion : Form
    {
        private int idUsuario;
        private CN_Transaccion cnTransaccion = new CN_Transaccion();
        private CN_Categoria cnCategoria = new CN_Categoria();

        public bool TransaccionAgregada = false;

        public FrmAgregarTransaccion(int usuario)
        {
            InitializeComponent();
            idUsuario = usuario;
        }

        private void FrmAgregarTransaccion_Load(object sender, EventArgs e)
        {
            // Cargar categorías
            comboCategoria.DataSource = cnCategoria.Listar(idUsuario);
            comboCategoria.DisplayMember = "Nombre";
            comboCategoria.ValueMember = "IdCategoria";

            // Cargar opciones de tipo
            comboTipo.Items.Add("Ingreso");
            comboTipo.Items.Add("Gasto");
            comboTipo.SelectedIndex = 0;

            comboMetodoPago.Items.Clear();
            comboMetodoPago.Items.Add("Efectivo");
            comboMetodoPago.Items.Add("Transferencia");
            comboMetodoPago.Items.Add("Tarjeta");

            comboMetodoPago.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CE_Transaccion tx = new CE_Transaccion()
            {
                IdUsuario = idUsuario,
                IdCategoria = (int)comboCategoria.SelectedValue,
                Monto = txtMonto.Value,
                Fecha = dtpFecha.Value.Date,
                Tipo = comboTipo.SelectedItem.ToString(),
                MetodoPago = comboMetodoPago.SelectedItem.ToString(),
                Nota = txtNota.Text
            };

            cnTransaccion.Agregar(tx);

            TransaccionAgregada = true;
            this.Close();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

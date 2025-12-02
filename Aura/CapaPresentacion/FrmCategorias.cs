using CapaEntidad;
using CapaNegocio;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmCategorias : Form
    {
        private CE_Usuario usuarioActual;
        private CN_Categoria cnCategoria = new CN_Categoria();

        // Guardar color #RRGGBB
        private string colorSeleccionado = "#FFFFFF";

        // Variables para editar
        private int categoriaIdSeleccionada = 0;
        private bool modoEdicion = false;

        public FrmCategorias(CE_Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            dgvCategorias.CellClick += dgvCategorias_CellClick;
            CargarCategorias();
        }

        private void CargarCategorias()
        {
            dgvCategorias.DataSource = cnCategoria.Listar(usuarioActual.IdUsuario);

            if (dgvCategorias.Columns["IdCategoria"] != null)
                dgvCategorias.Columns["IdCategoria"].Visible = false;
        }

        // -------------------------------
        // SELECCIONAR COLOR
        // -------------------------------
        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
            {
                colorSeleccionado = ColorTranslator.ToHtml(cd.Color);
                panelColor.BackColor = cd.Color;
            }
        }

        // ------------------------------------------------------
        // SELECCIONAR FILA → CARGAR DATOS PARA EDITAR
        // ------------------------------------------------------
        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                categoriaIdSeleccionada = Convert.ToInt32(
                    dgvCategorias.Rows[e.RowIndex].Cells["IdCategoria"].Value
                );

                txtNombre.Text = dgvCategorias.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                colorSeleccionado = dgvCategorias.Rows[e.RowIndex].Cells["Color"].Value.ToString();

                panelColor.BackColor = ColorTranslator.FromHtml(colorSeleccionado);

                modoEdicion = true;
                btnAgregar.Text = "Guardar Cambios";
            }
        }

        // ------------------------------------------------------
        // AGREGAR O EDITAR
        // ------------------------------------------------------
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre para la categoría.");
                return;
            }

            try
            {
                CE_Categoria categoria = new CE_Categoria
                {
                    IdCategoria = categoriaIdSeleccionada, // solo si estás editando
                    Nombre = txtNombre.Text.Trim(),
                    Tipo = "Gasto", // valor por defecto
                    Color = colorSeleccionado
                };

                if (modoEdicion)
                {
                    if (cnCategoria.Editar(categoria))
                        MessageBox.Show("Categoría actualizada correctamente.");
                    else
                        MessageBox.Show("Error al actualizar la categoría.");
                }
                else
                {
                    cnCategoria.Agregar(categoria, usuarioActual.IdUsuario);
                    MessageBox.Show("Categoría agregada correctamente.");
                }

                LimpiarFormulario();
                CargarCategorias();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // ------------------------------------------------------
        // ELIMINAR
        // ------------------------------------------------------
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una categoría.");
                return;
            }

            int idCategoria = (int)dgvCategorias.SelectedRows[0].Cells["IdCategoria"].Value;

            // Validar si tiene transacciones asociadas
            if (cnCategoria.TieneTransacciones(idCategoria))
            {
                MessageBox.Show("No se puede eliminar esta categoría porque tiene transacciones asociadas.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "¿Seguro que desea eliminar esta categoría?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                cnCategoria.Eliminar(idCategoria);
                CargarCategorias();
            }
        }

        // ------------------------------------------------------
        // LIMPIAR FORMULARIO
        // ------------------------------------------------------
        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            colorSeleccionado = "#FFFFFF";
            panelColor.BackColor = Color.White;

            categoriaIdSeleccionada = 0;
            modoEdicion = false;
            btnAgregar.Text = "Agregar";
        }
    }
}

using CapaEntidad;
using CapaNegocio;
using System.Data;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing;

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
            GenerarReportePDF();
        }

        private void GenerarReportePDF()
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files|*.pdf";
                saveFileDialog.Title = "Guardar Reporte PDF";
                saveFileDialog.FileName = $"Reporte_Financiero_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Crear el documento PDF
                    Document document = new Document(PageSize.A4, 50, 50, 50, 50);
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));

                    document.Open();

                    // Configurar fuentes - USANDO EL CONSTRUCTOR CORRECTO
                    BaseFont baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);


                    iTextSharp.text.Font titleFont = new iTextSharp.text.Font(baseFont, 18, 1); 
                    iTextSharp.text.Font subtitleFont = new iTextSharp.text.Font(baseFont, 14, 1); 
                    iTextSharp.text.Font normalFont = new iTextSharp.text.Font(baseFont, 10, 0); 
                    iTextSharp.text.Font headerFont = new iTextSharp.text.Font(baseFont, 10, 1); 

                    // Título del reporte
                    Paragraph title = new Paragraph("REPORTE FINANCIERO", titleFont);
                    title.Alignment = Element.ALIGN_CENTER;
                    title.SpacingAfter = 20f;
                    document.Add(title);

                    // Información del usuario y fecha
                    Paragraph userInfo = new Paragraph();
                    userInfo.Add(new Chunk($"Usuario: {usuarioActual.Nombre}\n", normalFont));
                    userInfo.Add(new Chunk($"Fecha de generación: {DateTime.Now:dd/MM/yyyy HH:mm}\n", normalFont));
                    userInfo.SpacingAfter = 15f;
                    document.Add(userInfo);

                    // Resumen de saldos
                    var saldo = cnSaldo.ObtenerSaldo(usuarioActual.IdUsuario);
                    Paragraph saldosTitle = new Paragraph("RESUMEN DE SALDOS", subtitleFont);
                    saldosTitle.SpacingAfter = 10f;
                    document.Add(saldosTitle);

                    PdfPTable saldosTable = new PdfPTable(2);
                    saldosTable.WidthPercentage = 50;
                    saldosTable.SetWidths(new float[] { 1, 1 });

                    saldosTable.AddCell(CrearCelda("Total Ingresos", headerFont, BaseColor.LIGHT_GRAY));
                    saldosTable.AddCell(CrearCelda(saldo.TotalIngresos.ToString("C"), normalFont));
                    saldosTable.AddCell(CrearCelda("Total Gastos", headerFont, BaseColor.LIGHT_GRAY));
                    saldosTable.AddCell(CrearCelda(saldo.TotalGastos.ToString("C"), normalFont));
                    saldosTable.AddCell(CrearCelda("Saldo Final", headerFont, BaseColor.LIGHT_GRAY));
                    saldosTable.AddCell(CrearCelda(saldo.SaldoFinal.ToString("C"), normalFont));

                    saldosTable.SpacingAfter = 20f;
                    document.Add(saldosTable);

                    // Transacciones
                    Paragraph transaccionesTitle = new Paragraph("TRANSACCIONES", subtitleFont);
                    transaccionesTitle.SpacingAfter = 10f;
                    document.Add(transaccionesTitle);

                    DataTable dtTransacciones = cnTransaccion.ListarDT(usuarioActual.IdUsuario);
                    if (dtTransacciones.Rows.Count > 0)
                    {
                        PdfPTable transaccionesTable = CrearTablaDesdeDataTable(dtTransacciones, headerFont, normalFont);
                        transaccionesTable.SpacingAfter = 20f;
                        document.Add(transaccionesTable);
                    }
                    else
                    {
                        document.Add(new Paragraph("No hay transacciones registradas.", normalFont));
                        document.Add(new Paragraph(" ")); // Espacio en blanco
                    }

                    // Presupuestos
                    Paragraph presupuestosTitle = new Paragraph("PRESUPUESTOS", subtitleFont);
                    presupuestosTitle.SpacingAfter = 10f;
                    document.Add(presupuestosTitle);

                    DataTable dtPresupuestos = cnPresupuesto.ListarConGasto(usuarioActual.IdUsuario);
                    if (dtPresupuestos.Rows.Count > 0)
                    {
                        PdfPTable presupuestosTable = CrearTablaDesdeDataTable(dtPresupuestos, headerFont, normalFont);
                        document.Add(presupuestosTable);
                    }
                    else
                    {
                        document.Add(new Paragraph("No hay presupuestos registrados.", normalFont));
                    }

                    document.Close();
                    writer.Close();

                    MessageBox.Show("Reporte PDF generado exitosamente!", "Éxito",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el PDF: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private PdfPTable CrearTablaDesdeDataTable(DataTable dataTable, iTextSharp.text.Font headerFont, iTextSharp.text.Font normalFont)
        {
            PdfPTable table = new PdfPTable(dataTable.Columns.Count);
            table.WidthPercentage = 100;

            // Agregar headers
            foreach (DataColumn column in dataTable.Columns)
            {
                string headerName = ObtenerNombreAmigable(column.ColumnName);
                table.AddCell(CrearCelda(headerName, headerFont, BaseColor.LIGHT_GRAY));
            }

            // Agregar datos
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var cell in row.ItemArray)
                {
                    table.AddCell(CrearCelda(cell?.ToString() ?? "", normalFont));
                }
            }

            return table;
        }

        private string ObtenerNombreAmigable(string columnName)
        {
            // Puedes personalizar los nombres de las columnas aquí
            var nombres = new Dictionary<string, string>
            {
                { "IdTransaccion", "ID" },
                { "Descripcion", "Descripción" },
                { "Monto", "Monto" },
                { "Fecha", "Fecha" },
                { "Tipo", "Tipo" },
                { "Categoria", "Categoría" },
                { "IdPresupuesto", "ID Presupuesto" },
                { "MontoPresupuestado", "Monto Presupuestado" },
                { "MontoGastado", "Monto Gastado" },
                { "Diferencia", "Diferencia" }
            };

            return nombres.ContainsKey(columnName) ? nombres[columnName] : columnName;
        }

        private PdfPCell CrearCelda(string texto, iTextSharp.text.Font font, BaseColor backgroundColor = null)
        {
            PdfPCell cell = new PdfPCell(new Phrase(texto, font));
            cell.Padding = 5;
            if (backgroundColor != null)
            {
                cell.BackgroundColor = backgroundColor;
            }
            return cell;
        }

        private void lblGastos_Click(object sender, EventArgs e)
        {

        }
    }
}
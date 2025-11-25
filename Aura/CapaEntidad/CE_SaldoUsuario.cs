namespace CapaEntidad
{
    public class CE_SaldoUsuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public decimal TotalIngresos { get; set; }
        public decimal TotalGastos { get; set; }
        public decimal SaldoFinal { get; set; }
    }
}

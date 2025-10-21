namespace CapaEntidad
{
    public class CE_Transaccion
    {
        public int IdTransaccion { get; set; }
        public int IdUsuario { get; set; }
        public int IdCategoria { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; } 
        public string MetodoPago { get; set; }
        public string Nota { get; set; }
    }
}

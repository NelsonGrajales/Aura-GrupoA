namespace CapaEntidad
{
    public class CE_Presupuesto
    {
        public int IdPresupuesto { get; set; }
        public int IdUsuario { get; set; }
        public int IdCategoria { get; set; }
        public decimal MontoLimite { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Periodo { get; set; } // "Mensual", "Semanal", "Anual"
        public string CategoriaNombre { get; set; }

        public decimal MontoGastado { get; set; } // se calcula con transacciones
    }
}

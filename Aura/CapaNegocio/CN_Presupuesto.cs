using CapaDatos;
using CapaEntidad;
using System;
using System.Data;

namespace CapaNegocio
{
    public class CN_Presupuesto
    {
        private readonly CD_Presupuesto cdPresupuesto = new CD_Presupuesto();

        // ------------------------------------------------------------
        // LISTAR
        // ------------------------------------------------------------
        public DataTable ListarConGasto(int idUsuario)
        {
            if (idUsuario <= 0)
                throw new Exception("ID de usuario inválido.");

            return cdPresupuesto.ObtenerPorUsuarioSP(idUsuario);
        }

        // ------------------------------------------------------------
        // AGREGAR
        // ------------------------------------------------------------
        public void Agregar(CE_Presupuesto presupuesto, int idUsuario)
        {
            if (idUsuario <= 0)
                throw new Exception("ID de usuario inválido.");

            ValidarPresupuesto(presupuesto);

            cdPresupuesto.Insertar(presupuesto, idUsuario);
        }

        // ------------------------------------------------------------
        // EDITAR
        // ------------------------------------------------------------
        public void Editar(CE_Presupuesto presupuesto)
        {
            if (presupuesto.IdPresupuesto <= 0)
                throw new Exception("ID de presupuesto inválido.");

            ValidarPresupuesto(presupuesto);

            cdPresupuesto.Actualizar(presupuesto);
        }

        // ------------------------------------------------------------
        // ELIMINAR
        // ------------------------------------------------------------
        public void Eliminar(int idPresupuesto)
        {
            if (idPresupuesto <= 0)
                throw new Exception("ID inválido para eliminar presupuesto.");

            cdPresupuesto.Eliminar(idPresupuesto);
        }

        // ------------------------------------------------------------
        // VALIDACIONES DE NEGOCIO
        // ------------------------------------------------------------
        private void ValidarPresupuesto(CE_Presupuesto p)
        {
            if (p == null)
                throw new Exception("El presupuesto no puede ser nulo.");

            if (p.IdCategoria <= 0)
                throw new Exception("Debe seleccionar una categoría válida.");

            if (p.MontoLimite <= 0)
                throw new Exception("El monto límite debe ser mayor que cero.");

            if (p.FechaInicio == default(DateTime))
                throw new Exception("Debe seleccionar una fecha de inicio válida.");

            if (p.FechaFin == default(DateTime))
                throw new Exception("Debe seleccionar una fecha de fin válida.");

            if (p.FechaFin < p.FechaInicio)
                throw new Exception("La fecha de fin no puede ser menor que la fecha de inicio.");

            if (string.IsNullOrWhiteSpace(p.Periodo))
                throw new Exception("Debe seleccionar un periodo válido (Mensual, Semanal, Anual).");
        }

    }
}

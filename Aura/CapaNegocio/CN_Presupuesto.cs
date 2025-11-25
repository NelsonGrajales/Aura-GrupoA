using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;
using System.Data;

namespace CapaNegocio
{
    public class CN_Presupuesto
    {
        private CD_Presupuesto cdPresupuesto = new CD_Presupuesto();

        public DataTable ListarConGasto(int idUsuario)
        {
            return cdPresupuesto.ObtenerPorUsuarioSP(idUsuario);
        }

        public void Agregar(CE_Presupuesto presupuesto, int idUsuario)
        {
            cdPresupuesto.Insertar(presupuesto, idUsuario);
        }

        public void Editar(CE_Presupuesto presupuesto)
        {
            cdPresupuesto.Actualizar(presupuesto);
        }

        public void Eliminar(int idPresupuesto)
        {
            cdPresupuesto.Eliminar(idPresupuesto);
        }
    }
}

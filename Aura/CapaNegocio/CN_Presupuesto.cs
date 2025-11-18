using System.Collections.Generic;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Presupuesto
    {
        private CD_Presupuesto cdPresupuesto = new CD_Presupuesto();

        public List<CE_Presupuesto> Listar(int idUsuario)
        {
            return cdPresupuesto.ObtenerPorUsuario(idUsuario);
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

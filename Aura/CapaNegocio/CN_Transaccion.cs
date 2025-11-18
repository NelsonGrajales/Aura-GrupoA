using System.Collections.Generic;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Transaccion
    {
        private CD_Transaccion cdTransaccion = new CD_Transaccion();

        public List<CE_Transaccion> Listar(int idUsuario)
        {
            return cdTransaccion.ObtenerTransaccionesPorUsuario(idUsuario);
        }

        public void Agregar(CE_Transaccion transaccion)
        {
            cdTransaccion.InsertarTransaccion(transaccion);
        }
    }
}

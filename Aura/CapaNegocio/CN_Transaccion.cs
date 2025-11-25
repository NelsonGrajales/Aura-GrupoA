using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;
using System.Data;

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

        public DataTable ListarDT(int idUsuario)
        {
            return cdTransaccion.ObtenerTransaccionesDT(idUsuario);
        }

        public DataTable ListarFiltrado(int idUsuario, DateTime? fecha, int? idCategoria)
        {
            return cdTransaccion.ListarFiltrado(idUsuario, fecha, idCategoria);
        }

        public bool Eliminar(int idTransaccion)
        {
            return cdTransaccion.Eliminar(idTransaccion);
        }


    }
}

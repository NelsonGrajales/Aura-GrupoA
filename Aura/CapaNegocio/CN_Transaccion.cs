using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapaNegocio
{
    public class CN_Transaccion
    {
        private readonly CD_Transaccion cdTransaccion = new CD_Transaccion();
        private readonly CN_Categoria cnCategoria = new CN_Categoria();

        // ------------------------------------------------------------
        // LISTAR
        // ------------------------------------------------------------

        public DataTable ListarDT(int idUsuario)
        {
            if (idUsuario <= 0)
                throw new Exception("ID de usuario inválido.");

            return cdTransaccion.ObtenerTransaccionesDT(idUsuario);
        }

        public DataTable ListarFiltrado(int idUsuario, DateTime? fecha, int? idCategoria)
        {
            if (idUsuario <= 0)
                throw new Exception("ID de usuario inválido.");

            return cdTransaccion.ListarFiltrado(idUsuario, fecha, idCategoria);
        }

        // ------------------------------------------------------------
        // AGREGAR
        // ------------------------------------------------------------
        public void Agregar(CE_Transaccion transaccion)
        {
            ValidarTransaccion(transaccion);

            cdTransaccion.InsertarTransaccion(transaccion);
        }

        // ------------------------------------------------------------
        // EDITAR
        // ------------------------------------------------------------
        public bool Editar(CE_Transaccion t)
        {
            if (t.IdTransaccion <= 0)
                throw new Exception("ID de transacción no válido.");

            ValidarTransaccion(t);

            return cdTransaccion.Editar(t);
        }

        // ------------------------------------------------------------
        // ELIMINAR
        // ------------------------------------------------------------
        public bool Eliminar(int idTransaccion)
        {
            if (idTransaccion <= 0)
                throw new Exception("ID inválido para eliminar.");

            return cdTransaccion.Eliminar(idTransaccion);
        }

        // ------------------------------------------------------------
        // VALIDACIONES DE NEGOCIO
        // ------------------------------------------------------------
        private void ValidarTransaccion(CE_Transaccion t)
        {
            if (t == null)
                throw new Exception("La transacción no puede ser nula.");

            if (t.IdUsuario <= 0)
                throw new Exception("Usuario inválido.");

            if (t.IdCategoria <= 0)
                throw new Exception("Debe seleccionar una categoría.");

            if (t.Monto <= 0)
                throw new Exception("El monto debe ser mayor que cero.");

            if (string.IsNullOrEmpty(t.Tipo))
                throw new Exception("Debe seleccionar un tipo (Ingreso o Gasto).");

            if (string.IsNullOrEmpty(t.MetodoPago))
                throw new Exception("Debe seleccionar un método de pago.");

            if (t.Fecha == default)
                throw new Exception("Debe seleccionar una fecha válida.");
        }
    }
}

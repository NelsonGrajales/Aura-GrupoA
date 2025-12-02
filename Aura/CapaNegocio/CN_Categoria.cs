using System;
using System.Collections.Generic;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Categoria
    {
        private readonly CD_Categoria cdCategoria = new CD_Categoria();

        // ------------------------------------------------------------
        // LISTAR
        // ------------------------------------------------------------
        public List<CE_Categoria> Listar(int idUsuario)
        {
            if (idUsuario <= 0)
                throw new Exception("ID de usuario inválido.");

            return cdCategoria.ObtenerPorUsuario(idUsuario);
        }

        // ------------------------------------------------------------
        // AGREGAR
        // ------------------------------------------------------------
        public void Agregar(CE_Categoria categoria, int idUsuario)
        {
            if (idUsuario <= 0)
                throw new Exception("ID de usuario inválido.");

            ValidarCategoria(categoria);

            cdCategoria.Insertar(categoria, idUsuario);
        }

        // ------------------------------------------------------------
        // EDITAR
        // ------------------------------------------------------------
        public bool Editar(CE_Categoria categoria)
        {
            if (categoria.IdCategoria <= 0)
                throw new Exception("ID de categoría inválido.");

            ValidarCategoria(categoria);

            return cdCategoria.Editar(categoria);
        }

        // ------------------------------------------------------------
        // ELIMINAR
        // ------------------------------------------------------------
        public void Eliminar(int idCategoria)
        {
            if (idCategoria <= 0)
                throw new Exception("ID de categoría inválido.");

            if (cdCategoria.CategoriaTieneTransacciones(idCategoria))
                throw new Exception("No puede eliminar esta categoría porque tiene transacciones asociadas.");

            cdCategoria.Eliminar(idCategoria);
        }

        // ------------------------------------------------------------
        // VALIDACIÓN
        // ------------------------------------------------------------
        private void ValidarCategoria(CE_Categoria categoria)
        {
            if (categoria == null)
                throw new Exception("La categoría no puede ser nula.");

            if (string.IsNullOrWhiteSpace(categoria.Nombre))
                throw new Exception("El nombre de la categoría es obligatorio.");

            if (categoria.Nombre.Length > 50)
                throw new Exception("El nombre de la categoría no puede exceder 50 caracteres.");
        }

        // ------------------------------------------------------------
        // CONSULTAS SIMPLES
        // ------------------------------------------------------------
        public bool TieneTransacciones(int idCategoria)
        {
            if (idCategoria <= 0)
                throw new Exception("ID de categoría inválido.");

            return cdCategoria.CategoriaTieneTransacciones(idCategoria);
        }
    }
}

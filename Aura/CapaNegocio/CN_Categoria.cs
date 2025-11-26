using System.Collections.Generic;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Categoria
    {
        private CD_Categoria cdCategoria = new CD_Categoria();

        public List<CE_Categoria> Listar(int idUsuario)
        {
            return cdCategoria.ObtenerPorUsuario(idUsuario);
        }

        public void Agregar(CE_Categoria categoria, int idUsuario)
        {
            cdCategoria.Insertar(categoria, idUsuario);
        }

        public void Eliminar(int idCategoria)
        {
            cdCategoria.Eliminar(idCategoria);
        }

        public bool TieneTransacciones(int idCategoria)
        {
            return cdCategoria.CategoriaTieneTransacciones(idCategoria);
        }
        public bool Editar(CE_Categoria categoria)
        {
            return cdCategoria.Editar(categoria);
        }

    }

}

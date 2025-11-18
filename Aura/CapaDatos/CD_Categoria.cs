using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Categoria
    {
        private string conexion = "Server=localhost;Database=Proyecto;Uid=root;Pwd=8020;";

        public List<CE_Categoria> ObtenerPorUsuario(int idUsuario)
        {
            List<CE_Categoria> lista = new List<CE_Categoria>();

            using (var cn = new MySqlConnection(conexion))
            {
                cn.Open();
                string sql = "SELECT * FROM categorias WHERE id_usuario = @IdUsuario";

                using (var cmd = new MySqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new CE_Categoria
                            {
                                IdCategoria = dr.GetInt32("id_categoria"),
                                Nombre = dr.GetString("nombre"),
                                Tipo = dr.GetString("tipo"),
                                Color = dr.GetString("color")
                            });
                        }
                    }
                }
            }

            return lista;
        }

        public void Insertar(CE_Categoria categoria, int idUsuario)
        {
            using (var cn = new MySqlConnection(conexion))
            {
                cn.Open();
                string sql = @"INSERT INTO categorias (id_usuario, nombre, tipo, color)
                               VALUES (@IdUsuario, @Nombre, @Tipo, @Color)";

                using (var cmd = new MySqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                    cmd.Parameters.AddWithValue("@Tipo", categoria.Tipo);
                    cmd.Parameters.AddWithValue("@Color", categoria.Color);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int idCategoria)
        {
            using (var cn = new MySqlConnection(conexion))
            {
                cn.Open();
                string sql = "DELETE FROM categorias WHERE id_categoria = @IdCategoria";

                using (var cmd = new MySqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

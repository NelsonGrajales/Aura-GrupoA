using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Transaccion
    {
        private string conexion = "Server=localhost;Database=Proyecto;Uid=root;Pwd=8020;";

        public List<CE_Transaccion> ObtenerTransaccionesPorUsuario(int idUsuario)
        {
            List<CE_Transaccion> lista = new List<CE_Transaccion>();

            using (var cn = new MySqlConnection(conexion))
            {
                cn.Open();
                string sql = "SELECT * FROM transacciones WHERE id_usuario = @IdUsuario ORDER BY fecha DESC";

                using (var cmd = new MySqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new CE_Transaccion
                            {
                                IdTransaccion = dr.GetInt32("id_transaccion"),
                                IdUsuario = dr.GetInt32("id_usuario"),
                                IdCategoria = dr.GetInt32("id_categoria"),
                                Monto = dr.GetDecimal("monto"),
                                Fecha = dr.GetDateTime("fecha"),
                                Tipo = dr.GetString("tipo"),
                                MetodoPago = dr.GetString("metodo_pago"),
                                Nota = dr["nota"].ToString()
                            });
                        }
                    }
                }
            }

            return lista;
        }

        public void InsertarTransaccion(CE_Transaccion t)
        {
            using (var cn = new MySqlConnection(conexion))
            {
                cn.Open();
                string sql = @"INSERT INTO transacciones 
                            (id_usuario, id_categoria, monto, fecha, tipo, metodo_pago, nota)
                            VALUES (@IdUsuario, @IdCategoria, @Monto, @Fecha, @Tipo, @MetodoPago, @Nota)";

                using (var cmd = new MySqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@IdUsuario", t.IdUsuario);
                    cmd.Parameters.AddWithValue("@IdCategoria", t.IdCategoria);
                    cmd.Parameters.AddWithValue("@Monto", t.Monto);
                    cmd.Parameters.AddWithValue("@Fecha", t.Fecha);
                    cmd.Parameters.AddWithValue("@Tipo", t.Tipo);
                    cmd.Parameters.AddWithValue("@MetodoPago", t.MetodoPago);
                    cmd.Parameters.AddWithValue("@Nota", t.Nota ?? "");
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

using CapaEntidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

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

        public CE_SaldoUsuario ObtenerSaldoUsuario(int idUsuario)
        {
            CE_SaldoUsuario saldo = null;

            using (var cn = new MySqlConnection(conexion))
            {
                cn.Open();

                using (var cmd = new MySqlCommand("sp_calcular_saldos_usuarios", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_id_usuario", idUsuario);

                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            saldo = new CE_SaldoUsuario
                            {
                                IdUsuario = dr.GetInt32("id_usuario"),
                                Nombre = dr.GetString("nombre"),
                                TotalIngresos = dr.GetDecimal("total_ingresos"),
                                TotalGastos = dr.GetDecimal("total_gastos"),
                                SaldoFinal = dr.GetDecimal("saldo_final")
                            };
                        }
                    }
                }
            }

            return saldo;
        }

        public DataTable ObtenerTransaccionesDT(int idUsuario)
        {
            DataTable dt = new DataTable();

            using (var cn = new MySqlConnection(conexion))
            {
                cn.Open();

                string sql = @"
            SELECT 
                t.id_transaccion,
                t.monto,
                t.fecha,
                t.tipo,
                c.nombre AS categoria,
                t.metodo_pago,
                t.nota
            FROM transacciones t
            INNER JOIN categorias c ON t.id_categoria = c.id_categoria
            WHERE t.id_usuario = @IdUsuario
            ORDER BY t.fecha DESC";

                using (var cmd = new MySqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }


        public DataTable ListarFiltrado(int idUsuario, DateTime? fecha, int? idCategoria)
        {
            DataTable tabla = new DataTable();

            using (var cn = new MySqlConnection(conexion))
            {
                cn.Open();

                // Consulta base con JOIN para obtener el nombre de la categoria
                string sql = @"
            SELECT 
                t.id_transaccion,
                c.nombre AS categoria,
                t.monto,
                t.fecha,
                t.tipo,
                t.metodo_pago,
                t.nota
            FROM transacciones t
            INNER JOIN categorias c 
                ON t.id_categoria = c.id_categoria
            WHERE t.id_usuario = @IdUsuario";

                // Agregar filtros dinámicos
                if (fecha != null)
                    sql += " AND DATE(t.fecha) = @Fecha";

                if (idCategoria != null)
                    sql += " AND t.id_categoria = @IdCategoria";

                using (var cmd = new MySqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                    if (fecha != null)
                        cmd.Parameters.AddWithValue("@Fecha", fecha.Value.Date);

                    if (idCategoria != null)
                        cmd.Parameters.AddWithValue("@IdCategoria", idCategoria.Value);

                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(tabla);
                    }
                }
            }

            return tabla;
        }

        public bool Eliminar(int idTransaccion)
        {
            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                conn.Open();
                string query = "DELETE FROM transacciones WHERE id_transaccion = @id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idTransaccion);

                return cmd.ExecuteNonQuery() > 0;
            }
        }



    }
}

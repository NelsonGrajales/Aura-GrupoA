using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Presupuesto
    {
        private string conexion = "Server=localhost;Database=Proyecto;Uid=root;Pwd=8020;";

        public List<CE_Presupuesto> ObtenerPorUsuario(int idUsuario)
        {
            List<CE_Presupuesto> lista = new List<CE_Presupuesto>();

            using (var cn = new MySqlConnection(conexion))
            {
                cn.Open();
                string sql = @"
                    SELECT p.id_presupuesto, p.id_categoria, c.nombre AS categoria,
                           p.monto_limite, p.fecha_inicio, p.fecha_fin, 
                           p.periodo, p.monto_gastado
                    FROM presupuestos p
                    INNER JOIN categorias c ON p.id_categoria = c.id_categoria
                    WHERE p.id_usuario = @IdUsuario";

                using (var cmd = new MySqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new CE_Presupuesto
                            {
                                IdPresupuesto = dr.GetInt32("id_presupuesto"),
                                IdCategoria = dr.GetInt32("id_categoria"),
                                CategoriaNombre = dr.GetString("categoria"),
                                MontoLimite = dr.GetDecimal("monto_limite"),
                                FechaInicio = dr.GetDateTime("fecha_inicio"),
                                FechaFin = dr.GetDateTime("fecha_fin"),
                                Periodo = dr.GetString("periodo"),
                                MontoGastado = dr.GetDecimal("monto_gastado")
                            });
                        }
                    }
                }
            }

            return lista;
        }

        public void Insertar(CE_Presupuesto p, int idUsuario)
        {
            using (var cn = new MySqlConnection(conexion))
            {
                cn.Open();
                string sql = @"INSERT INTO presupuestos 
                               (id_usuario, id_categoria, monto_limite, fecha_inicio, fecha_fin, periodo, monto_gastado)
                               VALUES (@IdUsuario, @IdCategoria, @MontoLimite, @FechaInicio, @FechaFin, @Periodo, @MontoGastado)";

                using (var cmd = new MySqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@IdCategoria", p.IdCategoria);
                    cmd.Parameters.AddWithValue("@MontoLimite", p.MontoLimite);
                    cmd.Parameters.AddWithValue("@FechaInicio", p.FechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFin", p.FechaFin);
                    cmd.Parameters.AddWithValue("@Periodo", p.Periodo);
                    cmd.Parameters.AddWithValue("@MontoGastado", p.MontoGastado);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Actualizar(CE_Presupuesto p)
        {
            using (var cn = new MySqlConnection(conexion))
            {
                cn.Open();
                string sql = @"UPDATE presupuestos 
                               SET id_categoria=@IdCategoria, monto_limite=@MontoLimite,
                                   fecha_inicio=@FechaInicio, fecha_fin=@FechaFin, 
                                   periodo=@Periodo, monto_gastado=@MontoGastado
                               WHERE id_presupuesto=@IdPresupuesto";

                using (var cmd = new MySqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@IdCategoria", p.IdCategoria);
                    cmd.Parameters.AddWithValue("@MontoLimite", p.MontoLimite);
                    cmd.Parameters.AddWithValue("@FechaInicio", p.FechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFin", p.FechaFin);
                    cmd.Parameters.AddWithValue("@Periodo", p.Periodo);
                    cmd.Parameters.AddWithValue("@MontoGastado", p.MontoGastado);
                    cmd.Parameters.AddWithValue("@IdPresupuesto", p.IdPresupuesto);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int idPresupuesto)
        {
            using (var cn = new MySqlConnection(conexion))
            {
                cn.Open();
                string sql = "DELETE FROM presupuestos WHERE id_presupuesto = @Id";

                using (var cmd = new MySqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@Id", idPresupuesto);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

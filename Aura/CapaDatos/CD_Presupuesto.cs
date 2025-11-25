using CapaEntidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapaDatos
{
    public class CD_Presupuesto
    {
        private string conexion = "Server=localhost;Database=Proyecto;Uid=root;Pwd=8020;";

        public DataTable ObtenerPorUsuarioSP(int idUsuario)
        {
            DataTable dt = new DataTable();

            using (var cn = new MySqlConnection(conexion))
            {
                cn.Open();
                using (var cmd = new MySqlCommand("sp_listar_presupuestos_con_gasto", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_id_usuario", idUsuario);

                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
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

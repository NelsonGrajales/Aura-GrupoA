using MySql.Data.MySqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Usuario
    {
        private string conexion = "Server=localhost;Database=Proyecto;Uid=root;Pwd=8020;";

        public CE_Usuario ValidarLogin(string email, string password)
        {
            CE_Usuario usuario = null;

            using (var cn = new MySqlConnection(conexion))
            {
                cn.Open();
                string sql = "SELECT id_usuario, nombre, email, password, fecha_registro " +
                             "FROM usuarios WHERE email=@Email AND password=@Password LIMIT 1";

                using (var cmd = new MySqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            usuario = new CE_Usuario
                            {
                                IdUsuario = dr.GetInt32("id_usuario"),
                                Nombre = dr.GetString("nombre"),
                                Email = dr.GetString("email"),
                                Password = dr.GetString("password"),
                                FechaRegistro = dr.GetDateTime("fecha_registro")
                            };
                        }
                    }
                }
            }

            return usuario;
        }

    }
}

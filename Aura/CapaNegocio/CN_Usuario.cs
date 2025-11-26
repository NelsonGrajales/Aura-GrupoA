using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario datos = new CD_Usuario();

        public CE_Usuario Login(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                throw new Exception("Email y contraseña son obligatorios");

            CE_Usuario usuario = datos.ValidarLogin(email, password);

            if (usuario == null)
                throw new Exception("Usuario o contraseña incorrectos");

            return usuario;
        }

        public bool Registrar(string nombre, string email, string password)
        {
            return datos.Registrar(nombre, email, password);
        }
    }
}

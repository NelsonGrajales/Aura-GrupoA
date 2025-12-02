using CapaDatos;
using CapaEntidad;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario cd = new CD_Usuario();

        // -----------------------------
        // MÉTODO LOGIN
        // -----------------------------
        public CE_Usuario Login(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new Exception("Debe ingresar un correo.");

            if (string.IsNullOrWhiteSpace(password))
                throw new Exception("Debe ingresar una contraseña.");

            if (!EsEmailValido(email))
                throw new Exception("El correo no tiene un formato válido.");

            string passEncriptada = EncriptarSHA256(password);

            return cd.ValidarLogin(email, passEncriptada);
        }

        // -----------------------------
        // MÉTODO REGISTRAR
        // -----------------------------
        public bool Registrar(string nombre, string email, string password)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new Exception("El nombre es obligatorio.");

            if (string.IsNullOrWhiteSpace(email))
                throw new Exception("El correo es obligatorio.");

            if (!EsEmailValido(email))
                throw new Exception("El correo no tiene un formato válido.");

            if (string.IsNullOrWhiteSpace(password))
                throw new Exception("La contraseña es obligatoria.");

            if (password.Length < 6)
                throw new Exception("La contraseña debe tener al menos 6 caracteres.");

            // Verificar si el correo ya existe
            if (cd.ExisteEmail(email))
                throw new Exception("El correo ya está registrado.");

            string passEncriptada = EncriptarSHA256(password);

            return cd.Registrar(nombre, email, passEncriptada);
        }

        // -----------------------------
        // VALIDAR CORREO
        // -----------------------------
        private bool EsEmailValido(string email)
        {
            return Regex.IsMatch(email,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                RegexOptions.IgnoreCase);
        }

        // -----------------------------
        // ENCRIPTAR SHA256
        // -----------------------------
        private string EncriptarSHA256(string texto)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(texto);
                byte[] hash = sha.ComputeHash(bytes);

                StringBuilder sb = new StringBuilder();
                foreach (byte b in hash)
                    sb.Append(b.ToString("x2"));

                return sb.ToString();
            }
        }
    }
}

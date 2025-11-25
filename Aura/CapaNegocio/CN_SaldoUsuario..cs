using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_SaldoUsuario
    {
        private CD_Transaccion cdSaldo = new CD_Transaccion();

        public CE_SaldoUsuario ObtenerSaldo(int idUsuario)
        {
            return cdSaldo.ObtenerSaldoUsuario(idUsuario);
        }
    }
}

using Entidades;

namespace Presentación
{
    public class SesionUsuario
    {
        public static Usuarios? Actual { get; private set; }

        public static void Iniciar(Usuarios usuario)
        {
            Actual = usuario;
        }

        public static void Cerrar()
        {
            Actual = null;
        }
    }
}

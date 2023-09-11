using Entrega1_Patrones.Products;

namespace Entrega1_Patrones.Services.Login.Implements
{
    public class AnonimoLogin : ILoginService
    {
        private readonly Permiso _permiso;

        public AnonimoLogin(Permiso permiso)
        {
            _permiso = permiso;
        }
        public string IniciarSesion()
        {
            return $"Inicio de sesión anonimo con {_permiso.ObtenerPermisos()}\n";
        }
    }
}

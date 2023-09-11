using Entrega1_Patrones.Business.Entities;
using Entrega1_Patrones.Products;

namespace Entrega1_Patrones.Services.Login.Implements
{
    public class ClienteLogin : ILoginService
    {
        private readonly Usuario _usuario;
        private readonly Permiso _permiso;

        public ClienteLogin(CuentaDTO cuenta)
        {
            _usuario = cuenta.Usuario;
            _permiso = cuenta.Permiso;
        }

        public string IniciarSesion()
        {
            return $"Inicio de sesión exitoso {_usuario.Nombre}\n {_permiso.ObtenerPermisos()}";
        }
    }
}

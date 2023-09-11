using Entrega1_Patrones.Products;
using Entrega1_Patrones.Products.Specific.Administrator;

namespace Entrega1_Patrones.Factory.Administrator
{
    public class AdministradorFactory : IUsuarioFactory
    {
        public Permiso CrearPermiso()
        {
            return new PermisoAdministrador();
        }

        public Usuario CrearUsuario()
        {
            return new Administrador();
        }
    }
}

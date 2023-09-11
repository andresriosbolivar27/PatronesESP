using Entrega1_Patrones.Products;
using Entrega1_Patrones.Products.Specific.Client;

namespace Entrega1_Patrones.Factory.Client
{
    public class ClienteFactory : IUsuarioFactory
    {
        public Permiso CrearPermiso()
        {
            return new PermisoCliente();
        }

        public Usuario CrearUsuario()
        {
            return new Cliente();
        }
    }
}

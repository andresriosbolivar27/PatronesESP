using Entrega1_Patrones.Products;
using Entrega1_Patrones.Products.Specific.Anonymous;

namespace Entrega1_Patrones.Factory.Anonymous
{
    public class AnonimoFactory : IUsuarioFactory
    {
        public Permiso CrearPermiso()
        {
            return new PermisoAnonimo();
        }

        public Usuario CrearUsuario()
        {
            return new Anonimo();
        }
    }
}

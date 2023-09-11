using Entrega1_Patrones.Products;
using Entrega1_Patrones.Products.Specific.Veterinary;

namespace Entrega1_Patrones.Factory.Veterinary
{
    public class VeterinarioFactory : IUsuarioFactory
    {
        public Permiso CrearPermiso()
        {
            return new PermisoVeterinario();
        }

        public Usuario CrearUsuario()
        {
            return new Veterinario();
        }
    }
}

using Entrega1_Patrones.Products;

namespace Entrega1_Patrones.Factory
{
    public interface IUsuarioFactory
    {
        public Usuario CrearUsuario();
        public Permiso CrearPermiso();
    }
}

namespace Entrega1_Patrones.Products
{
    public abstract class Permiso
    {
        public bool Crear { get; set; }
        public bool Consultar { get; set; }
        public bool Editar { get; set; }
        public bool Eliminar { get; set; }
        public abstract string ObtenerPermisos();
    }
}

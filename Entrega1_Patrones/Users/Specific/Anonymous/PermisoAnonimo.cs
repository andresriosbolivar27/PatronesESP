namespace Entrega1_Patrones.Products.Specific.Anonymous
{
    public class PermisoAnonimo : Permiso
    {
        public PermisoAnonimo()
        {
            this.Crear = false;
            this.Consultar = true;
            this.Editar = false;
            this.Eliminar = false;
        }

        public override string ObtenerPermisos()
        {
            return
                $"Permisos de:\n" +
                $"Crear: {this.Crear} " +
                $"Consultar: {this.Consultar} " +
                $"Editar: {this.Editar} " +
                $"Eliminar: {this.Eliminar} ";
        }
    }
}

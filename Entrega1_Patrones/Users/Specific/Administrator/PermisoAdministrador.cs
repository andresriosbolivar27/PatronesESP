namespace Entrega1_Patrones.Products.Specific.Administrator
{
    public class PermisoAdministrador : Permiso
    {
        public PermisoAdministrador()
        {
            this.Crear = true;
            this.Consultar = true;
            this.Editar = true;
            this.Eliminar = true;
        }

        public override string ObtenerPermisos()
        {
            return
                "Permisos de:\n" +
                $"Crear: {this.Crear} " +
                $"Consultar: {this.Consultar} " +
                $"Editar: {this.Editar} " +
                $"Eliminar: {this.Eliminar} ";
        }
    }
}

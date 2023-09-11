namespace Entrega1_Patrones.Products.Specific.Veterinary
{
    public class PermisoVeterinario : Permiso
    {
        public PermisoVeterinario()
        {
            this.Crear = true;
            this.Consultar = true;
            this.Editar = true;
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

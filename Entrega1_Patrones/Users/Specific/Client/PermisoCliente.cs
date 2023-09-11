namespace Entrega1_Patrones.Products.Specific.Client
{
    public class PermisoCliente : Permiso
    {
        public PermisoCliente()
        {
            this.Crear = true;
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

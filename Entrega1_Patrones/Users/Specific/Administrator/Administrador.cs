using Entrega1_Patrones.Business.Entities;

namespace Entrega1_Patrones.Products.Specific.Administrator
{
    public class Administrador : Usuario
    {
        public Administrador()
        {
            Rol = "Administrador";
        }

        public void GestionarUsuarios(List<CuentaDTO> cuentas)
        {
            Console.WriteLine("Gestionando usuarios:");
            foreach (var cuenta in cuentas)
            {
                Console.WriteLine($"- {cuenta.Usuario.Nombre} ({cuenta.Usuario.Email})");
            }
        }

        public void GestionarServicios(List<ServicioVeterinario> servicios)
        {
            Console.WriteLine("\nGestionando servicios veterinarios:");

            foreach (var servicio in servicios)
            {
                Console.WriteLine($"- {servicio.Nombre} ({servicio.Especialidad}): ${servicio.Precio}");
            }
        }
    }
}

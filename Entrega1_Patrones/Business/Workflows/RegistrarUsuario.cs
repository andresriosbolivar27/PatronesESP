using Entrega1_Patrones.Business.Entities;
using Entrega1_Patrones.Factory;
using Entrega1_Patrones.Helpers;
using Entrega1_Patrones.Products;

namespace Entrega1_Patrones.Business.Workflows
{
    public class RegistrarUsuario
    {
        private readonly IUsuarioFactory _factory;

        public RegistrarUsuario(IUsuarioFactory factory)
        {
            _factory = factory;
        }

        public void AdicionarUsuario(List<CuentaDTO> usuarios)
        {
            Usuario nuevoUsuario = _factory.CrearUsuario();
            Permiso permisoUsuario = _factory.CrearPermiso();
            PrinterHelper.ImprimirSeparador();
            Console.WriteLine($"Registrando usuario {nuevoUsuario.Rol}");

            foreach (var property in nuevoUsuario.GetType().GetProperties())
            {
                if (string.IsNullOrEmpty(property.GetValue(nuevoUsuario)!.ToString()))
                {
                    Console.WriteLine($"Ingrese el valor para el campo {property.Name}:");
                    var valor = Console.ReadLine();
                    property.SetValue(nuevoUsuario, valor);
                }
            }

            usuarios.Add(new CuentaDTO { Usuario = nuevoUsuario, Permiso = permisoUsuario });
            Console.WriteLine($"Usuario {nuevoUsuario.Nombre} registrado con éxito.\n");
            Console.WriteLine($"{permisoUsuario.ObtenerPermisos()}");
            permisoUsuario.ObtenerPermisos();
            PrinterHelper.ImprimirSeparador();
        }
    }
}

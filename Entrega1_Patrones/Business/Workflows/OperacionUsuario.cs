using Entrega1_Patrones.Business.Entities;
using Entrega1_Patrones.Helpers;
using Entrega1_Patrones.Products;
using Entrega1_Patrones.Products.Specific.Administrator;
using Entrega1_Patrones.Products.Specific.Client;
using Entrega1_Patrones.Products.Specific.Veterinary;
using Entrega1_Patrones.Services.Login;

namespace Entrega1_Patrones.Business.Workflows
{
    public class OperacionUsuario
    {
        private readonly List<Usuario> _veterinarios;
        private readonly List<Usuario> _clientes;
        private readonly List<CuentaDTO> _usuarios;

        public OperacionUsuario(List<CuentaDTO> usuarios)
        {
            _usuarios = usuarios;
            _veterinarios = usuarios.Where(v => v.Usuario.Rol == "Veterinario").Select(x => x.Usuario).ToList();
            _clientes = usuarios.Where(v => v.Usuario.Rol == "Cliente").Select(x => x.Usuario).ToList();
        }
        public void RealizarOperacion(Usuario cuentaUsuario)
        {
            PrinterHelper.ImprimirSeparador();
            Console.WriteLine($"Operacion de usuario: {cuentaUsuario.Rol}");

            if (cuentaUsuario != null)
            {
                ILoginService loginService;

                switch (cuentaUsuario.Rol)
                {
                    case "Administrador":
                        var administrador = (Administrador)cuentaUsuario;
                        administrador.GestionarUsuarios(_usuarios);
                        administrador.GestionarServicios(new List<ServicioVeterinario>
                            {
                                new ServicioVeterinario { Nombre = "Consulta General", Especialidad = "General", Precio = 50.0M },
                                new ServicioVeterinario { Nombre = "Vacunación", Especialidad = "Prevención", Precio = 30.0M },
                                new ServicioVeterinario { Nombre = "Cirugía", Especialidad = "Cirugía", Precio = 150.0M }
                            });
                        break;
                    case "Cliente":
                        var cliente = (Cliente)cuentaUsuario;
                        var venterinarioAgendado = _veterinarios.FirstOrDefault() as Veterinario;
                        cliente.AgendarCita(venterinarioAgendado, DateTime.Now.AddDays(7));
                        cliente.ConsultarCitas();
                        cliente.ConsultarHistorialMedico();
                        break;
                    case "Veterinario":
                        var veterinario = (Veterinario)cuentaUsuario;
                        var clienteAtendido = _clientes.FirstOrDefault() as Cliente;
                        veterinario.RealizarDiagnostico(clienteAtendido, DateTime.Now, "Picazón en la piel");
                        break;
                    case "Anonimo":
                        Console.WriteLine("Inicio de sesión fallido. Verifique sus credenciales.");
                        break;
                    default:
                        Console.WriteLine("Rol de usuario no válido.");
                        break;
                }

                PrinterHelper.ImprimirSeparador();

            }
        }
    }
}

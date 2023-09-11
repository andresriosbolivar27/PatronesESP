using Entrega1_Patrones.Business.Entities;
using Entrega1_Patrones.Helpers;
using Entrega1_Patrones.Services.Login;
using Entrega1_Patrones.Services.Login.Implements;

namespace Entrega1_Patrones.Business.Workflows
{
    public class IniciarSesion
    {
        public static void InicioSesion(List<CuentaDTO> usuarios)
        {
            var operacion = new OperacionUsuario(usuarios);

            while (true)
            {
                PrinterHelper.ImprimirSeparador();
                Console.WriteLine("Inicio de sesión:");
                Console.WriteLine("Ingrese su correo electrónico:");
                var email = Console.ReadLine();
                Console.WriteLine("Ingrese su contraseña:");
                var contrasena = Console.ReadLine();

                CuentaDTO? cuentaUsuario = usuarios.FirstOrDefault(u => u.Usuario.Email == email && u.Usuario.Contrasena == contrasena);

                if (cuentaUsuario != null)
                {
                    ILoginService loginService;

                    switch (cuentaUsuario.Usuario.Rol)
                    {
                        case "Administrador":
                            loginService = new AdministradorLogin(cuentaUsuario);
                            Console.WriteLine(loginService.IniciarSesion());
                            operacion.RealizarOperacion(cuentaUsuario.Usuario);
                            break;
                        case "Cliente":
                            loginService = new ClienteLogin(cuentaUsuario);
                            loginService.IniciarSesion();
                            operacion.RealizarOperacion(cuentaUsuario.Usuario);
                            break;
                        case "Veterinario":
                            loginService = new VeterinarioLogin(cuentaUsuario);
                            loginService.IniciarSesion();
                            operacion.RealizarOperacion(cuentaUsuario.Usuario);
                            break;
                        case "Anonimo":
                            loginService = new AnonimoLogin(cuentaUsuario.Permiso);
                            loginService.IniciarSesion();
                            operacion.RealizarOperacion(cuentaUsuario.Usuario);
                            break;
                        default:
                            Console.WriteLine("Rol de usuario no válido.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Inicio de sesión fallido. Verifique sus credenciales.");
                }

                PrinterHelper.ImprimirSeparador();
                Console.WriteLine("¿Desea iniciar sesión con otro usuario? (S/N)");
                var respuesta = Console.ReadLine() ?? "N";

                if (respuesta.ToUpper() != "S")
                {
                    break;
                }
            }
        }
    }
}

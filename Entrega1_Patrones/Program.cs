using Entrega1_Patrones.Business.Entities;
using Entrega1_Patrones.Business.Workflows;
using Entrega1_Patrones.Factory;
using Entrega1_Patrones.Factory.Administrator;
using Entrega1_Patrones.Factory.Anonymous;
using Entrega1_Patrones.Factory.Client;
using Entrega1_Patrones.Factory.Veterinary;
using Entrega1_Patrones.Services.Connection;

public class Program
{
    public static void Main(string[] args)
    {
        DatabaseConnection.Connect();

        var usuarios = new List<CuentaDTO>();
        var factories = new List<IUsuarioFactory>
        {
            new AdministradorFactory(),
            new ClienteFactory(),
            new VeterinarioFactory(),
            new AnonimoFactory()
        };

        RegistrarUsuario cliente;

        foreach (var factory in factories)
        {
            cliente = new RegistrarUsuario(factory);
            cliente.AdicionarUsuario(usuarios);
        }

        IniciarSesion.InicioSesion(usuarios);
    }
}
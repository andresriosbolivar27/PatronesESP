using Entrega1_Patrones.Products.Specific.Client;

namespace Entrega1_Patrones.Products.Specific.Veterinary
{
    public class Veterinario : Usuario
    {
        public string Especialidad { get; set; }

        public Veterinario()
        {
            Rol = "Veterinario";
            Especialidad = string.Empty;
        }

        public void RealizarDiagnostico(Cliente cliente, DateTime fecha, string sintomas)
        {
            Console.WriteLine($"Realizando diagnóstico para {cliente.Nombre}\n" +
                $"Cliente: {cliente.Nombre}\n" +
                $"Mascota: {cliente.Mascota}\n" +
                $"Fecha: {fecha}\n" +
                $"Diagnostico: {sintomas}");
        }
    }
}

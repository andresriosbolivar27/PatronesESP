using Entrega1_Patrones.Products.Specific.Veterinary;

namespace Entrega1_Patrones.Products.Specific.Client
{
    public class Cliente : Usuario
    {
        private readonly List<Veterinario> _veterinarios;

        public string Mascota { get; set; }
        public string Direccion { get; set; }
        public List<Cita> Citas { get; set; }

        public Cliente()
        {
            Mascota = string.Empty;
            Citas = new List<Cita>();
            Rol = "Cliente";
            Direccion = string.Empty;           
        }

        public void ConsultarCitas()
        {
            Console.WriteLine("Consultando citas agendadas:");
            foreach (var cita in Citas)
            {
                Console.WriteLine($"- Veterinario: {cita.Veterinario.Nombre}, Fecha: {cita.Fecha}");
            }
        }

        public void AgendarCita(Veterinario veterinario, DateTime fecha)
        {
            Console.WriteLine($"Agendando cita con el veterinario {veterinario.Nombre} para el {fecha}");
            Citas.Add(new Cita { Fecha = fecha, Veterinario = veterinario, Cliente = this });
        }

        public void ConsultarHistorialMedico()
        {
            Console.WriteLine("Consultando historial médico:");
        }
    }
}

using Entrega1_Patrones.Products.Specific.Client;
using Entrega1_Patrones.Products.Specific.Veterinary;

public class Cita
{
    public DateTime Fecha { get; set; }
    public Veterinario Veterinario { get; set; }
    public Cliente Cliente { get; set; }
}

using Entrega1_Patrones.Products.Specific.Administrator;
using Entrega1_Patrones.Products.Specific.Client;
using Entrega1_Patrones.Products.Specific.Veterinary;
using System.Data.Common;

namespace Entrega1_Patrones.Services.Singleton
{
    public abstract class AbstractContext
    {
        public Cliente Clients { get; set; }
        public Administrador Admistrators { get; set; }
        public Veterinario Veterinaries { get; set; }

        public abstract string GetStatusConnection();
        
    }
}

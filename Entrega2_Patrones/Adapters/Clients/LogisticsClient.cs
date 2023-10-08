using Entrega2_Patrones.Adapters.Abstractions;

namespace Entrega2_Patrones.Adapters.Clients
{
    public class LogisticsClient
    {
        private readonly INewShippingService newService;

        public LogisticsClient(INewShippingService service)
        {
            newService = service;
        }

        public void ProcessInformationShipments()
        {
            var shipping = newService.ProcessInformationJSON();

            if (!shipping.Any())
            {
                Console.WriteLine("No hay envios para procesar");

                return;
            }

            Console.WriteLine("Procesando información de envíos transformada:");
            
            foreach (var shipment in shipping)
            {
                Console.WriteLine(shipment);
            }
        }
    }
}

using Entrega2_Patrones.Adapters.Abstractions;
using Entrega2_Patrones.Business.Entities;
using Newtonsoft.Json;

namespace Entrega2_Patrones.Adapters.Implements
{
    public class NewShippingService : INewShippingService
    {
        public ICollection<Shipment> ProcessInformationJSON()
        {
            Console.WriteLine("Obteniendo información de envíos en formato JSON del servicio nuevo...");
            var enviosJson = " [{ \"ID\": \"001\", \"Destino\": \"DestinoX\" },{ \"ID\": \"002\", \"Destino\": \"DestinoY\" }]";

            return JsonConvert.DeserializeObject<ICollection<Shipment>>(enviosJson) ?? new List<Shipment>();
        }
    }
}

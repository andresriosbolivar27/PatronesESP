using Entrega2_Patrones.Business.Entities;

namespace Entrega2_Patrones.Adapters.Abstractions
{
    public interface INewShippingService
    {
        ICollection<Shipment> ProcessInformationJSON();
    }
}

using Entrega2_Patrones.Adapters.Abstractions;
using Entrega2_Patrones.Adapters.Implements;
using Entrega2_Patrones.Bridges;
using Entrega2_Patrones.Bridges.Abstractions;
using Entrega2_Patrones.Business.Workflows;

namespace Entrega2_Patrones.Facades
{
    public class ServiceCoreFacade
    {
        private readonly IOldShippingService oldShippingService;
        private readonly INewShippingService newShippingService;

        public ServiceCoreFacade()
        {
            this.oldShippingService = new OldShippingService();
            this.newShippingService = new NewShippingService();
        }

        public void ProcessNewShipping(string message, INotificationImplementor implementor)
        {
            new SenderWF(this.oldShippingService, this.newShippingService).ProcessNewShipping();

            new ShipmentNotificationWF(implementor).Notify(message);
        }

        public void ProcessOldShipping(string message, INotificationImplementor implementor)
        {
            new SenderWF(this.oldShippingService, this.newShippingService).ProcessOldShipping();
            new ShipmentNotificationWF(implementor).Notify(message);
        }
    }
}

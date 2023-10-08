using Entrega2_Patrones.Adapters.Abstractions;

namespace Entrega2_Patrones.Adapters.Implements
{
    public class OldShippingService : IOldShippingService
    {
        public string GetInformationShipmentsXML()
        {
            Console.WriteLine("Obteniendo información de envíos en formato XML del servicio antiguo...");

            return "<Envios><Envio><ID>001</ID><Destino>DestinoA</Destino></Envio><Envio><ID>002</ID><Destino>DestinoB</Destino></Envio></Envios>";
        }
    }
}

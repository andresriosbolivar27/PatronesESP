using Entrega2_Patrones.Adapters.Abstractions;
using Entrega2_Patrones.Business.Entities;
using System.Xml.Linq;

namespace Entrega2_Patrones.Adapters.Implements
{
    public class NewShippingAdapter : INewShippingService
    {
        private IOldShippingService oldService;

        public NewShippingAdapter(IOldShippingService nuevo)
        {
            oldService = nuevo;
        }

        public ICollection<Shipment> ProcessInformationJSON()
        {
            Console.WriteLine("Adaptando la obtención de información de envíos para el servicio nuevo...");
            var datosXmlAntiguo = oldService.GetInformationShipmentsXML();
            
            return XMLToObject(datosXmlAntiguo);
        }

        private static List<Shipment> XMLToObject(string xml)
        {
            try
            {
                var xmlDoc = XDocument.Parse(xml);
                var envios = new List<Shipment>();

                if (xmlDoc is not null)
                {
                    foreach (var envioElement in xmlDoc.Root.Elements("Envio"))
                    {
                        var envio = new Shipment
                        {
                            ID = envioElement.Element("ID").Value,
                            Destino = envioElement.Element("Destino").Value
                        };

                        envios.Add(envio);
                    }
                }

                return envios;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al convertir XML a objetos Envio: {ex.Message}");
                return new List<Shipment>();
            }
        }
    }
}

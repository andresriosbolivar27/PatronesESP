
namespace Entrega2_Patrones.Business.Entities
{
    public class Shipment
    {
        public string ID { get; set; }
        public string Destino { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}, Destino: {Destino}";
        }
    }
}

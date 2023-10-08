using Entrega2_Patrones.Adapters.Abstractions;
using Entrega2_Patrones.Adapters.Clients;
using Entrega2_Patrones.Adapters.Implements;

namespace Entrega2_Patrones.Business.Workflows
{
    public class SenderWF
    {
        private readonly IOldShippingService servicioAntiguoEnvios;
        private readonly INewShippingService servicioNuevoEnvios;

        public SenderWF(
            IOldShippingService servicioAntiguoEnvios,
            INewShippingService servicioNuevoEnvios)
        {
            this.servicioAntiguoEnvios = servicioAntiguoEnvios;
            this.servicioNuevoEnvios = servicioNuevoEnvios;
        }

        public void ProcessNewShipping()
        {
            Console.WriteLine("\nCliente utilizando directamente el servicio nuevo:");
            LogisticsClient clienteNuevo = new(this.servicioNuevoEnvios);
            clienteNuevo.ProcessInformationShipments();
        }

        public void ProcessOldShipping()
        {
            INewShippingService adaptador = new NewShippingAdapter(this.servicioAntiguoEnvios);
            Console.WriteLine("\nCliente utilizando el adaptador para el sistema nuevo:");
            LogisticsClient clienteAdaptador = new(adaptador);
            clienteAdaptador.ProcessInformationShipments();
        }
    }
}

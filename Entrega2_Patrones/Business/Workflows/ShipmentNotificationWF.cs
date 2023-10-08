using Entrega2_Patrones.Bridges.Abstractions;

namespace Entrega2_Patrones.Business.Workflows
{
    public class ShipmentNotificationWF : Notification
    {
        public ShipmentNotificationWF(INotificationImplementor implementor) : base(implementor)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine("Notificando envío:");
            implementor.SendNotification(message);
        }
    }
}

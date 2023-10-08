using Entrega2_Patrones.Bridges.Abstractions;

namespace Entrega2_Patrones.Bridges.Implements
{
    internal class SMSNotification : INotificationImplementor
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Enviando notificación por mensaje de texto: {message}");
        }
    }
}

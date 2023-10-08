using Entrega2_Patrones.Bridges.Abstractions;

namespace Entrega2_Patrones.Bridges.Implements
{
    public class EmailNotification: INotificationImplementor
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Enviando notificacion por email: {message}");
        }
    }
}

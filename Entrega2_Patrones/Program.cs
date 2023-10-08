using Entrega2_Patrones.Bridges.Implements;
using Entrega2_Patrones.Facades;

public class Program
{
    public static void Main()
    {
        var facade = new ServiceCoreFacade();
        facade.ProcessNewShipping("Nuevo envío disponible", new EmailNotification());

        facade.ProcessOldShipping("Envío antiguo procesado", new SMSNotification());
    }
}

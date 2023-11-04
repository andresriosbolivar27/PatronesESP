using System.Text;

public class PrinterHelper
{
    public PrinterHelper()
    {
    }

    public PrinterHelper ImprimirSeparador()
    {
        Console.WriteLine("---------------------------------------------------------");
        return this;
    }

    public PrinterHelper ImprimirSaltoLinea()
    {
        Console.WriteLine("\n");
        return this;
    }
}

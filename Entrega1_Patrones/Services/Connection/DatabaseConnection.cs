using Entrega1_Patrones.Helpers;
using Entrega1_Patrones.Services.Builder;
using Entrega1_Patrones.Services.Singleton;

namespace Entrega1_Patrones.Services.Connection
{
    public class DatabaseConnection
    {
        public static void Connect() 
        {
            PrinterHelper.ImprimirSeparador();
            Console.WriteLine(
                "Plataforma Conexion:\n" +
                "Seleccione el servidor\n" +
                "1. Estados Unidos\n" +
                "2. America Latina\n");

            var serverSelected = Console.ReadLine();
            var connectionString = new ConnectionStringBuilder();
            AbstractContext dbContext = null;
            
            switch (serverSelected.Trim())
            {
                case "1":
                    connectionString
                        .SetServer("usa")
                        .SetDatabase("VeterinaryDB")
                        .SetUsername("root")
                        .SetPassword("******")
                        .SetPort(1433)
                        .SetConnectionTimeout(2000)
                        .SetIntegratedSecurity(false);
                    
                    dbContext = DbContextUsa.GetInstance(connectionString.Build());

                    break;
                case "2":
                    connectionString
                        .SetServer("la")
                        .SetDatabase("VeterinaryDB")
                        .SetUsername("su")
                        .SetPassword("******")
                        .SetPort(3314)
                        .SetConnectionTimeout(2000)
                        .SetIntegratedSecurity(true);
                    
                    dbContext = DbContextLatinAmerica.GetInstance(connectionString.Build());

                    break;

            };
             
            Console.WriteLine(dbContext.GetStatusConnection());
            PrinterHelper.ImprimirSeparador();
        }
    }
}

namespace Entrega1_Patrones.Services.Singleton
{
    public class DbContextLatinAmerica : AbstractContext
    {
        private static DbContextLatinAmerica _dbConnection;
        
        private static bool _connection;
        private static string _Server = "Latin America";

        private DbContextLatinAmerica(string optionsConnection)
        {            
        }

        public static DbContextLatinAmerica GetInstance(string connectioString)
        {
            if (_dbConnection == null)
            {
                _dbConnection = new DbContextLatinAmerica(connectioString);
                _connection = true;
            }

            return _dbConnection;
        }

        public override string GetStatusConnection()
        {
            return $"Conectado al servidor {_Server} estado de conexion: {_connection}";
        }
    }
}

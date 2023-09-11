namespace Entrega1_Patrones.Services.Singleton
{
    public class DbContextUsa : AbstractContext
    {
        private static DbContextUsa _dbConnection;

        private static bool _connection;

        private static string _Server = "USA";

        private DbContextUsa(string optionsConnection)
        {
        }

        public static DbContextUsa GetInstance(string connectioString)
        {
            if (_dbConnection == null)
            {
                _dbConnection = new DbContextUsa(connectioString);
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

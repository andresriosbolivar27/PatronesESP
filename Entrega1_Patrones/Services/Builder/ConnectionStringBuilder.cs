using Entrega1_Patrones.Business.Entities;

namespace Entrega1_Patrones.Services.Builder
{
    public class ConnectionStringBuilder
    {
        private ConnectionString _connectionString;

        public ConnectionStringBuilder()
        {
            _connectionString = new ConnectionString();                
        }

        public ConnectionStringBuilder SetServer(string server)
        {
            _connectionString.Server = server;
            return this;
        }

        public ConnectionStringBuilder SetDatabase(string database)
        {
            _connectionString.DataBase = database;
            return this;
        }

        public ConnectionStringBuilder SetUsername(string username)
        {
            _connectionString.UserName = username;
            return this;
        }

        public ConnectionStringBuilder SetPassword(string password)
        {
            _connectionString.Password = password;
            return this;
        }

        public ConnectionStringBuilder SetPort(int port)
        {
            _connectionString.Port = port;
            return this;
        }

        public ConnectionStringBuilder SetIntegratedSecurity(bool useIntegratedSecurity)
        {
            _connectionString.IntegratedSecurity = useIntegratedSecurity;
            return this;
        }

        public ConnectionStringBuilder SetConnectionTimeout(int timeoutInSeconds)
        {
            _connectionString.ConnectionTimeout = timeoutInSeconds;
            return this;
        }

        public string Build()
        {
            string connectionString = $"Server={_connectionString.Server};" +
                $"Database={_connectionString.DataBase};" +
                $"User Id={_connectionString.UserName};" +
                $"Password={_connectionString.Password};" +
                (_connectionString.Port.HasValue ? $"Port={_connectionString.Port};" : "") +
                (_connectionString.IntegratedSecurity ? "Integrated Security=True;" : "") +
                (_connectionString.ConnectionTimeout.HasValue ? $"Connection Timeout={_connectionString.ConnectionTimeout};" : "");

            return connectionString;
        }
    }
}

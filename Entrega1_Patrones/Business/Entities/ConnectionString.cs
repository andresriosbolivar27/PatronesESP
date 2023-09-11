namespace Entrega1_Patrones.Business.Entities
{
    public class ConnectionString
    {
        public string Server {get;set;}
        public string DataBase {get;set;}
        public string UserName {get;set;}
        public string Password {get;set;}
        public int? Port {get;set;}
        public bool IntegratedSecurity {get;set;}
        public int? ConnectionTimeout { get; set; }

    }
}

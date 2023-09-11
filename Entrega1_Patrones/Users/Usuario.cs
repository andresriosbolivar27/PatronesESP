namespace Entrega1_Patrones.Products
{
    public abstract class Usuario
    {
        public string Nombre { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Contrasena { get; set; } = string.Empty;
        public string Rol { get; set; }
    }
}

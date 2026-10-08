namespace gestion_de_clientes.Models
{
    public class Cliente
    {
        public int IdCliente { get; set; }

        public string Nombre { get; set; } = "";

        public string Apellido { get; set; } = "";

        public string Telefono { get; set; } = "";

        public string Correo { get; set; } = "";

        public string Direccion { get; set; } = "";

        public DateTime FechaRegistro { get; set; }

        public bool Activo { get; set; }

        public byte[]? RowVersion { get; set; }
    }
}
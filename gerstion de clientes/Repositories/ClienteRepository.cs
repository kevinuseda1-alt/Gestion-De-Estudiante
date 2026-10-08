using Microsoft.Data.SqlClient;
using gestion_de_clientes.Data;
using gestion_de_clientes.Models;

namespace gestion_de_clientes.Repositories
{
    public class ClienteRepository
    {
        public async Task<List<Cliente>> ObtenerClientesAsync(CancellationToken cancellationToken = default)
        {
            var lista = new List<Cliente>();

            using var conexion = ConexionBD.ObtenerConexion();
            await conexion.OpenAsync(cancellationToken);

            string sql = @"SELECT IdCliente, Nombre, Apellido,
                                  Telefono, Correo, Direccion,
                                  FechaRegistro, Activo, RowVersion
                           FROM Clientes
                           WHERE Activo = 1
                           ORDER BY IdCliente DESC";

            using var comando = new SqlCommand(sql, conexion);
            using var lector = await comando.ExecuteReaderAsync(cancellationToken);

            while (await lector.ReadAsync(cancellationToken))
            {
                lista.Add(new Cliente
                {
                    IdCliente = Convert.ToInt32(lector["IdCliente"]),
                    Nombre = lector["Nombre"].ToString() ?? "",
                    Apellido = lector["Apellido"].ToString() ?? "",
                    Telefono = lector["Telefono"].ToString() ?? "",
                    Correo = lector["Correo"].ToString() ?? "",
                    Direccion = lector["Direccion"].ToString() ?? "",
                    FechaRegistro = Convert.ToDateTime(lector["FechaRegistro"]),
                    Activo = Convert.ToBoolean(lector["Activo"]),
                    RowVersion = (byte[])lector["RowVersion"]
                });
            }

            return lista;
        }

        // GUARDAR CLIENTE
        public async Task<bool> InsertarClienteAsync(Cliente cliente)
        {
            using var conexion = ConexionBD.ObtenerConexion();
            await conexion.OpenAsync();

            string sql = @"
                INSERT INTO Clientes
                (Nombre, Apellido, Telefono, Correo, Direccion)
                VALUES
                (@Nombre, @Apellido, @Telefono, @Correo, @Direccion);";

            using var comando = new SqlCommand(sql, conexion);

            comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
            comando.Parameters.AddWithValue("@Apellido", cliente.Apellido);
            comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);
            comando.Parameters.AddWithValue("@Correo", cliente.Correo);
            comando.Parameters.AddWithValue("@Direccion", cliente.Direccion);

            int filas = await comando.ExecuteNonQueryAsync();

            return filas > 0;
        }

        // ACTUALIZAR CLIENTE

        public async Task<bool> ActualizarClienteAsync(Cliente cliente)
        {
            using var conexion = ConexionBD.ObtenerConexion();
            await conexion.OpenAsync();

            string sql = @"
        UPDATE Clientes
        SET Nombre = @Nombre,
            Apellido = @Apellido,
            Telefono = @Telefono,
            Correo = @Correo,
            Direccion = @Direccion
        WHERE IdCliente = @IdCliente
          AND RowVersion = @RowVersion;";

            using var comando = new SqlCommand(sql, conexion);

            comando.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);
            comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
            comando.Parameters.AddWithValue("@Apellido", cliente.Apellido);
            comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);
            comando.Parameters.AddWithValue("@Correo", cliente.Correo);
            comando.Parameters.AddWithValue("@Direccion", cliente.Direccion);
            comando.Parameters.AddWithValue("@RowVersion", cliente.RowVersion);

            int filas = await comando.ExecuteNonQueryAsync();

            return filas > 0;
        }


        // ELIMINAR CLIENTE
        public async Task<bool> EliminarClienteAsync(int idCliente)
        {
            using var conexion = ConexionBD.ObtenerConexion();
            await conexion.OpenAsync();

            string sql = @"
        UPDATE Clientes
        SET Activo = 0
        WHERE IdCliente = @IdCliente;";

            using var comando = new SqlCommand(sql, conexion);

            comando.Parameters.AddWithValue("@IdCliente", idCliente);

            int filas = await comando.ExecuteNonQueryAsync();

            return filas > 0;
        }

        // BUSCAR CLIENTES
        public async Task<List<Cliente>> BuscarAsync(
            string texto,
            CancellationToken cancellationToken = default)
        {
            var lista = new List<Cliente>();

            using var conexion = ConexionBD.ObtenerConexion();

            await conexion.OpenAsync(cancellationToken);

            string sql = @"
        SELECT IdCliente, Nombre, Apellido,
               Telefono, Correo, Direccion,
               FechaRegistro, Activo, RowVersion
        FROM Clientes
        WHERE Activo = 1
          AND (
              Nombre LIKE @Texto
              OR Apellido LIKE @Texto
              OR Telefono LIKE @Texto
              OR Correo LIKE @Texto
              OR Direccion LIKE @Texto
          )
        ORDER BY IdCliente DESC;";

            using var comando = new SqlCommand(sql, conexion);

            comando.Parameters.AddWithValue(
                "@Texto",
                "%" + texto + "%");

            using var lector =
                await comando.ExecuteReaderAsync(cancellationToken);

            while (await lector.ReadAsync(cancellationToken))
            {
                lista.Add(new Cliente
                {
                    IdCliente = Convert.ToInt32(lector["IdCliente"]),
                    Nombre = lector["Nombre"].ToString() ?? "",
                    Apellido = lector["Apellido"].ToString() ?? "",
                    Telefono = lector["Telefono"].ToString() ?? "",
                    Correo = lector["Correo"].ToString() ?? "",
                    Direccion = lector["Direccion"].ToString() ?? "",
                    FechaRegistro = Convert.ToDateTime(lector["FechaRegistro"]),
                    Activo = Convert.ToBoolean(lector["Activo"]),
                    RowVersion = (byte[])lector["RowVersion"]
                });
            }

            return lista;
        }
    }
}

using System.Threading;
using gestion_de_clientes.Models;
using gestion_de_clientes.Repositories;

namespace gerstion_de_clientes
{
    public partial class frmClientes : Form
    {
        private readonly ClienteRepository _repositorio = new();
        private readonly SemaphoreSlim _operacionLock = new(1, 1);
        private CancellationTokenSource? _cancellationTokenSource;

        private byte[]? _rowVersionSeleccionado;

        public frmClientes()
        {
            InitializeComponent();

            _cancellationTokenSource = new CancellationTokenSource();

            dgvClientes.AutoGenerateColumns = false;

            Load += async (s, e) => await CargarClientesAsync();
        }

        private async Task CargarClientesAsync()

        {
            _cancellationTokenSource?.Cancel();
            _cancellationTokenSource?.Dispose();

            _cancellationTokenSource = new CancellationTokenSource();

            var clientes = await _repositorio.ObtenerClientesAsync(
                _cancellationTokenSource.Token);

            dgvClientes.DataSource = clientes;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!await _operacionLock.WaitAsync(0))
            {
                MessageBox.Show("Ya existe una operación en ejecución.");
                return;
            }

            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtApellido.Text))
                {
                    MessageBox.Show("Nombre y Apellido son obligatorios.");
                    return;
                }

                Cliente cliente = new Cliente
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Telefono = txtTelefono.Text,
                    Correo = txtCorreo.Text,
                    Direccion = txtDireccion.Text
                };

                bool guardado = await _repositorio.InsertarClienteAsync(cliente);

                if (guardado)
                {
                    MessageBox.Show("Cliente guardado correctamente.");

                    await CargarClientesAsync();

                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el cliente.");
                }
            }
            finally
            {
                _operacionLock.Release();
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!await _operacionLock.WaitAsync(0))
            {
                MessageBox.Show("Ya existe una operación en ejecución.");
                return;
            }

            try
            {
                if (string.IsNullOrWhiteSpace(txtIdCliente.Text))
                {
                    MessageBox.Show("Selecciona un cliente primero.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtApellido.Text))
                {
                    MessageBox.Show("Nombre y Apellido son obligatorios.");
                    return;
                }

                if (_rowVersionSeleccionado == null)
                {
                    MessageBox.Show(
                        "Selecciona nuevamente el cliente antes de actualizar.");
                    return;
                }

                Cliente cliente = new Cliente
                {
                    IdCliente = int.Parse(txtIdCliente.Text),
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Telefono = txtTelefono.Text,
                    Correo = txtCorreo.Text,
                    Direccion = txtDireccion.Text,
                    RowVersion = _rowVersionSeleccionado
                };

                bool actualizado =
                    await _repositorio.ActualizarClienteAsync(cliente);

                if (actualizado)
                {
                    MessageBox.Show(
                        "Cliente actualizado correctamente.");

                    await CargarClientesAsync();

                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo actualizar el cliente.\n\n" +
                        "Es posible que otro usuario haya modificado " +
                        "este cliente. Vuelve a seleccionarlo e inténtalo nuevamente.",
                        "Conflicto de concurrencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            finally
            {
                _operacionLock.Release();
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!await _operacionLock.WaitAsync(0))
            {
                MessageBox.Show("Ya existe una operación en ejecución.");
                return;
            }

            try
            {
                if (string.IsNullOrWhiteSpace(txtIdCliente.Text))
                {
                    MessageBox.Show("Selecciona un cliente primero.");
                    return;
                }

                int idCliente = int.Parse(txtIdCliente.Text);

                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de eliminar este cliente?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    bool eliminado =
                        await _repositorio.EliminarClienteAsync(idCliente);

                    if (eliminado)
                    {
                        MessageBox.Show(
                            "Cliente eliminado correctamente.");

                        await CargarClientesAsync();

                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show(
                            "No se pudo eliminar el cliente.");
                    }
                }
            }
            finally
            {
                _operacionLock.Release();
            }
        }

        private void dgvClientes_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];

                txtIdCliente.Text =
                    fila.Cells["colIdCliente"].Value?.ToString();

                txtNombre.Text =
                    fila.Cells["colNombre"].Value?.ToString();

                txtApellido.Text =
                    fila.Cells["colApellido"].Value?.ToString();

                txtTelefono.Text =
                    fila.Cells["colTelefono"].Value?.ToString();

                txtCorreo.Text =
                    fila.Cells["colCorreo"].Value?.ToString();

                txtDireccion.Text =
                    fila.Cells["colDireccion"].Value?.ToString();

                if (dgvClientes.DataSource is List<Cliente> clientes &&
                    e.RowIndex < clientes.Count)
                {
                    Cliente clienteSeleccionado =
                        clientes[e.RowIndex];


                    _rowVersionSeleccionado =
                        clienteSeleccionado.RowVersion;
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

            txtNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

            dgvClientes.ClearSelection();
        }


        private void LimpiarCampos()
        {
            txtIdCliente.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            _rowVersionSeleccionado = null;
        }

        private async void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (!await _operacionLock.WaitAsync(0))
            {
                MessageBox.Show("Ya existe una operación en ejecución.");
                return;
            }

            try
            {
                if (string.IsNullOrWhiteSpace(txtIdCliente.Text))
                {
                    MessageBox.Show("Selecciona un cliente primero.");
                    return;
                }

                int idCliente = int.Parse(txtIdCliente.Text);

                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de eliminar este cliente?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    bool eliminado =
                        await _repositorio.EliminarClienteAsync(idCliente);

                    if (eliminado)
                    {
                        MessageBox.Show(
                            "Cliente eliminado correctamente.");

                        await CargarClientesAsync();

                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show(
                            "No se pudo eliminar el cliente.");
                    }
                }
            }
            finally
            {
                _operacionLock.Release();
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
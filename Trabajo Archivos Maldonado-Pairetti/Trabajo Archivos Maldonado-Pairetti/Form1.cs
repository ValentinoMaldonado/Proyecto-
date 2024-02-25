using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Trabajo_Archivos_Maldonado_Pairetti
{
    public partial class Form1 : Form
    {
        private List<Pedido> listaPedidos = new List<Pedido>();
        private List<Modelo> listaModelos = new List<Modelo>();
        private List<Pieza> listaPiezas = new List<Pieza>();

        public Form1()
        {
            InitializeComponent();
            ConfigurarDataGridView();
        }

        // Método para configurar los DataGridView
        private void ConfigurarDataGridView()
        {
            // Configuración de dgvPedidos
            dgvPedidos.ColumnCount = 3;
            dgvPedidos.Columns[0].Name = "Numero de Modelo";
            dgvPedidos.Columns[1].Name = "Numero de Concesionaria";
            dgvPedidos.Columns[2].Name = "Cantidad";
            dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        

        // Configuracion de dgvModelos
            dgvModelos.ColumnCount = 3;
            dgvModelos.Columns[0].Name = "Numero de Modelo";
            dgvModelos.Columns[1].Name = "Descripcion";
            dgvModelos.Columns[2].Name = "Stock Actual";
            dgvModelos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
         }
        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            // Obtén los datos del formulario
            if (!int.TryParse(txtNumeroModelo.Text, out int numeroModelo) ||
                !int.TryParse(txtNumeroConcesionaria.Text, out int numeroConcesionaria) ||
                !int.TryParse(txtCantidad.Text, out int cantidad))
            {
                MessageBox.Show("Por favor, ingrese números válidos en los campos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crea una instancia de Pedido
            Pedido nuevoPedido = new Pedido
            {
                NumeroModelo = numeroModelo,
                NumeroConcesionaria = numeroConcesionaria,
                Cantidad = cantidad
            };

            // Agrega el pedido a la lista
            listaPedidos.Add(nuevoPedido);

            // Actualiza el DataGridView
            ActualizarDataGridViewPedidos();
        }

        // Método para actualizar el DataGridView con la lista de pedidos
        private void ActualizarDataGridViewPedidos()
        {
            dgvPedidos.Rows.Clear();

            foreach (var pedido in listaPedidos)
            {
                dgvPedidos.Rows.Add(new string[] { pedido.NumeroModelo.ToString(), pedido.NumeroConcesionaria.ToString(), pedido.Cantidad.ToString() });
            }
        }

        private void btnOrdenarYEnviar_Click(object sender, EventArgs e)
        {
            OrdenarListaPedidos();
            EnviarPedidosAFabrica();
            ActualizarDataGridViewPedidos();
        }

        private void btnGuardarPedidos_Click(object sender, EventArgs e)
        {
            GuardarPedidosEnArchivo();
        }

        private void btnCargarPedidos_Click(object sender, EventArgs e)
        {
            CargarPedidosDesdeArchivo();
        }

        private void OrdenarListaPedidos()
        {
            // Ordena la lista de pedidos por número de modelo y luego por número de concesionaria
            listaPedidos.Sort((p1, p2) =>
            {
                int compareModelo = p1.NumeroModelo.CompareTo(p2.NumeroModelo);
                if (compareModelo == 0)
                {
                    return p1.NumeroConcesionaria.CompareTo(p2.NumeroConcesionaria);
                }
                return compareModelo;
            });
        }

        private void EnviarPedidosAFabrica()
        {
            // Implementa aquí la lógica para enviar los pedidos a la fábrica si es necesario
            // Puedes usar la lista ordenada listaPedidos para realizar las operaciones necesarias
            // Puedes mostrar un MessageBox u otro tipo de notificación después de enviar los pedidos
        }

        private void GuardarPedidosEnArchivo()
        {
            try
            {
                // Ordena la lista de pedidos antes de guardarla en el archivo
                OrdenarListaPedidos();

                // Convierte cada pedido a una cadena y guarda en el archivo
                List<string> lineasArchivo = new List<string>();
                foreach (var pedido in listaPedidos)
                {
                    string linea = $"{pedido.NumeroModelo}\t{pedido.NumeroConcesionaria}\t{pedido.Cantidad}";
                    lineasArchivo.Add(linea);
                }

                // Guarda en el archivo Pedidos.txt
                File.WriteAllLines("Pedidos.txt", lineasArchivo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los pedidos en el archivo: {ex.Message}", "Error de Guardado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPedidosDesdeArchivo()
        {
            listaPedidos.Clear();

            try
            {
                if (File.Exists("Pedidos.txt"))
                {
                    var lineas = File.ReadAllLines("Pedidos.txt");

                    foreach (var linea in lineas)
                    {
                        var partes = linea.Split('\t');

                        if (partes.Length == 3 &&
                            int.TryParse(partes[0], out int numeroModelo) &&
                            int.TryParse(partes[1], out int numeroConcesionaria) &&
                            int.TryParse(partes[2], out int cantidad))
                        {
                            Pedido pedido = new Pedido
                            {
                                NumeroModelo = numeroModelo,
                                NumeroConcesionaria = numeroConcesionaria,
                                Cantidad = cantidad
                            };

                            listaPedidos.Add(pedido);
                        }
                    }

                    // Actualiza el DataGridView con los pedidos cargados
                    ActualizarDataGridViewPedidos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los pedidos desde el archivo: {ex.Message}", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarPedido_Click(object sender, EventArgs e)
        {
            // Obtén los datos del formulario
            if (!int.TryParse(txtEliminarModelo.Text, out int numeroModelo) ||
                !int.TryParse(txtEliminarConcesionaria.Text, out int numeroConcesionaria))
            {
                MessageBox.Show("Por favor, ingrese números válidos en los campos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Busca el pedido en la lista
            Pedido pedidoAEliminar = listaPedidos.Find(p => p.NumeroModelo == numeroModelo && p.NumeroConcesionaria == numeroConcesionaria);

            if (pedidoAEliminar != null)
            {
                // Elimina el pedido de la lista
                listaPedidos.Remove(pedidoAEliminar);

                // Actualiza el DataGridView
                ActualizarDataGridViewPedidos();

                // Muestra un mensaje de éxito
                MessageBox.Show("Pedido eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Muestra un mensaje de error si el pedido no se encuentra
                MessageBox.Show("No se encontró el pedido especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarPedido_Click(object sender, EventArgs e)
        {
            // Obtén los datos del formulario
            if (!int.TryParse(txtModificarModelo.Text, out int numeroModelo) ||
                !int.TryParse(txtModificarConcesionaria.Text, out int numeroConcesionaria) ||
                !int.TryParse(txtModificarCantidad.Text, out int nuevaCantidad))
            {
                MessageBox.Show("Por favor, ingrese números válidos en los campos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Busca el pedido en la lista
            Pedido pedidoAModificar = listaPedidos.Find(p => p.NumeroModelo == numeroModelo && p.NumeroConcesionaria == numeroConcesionaria);

            if (pedidoAModificar != null)
            {
                // Modifica la cantidad del pedido
                pedidoAModificar.Cantidad = nuevaCantidad;

                // Actualiza el DataGridView
                ActualizarDataGridViewPedidos();

                // Muestra un mensaje de éxito
                MessageBox.Show("Pedido modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Muestra un mensaje de error si el pedido no se encuentra
                MessageBox.Show("No se encontró el pedido especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void buttonAgregarModelo_Click_1(object sender, EventArgs e)
        {
            // Obtén los datos del formulario
            if (!int.TryParse(textBoxNumeroModelo.Text, out int numeroModelo) ||
                string.IsNullOrWhiteSpace(textBoxDescripcionModelo.Text) ||
                !int.TryParse(textBoxStockModelo.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("Por favor, complete todos los campos correctamente.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica si el número de modelo ya existe
            if (listaModelos.Any(m => m.NumeroModelo == numeroModelo))
            {
                MessageBox.Show("Ya existe un modelo con ese número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crea una nueva instancia de Modelo
            Modelo nuevoModelo = new Modelo
            {
                NumeroModelo = numeroModelo,
                Descripcion = textBoxDescripcionModelo.Text,
                StockActual = stock
            };

            // Agrega el modelo a la lista
            listaModelos.Add(nuevoModelo);

            // Actualiza el DataGridView
            ActualizarDataGridViewModelos();

            // Muestra un mensaje de éxito
            MessageBox.Show("Modelo agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpia los campos del formulario
           // LimpiarCamposModelo();
        }

        private void buttonEliminarModelo_Click_1(object sender, EventArgs e)
        {
            // Obtén el número de modelo a eliminar
            if (!int.TryParse(textBoxNumeroModelo.Text, out int numeroModelo))
            {
                MessageBox.Show("Por favor, ingrese un número de modelo válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Busca el modelo en la lista
            Modelo modeloAEliminar = listaModelos.Find(m => m.NumeroModelo == numeroModelo);

            if (modeloAEliminar != null)
            {
                // Elimina el modelo de la lista
                listaModelos.Remove(modeloAEliminar);

                // Actualiza el DataGridView
                ActualizarDataGridViewModelos();

                // Muestra un mensaje de éxito
                MessageBox.Show("Modelo eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpia los campos del formulario
                LimpiarCamposModelo();
            }
            else
            {
                // Muestra un mensaje de error si el modelo no se encuentra
                MessageBox.Show("No se encontró el modelo especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonModificarModelo_Click_1(object sender, EventArgs e)
        {
            // Obtén los datos del formulario
            if (!int.TryParse(textBoxNumeroModelo.Text, out int numeroModelo) ||
                string.IsNullOrWhiteSpace(textBoxDescripcionModelo.Text) ||
                !int.TryParse(textBoxStockModelo.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("Por favor, complete todos los campos correctamente.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Busca el modelo en la lista
            Modelo modeloAModificar = listaModelos.Find(m => m.NumeroModelo == numeroModelo);

            if (modeloAModificar != null)
            {
                // Modifica la información del modelo
                modeloAModificar.Descripcion = textBoxDescripcionModelo.Text;
                modeloAModificar.StockActual = stock;

                // Actualiza el DataGridView
                ActualizarDataGridViewModelos();

                // Muestra un mensaje de éxito
                MessageBox.Show("Modelo modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpia los campos del formulario
                LimpiarCamposModelo();
            }
            else
            {
                // Muestra un mensaje de error si el modelo no se encuentra
                MessageBox.Show("No se encontró el modelo especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonListarModelos_Click_1(object sender, EventArgs e)
        {
            // Actualiza el DataGridView con la lista de modelos
            ActualizarDataGridViewModelos();
        }

        private void ActualizarDataGridViewModelos()
        {
            dgvModelos.Rows.Clear();

            foreach (var modelo in listaModelos)
            {
                dgvModelos.Rows.Add(new string[] { modelo.NumeroModelo.ToString(), modelo.Descripcion, modelo.StockActual.ToString() });
            }
        }

        private void LimpiarCamposModelo()
        {
            textBoxNumeroModelo.Clear();
            textBoxDescripcionModelo.Clear();
            textBoxStockModelo.Clear();
        }

        private void dgvModelos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}

// Clase Pedido
public class Pedido
{
    public int NumeroModelo { get; set; }
    public int NumeroConcesionaria { get; set; }
    public int Cantidad { get; set; }
}

// Clase Modelo
public class Modelo
{
    public int NumeroModelo { get; set; }
    public string Descripcion { get; set; }
    public int StockActual { get; set; }
}

// Clase Pieza
public class Pieza
{
    public int NumeroPieza { get; set; }
    public string Descripcion { get; set; }
    public int StockActual { get; set; }
}

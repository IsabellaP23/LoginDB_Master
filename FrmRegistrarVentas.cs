using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using static System.Collections.Specialized.BitVector32;

namespace LoginV1
{
    public partial class FrmRegistrarVentas : Form
    {
        private static string cadena = "Data Source=tienda.db;Version=3;";
        private List<CarritoItem> carrito = new List<CarritoItem>();
        private int vendedorID;
        public FrmRegistrarVentas()
        {
            InitializeComponent();

            vendedorID = Sesion.UsuarioID;
            lblNombreVendedor.Text = Sesion.NombreUsuario;
            CargarClientes();
            CargarProductos();
        }

        private void CargarClientes()
        {
            using (var conn = new SQLiteConnection(cadena))
            {
                conn.Open();
                var da = new SQLiteDataAdapter("SELECT ClienteID, Nombre FROM Clientes", conn);
                var dt = new DataTable();
                da.Fill(dt);
                cbClientes.DisplayMember = "Nombre";
                cbClientes.ValueMember = "ClienteID";
                cbClientes.DataSource = dt;
            }
        }

        private void CargarProductos()
        {
            using (var conn = new SQLiteConnection(cadena))
            {
                conn.Open();
                var da = new SQLiteDataAdapter("SELECT ProductoID, Nombre_Producto FROM Productos", conn);
                var dt = new DataTable();
                da.Fill(dt);
                cbProductos.DisplayMember = "Nombre_Producto";
                cbProductos.ValueMember = "ProductoID";
                cbProductos.DataSource = dt;
            }
        }

        private decimal ObtenerPrecioProducto(int idProducto)
        {
            using (var conn = new SQLiteConnection(cadena))
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT Precio FROM Productos WHERE ProductoID = @id", conn);
                cmd.Parameters.AddWithValue("@id", idProducto);
                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
        }

        private void ActualizarCarrito()
        {
            dgvCarrito.DataSource = null;
            dgvCarrito.DataSource = carrito;
            lblTotal.Text = $"Total: {carrito.Sum(i => i.Subtotal):C}";
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            int idProducto = Convert.ToInt32(cbProductos.SelectedValue);
            string nombre = cbProductos.Text;
            int cantidad = (int)nudCantidad.Value;
            decimal precio = ObtenerPrecioProducto(idProducto);
            decimal subtotal = cantidad * precio;

            carrito.Add(new CarritoItem
            {
                ProductoID = idProducto,
                NombreProducto = nombre,
                Cantidad = cantidad,
                Precio = precio,
                Subtotal = subtotal
            });

            ActualizarCarrito();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (cbClientes.SelectedValue == null || carrito.Count == 0)
            {
                MessageBox.Show("Falta seleccionar cliente o productos.");
                return;
            }

            int idCliente = Convert.ToInt32(cbClientes.SelectedValue);
            string tipoPago = cbTipoPago.Text;
            decimal total = carrito.Sum(i => i.Subtotal);
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");

            using (var conn = new SQLiteConnection(cadena))
            {
                conn.Open();

                var cmd = new SQLiteCommand(@"
                INSERT INTO Compra (IdCliente, IdVendedor, Fecha, Total, TipoPago)
                VALUES (@cliente, @vendedor, @fecha, @total, @tipoPago);
                SELECT last_insert_rowid();", conn);

                cmd.Parameters.AddWithValue("@cliente", idCliente);
                cmd.Parameters.AddWithValue("@vendedor", vendedorID);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@total", total);
                cmd.Parameters.AddWithValue("@tipoPago", tipoPago);

                long idCompra = (long)cmd.ExecuteScalar();

                foreach (var item in carrito)
                {
                    var cmdDetalle = new SQLiteCommand(@"
                    INSERT INTO DetalleCompra (IdCompra, IdProducto, Cantidad, Subtotal)
                    VALUES (@idCompra, @idProducto, @cantidad, @subtotal)", conn);
                    cmdDetalle.Parameters.AddWithValue("@idCompra", idCompra);
                    cmdDetalle.Parameters.AddWithValue("@idProducto", item.ProductoID);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", item.Cantidad);
                    cmdDetalle.Parameters.AddWithValue("@subtotal", item.Subtotal);
                    cmdDetalle.ExecuteNonQuery();
                }

                MessageBox.Show("Venta registrada correctamente.");
                carrito.Clear();
                ActualizarCarrito();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmMaestraCliente frmMaestraCliente = new FrmMaestraCliente();  
            frmMaestraCliente.Show();
            this.Close();
        }
    }

    public class CarritoItem
    {
        public int ProductoID { get; set; }
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Subtotal { get; set; }
    }
}


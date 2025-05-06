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

namespace LoginV1
{
    public partial class FrmDetalleVentas : Form
    {
        private static string cadena = "Data Source=tienda.db;Version=3;";
        public FrmDetalleVentas()
        {
            InitializeComponent();
            CargarClientes();
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

        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClientes.SelectedValue != null)
            {
                int idCliente = Convert.ToInt32(cbClientes.SelectedValue);
                CargarCompras(idCliente);
            }
        }

        private void CargarCompras(int idCliente)
        {
            using (var conn = new SQLiteConnection(cadena))
            {
                conn.Open();
                var query = @"
                SELECT C.IdCompra, C.Fecha, C.Total, C.TipoPago, U.Nombre_Usuario AS Vendedor
                FROM Compra C
                JOIN tbUsuarios U ON C.IdVendedor = U.UsuarioID
                WHERE C.IdCliente = @id";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idCliente);
                var da = new SQLiteDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtgCompras.DataSource = dt;
            }
        }

        private void dtgCompras_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgCompras.SelectedRows.Count > 0)
            {
                int idCompra = Convert.ToInt32(dtgCompras.SelectedRows[0].Cells["IdCompra"].Value);
                CargarDetalleCompra(idCompra);
                CargarAbonos(idCompra);
            }
        }

        private void CargarDetalleCompra(int idCompra)
        {
            using (var conn = new SQLiteConnection(cadena))
            {
                conn.Open();
                var query = @"
                SELECT P.Nombre_Producto AS Producto, D.Cantidad, D.Subtotal
                FROM DetalleCompra D
                JOIN Productos P ON D.IdProducto = P.ProductoID
                WHERE D.IdCompra = @id";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idCompra);
                var da = new SQLiteDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtgDetalleCompras.DataSource = dt;
            }
        }

        private void CargarAbonos(int idCompra)
        {
            using (var conn = new SQLiteConnection(cadena))
            {
                conn.Open();
                var query = "SELECT Fecha, Monto FROM Abono WHERE IdCompra = @id";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idCompra);
                var da = new SQLiteDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtgAbonos.DataSource = dt;
            }
        }

        private void btnAgregarAbono_Click(object sender, EventArgs e)
        {
            if (dtgCompras.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una compra primero.");
                return;
            }

            int idCompra = Convert.ToInt32(dtgCompras.SelectedRows[0].Cells["IdCompra"].Value);
            decimal monto = decimal.Parse(txtMontoAbono.Text);
            string fecha = dtpFechaAbono.Value.ToString("yyyy-MM-dd");

            using (var conn = new SQLiteConnection(cadena))
            {
                conn.Open();
                var query = "INSERT INTO Abono (IdCompra, Fecha, Monto) VALUES (@id, @fecha, @monto)";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idCompra);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@monto", monto);
                cmd.ExecuteNonQuery();
            }

            CargarAbonos(idCompra);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmBienvenido frmBienvenido = new frmBienvenido();
            frmBienvenido.Show();
            this.Close();
        }
    }
}

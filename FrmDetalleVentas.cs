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
using System.Drawing.Printing;

namespace LoginV1
{
    public partial class FrmDetalleVentas : Form
    {
        private static string cadena = "Data Source=tienda.db;Version=3;";
        private PrintDocument printDocument = new PrintDocument();
        private int filaActual = 0;
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
            try
            {
                using (var conn = new SQLiteConnection(cadena))
                {
                    conn.Open();
                    var query = @"
            SELECT C.IdCompra, C.Fecha, C.Total, C.TipoPago, U.Nombre_Usuario AS Vendedor
            FROM Compra C
            LEFT JOIN tbUsuarios U ON C.IdVendedor = U.UsuarioID
            WHERE C.IdCliente = @id";
                    var cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", idCliente);
                    var da = new SQLiteDataAdapter(cmd);
                    var dt = new DataTable();
                    da.Fill(dt);
                    dtgCompras.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar compras: " + ex.Message);
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
            try
            {
                using (var conn = new SQLiteConnection(cadena))
                {
                    conn.Open();
                    var query = @"
            SELECT P.Nombre_Producto AS Producto, D.Cantidad, D.Subtotal
            FROM DetalleCompra D
            LEFT JOIN Productos P ON D.IdProducto = P.ProductoID
            WHERE D.IdCompra = @id";

                    var cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", idCompra);
                    var da = new SQLiteDataAdapter(cmd);
                    var dt = new DataTable();
                    da.Fill(dt);
                    dtgDetalleCompras.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar detalle de compra: " + ex.Message);
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
        private void ImprimirPagina(object sender, PrintPageEventArgs e)
        {
            Font fuente = new Font("Arial", 10);
            int anchoPagina = e.MarginBounds.Width;
            int altoPagina = e.MarginBounds.Height;
            int x = e.MarginBounds.Left;
            int y = e.MarginBounds.Top;
            int alturaFila = 25;
            bool hayMasPaginas = false;

            // Dibujar encabezados
            for (int j = 0; j < dtgCompras.Columns.Count; j++)
            {
                string textoColumna = dtgCompras.Columns[j].HeaderText;
                e.Graphics.DrawString(textoColumna, fuente, Brushes.Black, x, y);
                x += dtgCompras.Columns[j].Width / 2; // Ajuste del ancho
            }

            y += alturaFila; // Espacio después del encabezado

            // Dibujar filas
            while (filaActual < dtgCompras.Rows.Count)
            {
                DataGridViewRow fila = dtgCompras.Rows[filaActual];
                if (fila.IsNewRow)
                {
                    filaActual++;
                    continue;
                }

                x = e.MarginBounds.Left;

                for (int j = 0; j < dtgCompras.Columns.Count; j++)
                {
                    string valor = fila.Cells[j].Value?.ToString() ?? "";
                    e.Graphics.DrawString(valor, fuente, Brushes.Black, x, y);
                    x += dtgCompras.Columns[j].Width / 2;
                }

                y += alturaFila;

                if (y > altoPagina - alturaFila)
                {
                    hayMasPaginas = true;
                    break;
                }

                filaActual++;
            }

            e.HasMorePages = hayMasPaginas;
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(dtgCompras.Width, dtgCompras.Height);
            dtgCompras.DrawToBitmap(bmp, new Rectangle(0, 0, dtgCompras.Width, dtgCompras.Height));
            e.Graphics.DrawImage(bmp, 100, 100);
        }
    }
}

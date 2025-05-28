using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginV1
{
    public partial class FrmMaestraProducto : Form
    {
        private DataTable dtProductos;

        public FrmMaestraProducto()
        {
            InitializeComponent();
        }

        private void FrmMaestraProducto_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            dtProductos = Crud.Consultar("Productos");
            dtgClientes.DataSource = dtProductos;
            dtgClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtStock.Clear();
            txtPrecio.Clear();
            if (dtgClientes.Rows.Count > 0)
                dtgClientes.ClearSelection();
        }

        private void dtgClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgClientes.CurrentRow != null && dtgClientes.CurrentRow.Index >= 0 && !dtgClientes.CurrentRow.IsNewRow)
            {
                txtNombre.Text = dtgClientes.CurrentRow.Cells["Nombre_Producto"].Value.ToString();
                txtStock.Text = dtgClientes.CurrentRow.Cells["Stock"].Value.ToString();
                txtPrecio.Text = dtgClientes.CurrentRow.Cells["Precio"].Value.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtStock.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Complete todos los campos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stock))
            {
                MessageBox.Show("Stock inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("Precio inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var datos = new Dictionary<string, object>
                {
                    { "Nombre_Producto", txtNombre.Text.Trim() },
                    { "Stock", stock },
                    { "Precio", precio }
                };
                Crud.Insertar("Productos", datos);

                MessageBox.Show("Producto agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string nombreFiltro = txtFiltroNombre.Text.Trim();
            string stockMinStr = txtStockMin.Text.Trim();
            string stockMaxStr = txtStockMax.Text.Trim();
            string precioMinStr = txtPrecioMin.Text.Trim();
            string precioMaxStr = txtPrecioMax.Text.Trim();

            List<string> condiciones = new List<string>();
            List<SQLiteParameter> parametros = new List<SQLiteParameter>();

            if (!string.IsNullOrWhiteSpace(nombreFiltro))
            {
                condiciones.Add("Nombre_Producto LIKE @nombre");
                parametros.Add(new SQLiteParameter("@nombre", $"%{nombreFiltro}%"));
            }

            if (int.TryParse(stockMinStr, out int stockMin))
            {
                condiciones.Add("Stock >= @stockMin");
                parametros.Add(new SQLiteParameter("@stockMin", stockMin));
            }
            if (int.TryParse(stockMaxStr, out int stockMax))
            {
                condiciones.Add("Stock <= @stockMax");
                parametros.Add(new SQLiteParameter("@stockMax", stockMax));
            }

            if (decimal.TryParse(precioMinStr, out decimal precioMin))
            {
                condiciones.Add("Precio >= @precioMin");
                parametros.Add(new SQLiteParameter("@precioMin", precioMin));
            }
            if (decimal.TryParse(precioMaxStr, out decimal precioMax))
            {
                condiciones.Add("Precio <= @precioMax");
                parametros.Add(new SQLiteParameter("@precioMax", precioMax));
            }

            string where = condiciones.Count > 0 ? "WHERE " + string.Join(" AND ", condiciones) : "";
            string query = $"SELECT * FROM Productos {where}";

            using (SQLiteConnection conexion = new SQLiteConnection("Data Source=tienda.db;Version=3;"))
            {
                conexion.Open();
                using (SQLiteCommand comando = new SQLiteCommand(query, conexion))
                {
                    comando.Parameters.AddRange(parametros.ToArray());
                    using (SQLiteDataAdapter adaptador = new SQLiteDataAdapter(comando))
                    {
                        DataTable resultados = new DataTable();
                        adaptador.Fill(resultados);
                        dtgClientes.DataSource = resultados;
                        dtgClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
        }



        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dtgClientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto para actualizar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stock) || !decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("Datos inválidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombreOriginal = dtgClientes.CurrentRow.Cells["Nombre_Producto"].Value.ToString();

            var datos = new Dictionary<string, object>
            {
                { "Nombre_Producto", txtNombre.Text.Trim() },
                { "Stock", stock },
                { "Precio", precio }
            };

            try
            {
                Crud.Actualizar("Productos", datos, "Nombre_Producto", nombreOriginal);
                MessageBox.Show("Producto actualizado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgClientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto para eliminar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("¿Está seguro de eliminar este producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            string nombre = dtgClientes.CurrentRow.Cells["Nombre_Producto"].Value.ToString();

            try
            {
                Crud.Eliminar("Productos", "Nombre_Producto", nombre);
                MessageBox.Show("Producto eliminado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnPrimerRegistro_Click(object sender, EventArgs e)
        {
            if (dtgClientes.Rows.Count > 0)
                dtgClientes.CurrentCell = dtgClientes.Rows[0].Cells[0];
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            int idx = dtgClientes.CurrentRow?.Index ?? -1;
            if (idx > 0)
                dtgClientes.CurrentCell = dtgClientes.Rows[idx - 1].Cells[0];
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            int idx = dtgClientes.CurrentRow?.Index ?? -1;
            if (idx < dtgClientes.Rows.Count - 1)
                dtgClientes.CurrentCell = dtgClientes.Rows[idx + 1].Cells[0];
        }

        private void btnUltimoRegistro_Click(object sender, EventArgs e)
        {
            int last = dtgClientes.Rows.Count - 1;
            if (last >= 0)
                dtgClientes.CurrentCell = dtgClientes.Rows[last].Cells[0];
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            frmBienvenido bienvenida = new frmBienvenido();
            bienvenida.Show();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            ArchivoImportador.ImportarArchivoYMostrar(dtgClientes);
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            string tipo = cbTipoArchivo.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(tipo))
            {
                MessageBox.Show("Selecciona un tipo de archivo primero.", "Exportar",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ArchivoExportador.Exportar(dtgClientes, tipo);
        }

    }
}

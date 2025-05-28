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
    public partial class FrmMaestraCliente : Form
    {
        private static string cadena = "Data Source=tienda.db;Version=3;";

        private int posicionActual = 0;

        public FrmMaestraCliente()
        {
            InitializeComponent();
        }

        private bool EsCorreoValido(string correo)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de continuar.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!EsCorreoValido(txtCorreo.Text))
            {
                MessageBox.Show("El correo ingresado no tiene un formato válido.", "Correo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtTelefono.Focus();
            }

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 13)
            {
                if (e.KeyChar == 13)
                {
                    txtCorreo.Focus();
                }
            }
            else
            {
                e.KeyChar = '\0';
                MessageBox.Show("¡No ingresaste un caracter permitido!");
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAgregar.Focus();
            }
        }

        private void CargarClientes()
        {
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "SELECT ClienteID, Nombre, Telefono, Correo FROM Clientes";

                using (SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, conexion))
                {
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dtgClientes.DataSource = tabla;

                    // Ocultar la columna del ID
                    dtgClientes.Columns["ClienteID"].Visible = false;
                }
            }
        }
        private void dtgClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgClientes.SelectedRows.Count > 0)
            {
                var fila = dtgClientes.SelectedRows[0];
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
                txtCorreo.Text = fila.Cells["Correo"].Value.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {

                string NombreCliente = txtNombre.Text;
                string Telefono = txtTelefono.Text;
                string correo = txtCorreo.Text;


                var datos = new Dictionary<string, object>
        {
            { "Nombre", NombreCliente },
            { "Telefono", Telefono },
            { "Correo", correo }
        };

                // Llamar al método genérico
                Crud.Insertar("Clientes", datos);

                MessageBox.Show("Cliente agregado correctamente.");

                CargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            if (dtgClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un Cliente para actualizar.");
                return;
            }

            try
            {
                int idCliente = Convert.ToInt32(dtgClientes.SelectedRows[0].Cells["ClienteID"].Value);
                string nombre = txtNombre.Text;
                string telefono = txtTelefono.Text;
                string correo = txtCorreo.Text;

                var datos = new Dictionary<string, object>
        {
            { "Nombre", nombre },
            { "Telefono", telefono },
            { "Correo", correo }
        };
                // Método del crud
                Crud.Actualizar("Clientes", datos, "ClienteID", idCliente);

                MessageBox.Show("Cliente actualizado correctamente.");
                CargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un Cliente para eliminar.");
                return;
            }

            try
            {
                int idCliente = Convert.ToInt32(dtgClientes.SelectedRows[0].Cells["ClienteID"].Value);

                var confirmar = MessageBox.Show("¿Estás seguro de eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (confirmar != DialogResult.Yes)
                    return;

                // Llamar al método del Crud
                Crud.Eliminar("Clientes", "ClienteID", idCliente);

                MessageBox.Show("Cliente eliminado correctamente.");

                CargarClientes(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void MostrarRegistro(int fila)
        {
            if (dtgClientes.Rows.Count == 0 || fila < 0 || fila >= dtgClientes.Rows.Count)
                return;

            dtgClientes.ClearSelection();
            dtgClientes.Rows[fila].Selected = true;

            txtNombre.Text = dtgClientes.Rows[fila].Cells["Nombre"].Value.ToString();
            txtTelefono.Text = dtgClientes.Rows[fila].Cells["Telefono"].Value.ToString();
            txtCorreo.Text = dtgClientes.Rows[fila].Cells["Correo"].Value.ToString();
        }

        private void btnPrimerRegistro_Click(object sender, EventArgs e)
        {
            posicionActual = 0;
            MostrarRegistro(posicionActual);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (posicionActual < dtgClientes.Rows.Count - 1)
            {
                posicionActual++;
                MostrarRegistro(posicionActual);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (posicionActual > 0)
            {
                posicionActual--;
                MostrarRegistro(posicionActual);
            }
        }

        private void btnUltimoRegistro_Click(object sender, EventArgs e)
        {
            if (dtgClientes.Rows.Count > 0)
            {
                // Buscar la última fila que no sea la fila nueva
                for (int i = dtgClientes.Rows.Count - 1; i >= 0; i--)
                {
                    if (!dtgClientes.Rows[i].IsNewRow)
                    {
                        posicionActual = i;
                        MostrarRegistro(posicionActual);
                        break;
                    }
                }
            }
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            FrmRegistrarVentas registrarVentas = new FrmRegistrarVentas();  
            registrarVentas.Show();
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmBienvenido frmBienvenido = new frmBienvenido();
            frmBienvenido.Show();
            this.Close();
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
                MessageBox.Show("Selecciona un tipo de archivo primero.", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ArchivoExportador.Exportar(dtgClientes, tipo);
        }
    }
}

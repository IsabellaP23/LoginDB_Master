using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace LoginV1
{
    public partial class FrmMaestraProveedores : Form
    {
        public FrmMaestraProveedores()
        {
            InitializeComponent();
        }

        private int idSeleccionado = -1;
        private int posicionActual = 0;

        private void ExportarDataGridViewAPdf(DataGridView dgv, string nombreArchivo)
        {
            if (dgv.Rows.Count > 0)
            {
                // Crear documento
                Document doc = new Document(PageSize.A4, 10f, 10f, 20f, 10f);
                PdfWriter.GetInstance(doc, new FileStream(nombreArchivo, FileMode.Create));
                doc.Open();

                // Fuente
                BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                Font font = new Font(bf, 10);

                // Tabla con columnas del DataGridView
                PdfPTable pdfTable = new PdfPTable(dgv.Columns.Count);
                pdfTable.WidthPercentage = 100;

                // Agregar encabezados
                foreach (DataGridViewColumn columna in dgv.Columns)
                {
                    PdfPCell celda = new PdfPCell(new Phrase(columna.HeaderText, font));
                    celda.BackgroundColor = BaseColor.LIGHT_GRAY;
                    pdfTable.AddCell(celda);
                }

                // Agregar datos
                foreach (DataGridViewRow fila in dgv.Rows)
                {
                    if (fila.IsNewRow) continue;

                    foreach (DataGridViewCell celda in fila.Cells)
                    {
                        string texto = celda.Value?.ToString() ?? "";
                        pdfTable.AddCell(new Phrase(texto, font));
                    }
                }

                doc.Add(pdfTable);
                doc.Close();

                MessageBox.Show("PDF generado correctamente en:\n" + nombreArchivo);
            }
            else
            {
                MessageBox.Show("No hay datos para exportar.");
            }
        }
        private void MostrarRegistro(int fila)
        {

            if (dtgProveedor.Rows.Count == 0 || fila < 0 || fila >= dtgProveedor.Rows.Count)
            {
                return;
            }

            // Evitar seleccionar la fila de nueva inserción si está habilitada
            if (dtgProveedor.AllowUserToAddRows && fila == dtgProveedor.Rows.Count - 1)
            {
                return;
            }

            dtgProveedor.ClearSelection();
            dtgProveedor.Rows[fila].Selected = true;

            var row = dtgProveedor.Rows[fila];

            if (row.Cells["Nombre_Empresa"].Value != null)
            {
                txtNombreEmpresa.Text = row.Cells["Nombre_Empresa"].Value.ToString();
            }
            else
            {
                txtNombreEmpresa.Text = "";
            }

            if (row.Cells["Telefono"].Value != null)
            {
                txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
            }
            else
            {
                txtTelefono.Text = "";
            }

            if (row.Cells["Correo"].Value != null)
            {
                txtCorreoEmpresa.Text = row.Cells["Correo"].Value.ToString();
            }
            else
            {
                txtCorreoEmpresa.Text = "";
            }

            if (row.Cells["EmpresaID"].Value != null && int.TryParse(row.Cells["EmpresaID"].Value.ToString(), out int id))
            {
                idSeleccionado = id;
            }
            else
            {
                idSeleccionado = -1;
            }
        }

        private void txtIdempresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                txtNombreEmpresa.Focus();
            }
        }

        private void txtNombreEmpresa_KeyPress(object sender, KeyPressEventArgs e)
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
                    txtCorreoEmpresa.Focus();
                }
            }
            else
            {
                e.KeyChar = '\0';
                MessageBox.Show("¡No ingresaste un caracter permitido!");
            }
        }

        private void txtCorreoEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                btnAgregarProovedor.Focus();
            }
        }

        private void btnAgregarProovedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                btnConsultar.Focus();
            }
        }

        private void btnConsultar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                btnActulizar.Focus();
            }
        }

        private void btnActulizar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                btnEliminar.Focus();
            }
        }

        private void btnEliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                dtgProveedor.Focus();
            }
        }

        private void btnAgregarProovedor_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreEmpresa = txtNombreEmpresa.Text;
                string telefono = txtTelefono.Text;
                string correo = txtCorreoEmpresa.Text;

                var datos = new Dictionary<string, object>
        {
            { "Nombre_Empresa", nombreEmpresa },
            { "Telefono", telefono },
            { "Correo", correo }
        };

                Crud.Insertar("Proovedores", datos);

                // Refrescar el DataGridView
                dtgProveedor.DataSource = Crud.Consultar("Proovedores");

                MessageBox.Show("Proveedor agregado correctamente.");
                txtNombreEmpresa.Clear();
                txtTelefono.Clear();
                txtCorreoEmpresa.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dtgProveedor.DataSource = Crud.Consultar("Proovedores");
            txtNombreEmpresa.Clear();
            txtTelefono.Clear();
            txtCorreoEmpresa.Clear();
        }

        private void FrmMaestraProveedores_Load(object sender, EventArgs e)
        {
            dtgProveedor.DataSource = Crud.Consultar("Proovedores");
            dtgProveedor.Visible = true;

        }

        private void btnActulizar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == -1)
            {
                MessageBox.Show("Por favor selecciona un proveedor en la tabla.");
                return;
            }

            try
            {
                var datos = new Dictionary<string, object>
        {
            { "Nombre_Empresa", txtNombreEmpresa.Text },
            { "Telefono", txtTelefono.Text },
            { "Correo", txtCorreoEmpresa.Text }
        };

                Crud.Actualizar("Proovedores", datos, "EmpresaID", idSeleccionado);

                dtgProveedor.DataSource = Crud.Consultar("Proovedores");
                dtgProveedor.Columns["EmpresaID"].Visible = true;

                MessageBox.Show("Proveedor actualizado correctamente.");
                idSeleccionado = -1; // Reseteamos
                txtNombreEmpresa.Clear();
                txtTelefono.Clear();
                txtCorreoEmpresa.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dtgProveedor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un proveedor para eliminar.");
                return;
            }

            try
            {
                int idProveedor = Convert.ToInt32(dtgProveedor.SelectedRows[0].Cells["EmpresaID"].Value);

                var confirmar = MessageBox.Show("¿Estás seguro de eliminar este proveedor?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (confirmar != DialogResult.Yes)
                    return;

                Crud.Eliminar("Proovedores", "EmpresaID", idProveedor);

                MessageBox.Show("Proveedor eliminado correctamente.");

                dtgProveedor.DataSource = Crud.Consultar("Proovedores");
                idSeleccionado = -1;
                txtNombreEmpresa.Clear();
                txtTelefono.Clear();
                txtCorreoEmpresa.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }

        }

        private void btnPrimerRegistro_Click(object sender, EventArgs e)
        {
            posicionActual = 0;
            MostrarRegistro(posicionActual);

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (posicionActual < dtgProveedor.Rows.Count - 1)
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
            if (dtgProveedor.Rows.Count > 0)
            {
                if (dtgProveedor.AllowUserToAddRows)
                {
                    posicionActual = dtgProveedor.Rows.Count - 2;
                }
                else
                {
                    posicionActual = dtgProveedor.Rows.Count - 1;
                }

                MostrarRegistro(posicionActual);
            }

        }

        private void dtgProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dtgProveedor.Rows[e.RowIndex];

                // Guarda el ID en una variable privada (sin mostrarlo)
                idSeleccionado = Convert.ToInt32(fila.Cells["EmpresaID"].Value);

                // Cargar el resto de los datos en los TextBox visibles
                txtNombreEmpresa.Text = fila.Cells["Nombre_Empresa"].Value.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
                txtCorreoEmpresa.Text = fila.Cells["Correo"].Value.ToString();
            }

        }

        private void dtgProveedor_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgProveedor.SelectedRows.Count > 0)
            {
                var fila = dtgProveedor.SelectedRows[0];
                txtNombreEmpresa.Text = fila.Cells["Nombre_Empresa"].Value.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
                txtCorreoEmpresa.Text = fila.Cells["Correo"].Value.ToString();
                idSeleccionado = Convert.ToInt32(fila.Cells["EmpresaID"].Value);
            }

        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            ArchivoImportador.ImportarArchivoYMostrar(dtgProveedor);
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            string tipo = cboFormatos.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(tipo))
            {
                MessageBox.Show("Selecciona un tipo de archivo primero.", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ArchivoExportador.Exportar(dtgProveedor, tipo);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmBienvenido frmBienvenido = new frmBienvenido();
            frmBienvenido.Show();
            this.Close();
        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivos PDF (*.pdf)|*.pdf";
            sfd.FileName = "Reporte.pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ExportarDataGridViewAPdf(dtgProveedor, sfd.FileName);
            }
        }
    }
}

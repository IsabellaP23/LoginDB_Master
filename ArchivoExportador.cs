using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoginDB
{
    public static class ArchivoExportador
    {
        public static void Exportar(DataGridView dgv, string tipo)
        {
            if (dgv.DataSource == null || dgv.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Guardar como...";

            // Aquí reemplazamos el switch-expression por un switch clásico
            if (tipo == "CSV")
            {
                sfd.Filter = "CSV (*.csv)|*.csv";
            }
            else if (tipo == "TXT")
            {
                sfd.Filter = "TXT (*.txt)|*.txt";
            }
            else if (tipo == "XML")
            {
                sfd.Filter = "XML (*.xml)|*.xml";
            }
            else
            {
                sfd.Filter = "Todos (*.*)|*.*";
            }

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                if (tipo == "CSV" || tipo == "TXT")
                {
                    ExportarCsvTxt(dgv, sfd.FileName);
                }
                else if (tipo == "XML")
                {
                    ExportarXml(dgv, sfd.FileName);
                }

                MessageBox.Show(
                    "Datos exportados exitosamente a:\n" + sfd.FileName,
                    "Exportar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al exportar: " + ex.Message,
                    "Exportar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private static void ExportarCsvTxt(DataGridView dgv, string ruta)
        {
            var sb = new StringBuilder();

            // Encabezados
            var headers = dgv.Columns
                             .Cast<DataGridViewColumn>()
                             .Where(c => c.Visible)
                             .Select(c => c.HeaderText);
            sb.AppendLine(string.Join(",", headers));

            // Filas
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;
                var cells = row.Cells
                               .Cast<DataGridViewCell>()
                               .Where(c => c.Visible)
                               .Select(c => c.Value?.ToString() ?? "");
                sb.AppendLine(string.Join(",", cells));
            }

            File.WriteAllText(ruta, sb.ToString(), Encoding.UTF8);
        }

        private static void ExportarXml(DataGridView dgv, string ruta)
        {
            // Convertir DataGridView a DataTable
            DataTable dt = new DataTable("Export");
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (col.Visible)
                    dt.Columns.Add(col.HeaderText, typeof(string));
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;
                DataRow dr = dt.NewRow();
                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    if (!col.Visible) continue;
                    dr[col.HeaderText] = row.Cells[col.Index].Value?.ToString() ?? "";
                }
                dt.Rows.Add(dr);
            }

            // Guardar XML con esquema
            dt.WriteXml(ruta, XmlWriteMode.WriteSchema);
        }
    }
}

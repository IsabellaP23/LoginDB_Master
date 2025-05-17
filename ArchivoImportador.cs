using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace LoginDB
{
    public static class ArchivoImportador
    {
        public static void ImportarArchivoYMostrar(DataGridView dgv)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Seleccionar archivo",
                Filter = "CSV (*.csv)|*.csv|TXT (*.txt)|*.txt|XML (*.xml)|*.xml"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string ruta = ofd.FileName;
                string extension = Path.GetExtension(ruta).ToLower();

                try
                {
                    DataTable dt = new DataTable();

                    switch (extension)
                    {
                        case ".csv":
                        case ".txt":
                            dt = LeerCsvTxt(ruta);
                            break;
                        case ".xml":
                            dt = LeerXml(ruta);
                            break;
                        default:
                            MessageBox.Show("Tipo de archivo no soportado.");
                            return;
                    }

                    dgv.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al importar: " + ex.Message);
                }
            }
        }

        private static DataTable LeerCsvTxt(string ruta)
        {
            DataTable dt = new DataTable();
            string[] lineas = File.ReadAllLines(ruta);

            if (lineas.Length > 0)
            {
                string[] columnas = lineas[0].Split(',');

                foreach (string columna in columnas)
                    dt.Columns.Add(columna);

                for (int i = 1; i < lineas.Length; i++)
                {
                    string[] datos = lineas[i].Split(',');
                    dt.Rows.Add(datos);
                }
            }

            return dt;
        }

        private static DataTable LeerXml(string ruta)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(ruta);
            return ds.Tables[0];
        }
    }
}

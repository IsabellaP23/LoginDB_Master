using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginV1
{
    public  class Crud
    {
        private static string cadena = "Data Source=tienda.db;Version=3;";
        public Crud() { }

        public static void Insertar(string tabla, Dictionary<string,object> datos)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string columnas = string.Join(", ", datos.Keys);
                string parametros = string.Join(", ", datos.Keys.Select(k => "@" + k));
                string query = $"INSERT INTO {tabla} ({columnas}) VALUES ({parametros})";

                using (SQLiteCommand comando = new SQLiteCommand(query, conexion))
                {
                    foreach (var par in datos)
                    {
                        comando.Parameters.AddWithValue("@" + par.Key, par.Value);
                    }

                    comando.ExecuteNonQuery();
                }
            }
        }

        public static void Actualizar(string tabla, Dictionary<string, object> datos, string campoClave, object valorClave)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                var sets = string.Join(", ", datos.Keys.Select(k => $"{k} = @{k}"));
                string query = $"UPDATE {tabla} SET {sets} WHERE {campoClave} = @clave";

                using (SQLiteCommand comando = new SQLiteCommand(query, conexion))
                {
                    foreach (var par in datos)
                    {
                        comando.Parameters.AddWithValue("@" + par.Key, par.Value);
                    }

                    comando.Parameters.AddWithValue("@clave", valorClave);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public static void Eliminar(string tabla, string campoClave, object valorClave)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = $"DELETE FROM {tabla} WHERE {campoClave} = @clave";

                using (SQLiteCommand comando = new SQLiteCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@clave", valorClave);
                    comando.ExecuteNonQuery();
                }
            }
        }



    }
}

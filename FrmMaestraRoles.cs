using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginV1
{
    public partial class FrmMaestraRoles : Form
    {
        private string connectionString = "Data Source=tienda.db;Version=3;";

        public FrmMaestraRoles()
        {
            InitializeComponent();
            cbRolID.Items.Add(new RolItem(1, "Admin"));
            cbRolID.Items.Add(new RolItem(2, "Almacenista"));
            cbRolID.Items.Add(new RolItem(3, "Proveedor"));
            cbRolID.Items.Add(new RolItem(4, "Vendedor"));
            cbRolID.DropDownStyle = ComboBoxStyle.DropDownList;
            CargarUsuarios();
        }
        public class RolItem
        {
            public int RolID { get; set; }
            public string NombreRol { get; set; }

            public RolItem(int id, string nombre)
            {
                RolID = id;
                NombreRol = nombre;
            }

            public override string ToString()
            {
                return NombreRol;
            }
        }
        private void CargarUsuarios()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM tbUsuarios";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvUsuarios.DataSource = dt;
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO tbUsuarios (UsuarioID, Nombre_Usuario, Contraseña, Rol_ID) VALUES (@id, @nombre, @contra, @rol)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", txtNombreUsuario.Text);
                    cmd.Parameters.AddWithValue("@contra", txtContraseña.Text);
                    var rolSeleccionado = (RolItem)cbRolID.SelectedItem;
                    cmd.Parameters.AddWithValue("@rol", rolSeleccionado.RolID);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuario registrado con éxito.");
                        CargarUsuarios();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un usuario para eliminar.");
                return;
            }

            int id = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["UsuarioID"].Value);

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM tbUsuarios WHERE UsuarioID = @id";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario eliminado.");
                    CargarUsuarios();
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE tbUsuarios SET Nombre_Usuario = @nombre, Contraseña = @contra, Rol_ID = @rol WHERE UsuarioID = @id";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", txtNombreUsuario.Text);
                    cmd.Parameters.AddWithValue("@contra", txtContraseña.Text);
                    var rolSeleccionado = (RolItem)cbRolID.SelectedItem;
                    cmd.Parameters.AddWithValue("@rol", rolSeleccionado.RolID);
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Usuario actualizado.");
                        CargarUsuarios();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el usuario.");
                    }
                }
            }
        }
    }
}

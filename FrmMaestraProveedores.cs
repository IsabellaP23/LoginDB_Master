using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginV1
{
    public partial class FrmMaestraProveedores : Form
    {
        public FrmMaestraProveedores()
        {
            InitializeComponent();
        }
        private int idSeleccionado = -1;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dtgProveedor.DataSource = Crud.Consultar("Proovedores");
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

                Crud.Actualizar("Proovedores", datos, "Id_Empresa", idSeleccionado);

                dtgProveedor.DataSource = Crud.Consultar("Proovedores");
                dtgProveedor.Columns["Id_Empresa"].Visible = false;

                MessageBox.Show("Proveedor actualizado correctamente.");
                idSeleccionado = -1; // Reseteamos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void dtgProveedor_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dtgProveedor.Rows[e.RowIndex];

                // Guarda el ID en una variable privada (sin mostrarlo)
                idSeleccionado = Convert.ToInt32(fila.Cells["Id_Empresa"].Value);

                // Cargar el resto de los datos en los TextBox visibles
                txtNombreEmpresa.Text = fila.Cells["Nombre_Empresa"].Value.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
                txtCorreoEmpresa.Text = fila.Cells["Correo"].Value.ToString();
            }
        }

        private void FrmMaestraProveedores_Load(object sender, EventArgs e)
        {

        }
    }
}

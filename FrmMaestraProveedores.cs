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

                // Llamar al método genérico
                Crud.Insertar("Proovedores", datos);

                MessageBox.Show("Proveedor agregado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }

        }
    }
}

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
    public partial class frmBienvenido : Form
    {
        public frmBienvenido()
        {
            InitializeComponent();
        }

        private void btnRol_Click(object sender, EventArgs e)
        {
            FrmMaestraRoles Roles = new FrmMaestraRoles();
            Roles.Show();
            this.Close();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            FrmMaestraProducto producto = new FrmMaestraProducto();
            producto.Show();
            this.Close();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmMaestraCliente cliente = new FrmMaestraCliente();
            cliente.Show();
            this.Close();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            FrmMaestraProveedores proveedores = new FrmMaestraProveedores();
            proveedores.Show();
            this.Close();
        }
    }
}

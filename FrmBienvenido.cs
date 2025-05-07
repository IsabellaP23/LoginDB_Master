using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginV1
{
    public partial class frmBienvenido : Form
    {
        private int rolID;
        public frmBienvenido()
        {
            InitializeComponent();
        }

        public frmBienvenido(int rolID)
        {
            InitializeComponent();
            this.rolID = rolID;
            this.Load += frmBienvenido_Load;
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

        private void btnCompras_Click(object sender, EventArgs e)
        {
            FrmDetalleVentas frmDetalleVentas = new FrmDetalleVentas();
            frmDetalleVentas.Show();
            this.Close();
        }

        private void btnRol_Click_1(object sender, EventArgs e)
        {
            FrmMaestraRoles Roles = new FrmMaestraRoles();
            Roles.Show();
            this.Close();
        }

        private void frmBienvenido_Load(object sender, EventArgs e)
        {
            lblUser.Text = Sesion.NombreUsuario;

            btnProducto.Visible = false;
            btnClientes.Visible = false;
            btnProveedores.Visible = false;
            btnRol.Visible = false;

            switch (rolID)
            {
                case 1:
                    btnProducto.Visible = true;
                    btnClientes.Visible = true;
                    btnProveedores.Visible = true;
                    btnRol.Visible = true;
                    break;
                case 2:
                    btnProducto.Visible = true;
                    break;
                case 3:
                    btnProveedores.Visible = true;
                    break;
                case 4:
                    btnProducto.Visible = true;
                    btnClientes.Visible = true;
                    break;
            }
        }
    }
}

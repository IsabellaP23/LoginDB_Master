using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Finisar.SQLite;

namespace LoginV1
{
    public partial class FrmLogin : Form
    {
        int cont = 0;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            /*bool isAuthenticated = //Autenticacion();

            if (isAuthenticated)
            {
                frmBienvenido frmbienvenido = new frmBienvenido();
                frmbienvenido.lblUser.Text = txtUsuario.Text;
                frmbienvenido.Show();
                this.Hide();
            }
            else
            {
                cont++;
                MessageBox.Show("Usuario o contraseña incorrectos");

                // Si hay demasiados intentos fallidos, cierra el formulario
                if (cont == 3)
                {
                    MessageBox.Show("Demasiados intentos incorrectos, inténtelo más tarde :)");
                    this.Close();
                }
            }*/
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtContraseña.Focus();
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnOk.Focus();
            }
        }

        private void btnOk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnOk.PerformClick();
            }
        }
    }

}

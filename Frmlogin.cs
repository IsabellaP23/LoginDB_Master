using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace LoginV1
{
    public partial class FrmLogin : Form
    {
        int cont = 0;
        database db = new database();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (db.VerificarCredenciales(usuario, contraseña))
            {
                int rolID = db.ObtenerRolID(usuario);
                frmBienvenido frm = new frmBienvenido(rolID);
                frm.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Usuario o contraseña incorrectos");
                cont++;
                if (cont == 3)
                {
                    MessageBox.Show("Demasiados intentos incorrectos, inténtelo más tarde :)");
                    this.Close();
                }
            }





        }
        private void txtUsuario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtContraseña.Focus();
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtContraseña_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnOk.Focus();
            }
        }

        private void btnOk_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnOk.PerformClick();
                string usuario = txtUsuario.Text;
                string contraseña = txtContraseña.Text;

                if (db.VerificarCredenciales(usuario, contraseña))
                {
                    frmBienvenido bienvenido = new frmBienvenido();
                    bienvenido.lblUser.Text = txtUsuario.Text;
                    bienvenido.Show();
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
                }
            }
        }

    }
}

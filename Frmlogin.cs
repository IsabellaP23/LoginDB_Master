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
            IniciarSesion();
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
                IniciarSesion();
            }
        }

        private void IniciarSesion()
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (db.VerificarCredenciales(usuario, contraseña))
            {
                // Guardar usuario logueado en Sesion
                Sesion.UsuarioID = db.ObtenerUsuarioID(usuario);
                Sesion.NombreUsuario = usuario;

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


    }

    public static class Sesion
    {
        public static int UsuarioID { get; set; }
        public static string NombreUsuario { get; set; }
    }
}
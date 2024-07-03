using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class FrmLogin : Form
    {
        public bool AutenticacionRealizada { get; private set; }
        public int CodigoRol { get; private set; }

        public FrmLogin()
        {
            InitializeComponent();
            this.AutenticacionRealizada = false;
        }

        private void btnIngresar_Click_Click(object sender, EventArgs e)
        {
            if (ValidarUsuario() && ValidarContrasenia())
            {
                DataRow dr = TrabajarUsuario.BuscarUsuarioAutenticar(txtNombreUsuario.Text, txtContrasenia.Text);
                if (dr != null)
                {
                    Usuario usuarioEncontrado = TrabajarUsuario.ConvertirUsuario(dr);
                    MessageBox.Show("Bienvenido " + usuarioEncontrado.Usu_ApellidoNombre);
                    this.AutenticacionRealizada = true;
                    this.CodigoRol = usuarioEncontrado.Rol_Codigo;
                    this.Close();
                }
                else 
                {
                    MessageBox.Show("El usuario y contraseña ingresado no existe, ingrese nuevamente los datos");
                    txtNombreUsuario.Text = "";
                    txtContrasenia.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Ambos campos (Usuario y Contraseña) deben ser completados");
            }
        }


        private bool ValidarUsuario()
        {
            if (string.IsNullOrEmpty(txtNombreUsuario.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidarContrasenia()
        {
            if (string.IsNullOrEmpty(txtContrasenia.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {
            txtContrasenia.PasswordChar = '*';
        }

    }
}

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
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click_Click(object sender, EventArgs e)
        {
            Boolean bUserFound = false;

            Roles oRol1 = new Roles(1, "Administrador");
            Roles oRol2 = new Roles(2, "Vendedor");
            Roles oRol3 = new Roles(3, "Operador");

            Usuario oUsuario1 = new Usuario(1, "MartinF", "123", "Martin Flores", 1);
            Usuario oUsuario2 = new Usuario(2, "JuanC", "456", "Juan Cardozo", 2);
            Usuario oUsuario3 = new Usuario(3, "CarlosG", "789", "Carlos Gerez", 3);

            FrmPrincipal oFormPrincipal = new FrmPrincipal();

            if (oUsuario1.Usu_NombreUsuario == txtNombreUsuario.Text && oUsuario1.Usu_Contraseña == txtContraseña.Text)
            {
                bUserFound = true;
            }
            else if (oUsuario2.Usu_NombreUsuario == txtNombreUsuario.Text && oUsuario2.Usu_Contraseña == txtContraseña.Text)
            {
                bUserFound = true;
            }
            else if (oUsuario3.Usu_NombreUsuario == txtNombreUsuario.Text && oUsuario3.Usu_Contraseña == txtContraseña.Text)
            {
                bUserFound = true;
            }


            if (bUserFound)
            {
                MessageBox.Show("Bienvenido/a: " + txtNombreUsuario.Text);
                oFormPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Los datos son incorrectos, intente nuevamente");
            }
        }
    }
}

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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            Cargar_gridUsuarios();
            Cargar_combRol();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            TrabajarUsuario.InsertarUsuario(ExtraerUsuario());
            Cargar_gridUsuarios();
        }

        private void gridUsuarios_CurrentCellChanged(object sender, EventArgs e)
        {
            if (gridUsuarios.CurrentRow != null)
            {
                combRol.SelectedValue = gridUsuarios.CurrentRow.Cells["Codigo Rol"].Value;

                txtUsuario.Text = gridUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();
                txtContrasenia.Text = gridUsuarios.CurrentRow.Cells["Contraseña"].Value.ToString();
                txtApellidoNombre.Text = gridUsuarios.CurrentRow.Cells["Apellido y Nombre"].Value.ToString();
            }
        }

        private void Cargar_gridUsuarios()
        {
            gridUsuarios.DataSource = TrabajarUsuario.ListarUsuarios();
        }

        private void Cargar_combRol()
        {
            combRol.DisplayMember = "Descripcion";
            combRol.ValueMember = "Codigo";
            combRol.DataSource = TrabajarUsuario.ListarRoles();
        }

        private Usuario ExtraerUsuario()
        {
            Usuario oUsu = new Usuario();
            oUsu.Usu_NombreUsuario = txtUsuario.Text;
            oUsu.Usu_Contraseña = txtContrasenia.Text;
            oUsu.Usu_ApellidoNombre = txtApellidoNombre.Text;
            oUsu.Rol_Codigo = (int) combRol.SelectedValue;
            return oUsu;
        }
    }
}

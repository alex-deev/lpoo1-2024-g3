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
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            TrabajarCategoria.InsertarCategoria(ExtraerCategoria());
            CargarCategoria();
        }

        private void CargarCategoria()
        {
            gridCategoria.DataSource = TrabajarCategoria.ListarCategorias();
        }

        private Categoria ExtraerCategoria()
        {
            Categoria oCategoria = new Categoria();
            if (gridCategoria.CurrentRow != null) {
                oCategoria.Cat_ID = (int)gridCategoria.CurrentRow.Cells["ID"].Value;
            }
            oCategoria.Cat_Nombre = txtNombre.Text;
            oCategoria.Cat_Descripcion = txtDescripcion.Text;

            return oCategoria;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

            btnGuardar.Enabled = true;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            TrabajarCategoria.ActualizarCategoria(ExtraerCategoria());
            CargarCategoria();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            TrabajarCategoria.EliminarCategoria(ExtraerCategoria());
            CargarCategoria();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            CargarCategoria();
        }

        private void gridCategoria_CurrentCellChanged(object sender, EventArgs e)
        {
            if (gridCategoria.CurrentRow != null)
            {
                txtNombre.Text = gridCategoria.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = gridCategoria.CurrentRow.Cells["Descripcion"].Value.ToString();

                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = false;
            }
        }

    }
}

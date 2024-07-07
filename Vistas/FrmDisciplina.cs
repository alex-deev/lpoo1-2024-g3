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
    public partial class FrmDisciplina : Form
    {
        public FrmDisciplina()
        {
            InitializeComponent();
        }

        private void FrmDisciplina_Load(object sender, EventArgs e)
        {
            Cargar_GridDisciplina();
        }

        private void Cargar_GridDisciplina() 
        {
            gridDisciplina.DataSource = TrabajarDisciplina.ListarDisciplinas();
        }

        private void gridDisciplina_CurrentCellChanged(object sender, EventArgs e)
        {
            if (gridDisciplina.CurrentRow != null) 
            {
                txtNombre.Text = gridDisciplina.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = gridDisciplina.CurrentRow.Cells["Descripcion"].Value.ToString();

                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = false;
            }
        }

        private Disciplina ExtraerDisciplina() 
        {
            Disciplina oDisciplina = new Disciplina();
            if (gridDisciplina.CurrentRow != null) 
            {
                oDisciplina.Dis_ID = (int)gridDisciplina.CurrentRow.Cells["ID"].Value;
            }
            oDisciplina.Dis_Nombre = txtNombre.Text;
            oDisciplina.Dis_Descripcion = txtDescripcion.Text;

            return oDisciplina;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                TrabajarDisciplina.InsertarDisciplina(ExtraerDisciplina());
                MessageBox.Show("La disciplina se guardo con exito");
                Cargar_GridDisciplina();
            }
            else 
            {
                MessageBox.Show("Debe completar los campos Nombre y Descripcion");
            }
            
        }

        private bool validarCampos() 
        {
            if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtDescripcion.Text))
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Text = null;
            txtDescripcion.Text = null;

            btnGuardar.Enabled = true;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                TrabajarDisciplina.ActualizarDisciplina(ExtraerDisciplina());
                MessageBox.Show("La disciplina fue actualizada con exito");
                Cargar_GridDisciplina();
            }
            else 
            {
                MessageBox.Show("Debe estar completos los campos Nombre y Descripcion");
            }
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea eliminar el registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes) 
            {
                TrabajarDisciplina.EliminarDisciplina(ExtraerDisciplina());
                MessageBox.Show("La disciplina fue eliminada con exito");
                Cargar_GridDisciplina();
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}

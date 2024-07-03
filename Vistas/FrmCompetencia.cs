using ClasesBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmCompetencia : Form
    {
        public FrmCompetencia()
        {
            InitializeComponent();
        }

        private void FrmCompetencia_Load(object sender, EventArgs e)
        {
            Cargar_gridComptetencias();
            Cargar_combEstado();
            Cargar_combCategoria();
            Cargar_combDisciplina();
        }

        private void Cargar_gridComptetencias()
        {
            gridCompetencias.DataSource = TrabajarCompetencia.ListarCompetencias();
        }

        private void Cargar_combEstado()
        {
            combEstado.DisplayMember = "Estado";
            combEstado.ValueMember = "Estado";

            List<Object> listaEstados = new List<Object>();
            listaEstados.Add(new { Estado = "Programado" });
            listaEstados.Add(new { Estado = "Postergado" });
            listaEstados.Add(new { Estado = "Reprogramado" });
            listaEstados.Add(new { Estado = "Cancelado" });
            combEstado.DataSource = listaEstados;
        }

        private void Cargar_combCategoria()
        {
            combCategoria.DisplayMember = "Nombre";
            combCategoria.ValueMember = "ID";
            combCategoria.DataSource = TrabajarCategoria.ListarCategorias();
        }

        private void Cargar_combDisciplina()
        {
            combDisciplina.DisplayMember = "Nombre";
            combDisciplina.ValueMember = "ID";
            combDisciplina.DataSource = TrabajarDisciplina.ListarDisciplinas();
        }

        private void gridCompetencias_CurrentCellChanged(object sender, EventArgs e)
        {
            if (gridCompetencias.CurrentRow != null)
            {
                txtNombre.Text = gridCompetencias.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = gridCompetencias.CurrentRow.Cells["Descripción"].Value.ToString();
                txtOrganizador.Text = gridCompetencias.CurrentRow.Cells["Organizador"].Value.ToString();
                txtUbicacion.Text = gridCompetencias.CurrentRow.Cells["Ubicación"].Value.ToString();
                txtSponsors.Text = gridCompetencias.CurrentRow.Cells["Sponsors"].Value.ToString();
                dateFechaInicio.Value = Convert.ToDateTime(gridCompetencias.CurrentRow.Cells["Inicio"].Value);
                dateFechaFin.Value = Convert.ToDateTime(gridCompetencias.CurrentRow.Cells["Fin"].Value);
                combEstado.SelectedValue = gridCompetencias.CurrentRow.Cells["Estado"].Value;
                combCategoria.SelectedValue = gridCompetencias.CurrentRow.Cells["ID Categoría"].Value;
                combDisciplina.SelectedValue = gridCompetencias.CurrentRow.Cells["ID Disciplina"].Value;

                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = false;
            }
        }

        private Competencia ExtraerCompetencia()
        {
            Competencia oCompetencia = new Competencia();
            if (gridCompetencias.CurrentRow != null) {
                oCompetencia.Com_ID = (int)gridCompetencias.CurrentRow.Cells["ID Competencia"].Value;
            }
            
            oCompetencia.Com_Nombre = txtNombre.Text;
            oCompetencia.Com_Descripcion = txtDescripcion.Text;
            oCompetencia.Com_FechaInicio = dateFechaInicio.Value;
            oCompetencia.Com_FechaFin = dateFechaFin.Value;
            oCompetencia.Com_Estado = combEstado.SelectedValue.ToString();
            oCompetencia.Com_Organizador = txtOrganizador.Text;
            oCompetencia.Com_Ubicacion = txtUbicacion.Text;
            oCompetencia.Com_Sponsors = txtSponsors.Text;
            oCompetencia.Cat_ID = (int) combCategoria.SelectedValue;
            oCompetencia.Dis_ID = (int) combDisciplina.SelectedValue;
            return oCompetencia;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                TrabajarCompetencia.ActualizarCompetencia(ExtraerCompetencia());
                MessageBox.Show("Se actualizo correctamente la competencia");
                Cargar_gridComptetencias();
            }
            else 
            {
                MessageBox.Show("Deben estar completos todos los campos");
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea eliminar el registro de la Competencia: " + txtNombre.Text, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado==DialogResult.Yes)
            {
                TrabajarCompetencia.EliminarCompetencia(ExtraerCompetencia());
                MessageBox.Show("Se elimino correctamente la competencia");
                Cargar_gridComptetencias();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                TrabajarCompetencia.InsertarCompetencia(ExtraerCompetencia());
                MessageBox.Show("La competencia fue guardada con exito");
                Cargar_gridComptetencias();
            }
            else 
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            
        }

        private bool validarCampos() 
        {
            if (txtNombre.Text == "" || txtDescripcion.Text == "" || txtOrganizador.Text == "" || txtUbicacion.Text == ""
                || txtSponsors.Text == "" || combEstado.Text == "" || combCategoria.Text == "" || combDisciplina.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Text = null;
            txtDescripcion.Text = null;
            txtOrganizador.Text = null;
            txtSponsors.Text = null;
            txtUbicacion.Text = null;
            combEstado.SelectedValue = "Programado";
            combCategoria.SelectedValue = 1;
            combDisciplina.SelectedValue = 1;
            dateFechaInicio.Value = DateTime.Now;
            dateFechaFin.Value = DateTime.Now;

            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

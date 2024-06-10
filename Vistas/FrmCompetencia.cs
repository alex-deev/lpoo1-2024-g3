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
            Competencia oCom = new Competencia();
            if (gridCompetencias.CurrentRow != null) {
                oCom.Com_ID = (int)gridCompetencias.CurrentRow.Cells["ID Competencia"].Value;
            }
            
            oCom.Com_Nombre = txtNombre.Text;
            oCom.Com_Descripcion = txtDescripcion.Text;
            oCom.Com_FechaInicio = dateFechaInicio.Value;
            oCom.Com_FechaFin = dateFechaInicio.Value;
            oCom.Com_Estado = combEstado.SelectedValue.ToString();
            oCom.Com_Organizador = txtOrganizador.Text;
            oCom.Com_Ubicacion = txtUbicacion.Text;
            oCom.Com_Sponsors = txtSponsors.Text;
            oCom.Cat_ID = (int) combCategoria.SelectedValue;
            oCom.Dis_ID = (int) combDisciplina.SelectedValue;
            return oCom;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            TrabajarCompetencia.ActualizarCompetencia(ExtraerCompetencia());
            Cargar_gridComptetencias();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea eliminar el registro de la Competencia: " + txtNombre.Text, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado==DialogResult.Yes)
            {
                TrabajarCompetencia.EliminarCompetencia(ExtraerCompetencia());
                Cargar_gridComptetencias();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            TrabajarCompetencia.InsertarCompetencia(ExtraerCompetencia());
            Cargar_gridComptetencias();
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
    }
}

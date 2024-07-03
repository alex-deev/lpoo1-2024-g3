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
    public partial class FrmAnularInscripcion : Form
    {
        public FrmAnularInscripcion()
        {
            InitializeComponent();
        }

        //BOTON BUSCAR ATLETA, BUSCA POR SU DNI 
        //Y MUESTRA EN DATA GRID 
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscar.Text))
            {
                MessageBox.Show("Campo DNI no debe estar vacio");
            }
            else
            {
                gridParticipantes.DataSource = TrabajarParticipante.buscarParticipante(txtBuscar.Text);

                if (gridParticipantes.RowCount < 1)
                {
                    MessageBox.Show("No existe el participante con el DNI ingresado");
                }
            }
        }
        //CADA VEZ QUE SE CAMBIE DE FILA SE CAMBIARA LAS COMPETENCIAS DEL ATLETA EN EL GRID
        private void gridParticipantes_CurrentCellChanged(object sender, EventArgs e)
        {
            if (gridParticipantes.CurrentRow != null)
            {
                //OBTENGO EL ID DEL ATLETA DEL DATAGRIDPARTICIPANTE
                int idAtleta = Convert.ToInt32(gridParticipantes.CurrentRow.Cells["Id"].Value);
                //RELLENO EL GRID COMPETENCIA CON LAS COMPETENCIAS DEL ATLETA
                gridCompetencia.DataSource = TrabajarParticipante.obtenerCompetenciasDeAtleta(idAtleta);
            }
        }
        //OBTEGO EL ID DE LA COMPETENCIA PARA SU CANCELACIO EN LA TABLA EVENTOS 
        private void gridCompetencia_CurrentCellChanged(object seder, EventArgs e)
        {
            if (gridCompetencia.CurrentRow != null)
            {
                txtIdCompetencia.Text = gridCompetencia.CurrentRow.Cells["Id_Competencia"].Value.ToString();
            }
        }
        //BOTON PARA ANULAR LA INSCRIPICON
        private void btnAnularInscripcion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdCompetencia.Text))
            {
                MessageBox.Show("Debes elegir una competencia para su anulacion");
            }
            else
            {
                //SE OBTIENE EL ID DE LA COMPETENCIA Y SE CAMBIA EL EVENTO A 'ANULADO'
                int idAtleta = Convert.ToInt32(gridParticipantes.CurrentRow.Cells["Id"].Value);
                TrabajarParticipante.modificarEvento(Convert.ToInt32(txtIdCompetencia.Text), idAtleta);
                MessageBox.Show("Competencia Anulada con exito");
                //SE LIMPIAN LOS GRID
                gridParticipantes.DataSource = null;
                gridCompetencia.DataSource = null;
                txtIdCompetencia.Text = null;
            }
        }

        private void btnAcreditarInscripcion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdCompetencia.Text))
            {
                MessageBox.Show("Debes elegir una competencia para su acreditacion");
            }
            else
            {
                //SE OBTIENE EL ID DE LA COMPETENCIA Y SE CAMBIA EL EVENTO A 'ANULADO'
                int idAtleta = Convert.ToInt32(gridParticipantes.CurrentRow.Cells["Id"].Value);
                TrabajarParticipante.acreditarIscripcion(Convert.ToInt32(txtIdCompetencia.Text), idAtleta);
                MessageBox.Show("Competencia Acreditada con exito");
                //SE LIMPIAN LOS GRID
                gridParticipantes.DataSource = null;
                gridCompetencia.DataSource = null;
                txtIdCompetencia.Text = null;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

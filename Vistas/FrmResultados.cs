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
    public partial class FrmResultados : Form
    {
        public FrmResultados()
        {
            InitializeComponent();
        }

        private void FrmResultados_Load(object sender, EventArgs e)
        {
            Cargar_comboCompetencia();
        }

        private void Cargar_comboCompetencia() 
        {
            comboCompetencias.DisplayMember = "Nombre";
            comboCompetencias.ValueMember = "ID Competencia";
            comboCompetencias.DataSource = TrabajarCompetencia.ListarCompetencias();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            gridResultados.DataSource = TrabajarResultados.mostrarResultados(Convert.ToInt32(comboCompetencias.SelectedValue));

            if (gridResultados.RowCount > 1)
            {
                int cantidad = gridResultados.RowCount - 1;
                txtAtletasParticipantes.Text = cantidad.ToString();

                txtAtletasAbandonaron.Text = Convert.ToString(TrabajarResultados.cantidadAtletasAbandonaron(Convert.ToInt32(comboCompetencias.SelectedValue)));

                txtAtletasDescalificados.Text = Convert.ToString(TrabajarResultados.cantidadAtletasDescalificados(Convert.ToInt32(comboCompetencias.SelectedValue)));
            }
            else
            {
                MessageBox.Show("La competencia: " + comboCompetencias.Text + " no tiene resultados");
                txtAtletasParticipantes.Text = "";
                txtAtletasAbandonaron.Text = "";
                txtAtletasDescalificados.Text = "";
            }

            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            gridResultados.DataSource = TrabajarResultados.mostrarResultados(Convert.ToInt32(numIdCompetencia.Value));

            if (gridResultados.RowCount > 1)
            {
                int cantidad = gridResultados.RowCount - 1;
                txtAtletasParticipantes.Text = cantidad.ToString();

                txtAtletasAbandonaron.Text = Convert.ToString(TrabajarResultados.cantidadAtletasAbandonaron(Convert.ToInt32(numIdCompetencia.Value)));

                txtAtletasDescalificados.Text = Convert.ToString(TrabajarResultados.cantidadAtletasDescalificados(Convert.ToInt32(numIdCompetencia.Value)));
            }
            else
            {
                MessageBox.Show("La competencia con id: " + numIdCompetencia.Value + " no existe o no tiene resultados");
            }

            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

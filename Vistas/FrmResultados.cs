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
        }
    }
}

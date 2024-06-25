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


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscar.Text))
            {
                MessageBox.Show("Campo DNI no debe estar vacio");
            }
            else
            {
                gridParticipantes.DataSource = TrabajarParticipante.buscarParticipante(txtBuscar.Text);
            }
        }


    }
}

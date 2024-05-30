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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void itemSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void itemCategorias_Click(object sender, EventArgs e)
        {
            FrmCategoria frmCategoria = new FrmCategoria();
            frmCategoria.Show();
        }

        private void itemDiciplinas_Click(object sender, EventArgs e)
        {
            FrmDisciplina frmDiciplina = new FrmDisciplina();
            frmDiciplina.Show();
        }

        private void itemParticipantes_Click(object sender, EventArgs e)
        {
            FrmParticipante frmParticipante = new FrmParticipante();
            frmParticipante.Show();
        }

        private void itemUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario();
            frmUsuario.Show();
        }
    }
}

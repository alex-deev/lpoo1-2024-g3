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
        public int CodigoRol { get; set; }

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            AdministrarAcceso();
        }

        private void AdministrarAcceso() 
        {
            itemCategorias.Enabled = false;
            itemDiciplinas.Enabled = false;
            itemParticipantes.Enabled = false;
            itemUsuarios.Enabled = false;
            itemCompetencias.Enabled = false;

            switch (CodigoRol)
            { 
                case 1: //Administrador
                    itemUsuarios.Enabled = true;
                    break;
                case 2: //Operador
                    itemParticipantes.Enabled = true;
                    itemCompetencias.Enabled = true;
                    break;
                case 3: //Auditor
                    itemCategorias.Enabled = true;
                    itemDiciplinas.Enabled = true;
                    itemParticipantes.Enabled = true;
                    itemUsuarios.Enabled = true;
                    itemCompetencias.Enabled = true;
                    break;
                default:
                    break;
            }
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
            Cursor.Current = Cursors.WaitCursor;

            FrmUsuario frmUsuario = new FrmUsuario();
            frmUsuario.Show();
        }

        private void itemCompetencia_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            FrmCompetencia frmCompetencia = new FrmCompetencia();
            frmCompetencia.Show();
        }

        private void itemInscripcionSubitemNueva_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            FrmInscripcion frmInscripcion = new FrmInscripcion();
            frmInscripcion.Show();
        }

        private void itemInscripcionSubitemConfigurar_Click(object sender, EventArgs e)
        {
            FrmAnularInscripcion frmAnularInscripcion = new FrmAnularInscripcion();
            frmAnularInscripcion.Show();
        }

        private void itemResultados_Click(object sender, EventArgs e)
        {
            FrmResultados frmResultados = new FrmResultados();
            frmResultados.Show();
        }

        private void cronometrajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCronometrajes frmCronometrajes = new FrmCronometrajes();
            frmCronometrajes.Show();
        }

    }
}

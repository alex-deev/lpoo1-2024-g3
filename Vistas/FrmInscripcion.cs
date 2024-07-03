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
    public partial class FrmInscripcion : Form
    {
        public TrabajarInscripcion trabajarInscripcion;

        public FrmInscripcion()
        {
            InitializeComponent();
            CargarCompetencias();
            Cargar_GridEvento();
        }

        private void Cargar_GridEvento()
        {
            gridEvento.DataSource = TrabajarInscripcion.ListarEventos();
        }

        private void CargarCompetencias()
        {
            List<Competencia> competencias = TrabajarInscripcion.ObtenerCompetenciasDisponibles();
            cbCompetencias.DataSource = competencias;
            cbCompetencias.DisplayMember = "Com_Nombre";
            cbCompetencias.ValueMember = "Com_ID";
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            int atletaId;
            if (!int.TryParse(txtAtletaID.Text, out atletaId))
            {
                MessageBox.Show("Por favor, ingrese un ID de atleta válido.");
                return;
            }

            int competenciaId = (int)cbCompetencias.SelectedValue;

            // Aquí llamamos al método de inscripción
            string resultado = TrabajarInscripcion.InscribirAtleta(atletaId, competenciaId);
            MessageBox.Show(resultado);

            // Recargar los eventos después de una inscripción
            Cargar_GridEvento();
        }

        private void FrmInscripcion_Load(object sender, EventArgs e)
        {
            Cargar_GridEvento();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

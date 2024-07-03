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
    public partial class FrmCronometrajes : Form
    {
        private int idCompetencia;
        private int idParticipante;

        public FrmCronometrajes()
        {
            InitializeComponent();
        }

        private void FrmCronometrajes_Load(object sender, EventArgs e)
        {
            Cargar_combCompetencia();

            groupInfoParticipante.Enabled = false;
            gridParticipantes.Enabled = false;
        }

        private void Cargar_combCompetencia()
        {
            combCompetencia.DisplayMember = "ID Competencia";
            combCompetencia.ValueMember = "ID Competencia";
            combCompetencia.DataSource = TrabajarCompetencia.ListarCompetencias();
        }

        private void combCompetencia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            idCompetencia = (int)combCompetencia.SelectedValue;
        }

        private void btnCompetencia_Click(object sender, EventArgs e)
        {
            DataTable dt = TrabajarEvento.ListarParticipantesPorCompetencia(idCompetencia);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("La Competencia elegida no tiene participantes inscriptos!\nSeleccione otra competencia.");
                gridParticipantes.Enabled = false;
            } else {
                Cargar_gridParticipantes();
                gridParticipantes.Enabled = true;
            }
        }

        private void gridParticipantes_CurrentCellChanged(object sender, EventArgs e)
        {
            if (gridParticipantes.CurrentRow != null)
            {
                groupInfoParticipante.Enabled = false;

                idParticipante = (int) gridParticipantes.CurrentRow.Cells["ID"].Value;

                Evento oEvento = ObtenerEvento();
                if (oEvento.Eve_Estado.Equals("Acreditado"))
                {
                    groupInfoParticipante.Enabled = true;
                    groupInicio.Enabled = (oEvento.Eve_HoraInicio == DateTime.MinValue);
                    groupFin.Enabled = (oEvento.Eve_HoraFin == DateTime.MinValue);
                }
                CargarInicio(oEvento.Eve_HoraInicio);
                CargarFin(oEvento.Eve_HoraFin);
            }
        }

        private void CargarInicio(DateTime inicio)
        {
            numHoraInico.Value = inicio.Hour;
            numMinutoInicio.Value = inicio.Minute;
            numSegundoInicio.Value = inicio.Second;
        }

        private void CargarFin(DateTime fin)
        {
            numHoraFin.Value = fin.Hour;
            numMinutoFin.Value = fin.Minute;
            numSegundoFin.Value = fin.Second;
        }

        private void btnCargarInicio_Click(object sender, EventArgs e)
        {
            Evento oEvento = ObtenerEvento();

            DateTime nuevaHora = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, (int)numHoraInico.Value, (int)numMinutoInicio.Value, (int)numSegundoInicio.Value);
            TrabajarEvento.ActualizarHoraInicio(oEvento.Eve_ID, nuevaHora);
            Cargar_gridParticipantes();
        }

        private void btnCargarFin_Click(object sender, EventArgs e)
        {
            Evento oEvento = ObtenerEvento();

            DateTime nuevaHora = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, (int)numHoraFin.Value, (int)numMinutoFin.Value, (int)numSegundoFin.Value);
            TrabajarEvento.ActualizarHoraFin(oEvento.Eve_ID, nuevaHora);
            Cargar_gridParticipantes();
        }

        private void btnHabilitarCorrecion_Click(object sender, EventArgs e)
        {
            groupInicio.Enabled = true;
            groupFin.Enabled = true;
        }

        private void Cargar_gridParticipantes()
        {
            gridParticipantes.DataSource = TrabajarEvento.ListarParticipantesPorCompetencia(idCompetencia);
        }

        private Evento ObtenerEvento()
        {
            DataRow dr = TrabajarEvento.BuscarEvento(idCompetencia, idParticipante);
            return TrabajarEvento.ConvertirEvento(dr);
        }

        private void btnEstadoAbandono_Click(object sender, EventArgs e)
        {
            Evento oEvento = ObtenerEvento();
            TrabajarEvento.CambiarEstado(oEvento.Eve_ID, "Abandono");
            Cargar_gridParticipantes();
        }

        private void btnEstadoDescalificado_Click(object sender, EventArgs e)
        {
            Evento oEvento = ObtenerEvento();
            TrabajarEvento.CambiarEstado(oEvento.Eve_ID, "Descalificado");
            Cargar_gridParticipantes();
        }
    }
}

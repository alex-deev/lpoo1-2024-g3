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
            combCompetencia.DisplayMember = "Nombre";
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

                idParticipante = (int) gridParticipantes.CurrentRow.Cells["Atl_ID"].Value;

                Evento oEvento = ObtenerEvento();
                if (oEvento.Eve_Estado.Equals("Acreditado"))
                {
                    groupInfoParticipante.Enabled = true;
                    groupInicio.Enabled = (oEvento.Eve_HoraInicio == DateTime.MinValue);
                    groupFin.Enabled = (oEvento.Eve_HoraFin == DateTime.MinValue);
                    btnHabilitarCorrecion.Enabled = true;
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
            DateTime nuevaHoraInicio = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, (int)numHoraInico.Value, (int)numMinutoInicio.Value, (int)numSegundoInicio.Value);
            DateTime horaFin = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, (int)numHoraFin.Value, (int)numMinutoFin.Value, (int)numSegundoFin.Value);

            if (!string.IsNullOrEmpty(gridParticipantes.CurrentRow.Cells["HoraFin"].Value.ToString())
            && TimeSpan.Compare(nuevaHoraInicio.TimeOfDay, horaFin.TimeOfDay) >= 0)
            {
                MessageBox.Show("No se puede cargar una hora de Inicio posterior o igual a la hora de Finalización.");
            } else {
                TrabajarEvento.ActualizarHoraInicio(oEvento.Eve_ID, nuevaHoraInicio);
                Cargar_gridParticipantes();
            }
        }

        private void btnCargarFin_Click(object sender, EventArgs e)
        {
            Evento oEvento = ObtenerEvento();
            DateTime nuevaHoraFin = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, (int)numHoraFin.Value, (int)numMinutoFin.Value, (int)numSegundoFin.Value);

            if (string.IsNullOrEmpty(gridParticipantes.CurrentRow.Cells["HoraInicio"].Value.ToString()))
            {
                MessageBox.Show("No se puede cagar una hora de Finalización sin tener la hora de Inicio");
            } else {
                if (TimeSpan.Compare(nuevaHoraFin.TimeOfDay, oEvento.Eve_HoraInicio.TimeOfDay) <= 0)
                {
                    MessageBox.Show("No se puede cargar una hora de Finalización anterior o igual a la hora de Inicio!");
                } else {
                    TrabajarEvento.ActualizarHoraFin(oEvento.Eve_ID, nuevaHoraFin);
                    Cargar_gridParticipantes();
                }
            } 
        }

        private void btnHabilitarCorrecion_Click(object sender, EventArgs e)
        {
            groupInicio.Enabled = true;
            groupFin.Enabled = true;
            btnHabilitarCorrecion.Enabled = false;
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

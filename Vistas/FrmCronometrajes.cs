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

            groupInicio.Enabled = false;
            groupFin.Enabled = false;
            groupInfoEstado.Enabled = false;
            gridParticipantes.Enabled = false;
            btnHabilitarCorrecion.Enabled = false;
            btnElegirCompetencia.Enabled = false;
        }

        private void Cargar_combCompetencia()
        {
            combCompetencia.DisplayMember = "ID Competencia";
            combCompetencia.ValueMember = "ID Competencia";
            combCompetencia.DataSource = TrabajarCompetencia.ListarCompetencias();
        }

        private void combCompetencia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = TrabajarCompetencia.BuscarCompetenciaPorId(Convert.ToInt32(combCompetencia.Text));
                if (dr != null)
                {
                    btnElegirCompetencia.Enabled = true;
                    idCompetencia = Convert.ToInt32(combCompetencia.Text);
                } else {
                    btnElegirCompetencia.Enabled = false;
                }
            } catch {
                btnElegirCompetencia.Enabled = false;
            }
        }

        private void btnElegirCompetencia_Click(object sender, EventArgs e)
        {
            DataTable dt = TrabajarEvento.ListarParticipantesPorCompetencia(idCompetencia);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("La Competencia elegida no tiene participantes inscriptos!");
            } else {
                gridParticipantes.DataSource = dt;
                gridParticipantes.Enabled = true;

                combCompetencia.Enabled = false;
                btnElegirCompetencia.Enabled = false;
            }
        }

        private void gridParticipantes_CurrentCellChanged(object sender, EventArgs e)
        {
            if (gridParticipantes.CurrentRow != null)
            {
                groupInicio.Enabled = false;
                groupFin.Enabled = false;
                groupInfoEstado.Enabled = false;
                btnHabilitarCorrecion.Enabled = false;

                idParticipante = (int) gridParticipantes.CurrentRow.Cells["ID"].Value;

                DataRow dr = TrabajarEvento.BuscarEvento(idCompetencia, idParticipante);
                Evento oEvento = TrabajarEvento.ConvertirEvento(dr);
                if (oEvento.Eve_Estado.Equals("Acreditado"))
                {
                    if (oEvento.Eve_HoraInicio == DateTime.MinValue)
                    {
                        groupInicio.Enabled = true;
                    }
                    if (oEvento.Eve_HoraFin == DateTime.MinValue)
                    {
                        groupFin.Enabled = true;
                    }
                    groupInfoEstado.Enabled = true;
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
            DataRow dr = TrabajarEvento.BuscarEvento(idCompetencia, idParticipante);
            Evento oEvento = TrabajarEvento.ConvertirEvento(dr);
            
            DateTime nuevaHora = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, (int)numHoraInico.Value, (int)numMinutoInicio.Value, (int)numSegundoInicio.Value);
            TrabajarEvento.ActualizarHoraInicio(oEvento.Eve_ID, nuevaHora);

            Cargar_gridParticipantes();
        }

        private void btnCargarFin_Click(object sender, EventArgs e)
        {
            DataRow dr = TrabajarEvento.BuscarEvento(idCompetencia, idParticipante);
            Evento oEvento = TrabajarEvento.ConvertirEvento(dr);

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

        private void btnEstadoAbandono_Click(object sender, EventArgs e)
        {
            DataRow dr = TrabajarEvento.BuscarEvento(idCompetencia, idParticipante);
            Evento oEvento = TrabajarEvento.ConvertirEvento(dr);
            //TrabajarEvento.CambiarEstado(oEvento.Eve_ID, "Abandono");
        }

        private void btnEstadoDescalificado_Click(object sender, EventArgs e)
        {
            DataRow dr = TrabajarEvento.BuscarEvento(idCompetencia, idParticipante);
            Evento oEvento = TrabajarEvento.ConvertirEvento(dr);
            //TrabajarEvento.CambiarEstado(oEvento.Eve_ID, "Descalificado");
        }
    }
}

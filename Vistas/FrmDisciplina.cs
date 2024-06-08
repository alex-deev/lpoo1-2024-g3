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
    public partial class FrmDisciplina : Form
    {
        public FrmDisciplina()
        {
            InitializeComponent();
        }

        private void FrmDisciplina_Load(object sender, EventArgs e)
        {
            Cargar_GridDisciplina();
        }

        private void Cargar_GridDisciplina() 
        {
            gridDisciplina.DataSource = TrabajarDisciplina.ListarDisciplinas();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Disciplina oDis = CargarDisciplina();
            string mensaje = "Nombre: " + oDis.Dis_Nombre;
            mensaje += "\nDescripción: " + oDis.Dis_Descripcion;
            MessageBox.Show(mensaje);
        }

        private Disciplina CargarDisciplina()
        {
            Disciplina oDis = new Disciplina();
            oDis.Dis_Nombre = txtNombre.Text;
            oDis.Dis_Descripcion = txtDescripcion.Text;
            return oDis;
        }




    }
}

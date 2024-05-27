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
    public partial class FrmParticipante : Form
    {
        public FrmParticipante()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Atleta oAtl = CargarAtleta();
            string mensaje = "DNI: " + oAtl.Atl_DNI;
            mensaje += "\nApellido: " + oAtl.Atl_Apellido;
            mensaje += "\nNombre: " + oAtl.Atl_Nombre;
            mensaje += "\nNacionalidad: " + oAtl.Atl_Nacionalidad;
            mensaje += "\nEntrenador: " + oAtl.Atl_Entrenador;
            mensaje += "\nGénero: " + oAtl.Atl_Genero;
            mensaje += "\nAltura: " + oAtl.Atl_Altura;
            mensaje += "\nPeso: " + oAtl.Atl_Peso;
            mensaje += "\nFecha de Nacimiento: " + oAtl.Atl_FechaNac.ToShortDateString();
            mensaje += "\nDirección: " + oAtl.Atl_Direccion;
            mensaje += "\nEmail: " + oAtl.Atl_Email;
            MessageBox.Show(mensaje);
        }

        private Atleta CargarAtleta()
        {
            Atleta oAtl = new Atleta();
            oAtl.Atl_DNI = txtDNI.Text;
            oAtl.Atl_Apellido = txtApellido.Text;
            oAtl.Atl_Nombre = txtNombre.Text;
            oAtl.Atl_Nacionalidad = txtNacionalidad.Text;
            oAtl.Atl_Entrenador = txtEntrenador.Text;
            oAtl.Atl_Genero = txtGenero.Text.First();
            oAtl.Atl_Altura = Decimal.ToDouble(numAltura.Value);
            oAtl.Atl_Peso = Decimal.ToDouble(numPeso.Value);
            oAtl.Atl_FechaNac = dateFechaNac.Value;
            oAtl.Atl_Direccion = txtDireccion.Text;
            oAtl.Atl_Email = txtEmail.Text;
            return oAtl;
        }
    }
}

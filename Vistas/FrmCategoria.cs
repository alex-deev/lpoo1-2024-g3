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
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Categoria oCat = CargarCategoria();
            string mensaje = "Nombre: " + oCat.Cat_Nombre;
            mensaje += "\nDescripción: " + oCat.Cat_Descripcion;
            MessageBox.Show(mensaje);
        }

        private Categoria CargarCategoria()
        {
            Categoria oCat = new Categoria();
            oCat.Cat_Nombre = txtNombre.Text;
            oCat.Cat_Descripcion = txtDescripcion.Text;
            return oCat;
        }
    }
}

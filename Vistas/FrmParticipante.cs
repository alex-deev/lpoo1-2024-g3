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
        private void FrmParticipante_Load(object sender, EventArgs e)
        {
            cargarParticipantes();
            cargarGenero();
        }

        /*CARGAR COMBOBOX
         * Carga el comboBox con los valores 
         * M para masculino
         * F para femenino
         * O para otro
         * */
        private void cargarGenero()
        {
            cmbGenero.Items.Add('M');
            cmbGenero.Items.Add('F');
            cmbGenero.Items.Add('O');
        }
        
        private void cargarParticipantes()
        {
            gridParticipantes.DataSource = TrabajarParticipante.ListarParticipantes();
        }

        //CARGAR EL GRID CON LOS ATLETAS DE LA BASE DE DATOS
        private void gridParticipantes_CurrentCellChanged(object sender, EventArgs e)
        {
            if(gridParticipantes.CurrentRow != null)
            {
                txtDNI.Text = gridParticipantes.CurrentRow.Cells["DNI"].Value.ToString();
                txtApellido.Text = gridParticipantes.CurrentRow.Cells["Apellido"].Value.ToString();
                txtNombre.Text = gridParticipantes.CurrentRow.Cells["Nombre"].Value.ToString();
                txtNacionalidad.Text = gridParticipantes.CurrentRow.Cells["Nacionalidad"].Value.ToString();
                txtEntrenador.Text = gridParticipantes.CurrentRow.Cells["Entrenador"].Value.ToString();
                cmbGenero.Text = gridParticipantes.CurrentRow.Cells["Genero"].Value.ToString();
                numAltura.Value = Convert.ToDecimal(gridParticipantes.CurrentRow.Cells["Altura"].Value);
                numPeso.Value = Convert.ToDecimal(gridParticipantes.CurrentRow.Cells["Peso"].Value);
                dateFechaNac.Value = Convert.ToDateTime(gridParticipantes.CurrentRow.Cells["FechaNac"].Value);
                txtDireccion.Text = gridParticipantes.CurrentRow.Cells["Direccion"].Value.ToString();
                txtEmail.Text = gridParticipantes.CurrentRow.Cells["Email"].Value.ToString();            
            }
        }
        //METODO PARA GUARDAR UN ATLETA
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(verificarCampos())
            {
                MessageBox.Show("Los Campos no deben estar vacio");
            }else{

                Atleta oAtl = CargarAtleta();
                if (TrabajarParticipante.verificarAtletaRepetido(oAtl.Atl_DNI))
                {
                    MessageBox.Show("El atleta con DNI " + oAtl.Atl_DNI + " ya existe.");
                }
                else
                {
                    TrabajarParticipante.guardarParcticipante(oAtl);

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

                    limpiarCampos();
                    cargarParticipantes();
                }
            }
        }

        /*CREA UN OBJETO ATLETA
         * crea un objeto atleta y llena sus datos con los campos
         * */
        private Atleta CargarAtleta()
        {
            Atleta oAtl = new Atleta();
            oAtl.Atl_DNI = txtDNI.Text;
            oAtl.Atl_Apellido = txtApellido.Text;
            oAtl.Atl_Nombre = txtNombre.Text;
            oAtl.Atl_Nacionalidad = txtNacionalidad.Text;
            oAtl.Atl_Entrenador = txtEntrenador.Text;
            oAtl.Atl_Genero = Convert.ToChar(cmbGenero.Text);
            oAtl.Atl_Altura = Convert.ToDouble(numAltura.Value);
            oAtl.Atl_Peso = Convert.ToDouble(numPeso.Value);
            oAtl.Atl_FechaNac = Convert.ToDateTime(dateFechaNac.Value);
            oAtl.Atl_Direccion = txtDireccion.Text;
            oAtl.Atl_Email = txtEmail.Text;

            return oAtl;
        }

        /*VERIFICA SI LOS CAMPOS DEL FORMULARIO ESTAN VACIOS
         * Si algunos de los campos estan vacios devuelve true
         * de lo contrario devuelve false
         **/
        private bool verificarCampos()
        {
            if(txtApellido.Text == "" || txtDNI.Text == "" || txtNombre.Text == "" ||
                txtNacionalidad.Text == "" || txtEntrenador.Text == "" || txtEmail.Text == "" ||
                txtDireccion.Text == "" || numAltura.Value == 0 || numPeso.Value == 0)
            {
                return true;
            }else
            {
                return false;
            }
        }

        //LIMPIA LOS DATOS DE LOS TEXTBOX Y DEMAS
        private void limpiarCampos()
        {
            txtDNI.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtEntrenador.Clear();
            txtNacionalidad.Clear();
            txtDireccion.Clear();
            txtEmail.Clear();
            numAltura.Value = 0;
            numPeso.Value = 0;
            cmbGenero.SelectedIndex = -1;
        }

        //METODO PARA ELIMINAR UN ATLETA
        private void bntEliminar_Click(object sender, EventArgs e)
        {
            if (verificarCampos())
            {
                MessageBox.Show("Debes seleccionar una persona");
            }
            else
            {
                Atleta atleta = new Atleta();
                atleta.Atl_ID = (int) gridParticipantes.CurrentRow.Cells["ID"].Value;
                TrabajarParticipante.eliminarParticipante(atleta);

                MessageBox.Show("Participante eliminado");
                limpiarCampos();
                cargarParticipantes();
            }

        }

        //BOTON LIMPIAR DATOS
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }


        //METODO PARA MODIFICAR UN ATLETA EXISTENTE
        private void bntModificar_Click(object sender, EventArgs e)
        {
            if(verificarCampos())
            {
                MessageBox.Show("Debes seleccionar un Atleta para modificar");
            }
            else
            {
                var confirmacion = MessageBox.Show("¿Estás seguro de que deseas modificar este usuario?", "Confirmar Modificación", MessageBoxButtons.YesNo);
                if (confirmacion == DialogResult.Yes)
                {
                    Atleta oAtl = CargarAtleta();
                    oAtl.Atl_ID = (int)gridParticipantes.CurrentRow.Cells["ID"].Value;

                    TrabajarParticipante.modificarParticipante(oAtl);
                    MessageBox.Show("Atleta modificado correctamente");

                    limpiarCampos();
                    cargarParticipantes();
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (rbtnDNI.Checked)
            {
              gridParticipantes.DataSource = TrabajarParticipante.listarAtletaPorDni();
            }
            if (rbtnApellido.Checked)
            {
                gridParticipantes.DataSource = TrabajarParticipante.listarAtletaPorApellido();
            }
        }

    }
}

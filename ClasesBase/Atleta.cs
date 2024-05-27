using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    class Atleta
    {
        public int Atl_ID { get; set; }
        public string Atl_DNI { get; set; }
        public string Atl_Apellido { get; set; }
        public string Atl_Nombre { get; set; }
        public string Atl_Nacionalidad { get; set; }
        public string Atl_Entrenador { get; set; }
        public char Atl_Genero { get; set; }
        public double Atl_Altura { get; set; }
        public double Atl_Peso { get; set; }
        public DateTime Atl_FechaNac { get; set; }
        public string Atl_Direccion { get; set; }
        public string Atl_Email { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {
        public int Usu_ID { get; set; }
        public string Usu_NombreUsuario { get; set; }
        public string Usu_Contraseña { get; set; }
        public string Usu_ApellidoNombre { get; set; }
        public int Rol_Codigo { get; set; }

        public Usuario(int usId, string nombreUsuario, string contraseña, string apellidoYnombre, int rol_Codigo)
        {
            Usu_ID = usId;
            Usu_NombreUsuario = nombreUsuario;
            Usu_Contraseña = contraseña;
            Usu_ApellidoNombre = apellidoYnombre;
            Rol_Codigo = rol_Codigo;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Roles
    {
        public int Rol_Codigo { get; set; }
        public string Rol_Descripcion { get; set; }

        public Roles(int rolCodigo, string rolDescripcion)
        {
            Rol_Codigo = rolCodigo;
            Rol_Descripcion = rolDescripcion;
        }
    }

}

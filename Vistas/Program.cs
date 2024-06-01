using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Vistas
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmLogin frmLogin = new FrmLogin();
            Application.Run(frmLogin);

            if (frmLogin.AutenticacionRealizada == true)
            {
                FrmPrincipal frmPrincipal = new FrmPrincipal();
                frmPrincipal.CodigoRol = frmLogin.CodigoRol;
                Application.Run(frmPrincipal);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaEntidad;

namespace capaPresentacion
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmIniciarSesion inicioSesion = new frmIniciarSesion();
            if(inicioSesion.ShowDialog() == DialogResult.OK)
            {
                if (inicioSesion.esAdmin)
                {
                    Application.Run(new frmAdministradorPantallaPrincipal());
                }
                else
                {
                    int idCli = inicioSesion.ClienteLogeado.idCliente;
                    Application.Run(new frmClientePantallaPrincipal(idCli));
                }
            }
        }
    }
}

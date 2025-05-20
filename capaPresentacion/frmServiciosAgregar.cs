using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class frmServiciosAgregar : Form
    {
        private frmAdministradorPantallaPrincipal formularioPadre;

        // Constructor que recibe el formulario padre
        public frmServiciosAgregar(frmAdministradorPantallaPrincipal padre)
        {
            InitializeComponent();
            formularioPadre = padre;
        }

        private void btnAtras_MouseEnter(object sender, EventArgs e)
        {
            btnAtras.Font = new Font(btnAtras.Font, FontStyle.Underline);

        }

        private void btnAtras_MouseLeave(object sender, EventArgs e)
        {
            btnAtras.Font = new Font(btnAtras.Font, FontStyle.Regular);
        }

        private void btnAtras_MouseDown(object sender, MouseEventArgs e)
        {
            btnAtras.ForeColor = Color.Firebrick;
            btnAtras.IconColor = Color.Firebrick;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            formularioPadre.abrirFormHijo(new frmServicios(formularioPadre));
            //this.Close();
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            // Volver al formulario anterior o cualquier otro que desees cargar
            formularioPadre.abrirFormHijo(new frmServicios(formularioPadre));
        }

        private void btnOtraAccion_Click(object sender, EventArgs e)
        {
            // Puedes seguir abriendo más formularios al mismo nivel si es necesario
            //formularioPadre.abrirFormHijo(new frmFormularioExtra(formularioPadre));
        }
    }
}
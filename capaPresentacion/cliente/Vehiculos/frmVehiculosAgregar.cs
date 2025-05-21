using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion.cliente
{
    public partial class frmVehiculosAgregar : Form
    {
        private frmClientePantallaPrincipal formularioPadre;
        public frmVehiculosAgregar(frmClientePantallaPrincipal padre)
        {
            InitializeComponent();
            this.formularioPadre = padre;
        }

        #region D I S E Ñ O
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
            btnAtras.ForeColor = Color.Black;
            btnAtras.IconColor = Color.Black;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            formularioPadre.abrirFormHijo(new frmVehiculos(formularioPadre));
        }

        #endregion

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}

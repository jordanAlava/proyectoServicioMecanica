using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaEntidad;
using capaLogica;
using System.Text.RegularExpressions;

namespace capaPresentacion.cliente
{
    public partial class frmVehiculosAgregar : Form
    {
        private frmClientePantallaPrincipal formularioPadre;
        private int id;
        public frmVehiculosAgregar(frmClientePantallaPrincipal padre, int id)
        {
            InitializeComponent();
            this.formularioPadre = padre;
            this.id = id;
        }
        private byte[] imagenEnBytes;
        classPuente objP = new classPuente();

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
            formularioPadre.abrirFormHijo(new frmVehiculos(formularioPadre, id));
        }

        #endregion

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}

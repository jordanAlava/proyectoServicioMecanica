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
    public partial class frmVehiculosEliminar : Form
    {
        private frmClientePantallaPrincipal formularioPadre;
        public frmVehiculosEliminar(frmClientePantallaPrincipal padre)
        {
            InitializeComponent();
            this.formularioPadre = padre;
        }
    }
}

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
    }
}

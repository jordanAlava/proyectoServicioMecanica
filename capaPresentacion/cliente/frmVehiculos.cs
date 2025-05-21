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
    public partial class frmVehiculos : Form
    {
        private frmClientePantallaPrincipal formularioPadre;
        public frmVehiculos(frmClientePantallaPrincipal padre)
        {
            InitializeComponent();
            this.formularioPadre = padre;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            formularioPadre.abrirFormHijo(new frmVehiculosAgregar(formularioPadre));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            formularioPadre.abrirFormHijo(new frmVehiculosEditar(formularioPadre));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            formularioPadre.abrirFormHijo(new frmVehiculosEliminar(formularioPadre));
        }
    }
}

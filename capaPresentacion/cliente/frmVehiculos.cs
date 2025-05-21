using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaLogica;

namespace capaPresentacion.cliente
{
    public partial class frmVehiculos : Form
    {
        private frmClientePantallaPrincipal formularioPadre;
        private int id;
        public frmVehiculos(frmClientePantallaPrincipal padre, int id)
        {
            InitializeComponent();
            this.formularioPadre = padre;
            this.id = id;
        }

        classPuente objP = new classPuente();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            formularioPadre.abrirFormHijo(new frmVehiculosAgregar(formularioPadre, id));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            formularioPadre.abrirFormHijo(new frmVehiculosEditar(formularioPadre, id));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            formularioPadre.abrirFormHijo(new frmVehiculosEliminar(formularioPadre, id));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            dtgvTabla.DataSource = null;
            dtgvTabla.DataSource = objP.listarVehiculosCliente(id);
        }
    }
}

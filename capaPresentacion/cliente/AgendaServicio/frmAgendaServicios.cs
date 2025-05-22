using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion.cliente.AgendaServicio
{
    public partial class frmAgendaServicios : Form
    {
        frmClientePantallaPrincipal formularioPadre;
        private int id;
        public frmAgendaServicios(frmClientePantallaPrincipal padre, int id)
        {
            InitializeComponent();
            this.formularioPadre = padre;
            this.id = id;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            formularioPadre.abrirFormHijo(new frmAgendaAgregar(formularioPadre, id));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            formularioPadre.abrirFormHijo(new frmAgendaEditar(formularioPadre, id));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            formularioPadre.abrirFormHijo(new frmAgendaEliminar(formularioPadre, id));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

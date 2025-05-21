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
        public frmAgendaServicios(frmClientePantallaPrincipal padre)
        {
            InitializeComponent();
            this.formularioPadre = padre;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            formularioPadre.abrirFormHijo(new frmAgendaAgregar(formularioPadre));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            formularioPadre.abrirFormHijo(new frmAgendaEditar(formularioPadre));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            formularioPadre.abrirFormHijo(new frmAgendaEliminar(formularioPadre));
        }
    }
}

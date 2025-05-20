using capaPresentacion.administrador;
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
    public partial class frmServicios : Form
    {
        private frmAdministradorPantallaPrincipal formularioPadre;

        // Constructor que recibe al formulario padre como parámetro
        public frmServicios(frmAdministradorPantallaPrincipal padre)
        {
            InitializeComponent();
            formularioPadre = padre;
        }

        private void frmServicios_Load(object sender, EventArgs e)
        {
            // Cargar datos si es necesario
            this.servicioTableAdapter.Fill(this.bDTallerMecanicoDataSet.Servicio);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Aquí llamas al método del padre para abrir un nuevo formulario (nieto)
            formularioPadre.abrirFormHijo(new frmServiciosAgregar(formularioPadre));
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            formularioPadre.abrirFormHijo(new frmServiciosEditar(formularioPadre));
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            formularioPadre.abrirFormHijo(new frmServiciosEliminar(formularioPadre));
        }



        # region D I S E Ñ O
        private void cmbxFiltroBusqueda_Enter(object sender, EventArgs e)
        {
            cmbxFiltroBusqueda.BorderColor = Color.Firebrick;
        }

        private void cmbxFiltroBusqueda_Leave(object sender, EventArgs e)
        {
            cmbxFiltroBusqueda.BorderColor = Color.Black;
        }



        #endregion


    }
}
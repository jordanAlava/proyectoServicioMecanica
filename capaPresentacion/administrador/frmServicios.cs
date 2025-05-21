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
using capaEntidad;
using capaLogica;

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

        classPuente objP = new classPuente();

        private void frmServicios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDTallerMecanicoDataSet.Servicio_Repuesto' Puede moverla o quitarla según sea necesario.
            //this.servicio_RepuestoTableAdapter.Fill(this.bDTallerMecanicoDataSet.Servicio_Repuesto);
            // Cargar datos si es necesario
            //this.servicioTableAdapter.Fill(this.bDTallerMecanicoDataSet.Servicio);
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
            cmbxFiltroBusquedaDetalle.BorderColor = Color.Firebrick;
        }

        private void cmbxFiltroBusqueda_Leave(object sender, EventArgs e)
        {
            cmbxFiltroBusquedaDetalle.BorderColor = Color.Black;
        }


        #endregion

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Cargar comboBox de Tipo servicios
            cmbxFiltroBusqueda.Items.Clear();
            cmbxFiltroBusqueda.Items.Add("(Ninguno)");
            cmbxFiltroBusqueda.Items.AddRange(objP.tipoServicios().ToArray());
            // Cargar DataGridView
            dtgvTabla.DataSource = null;
            dtgvTabla.DataSource = objP.listarServicios();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(cmbxFiltroBusqueda.SelectedIndex > 0 )
            {
                string tipo = cmbxFiltroBusqueda.Texts;
                decimal dinero = 0;
                if (cmbxFiltroBusquedaDetalle.SelectedIndex <= 0) dinero = 0;
                if (cmbxFiltroBusquedaDetalle.SelectedIndex == 1) dinero = 50;
                if (cmbxFiltroBusquedaDetalle.SelectedIndex == 2) dinero = 75;
                if (cmbxFiltroBusquedaDetalle.SelectedIndex == 3) dinero = 100;
                dtgvTabla.DataSource = null;
                dtgvTabla.DataSource = objP.filtrarServicios(tipo, dinero);
            }
            else if(cmbxFiltroBusqueda.SelectedIndex == 0)
            {
                dtgvTabla.DataSource = null;
                dtgvTabla.DataSource = objP.listarServicios();
            }
            else
            {
                MessageBox.Show("Para filtrar la tabla, elija al menos un tipo de servicio");
            }
        }
    }
}
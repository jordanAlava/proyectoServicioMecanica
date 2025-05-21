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

namespace capaPresentacion.administrador
{
    public partial class frmServiciosEliminar : Form
    {
        private frmAdministradorPantallaPrincipal formularioPadre;
        public frmServiciosEliminar(frmAdministradorPantallaPrincipal padre)
        {
            InitializeComponent();
            formularioPadre = padre;
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
            formularioPadre.abrirFormHijo(new frmServicios(formularioPadre));

        }
        #endregion
        classPuente objP = new classPuente();
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtBarraBusqueda.Texts.Trim());
                Servicio servicio = objP.buscarServicio(id);
                if (servicio == null)
                {
                    pnlIngresoDatos.Visible = false;
                    lblRegistroNoEncontrado.Visible = true; /// pongo MessageBox porque no se activa esto
                    MessageBox.Show("Servicio no encontrado");
                    return;
                }
                pnlIngresoDatos.Visible = true;
                lblRegistroNoEncontrado.Visible = false;
                lblNombreValor.Text = servicio.nombreServicio;
                lblTipoValor.Text = servicio.tipoServicio;
                lblDescripcionValor.Text = servicio.descripcionServicio;
                lblCostoUnitarioValor.Text = servicio.costoUnitarioServicio.ToString();
                lblIvaValor.Text = servicio.ivaServicio.ToString();
                lblCostoTotalValor.Text = servicio.costoTotalServicio.ToString();
                lblGarantiaValor.Text = servicio.garantiaServicio.ToString();
            }
            catch
            {
                MessageBox.Show("El id es un número entero...");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtBarraBusqueda.Texts.Trim());
                if(id > 0)
                {
                    if (objP.eliminarServicion(id))
                    {
                        MessageBox.Show("Servicio eliminado ! ");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error al eliminar el servicio");
            }
        }
    }
}

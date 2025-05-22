using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaEntidad;
using capaLogica;

namespace capaPresentacion.cliente
{
    public partial class frmVehiculosEliminar : Form
    {
        private frmClientePantallaPrincipal formularioPadre;
        private int id;
        public frmVehiculosEliminar(frmClientePantallaPrincipal padre, int id)
        {
            InitializeComponent();
            this.formularioPadre = padre;
            this.id = id;
        }

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string placa = cmbBuscar.Texts;
                Vehiculo vehiculo = objP.buscarVehiculo(placa);
                lblPlacaValor.Text = placa;
                lblMarcaValor.Text = vehiculo.marcaVehiculo;
                lblModeloValor.Text = vehiculo.modeloVehiculo;
                lblNoChasisValor.Text = vehiculo.numChasisVehiculo;
                lblAnioFabValor.Text = vehiculo.fechaFabricacionVehiculo.ToString();
                lblColorValor.Text = vehiculo.colorVehiculo;
                lblSeguroValor.Text = vehiculo.aseguradoVehiculo.ToString();
                lblCombustibleValor.Text = vehiculo.combustibleVehiculo;
                lblCilindrajeValor.Text = vehiculo.cilindrajeVehiculo;
                MemoryStream ms = new MemoryStream(vehiculo.fotoVehiculo);
                pctrFoto.Image = Image.FromStream(ms);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (objP.eliminarVehiculo(cmbBuscar.Texts))
            {
                MessageBox.Show("Vehículo eliminado correctamente");
                btnAtras.PerformClick();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            cmbBuscar.Items.Clear();
            cmbBuscar.Items.AddRange(objP.placasCliente(id).ToArray());
        }
    }
}

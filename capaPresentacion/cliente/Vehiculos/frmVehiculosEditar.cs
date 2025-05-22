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
    public partial class frmVehiculosEditar : Form
    {
        private frmClientePantallaPrincipal formularioPadre;
        private int id;
        public frmVehiculosEditar(frmClientePantallaPrincipal padre, int id)
        {
            InitializeComponent();
            this.formularioPadre = padre;
            this.id = id;
        }

        private void cargarImagen()
        {
            MemoryStream ms = new MemoryStream();
            pctrFoto.Image = Image.FromStream(ms);
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
            formularioPadre.abrirFormHijo(new frmVehiculos(formularioPadre, id));
        }

        #endregion
        classPuente objP = new classPuente();
        Vehiculo vehiculo = new Vehiculo();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbBuscar.SelectedIndex == -1)
                {
                    MessageBox.Show("Escoja la placa de alguno de sus vehículos...");
                        return;
                }
                //Vehiculo vehiculo = objP.buscarVehiculo(cmbBuscar.Texts);
                vehiculo = objP.buscarVehiculo(cmbBuscar.Texts);
                lblPlacaValor.Text = vehiculo.placaVehiculo;
                lblMarcaValor.Text = vehiculo.marcaVehiculo;
                lblModeloValor.Text = vehiculo.modeloVehiculo;
                lblFecha.Text = vehiculo.fechaFabricacionVehiculo.ToString();
                txtColor.Texts = vehiculo.colorVehiculo;
                lblNumChasis.Text = vehiculo.numChasisVehiculo;
                cmbxSeguro.Texts = vehiculo.aseguradoVehiculo.ToString();
                cmbxCombustible.Texts = vehiculo.combustibleVehiculo;
                txtCilindraje.Texts = vehiculo.cilindrajeVehiculo;
                MemoryStream ms = new MemoryStream(vehiculo.fotoVehiculo);
                pctrFoto.Image = Image.FromStream(ms);
            }
            catch
            {
                MessageBox.Show("Escoja la placa de alguno de sus vehículos...");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            cmbBuscar.Items.Clear();
            cmbBuscar.Items.AddRange(objP.placasCliente(id).ToArray());
        }

        private byte[] imagenEnBytes = null;
        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog imagen = new OpenFileDialog();
            imagen.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";
            if (imagen.ShowDialog() == DialogResult.OK)
            {
                pctrFoto.Image = Image.FromFile(imagen.FileName);
                using (MemoryStream ms = new MemoryStream())
                {
                    pctrFoto.Image.Save(ms, pctrFoto.Image.RawFormat);
                    imagenEnBytes = ms.ToArray();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                string color = txtColor.Texts;
                string asegurado = cmbxSeguro.Texts;
                string combustible = cmbxCombustible.Texts;
                int cilindraje = int.Parse(txtCilindraje.Texts);
                if(!string.IsNullOrWhiteSpace(color) && !string.IsNullOrWhiteSpace(asegurado) && !string.IsNullOrWhiteSpace(combustible) && cilindraje > 0)
                {
                    vehiculo.colorVehiculo = color;
                    vehiculo.aseguradoVehiculo = asegurado[0];
                    vehiculo.combustibleVehiculo = combustible;
                    vehiculo.cilindrajeVehiculo = cilindraje.ToString() + "Cc";
                    if(imagenEnBytes != null)
                    {
                        vehiculo.fotoVehiculo = imagenEnBytes;
                    }
                    if (objP.modificarVehiculo(vehiculo))
                    {
                        MessageBox.Show($"El vehículo {cmbBuscar.Texts} ha sido modificado");
                        btnAtras.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show($"El vehículo {cmbBuscar.Texts} NO ha sido modificado");
                    }
                }
                else
                {
                    MessageBox.Show("Asegurese de llenar todos los campos... además el cilindraje debe ser un número entero positivo");
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show("El cilindraje debe ser un número entero");
            }
        }
    }
}

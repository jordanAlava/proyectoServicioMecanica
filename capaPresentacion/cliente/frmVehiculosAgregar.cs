using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaEntidad;
using capaLogica;
using System.Text.RegularExpressions;

namespace capaPresentacion.cliente
{
    public partial class frmVehiculosAgregar : Form
    {
        private frmClientePantallaPrincipal formularioPadre;
        private int id;
        public frmVehiculosAgregar(frmClientePantallaPrincipal padre, int id)
        {
            InitializeComponent();
            this.formularioPadre = padre;
            this.id = id;
        }
        private byte[] imagenEnBytes;
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

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        
        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog imagen = new OpenFileDialog();
            imagen.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";
            if(imagen.ShowDialog() == DialogResult.OK)
            {
                pctrFoto.Image = Image.FromFile(imagen.FileName);
                using(MemoryStream ms = new MemoryStream())
                {
                    pctrFoto.Image.Save(ms, pctrFoto.Image.RawFormat);
                    imagenEnBytes = ms.ToArray();
                }
            }
        }

        private void txtPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (Char)Keys.Enter)
            {
                txtMarca.Focus();
            }
        }

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                txtModelo.Focus();
            }
        }

        private void txtModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                txtAnioFab.Focus();
            }
        }

        private void txtAnioFab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (Char)Keys.Enter)
            {
                txtColor.Focus();
            }
        }

        private void txtColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                txtNoChasis.Focus();
            }
        }

        private void txtCilindraje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                btnAgregar.PerformClick();
            }
        }

        public bool EsFechaValidaYAnterior(string fecha)
        {
            if (DateTime.TryParseExact(
                    fecha.Trim(),
                    "yyyy-MM-dd",
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None,
                    out DateTime fechaIngresada))
            {
                return fechaIngresada < DateTime.Today;
            }

            return false; // formato inválido o no es una fecha anterior
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string placa = txtPlaca.Texts, marca = txtMarca.Texts, modelo = txtModelo.Texts, anioF = txtAnioFab.Texts, color = txtColor.Texts, numChasis = txtNoChasis.Texts;
                char asegurado = cmbxSeguro.Texts[0];
                string combustible = cmbxCombustible.Texts;
                int Cc = Convert.ToInt32(txtCilindraje.Texts);
                if(Regex.IsMatch(placa, @"^[A-Z]{3}-\d{4}$"))
                {
                    if(!string.IsNullOrWhiteSpace(marca) && !string.IsNullOrWhiteSpace(modelo) && !string.IsNullOrWhiteSpace(anioF) && !string.IsNullOrWhiteSpace(color) && !string.IsNullOrWhiteSpace(numChasis) && cmbxCombustible.SelectedIndex != -1 && cmbxSeguro.SelectedIndex != -1)
                    {
                        if (EsFechaValidaYAnterior(anioF))
                        {
                            Vehiculo vehiculo = new Vehiculo
                            {
                                placaVehiculo = placa,
                                idCliente = id,
                                modeloVehiculo = modelo,
                                marcaVehiculo = marca,
                                numChasisVehiculo = numChasis,
                                colorVehiculo = color,
                                fechaFabricacionVehiculo = Convert.ToDateTime(anioF),
                                cilindrajeVehiculo = Cc.ToString() + "Cc",
                                combustibleVehiculo = combustible,
                                aseguradoVehiculo = asegurado,
                                fotoVehiculo = imagenEnBytes
                            };
                            if (objP.ingresarVehiculo(vehiculo))
                            {
                                MessageBox.Show("Vehículo agregado correctamente");
                            }
                            else
                            {
                                MessageBox.Show("Vehículo NO agregado correctamente");
                            }
                        }
                        else
                        {
                            
                            MessageBox.Show($"El formato de fecha es yyyy-MM-dd. No puede ingresar fechas futuras. FECHA {anioF}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Asegurese de llenar todos los campos...");
                    }
                }
                else
                {
                    MessageBox.Show("Placa inválida, el formato correcto es ABC-1234. En caso de ser ABC-123, ingresar ABC-0123");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ingrese una imagen");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //MessageBox.Show($"ID {id}");
        }
    }
}

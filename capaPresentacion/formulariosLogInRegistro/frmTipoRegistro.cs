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
    public partial class frmTipoRegistro : Form
    {
        //Inicialización

        private string itemSeleccionado = "";
        private Image imagenOriginal;


        public frmTipoRegistro()
        {
            InitializeComponent();
            inicializarFormulario();
        }
        public void inicializarFormulario()
        {
            this.ActiveControl = null;

            imagenOriginal = Image.FromFile("Recursos/Imagenes/carroFondo1.jpg");
            pctrImagenFondo.Image = imagenOriginal;
        }



        //Responsive
        private void frmTipoRegistro_Resize(object sender, EventArgs e)
        {
            // Ajusta ancho del panel al 40% del ancho del formulario
            pnlContenedor.Width = (int)(this.ClientSize.Width * 0.4);

        }

        private void pnlContenedor_Resize(object sender, EventArgs e)
        {
            escalarImagen();
        }

        private void escalarImagen()
        {
            if (imagenOriginal == null)
                return;

            // Calcula escala para que la imagen ocupe TODO el panel sin deformar
            float escalaAncho = (float)pnlContenedor.Width / imagenOriginal.Width;
            float escalaAlto = (float)pnlContenedor.Height / imagenOriginal.Height;
            float escala = Math.Max(escalaAncho, escalaAlto); // Mantener proporción

            int nuevoAncho = (int)(imagenOriginal.Width * escala);
            int nuevoAlto = (int)(imagenOriginal.Height * escala);

            pctrImagenFondo.Size = new Size(nuevoAncho, nuevoAlto);

            // Opcional: centrar el PictureBox dentro del panel
            pctrImagenFondo.Location = new Point(
                (pnlContenedor.Width - nuevoAncho) / 2,
                (pnlContenedor.Height - nuevoAlto) / 2
            );
        }

        //Efecto Hover y Lógica de Selección
        private void pctrAdministrador_MouseEnter(object sender, EventArgs e)
        {
            if (itemSeleccionado != pctrAdministrador.Name)
                pctrAdministrador.IconColor = Color.Silver;
        }

        private void pctrAdministrador_MouseLeave(object sender, EventArgs e)
        {
            if (itemSeleccionado != pctrAdministrador.Name)
                pctrAdministrador.IconColor = Color.DimGray;
        }

        private void pctrCliente_MouseEnter(object sender, EventArgs e)
        {
            if (itemSeleccionado != pctrCliente.Name)
                pctrCliente.IconColor = Color.Silver;
        }

        private void pctrCliente_MouseLeave(object sender, EventArgs e)
        {
            if (itemSeleccionado != pctrCliente.Name)
                pctrCliente.IconColor = Color.DimGray;
        }



   

        private void pctrCliente_Click(object sender, EventArgs e)
        {
            itemSeleccionado = pctrCliente.Name;

            pctrClienteMarco.Visible = true;
            lblCliente.Font = new Font(lblCliente.Font, FontStyle.Bold);
            pctrCliente.IconColor = Color.Silver;

            pctrAdministradorMarco.Visible = false;
            lblAdministrador.Font = new Font(lblAdministrador.Font, FontStyle.Regular);
            pctrAdministrador.IconColor = Color.DimGray;

            lblMensaje.Visible = false;
        }

        private void pctrAdministrador_Click(object sender, EventArgs e)
        {
            itemSeleccionado = pctrAdministrador.Name;

            pctrAdministradorMarco.Visible = true;
            pctrAdministrador.IconColor = Color.Silver;
            lblAdministrador.Font = new Font(lblAdministrador.Font, FontStyle.Bold);

            pctrClienteMarco.Visible = false;
            lblCliente.Font = new Font(lblCliente.Font, FontStyle.Regular);
            pctrCliente.IconColor = Color.DimGray;

            lblMensaje.Visible = false;

        }



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
            btnAtras.ForeColor = Color.Firebrick;
            btnAtras.IconColor = Color.Firebrick;
        }

        
        
        // Clicks
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (itemSeleccionado == pctrAdministrador.Name)
            {
                frmRegistroAdministrador obj = new frmRegistroAdministrador();
                obj.ShowDialog();
                
            }
            else if (itemSeleccionado == pctrCliente.Name)
            {
                frmRegistroCliente obj = new frmRegistroCliente();
                obj.ShowDialog();
                
            }
            else 
            {
                lblMensaje.Text = "Por favor, seleccione una opción antes de Continuar";
                lblMensaje.Visible = true;
            }

                
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pctrCliente_DoubleClick(object sender, EventArgs e)
        {
            btnSiguiente.PerformClick();
        }

        private void pctrAdministrador_DoubleClick(object sender, EventArgs e)
        {
            btnSiguiente.PerformClick();
        }

        private void btnSiguiente_Leave(object sender, EventArgs e)
        {
            lblMensaje.Visible = false; 
        }

        private void frmTipoRegistro_Click(object sender, EventArgs e)
        {
            itemSeleccionado = "";

            pctrAdministradorMarco.Visible = false;
            lblAdministrador.Font = new Font(lblAdministrador.Font, FontStyle.Regular);
            pctrAdministrador.IconColor = Color.DimGray;

            pctrClienteMarco.Visible = false;
            lblCliente.Font = new Font(lblCliente.Font, FontStyle.Regular);
            pctrCliente.IconColor = Color.DimGray;

            lblMensaje.Visible = false;
        }
    }
}

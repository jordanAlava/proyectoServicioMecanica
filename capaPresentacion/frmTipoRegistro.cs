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
        private Image imagenOriginal;
        public frmTipoRegistro()
        {
            InitializeComponent();
            inicializarFormulario();
        }

        public void inicializarFormulario()
        {
            this.ActiveControl = btnSiguiente;

            imagenOriginal = Image.FromFile("Recursos/Imagenes/carroFondo1.jpg");
            pctrImagenFondo.Image = imagenOriginal;

            //pctrImagenFondo.Image = Image.FromFile("Recursos/Imagenes/carroFondo1.jpg");

        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            frmRegistroAdministrador obj = new frmRegistroAdministrador();
            obj.ShowDialog();
        }

        private void frmTipoRegistro_Load(object sender, EventArgs e)
        {

        }



        private void frmTipoRegistro_Resize(object sender, EventArgs e)
        {
            // Ajusta ancho del panel al 40% del ancho del formulario
            pnlContenedor.Width = (int)(this.ClientSize.Width * 0.4);

        }

        private void pnlContenedor_Resize(object sender, EventArgs e)
        {
            EscalarImagen();
        }

        private void EscalarImagen()
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

    }
}

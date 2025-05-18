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
        public frmTipoRegistro()
        {
            InitializeComponent();
            inicializarFormulario();
        }

        public void inicializarFormulario()
        {
            this.ActiveControl = btnSiguiente;
            pctrImagenFondo.Image = Image.FromFile("Recursos/Imagenes/carroFondo1.jpg");
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            frmRegistroAdministrador obj = new frmRegistroAdministrador();
            obj.ShowDialog();
        }

        private void frmTipoRegistro_Load(object sender, EventArgs e)
        {

        }
    }
}

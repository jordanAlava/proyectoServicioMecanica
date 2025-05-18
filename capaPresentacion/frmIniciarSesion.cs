using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;


namespace capaPresentacion
{
    public partial class frmIniciarSesion : Form
    {
        public frmIniciarSesion()
        {

            InitializeComponent();
            inicializarFormulario();
        }

        public void inicializarFormulario()
        {
            this.ActiveControl = btnIniciarSesion;
            pctrLogotipo.Image = Image.FromFile( "Recursos/Imagenes/logotipo.jpg");
        }

        private void frmIniciarSesion_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

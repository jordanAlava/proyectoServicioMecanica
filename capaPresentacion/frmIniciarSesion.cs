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
            pctrLogotipo.Image = Image.FromFile( "Recursos/Imagenes/logotipo.jpg");
        }
    }
}

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



        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtContrasenia.Focus();
            }
        }

        private void txtContrasenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnIniciarSesion_Click(sender, e);
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {

        }

        private void linkRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmTipoRegistro obj = new frmTipoRegistro();
            obj.ShowDialog();

        }

        private void lblRegistrarse_Click(object sender, EventArgs e)
        {

        }

        private void frmIniciarSesion_Load(object sender, EventArgs e)
        {

        }
    }
}

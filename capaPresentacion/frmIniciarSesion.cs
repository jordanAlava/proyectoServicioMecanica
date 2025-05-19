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
using capaEntidad;
using capaLogica;


namespace capaPresentacion
{
    public partial class frmIniciarSesion : Form
    {
        Administrador admin = new Administrador();
        Cliente cliente = new Cliente();
        classPuente operacion = new classPuente();
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
                btnIniciarSesion.PerformClick();
            }
        }

        private void linkRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmTipoRegistro obj = new frmTipoRegistro();
            obj.ShowDialog();

        }


        public bool esAdmin { get; private set; }
        private void btnIniciarSesion_Click_1(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Texts;
                string contra = txtContrasenia.Texts;
                if (operacion.autenticarCliente(usuario, contra))
                {
                    esAdmin = false;
                    this.DialogResult = DialogResult.OK;
                }
                else if (operacion.autenticarAdmin(usuario, contra))
                {
                    esAdmin = true;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    // POR SERGURIDAD, NO SE DEBE DECIR SI ESTA MAL EL USUARIO O CONTRASEÑA
                    MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTO");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void frmIniciarSesion_Load(object sender, EventArgs e)
        {

        }
    }
}

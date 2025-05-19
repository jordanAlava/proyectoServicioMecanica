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
    public partial class frmAdministradorPantallaPrincipal : Form
    {
        public frmAdministradorPantallaPrincipal()
        {
            InitializeComponent();
            inicializarFormulario();
        }

        public void inicializarFormulario()
        {
            this.ActiveControl = null;
            pctrLogotipo.Image = Image.FromFile("Recursos/Imagenes/logotipo.jpg");
        }

        private Form formularioActivo = null;

        private void abrirFormHijo(Form formularioHijo)
        {
            if (formularioActivo == null) 
            {
                formularioActivo = new Form();
            }
            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            pnlFormulario.Controls.Add(formularioHijo);
            pnlFormulario.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();

        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmServicios());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class frmClientePantallaPrincipal : Form
    {

        private Form formularioActivo = null;
        public frmClientePantallaPrincipal()
        {
            InitializeComponent();
            inicializarFormulario();
        }

        public void inicializarFormulario()
        {
            this.ActiveControl = null;
            pctrLogotipo.Image = Image.FromFile("Recursos/Imagenes/logotipo.jpg");
        }

        public void abrirFormHijo(Form formularioHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            pnlFormulario.Controls.Clear(); // Limpia controles anteriores, opcional
            pnlFormulario.Controls.Add(formularioHijo);
            pnlFormulario.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrarSesion_MouseDown(object sender, MouseEventArgs e)
        {
            btnCerrarSesion.Font = new Font(btnCerrarSesion.Font.FontFamily, 11, btnCerrarSesion.Font.Style);
            btnCerrarSesion.IconSize += 1;
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.IconColor = Color.White;

        }


    }
}

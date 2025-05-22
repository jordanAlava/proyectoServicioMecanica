using capaPresentacion.cliente;
using capaPresentacion.cliente.AgendaServicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaEntidad;
using System.Diagnostics;

namespace capaPresentacion
{
    public partial class frmClientePantallaPrincipal : Form
    {
        private Form formularioActivo = null;
        private int idCliente;
        public frmClientePantallaPrincipal(int cliente)
        {
            InitializeComponent();
            inicializarFormulario();
            this.idCliente = cliente;
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

        private void btnMisVehiculos_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmVehiculos(this, idCliente));
        }

        private void frmClientePantallaPrincipal_Load(object sender, EventArgs e)
        {
            //MessageBox.Show($"ID: {idCliente}");
        }

        private void btnAgendarServicio_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmAgendaServicios(this, idCliente));
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            string ruta = "Recursos\\PaginasWeb\\Ayuda_DocumentacionMecaPro.htm";
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = ruta,
                UseShellExecute = true // necesario para abrir con el navegador predeterminado en .NET Core o versiones modernas
            });
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            string ruta = "Recursos\\PaginasWeb\\Acerca_de_MECAPRO_nuevo[1].htm";
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = ruta,
                UseShellExecute = true // necesario para abrir con el navegador predeterminado en .NET Core o versiones modernas
            });
        }
    }
}

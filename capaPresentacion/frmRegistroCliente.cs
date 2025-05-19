using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; // PARA VALIDAR EL CORREO
using capaLogica;
using capaEntidad;

namespace capaPresentacion
{
    public partial class frmRegistroCliente : Form
    {
        public frmRegistroCliente()
        {
            InitializeComponent();
            inicializarFormulario();
        }

        public void inicializarFormulario()
        {
            pctrLogotipo.Image = Image.FromFile("Recursos/Imagenes/logotipo.jpg");
        }

        classPuente puente = new classPuente();
        Cliente cliente = new Cliente();
        private const string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // patron que debe tener para ser correo valido: a@a.a

        private void btnCrearUsuarioCliente_Click_1(object sender, EventArgs e)
        {            
            if (puente.validarCedulaa(txtCedulaCliente.Texts.ToString()))
            {
                if(!puente.autenticarCliente(txtNombreUsuarioCliente.Texts, txtContraseniaUsuarioCliente.Texts) && !puente.autenticarAdmin(txtNombreUsuarioCliente.Texts, txtContraseniaUsuarioCliente.Texts))
                {
                    if (Regex.IsMatch(txtEmailCliente.Texts, patronCorreo))
                    {
                        if (!string.IsNullOrWhiteSpace(txtNombreCliente.Texts) && !string.IsNullOrWhiteSpace(txtApellidoCliente.Texts) && !string.IsNullOrWhiteSpace(txtEmailCliente.Texts) && !string.IsNullOrWhiteSpace(txtDireccionCliente.Texts) && cmbxCuidad.SelectedIndex != -1 && cmbxGeneroCliente.SelectedIndex != -1 && cmbxProvincia.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(txtNombreUsuarioCliente.Texts) && !string.IsNullOrWhiteSpace(txtContraseniaUsuarioCliente.Texts))
                        {
                            Cliente clienteNuevo = new Cliente
                            {
                                cedulaCliente = txtCedulaCliente.Texts,
                                nombreCliente = txtNombreCliente.Texts,
                                apellidoCliente = txtApellidoCliente.Texts,
                                generoCliente = cmbxGeneroCliente.Texts[0],
                                direccionCliente = txtDireccionCliente.Texts,
                                ciudadCliente = cmbxCuidad.Texts,
                                provinciaCliente = cmbxProvincia.Texts,
                                correoCliente = txtEmailCliente.Texts,
                                userCliente = txtNombreUsuarioCliente.Texts,
                                passCliente = txtContraseniaUsuarioCliente.Texts
                                // como no tiene pasaporte no se pone nada 
                            };
                            if (puente.ingresarrCliente(clienteNuevo))
                            {
                                MessageBox.Show("Cliente agregado");
                                this.Close();
                            }
                            else
                            {
                                if (puente.existeCliente(txtCedulaCliente.Texts))
                                {
                                    MessageBox.Show("Cliente NO agregado, esa cedula ya existe");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe llenar todos los campos");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un correo valido");
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe alguien con ese Usuario");
                }
            }
            else
            {
                txtCedulaCliente.Texts = "";
                MessageBox.Show("NOO ES UNA CEDULA LEGAL");
            }
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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

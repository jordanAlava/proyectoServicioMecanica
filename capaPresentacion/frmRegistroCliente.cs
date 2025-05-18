using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaLogica;
using capaEntidad;

namespace capaPresentacion
{
    public partial class frmRegistroCliente : Form
    {
        public frmRegistroCliente()
        {
            InitializeComponent();
        }

        classPuente puente = new classPuente();
        Cliente cliente = new Cliente();

        private void btnCrearUsuarioCliente_Click_1(object sender, EventArgs e)
        {
            if (puente.validarCedulaa(txtCedulaCliente.Texts.ToString()))
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
                        passCliente = txtContraseniaUsuarioCliente.Texts,
                        pasaporteCliente = ""
                    };
                    if (puente.ingrarCliente(clienteNuevo))
                    {
                        MessageBox.Show("Cliente agregado");
                    }
                    else {
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
                txtCedulaCliente.Texts = "";
                MessageBox.Show("NOO ES UNA CEDULA LEGAL");
            }
        }
    }
}

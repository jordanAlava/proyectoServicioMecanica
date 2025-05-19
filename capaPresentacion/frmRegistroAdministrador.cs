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
using capaLogica;

namespace capaPresentacion
{
    public partial class frmRegistroAdministrador : Form
    {

        int cedula;
        public frmRegistroAdministrador()
        {
            InitializeComponent();
        }

        classPuente operacion = new classPuente();

        private void txtCedulaAdministrador__TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCedulaAdministrador_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (txtCedulaAdministrador.Texts.Length != 10)
                    {
                        MessageBox.Show("La cédula debe tener exactamente 10 dígitos.");
                        txtCedulaAdministrador.ResetText();
                        return;
                    }

                    cedula = int.Parse(txtCedulaAdministrador.Texts);
                    txtNombreAdministrador.Focus();
                }
                else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; // Bloquea letras o símbolos
                }
            }
            catch
            {
                MessageBox.Show("Ingrese solo valores numéricos.");
                txtCedulaAdministrador.ResetText();
            }
        }




        private void txtNombreAdministrador_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo se permiten letras, espacios y teclas de control como Backspace
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquear entrada
                MessageBox.Show("Solo se permiten letras.");
            }

            // Si presiona Enter, mover el foco al siguiente campo
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtApellidoAdministrador.Focus(); // Cambia esto según tu formulario
            }
        }


        private void txtApellidoAdministrador_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo se permiten letras, espacios y teclas de control
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquear el carácter no válido
                MessageBox.Show("Solo se permiten letras.");
            }

            // Al presionar Enter, pasar al siguiente campo
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtEmailAdministracion.Focus();
            }
        }




        private void txtEmailAdministracion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string email = txtEmailAdministracion.Texts.Trim(); // o txtEmailAdministracion.Text si es un TextBox estándar

                // Validación básica de correo electrónico
                if (!System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show("Ingrese un correo electrónico válido.");
                    txtEmailAdministracion.ResetText(); // Limpiar el campo
                    return;
                }

                // Si el correo es válido, pasar al siguiente campo
                txtNombreUsuarioAdministrador.Focus();
            }
        }


        private void txtNombreUsuarioAdministrador_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Caracteres permitidos: letras, dígitos y algunos caracteres especiales (ejemplo: _ y . y -)
            // No se permiten espacios.
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '_' && e.KeyChar != '.' && e.KeyChar != '-' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquear carácter no permitido
                MessageBox.Show("Solo se permiten letras, números y los caracteres '_', '.', '-' (sin espacios).");
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                txtContraseniaUsuarioAdministrador.Focus();
            }
        }

        private void frmRegistroAdministrador_Load(object sender, EventArgs e)
        {
            lbl_Invisible.Focus();
            this.ActiveControl = null;
        }

        private void txtContraseniaUsuarioAdministrador__TextChanged(object sender, EventArgs e)
        {
            txtContraseniaUsuarioAdministrador.PasswordChar = true;
        }

        private void btnCrearUsuarioAdministrador_Click(object sender, EventArgs e)
        {
            if (operacion.validarCedulaa(txtCedulaAdministrador.Texts))
            {
                if(!string.IsNullOrWhiteSpace(txtNombreAdministrador.Texts) && !string.IsNullOrWhiteSpace(txtApellidoAdministrador.Texts) && !string.IsNullOrWhiteSpace(txtEmailAdministracion.Texts) && !string.IsNullOrWhiteSpace(txtNombreUsuarioAdministrador.Texts) && !string.IsNullOrWhiteSpace(txtContraseniaUsuarioAdministrador.Texts))
                {
                    if(!operacion.autenticarAdmin(txtNombreUsuarioAdministrador.Texts, txtContraseniaUsuarioAdministrador.Texts) && !operacion.autenticarCliente(txtNombreUsuarioAdministrador.Texts, txtContraseniaUsuarioAdministrador.Texts))
                    {
                        Administrador admin = new Administrador
                        {
                            cedulaAdmin = txtCedulaAdministrador.Texts,
                            nombreAdmin = txtNombreAdministrador.Texts,
                            apellidoAdmin = txtApellidoAdministrador.Texts,
                            userAdmin = txtNombreUsuarioAdministrador.Texts,
                            passAdmin = txtContraseniaUsuarioAdministrador.Texts,
                            correoAdmin = txtEmailAdministracion.Texts
                        };
                        if (operacion.ingresarAdmin(admin))
                        {
                            MessageBox.Show("Nuevo administrador agregado");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se agrego al nuevo administrador agregado");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un administrador con ese Usuario");
                    }
                }
                else
                {
                    MessageBox.Show("LLene todos los campos");
                }
            }
            else
            {
                MessageBox.Show("Cedula invalida");
            }
        }

        private void txtContraseniaUsuarioAdministrador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (Char)Keys.Enter)
            {
                btnCrearUsuarioAdministrador.PerformClick();
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

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
    public partial class frmRegistroAdministrador : Form
    {

        int cedula;
        public frmRegistroAdministrador()
        {
            InitializeComponent();
        }

        private void txtCedulaAdministrador__TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCedulaAdministrador_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if (e.KeyChar == (Char)Keys.Enter)
                {
                    cedula = int.Parse(txtCedulaAdministrador.Text);
                    if (txtCedulaAdministrador.Text.Length <= 10 || txtCedulaAdministrador.Text.Length >= 10)
                    {
                        MessageBox.Show("La cedula debe tener 10 digitoos");
                        txtCedulaAdministrador.Text = "";
                    }
                    else
                    {
                        txtNombreAdministrador.Focus();
                    }
                }

            }
            catch
            {
                MessageBox.Show("Ingrese valores númericos");
                txtCedulaAdministrador.Texts = "";

            }
        }



        private void txtNombreAdministrador_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir teclas de control como Backspace
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Permitir letras y espacio
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras y espacios en el nombre.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Bloquear combinación Ctrl + V (pegar)
            if ((Control.ModifierKeys == Keys.Control) && (e.KeyChar == 22)) // Ctrl+V = ASCII 22
            {
                e.Handled = true;
                MessageBox.Show("No se permite pegar texto en este campo.", "Acción no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtApellidoAdministrador.Focus();
            }
            
        }

        private void txtApellidoAdministrador_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir teclas de control como Backspace
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Permitir letras y espacio
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras y espacios en el apellido.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Bloquear combinación Ctrl + V (pegar)
            if ((Control.ModifierKeys == Keys.Control) && (e.KeyChar == 22)) // Ctrl+V = ASCII 22
            {
                e.Handled = true;
                MessageBox.Show("No se permite pegar texto en este campo.", "Acción no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtEmailAdministracion.Focus();
            }
        }



        private void txtEmailAdministracion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir teclas de control como Backspace, Supr, flechas, etc.
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Permitir letras, dígitos, @, ., guion y guion bajo
            if (!char.IsLetterOrDigit(e.KeyChar) &&
                e.KeyChar != '@' &&
                e.KeyChar != '.' &&
                e.KeyChar != '-' &&
                e.KeyChar != '_')
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras, números y los siguientes caracteres: @ . - _", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Bloquear espacios
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se permiten espacios en el correo electrónico.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Bloquear Ctrl + V (pegar)
            if ((Control.ModifierKeys == Keys.Control) && (e.KeyChar == 22)) // ASCII de Ctrl+V
            {
                e.Handled = true;
                MessageBox.Show("No se permite pegar texto en este campo.", "Acción no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtNombreUsuarioAdministrador.Focus();
            }
        }

        private void txtNombreUsuarioAdministrador_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir teclas de control como Backspace
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Permitir solo letras y números
            if (!char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras y números. No se permiten espacios ni caracteres especiales.",
                    "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Bloquear combinación Ctrl + V (pegar)
            if ((Control.ModifierKeys == Keys.Control) && (e.KeyChar == 22)) // Ctrl+V = ASCII 22
            {
                e.Handled = true;
                MessageBox.Show("No se permite pegar texto en este campo.",
                    "Acción no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtContraseniaUsuarioAdministrador.Focus();
            }
            
        }

    }
}

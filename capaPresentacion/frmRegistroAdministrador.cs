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
                TextBox txt = sender as TextBox;
                if (txt == null) return;

                // Bloquear Ctrl + V (pegar)
                if ((Control.ModifierKeys == Keys.Control) && (e.KeyChar == 22))
                {
                    e.Handled = true;
                    MessageBox.Show("No se permite pegar en este campo.", "Acción no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Permitir teclas de control excepto Enter (que manejamos aparte)
                if (char.IsControl(e.KeyChar) && e.KeyChar != (char)Keys.Enter)
                {
                    return;
                }

                // Solo números permitidos
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Enter)
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se permiten números en la cédula.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cuando se presiona Enter, validar longitud y mover foco
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true; // Evita el beep

                    if (txt.Text.Length == 10)
                    {
                        txtNombreAdministrador.Focus();
                    }
                    else
                    {
                        MessageBox.Show("La cédula debe tener exactamente 10 dígitos para continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {
                // En caso de error, pasar foco para no trabar la app
                txtNombreAdministrador.Focus();
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

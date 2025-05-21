using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion.administrador
{
    public partial class frmServiciosEditar : Form
    {

        private frmAdministradorPantallaPrincipal formularioPadre;

        public frmServiciosEditar(frmAdministradorPantallaPrincipal padre)
        {
            InitializeComponent();
            this.ActiveControl = txtBarraBusqueda;
            formularioPadre = padre;
        }

        void limpiar_formulario(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Clear();
                else if (ctrl is ComboBox)
                    ((ComboBox)ctrl).SelectedIndex = -1;
                else if (ctrl is CheckBox)
                    ((CheckBox)ctrl).Checked = false;
                else if (ctrl.HasChildren)
                    limpiar_formulario(ctrl);  // llamada recursiva
            }
        }


        #region D I S E Ñ O
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
            btnAtras.ForeColor = Color.Black;
            btnAtras.IconColor = Color.Black;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            formularioPadre.abrirFormHijo(new frmServicios(formularioPadre));

        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Control actual = sender as Control;
                if (actual.Name != "txtGarantia")
                {
                    panel1.SelectNextControl(actual, true, true, true, false);

                }
                else
                {
                    btnEditar_Click(sender, e);
                }
                e.Handled = true; // Para evitar beep al presionar Enter
            }

        }
        #endregion

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Servicio Editado Exitósamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar_formulario(this);
        }


    }
}

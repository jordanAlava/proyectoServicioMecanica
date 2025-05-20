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
    public partial class frmServiciosAgregar : Form
    {
        private frmAdministradorPantallaPrincipal formularioPadre;

        // Constructor que recibe el formulario padre
        public frmServiciosAgregar(frmAdministradorPantallaPrincipal padre)
        {
            InitializeComponent();
            formularioPadre = padre;
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
                    btnAgregar_Click(sender, e);
                }
                e.Handled = true; // Para evitar beep al presionar Enter
            }
        }


        #endregion

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Servicio Agregado");
        }


    }
}
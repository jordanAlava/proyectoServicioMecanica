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
    public partial class frmServiciosAgregar : Form
    {
        private frmAdministradorPantallaPrincipal formularioPadre;

        // Constructor que recibe el formulario padre
        public frmServiciosAgregar(frmAdministradorPantallaPrincipal padre)
        {
            InitializeComponent();
            formularioPadre = padre;
            this.ActiveControl = txtNombre;
            this.AcceptButton = new Button();
            txtNombre.Controls[0].Focus();
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
                e.Handled = true;
                txtTipo.Focus();
            }
        }


        #endregion

        classPuente objP = new classPuente();


        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // VALIDACIONES
                string nombre = txtNombre.Texts, tipo = txtTipo.Texts, descripcion = txtDescripcion.Texts;
                int iva = Convert.ToInt32(txtIVA.Texts), garantia = Convert.ToInt32(txtGarantia.Texts);
                decimal costoU = Convert.ToDecimal(txtCostoUnitario.Texts), costoT = Math.Round(costoU * ((Convert.ToDecimal(iva)) / 100 + 1), 2);
                lblCostoT.Text = costoT.ToString();
                if(!string.IsNullOrWhiteSpace(nombre) && !string.IsNullOrWhiteSpace(tipo) && !string.IsNullOrWhiteSpace(descripcion) && !string.IsNullOrWhiteSpace(txtIVA.Texts) && !string.IsNullOrWhiteSpace(txtGarantia.Texts) && !string.IsNullOrWhiteSpace(txtCostoUnitario.Texts))
                {
                    Servicio servicio = new Servicio
                    {
                        nombreServicio = nombre,
                        tipoServicio = tipo,
                        descripcionServicio = descripcion,
                        ivaServicio = iva,
                        garantiaServicio = garantia,
                        costoUnitarioServicio = costoU,
                        costoTotalServicio = costoT
                    };
                    if (objP.ingresarServicio(servicio))
                    {
                        MessageBox.Show("Servicio agregado correctamente");
                        btnAtras.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Error, no se agregó el servicio");
                    }
                }
                else
                {
                    MessageBox.Show("Llene todos los campos...");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ingreso los valores correctos (IVA, Garantia son números enteros");
            }
        }

        private void txtIVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if(e.KeyChar == (Char)Keys.Enter)
                {
                    int iva = Convert.ToInt32(txtIVA.Texts);
                    decimal costoU = Convert.ToDecimal(txtCostoUnitario.Texts), costoT = costoU * ((Convert.ToDecimal(iva)) / 100 + 1);
                    lblCostoT.Text = costoT.ToString();
                    e.Handled = true;
                    txtGarantia.Focus();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Ingreso los valores correctos (IVA, Garantia son números enteros");
            }
            
        }

        private void txtGarantia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (Char)Keys.Enter)
            {
                e.Handled = true;
                btnAgregar.PerformClick();
            }
        }

        private void txtTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (Char)Keys.Enter)
            {
                e.Handled = true;
                txtDescripcion.Focus();
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                e.Handled = true;
                txtCostoUnitario.Focus();
            }
        }

        private void txtCostoUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                e.Handled = true;
                txtIVA.Focus();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                e.Handled = true;
                txtTipo.Focus();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            txtNombre.Focus();
        }
    }
}
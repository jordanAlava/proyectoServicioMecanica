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

namespace capaPresentacion.administrador
{
    public partial class frmServiciosEditar : Form
    {
        classPuente objP = new classPuente();
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
            try
            {
                // VALIDACIONES
                string nombre = txtNombre.Texts, tipo = txtTipo.Texts, descripcion = txtDescripcion.Texts;
                int iva = Convert.ToInt32(txtIVA.Texts), garantia = Convert.ToInt32(txtGarantia.Texts);
                decimal costoU = Convert.ToDecimal(txtCostoUnitario.Texts), costoT = Math.Round(costoU * ((Convert.ToDecimal(iva)) / 100 + 1), 2);
                lblCostoT.Text = costoT.ToString();
                if (costoU < 0)
                {
                    MessageBox.Show("El costo unitario debe ser positivo...");
                    txtCostoUnitario.Texts = "";
                    return;
                }
                if (garantia < 0)
                {
                    MessageBox.Show("Los meses debe ser positivo...");
                    txtIVA.Texts = "";
                    return;
                }
                if (iva < 0)
                {
                    MessageBox.Show("El IVA debe ser positivo...");
                    txtIVA.Texts = "";
                    return;
                }
                if (!string.IsNullOrWhiteSpace(nombre) && !string.IsNullOrWhiteSpace(tipo) && !string.IsNullOrWhiteSpace(descripcion) && !string.IsNullOrWhiteSpace(txtIVA.Texts) && !string.IsNullOrWhiteSpace(txtGarantia.Texts) && !string.IsNullOrWhiteSpace(txtCostoUnitario.Texts))
                {
                    Servicio servicio = new Servicio
                    {
                        idServicio = Convert.ToInt32(txtBarraBusqueda.Texts.Trim()),
                        nombreServicio = nombre,
                        tipoServicio = tipo,
                        descripcionServicio = descripcion,
                        ivaServicio = iva,
                        garantiaServicio = garantia,
                        costoUnitarioServicio = costoU,
                        costoTotalServicio = costoT
                    };
                    if (objP.modificarServicio(servicio))
                    {
                        MessageBox.Show("Servicio Editado Exitósamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            catch 
            {
                MessageBox.Show("Ingreso los valores correctos (IVA, Garantia son números enteros");
            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtBarraBusqueda.Texts.Trim());
                Servicio servicio = objP.buscarServicio(id);
                if(servicio == null)
                {
                    pnlIngresoDatos.Visible = false;
                    lblRegistroNoEncontrado.Visible = true; /// pongo MessageBox porque no se activa esto
                    MessageBox.Show("Servicio no encontrado");
                    return;
                }
                pnlIngresoDatos.Visible = true;
                lblRegistroNoEncontrado.Visible = false;
                txtNombre.Texts = servicio.nombreServicio;
                txtTipo.Texts =servicio.tipoServicio;
                txtDescripcion.Texts = servicio.descripcionServicio;
                txtCostoUnitario.Texts = servicio.costoUnitarioServicio.ToString();
                txtIVA.Texts = servicio.ivaServicio.ToString();
                lblCostoT.Text = servicio.costoTotalServicio.ToString();
                txtGarantia.Texts = servicio.garantiaServicio.ToString();
            }
            catch
            {
                MessageBox.Show("El id es un número entero...");
            }
        }

        private void txtBarraBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (Char)Keys.Enter)
            {
                btnBuscar.PerformClick();
            }
        }

        private void txtIVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (Char)Keys.Enter)
            {
                int iva = Convert.ToInt32(txtIVA.Texts);
                decimal costoU = Convert.ToDecimal(txtCostoUnitario.Texts), costoT = Math.Round(costoU * ((Convert.ToDecimal(iva)) / 100 + 1), 2);
                lblCostoT.Text = costoT.ToString();
                txtGarantia.Focus();
            }
        }
    }
}

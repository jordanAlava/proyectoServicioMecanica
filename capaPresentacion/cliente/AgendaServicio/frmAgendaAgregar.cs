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

namespace capaPresentacion.cliente.AgendaServicio
{
    public partial class frmAgendaAgregar : Form
    {
        frmClientePantallaPrincipal formularioPadre;
        private int id;
        public frmAgendaAgregar(frmClientePantallaPrincipal padre, int id)
        {
            InitializeComponent();
            this.formularioPadre = padre;
            this.id = id;
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
            formularioPadre.abrirFormHijo(new frmAgendaServicios(formularioPadre, id));

        }

        classPuente objP = new classPuente();
        #endregion

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // CARGAR SERVICIOS
            dtgvTabla.DataSource = null;
            dtgvTabla.DataSource = objP.listarServicios();
            //CARGAR PLACAS
            cmbxVehiculo.Items.Clear();
            cmbxVehiculo.Items.AddRange(objP.placasCliente(id).ToArray());
        }

        public bool EsFechaValidaYAnterior(string fecha)
        {
            if (DateTime.TryParseExact(
                    fecha.Trim(),
                    "yyyy-MM-dd",
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None,
                    out DateTime fechaIngresada))
            {
                return fechaIngresada >= DateTime.Today;
            }

            return false; // formato inválido o no es una fecha anterior
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int idServicio = int.Parse(txtidServicio.Texts);
                string fecha = txtFecha.Texts;
                string placa = cmbxVehiculo.Texts;
                if(cmbxVehiculo.SelectedIndex != -1)
                {
                    if (EsFechaValidaYAnterior(fecha))
                    {
                        vehiculoServicio vhServicio = new vehiculoServicio
                        {
                            placa = placa,
                            idServicio = idServicio,
                            fechaServicio = Convert.ToDateTime(fecha)
                        };
                        if (objP.agendarServicio(vhServicio))
                        {
                            MessageBox.Show("Se ha agendado correctamente su servicio");
                        }
                        else
                        {
                            MessageBox.Show("Error al agendar el servicio");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El formato de la fecha es yyyy-mm-dd (2026-12-25) y fechas desde el presente en adelante");
                    }
                }
                else
                {
                    MessageBox.Show("Escoja un vehículo");
                }
            }catch
            {
                MessageBox.Show("El id debe ser entero y existir...");
            }
        }
    }
}

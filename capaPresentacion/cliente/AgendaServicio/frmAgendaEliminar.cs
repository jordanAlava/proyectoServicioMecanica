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

namespace capaPresentacion.cliente.AgendaServicio
{
    public partial class frmAgendaEliminar : Form
    {
        frmClientePantallaPrincipal formularioPadre;
        private int id;
        public frmAgendaEliminar(frmClientePantallaPrincipal padre, int id)
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
        #endregion
        classPuente objP = new classPuente();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //CARGAR PLACAS
            cmbxVehiculo.Items.Clear();
            cmbxVehiculo.Items.AddRange(objP.placasCliente(id).ToArray());
        }

        private void cmbxVehiculo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            cmbServicio.Items.Clear();
            cmbServicio.Items.AddRange(objP.serviciosPlaca(cmbxVehiculo.Texts).ToArray());
        }

        private void cmbServicio_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFecha.Items.Clear();

            string placa = cmbxVehiculo.Texts;
            string servicio = cmbServicio.Texts;

            if (string.IsNullOrWhiteSpace(placa) || string.IsNullOrWhiteSpace(servicio))
            {
                MessageBox.Show("Seleccione primero un vehículo y un servicio válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                List<DateTime> fechas = objP.tenerFechas(placa, servicio);

                if (fechas.Count == 0)
                {
                    MessageBox.Show("No hay fechas registradas para ese servicio.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string[] fechasFormateadas = fechas
                    .Select(f => f.ToString("dd/MM/yyyy")) // o "yyyy-MM-dd"
                    .ToArray();

                cmbFecha.Items.AddRange(fechasFormateadas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al obtener las fechas:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(objP.eliminarServicio(cmbxVehiculo.Texts, Convert.ToDateTime(cmbFecha.Texts)))
            {
                MessageBox.Show("Servicio eliminado");
            }
            else
            {
                MessageBox.Show("Error al eliminar servicio");

            }
        }
    }
}

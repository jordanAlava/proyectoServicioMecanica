using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion.administrador.ReportesAdministrador
{
    public partial class reporteServiciosPendiente : Form
    {
        public reporteServiciosPendiente()
        {
            InitializeComponent();
        }

        private void reporteServiciosPendiente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDTallerMecanicoDataSet2.Vehiculo_Servicio' Puede moverla o quitarla según sea necesario.
            this.vehiculo_ServicioTableAdapter.Fill(this.bDTallerMecanicoDataSet2.Vehiculo_Servicio);

            this.reportViewer1.RefreshReport();
        }
    }
}

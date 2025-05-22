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
    public partial class reporteTipoServicios : Form
    {
        public reporteTipoServicios()
        {
            InitializeComponent();
        }

        private void reporteTipoServicios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDTallerMecanicoDataSet2.Servicio' Puede moverla o quitarla según sea necesario.
            this.servicioTableAdapter.Fill(this.bDTallerMecanicoDataSet2.Servicio);
            // TODO: esta línea de código carga datos en la tabla 'bDTallerMecanicoDataSet2.Servicio' Puede moverla o quitarla según sea necesario.
            this.servicioTableAdapter.Fill(this.bDTallerMecanicoDataSet2.Servicio);
            // TODO: esta línea de código carga datos en la tabla 'bDTallerMecanicoDataSet1.Servicio' Puede moverla o quitarla según sea necesario.
            this.servicioTableAdapter.Fill(this.bDTallerMecanicoDataSet2.Servicio);

            this.reportViewer1.RefreshReport();
        }
    }
}

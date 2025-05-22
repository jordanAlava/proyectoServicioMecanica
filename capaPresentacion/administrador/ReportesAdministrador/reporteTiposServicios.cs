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
    public partial class reporteTiposServicios : Form
    {
        public reporteTiposServicios()
        {
            InitializeComponent();
        }

        private void reporteTiposServicios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDTallerMecanicoDataSet.Servicio' Puede moverla o quitarla según sea necesario.
            this.servicioTableAdapter.Fill(this.bDTallerMecanicoDataSet.Servicio);

            this.reportViewer1.RefreshReport();
        }
    }
}

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
    public partial class reporteClientesRegistrados : Form
    {
        public reporteClientesRegistrados()
        {
            InitializeComponent();
        }

        private void reporteClientesRegistrados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDTallerMecanicoDataSet2.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.bDTallerMecanicoDataSet2.Cliente);

            this.reportViewer1.RefreshReport();
        }
    }
}

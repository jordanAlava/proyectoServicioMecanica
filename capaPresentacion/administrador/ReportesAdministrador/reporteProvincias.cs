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
    public partial class reporteProvincias : Form
    {
        public reporteProvincias()
        {
            InitializeComponent();
        }

        private void reporteProvincias_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}

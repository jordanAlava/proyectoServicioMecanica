﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion.cliente.ReportesCliente
{
    public partial class reporteServiciosRealizados : Form
    {
        public reporteServiciosRealizados()
        {
            InitializeComponent();
        }

        private void reporteServiciosRealizados_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}

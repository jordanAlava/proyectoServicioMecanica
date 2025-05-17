using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class Repuesto
    {
        public int idRepuesto {  get; set; }
        public string modeloRepuesto { get; set; }
        public string marcaRepuesto { get; set; }
        public string tipoRepuesto { get; set; }
        public decimal costoUnitarioRepuesto { get; set; }
        public int ivaRepuesto { get; set; }
        public int stockRepuesto { get; set; }
        public int tiempoGarantiaRepuesto { get; set; }
    }
}

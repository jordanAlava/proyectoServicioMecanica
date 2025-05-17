using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class Servicio
    {
        public int idServicio {  get; set; }
        public string nombreServicio { get; set; }
        public string tipoServicio { get; set; }
        public string descripcionServicio { get; set; }
        public decimal costoUnitarioServicio { get; set; }
        public int ivaServicio { get; set; }
        public decimal costoTotalServicio { get; set; }
        public int garantiaServicio { get; set; }
    }
}

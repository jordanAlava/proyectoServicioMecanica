using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class serviciosCliente
    {
        public string placa {  get; set; }
        public string servicio { get; set; }
        public string descripcion { get; set; }
        public decimal costoTotal { get; set; }
        public DateTime fecha { get; set; }
    }
}

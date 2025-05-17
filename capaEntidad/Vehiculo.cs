using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class Vehiculo
    {
        public string placaVehiculo {  get; set; }
        public int idCliente { get; set; }
        public string modeloVehiculo { get; set; }
        public string marcaVehiculo { get; set; }
        public string numChasisVehiculo { get; set; }
        public string colorVehiculo { get; set; }
        public DateTime fechaFabricacionVehiculo { get; set; }
        public string cilindrajeVehiculo { get; set; }
        public string combustibleVehiculo { get; set; }
        public char aseguradoVehiculo { get; set; }
        public byte[] fotoVehiculo { get; set; }
    }
}

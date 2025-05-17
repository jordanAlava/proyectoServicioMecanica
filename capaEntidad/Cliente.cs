using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class Cliente
    {
        public int idCliente {  get; set; }
        public string cedulaCliente { get; set; }
        public string nombreCliente { get; set; }
        public string apellidoCliente { get; set; }
        public char generoCliente { get; set; }
        public string direccionCliente { get; set; }
        public string ciudadCliente { get; set; }
        public string provinciaCliente { get; set; }
        public string correoCliente { get; set; }
        public string userCliente { get; set; }
        public string passCliente { get; set; }
    }
}

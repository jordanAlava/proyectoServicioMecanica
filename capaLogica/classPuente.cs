using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDato;
using capaEntidad;

namespace capaLogica
{
    public class classPuente
    {
        ClassOperacionesBD operacion = new ClassOperacionesBD();
        public bool validarCedulaa(string cedula)
        {
            return operacion.validarCedula(cedula);
        }
        public bool ingrarCliente(Cliente cliente)
        {
            return operacion.ingresarCliente(cliente);
        }
        public bool existeCliente(string cedulaE)
        {
            return operacion.existeCliente(cedulaE);
        }
    }
}

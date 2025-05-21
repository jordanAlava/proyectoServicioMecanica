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
        // OPERACIONES CLIENTE
        public bool validarCedulaa(string cedula)
        {
            return operacion.validarCedula(cedula);
        }
        public bool ingresarrCliente(Cliente cliente)
        {
            return operacion.ingresarCliente(cliente);
        }
        public bool existeCliente(string cedulaE)
        {
            return operacion.existeCliente(cedulaE);
        }
        public Cliente buscarCliente(int idE)
        {
            return operacion.buscarCliente(idE);
        }
        public bool modificarCliente(Cliente cliente)
        {
            return operacion.modificarCliente(cliente);
        }
        public bool autenticarCliente(string user, string contra)
        {
            return operacion.autenticacionCliente(user, contra);
        }

        ///// ADMINISTRADOR
        ///

        public bool ingresarAdmin(Administrador admin)
        {
            return operacion.ingresarAdmin(admin);
        }
        public Administrador buscarAdminn(string cedula)
        {
            return operacion.buscarAdmin(cedula);
        }
        public bool modificarAdmin(Administrador admin)
        {
            return operacion.modificarAdministrador(admin);
        }
        public bool eliminarAdmin(string cedula)
        {
            return operacion.eliminarAdministrador(cedula);
        }
        public bool autenticarAdmin(string user, string contra)
        {
            return operacion.autenticarAdministrador(user, contra);
        }
        public List<Administrador> listaAdministradores()
        {
            return operacion.listarAdministradores();
        }
        public List<Cliente> listaClientes()
        {
            return operacion.listarClientes();
        }
        public bool existeUsuario(string usuario)
        {
            return operacion.existeUsuario(usuario);
        }

        /////////////////// SERVICIOS //////////////////////
        public List<string> tipoServicios()
        {
            return operacion.tipoServicios();
        }
        public Servicio buscarServicio(int idSer)
        {
            return operacion.buscarServicio(idSer);
        }
        public bool modificarServicio(Servicio servicio)
        {
            return operacion.modificarServicio(servicio);
        }
        public bool ingresarServicio(Servicio servicio)
        {
            return operacion.ingresarServicio(servicio);
        }
        public List<Servicio> listarServicios()
        {
            return operacion.listarServicios();
        }
        public List<Servicio> filtrarServicios(string tipo, decimal dinero)
        {
            return operacion.filtrarServicios(tipo, dinero);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidad;

namespace capaDato
{
    public class ClassOperacionesBD
    {
        ClassConexion objConnect = new ClassConexion();
        ///////////////// OPERACIONES DE ADMINISTRADOR //////////////////////
        /* Metodos
         * 1    bool ingresarAdmin
         * 2    bool modificarAdmin 
         * 3    Administrador buscarAdmin - retorna todos los datos del administrador
         * 4    bool eliminarAdministrador
         * 5    bool autenticarAdmin
         * 6    List listaAdministradores - retorna una lista 
         */
        
        public bool ingresarAdmin(Administrador nuevoAdmin)
        {
            try
            {
                objConnect.Abrir();
                SqlCommand sqlC = new SqlCommand("INSERT INTO Administrador (cedula,nombreAdmin,apellidoAdmin,e_mail,userName,passAdmin) VALUES (@cedula, @nombre, @apellido, @correo, @usuario, @pass)", objConnect.conectar);
                sqlC.Parameters.AddWithValue("@cedula", nuevoAdmin.cedulaAdmin);
                sqlC.Parameters.AddWithValue("@nombre", nuevoAdmin.nombreAdmin);
                sqlC.Parameters.AddWithValue("@apellido", nuevoAdmin.apellidoAdmin);
                sqlC.Parameters.AddWithValue("@correo", nuevoAdmin.correoAdmin);
                sqlC.Parameters.AddWithValue("@usuario", nuevoAdmin.userAdmin);
                sqlC.Parameters.AddWithValue("@pass", nuevoAdmin.passAdmin);
                int filaAgregada = sqlC.ExecuteNonQuery();
                objConnect.Cerrar();
                return filaAgregada > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public Administrador buscarAdmin(string cedulaBuscar)
        {
            try
            {
                objConnect.Abrir();
                SqlCommand sqlC = new SqlCommand("SELECT * FROM Administrador WHERE cedula = @cedulaBuscar", objConnect.conectar);
                sqlC.Parameters.AddWithValue("@cedulaBuscar", cedulaBuscar);
                SqlDataReader reader = sqlC.ExecuteReader();
                if (reader.Read())
                {
                    Administrador admin = new Administrador
                    {
                        cedulaAdmin = Convert.ToString(reader["cedula"]),
                        nombreAdmin = Convert.ToString(reader["nombreAdmin"]),
                        apellidoAdmin = Convert.ToString(reader["apellidoAdmin"]),
                        correoAdmin = Convert.ToString(reader["e_mail"]),
                        userAdmin = Convert.ToString(reader["userName"]),
                        passAdmin = Convert.ToString(reader["passAdmin"])
                    };
                    reader.Close();
                    objConnect.Cerrar();
                    return admin;
                }
                else
                {
                    reader.Close();
                    objConnect.Cerrar();
                    return null;
                }

            }catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
        public bool modificarAdministrador(Administrador admin)
        {
            try
            {
                objConnect.Abrir();
                SqlCommand sqlC = new SqlCommand("UPDATE Administrador SET nombreAdmin = @nombre, apellidoAdmin = @apellido, e_mail = @correo, userName = @usuario, passAdmin = @pass WHERE cedula = @cedula", objConnect.conectar);
                sqlC.Parameters.AddWithValue("@cedula", admin.cedulaAdmin);
                sqlC.Parameters.AddWithValue("@nombre", admin.nombreAdmin);
                sqlC.Parameters.AddWithValue("@apellido", admin.apellidoAdmin);
                sqlC.Parameters.AddWithValue("@correo", admin.correoAdmin);
                sqlC.Parameters.AddWithValue("@usuario", admin.userAdmin);
                sqlC.Parameters.AddWithValue("@pass", admin.passAdmin);
                int adminModificado = sqlC.ExecuteNonQuery();
                objConnect.Cerrar();
                return adminModificado > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public bool eliminarAdministrador(string cedulaBuscar)
        {
            try
            {
                objConnect.Abrir();
                SqlCommand sqlC = new SqlCommand("DELETE FROM Administrador WHERE cedula = @cedulaBuscar", objConnect.conectar);
                sqlC.Parameters.AddWithValue("@cedulaBuscar", cedulaBuscar);
                int adminEliminado = sqlC.ExecuteNonQuery();
                objConnect.Cerrar();
                return adminEliminado > 0;
            }catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public bool autenticarAdministrador(string usuario, string pass)
        {
            try
            {
                objConnect.Abrir();
                SqlCommand sqlC = new SqlCommand("SELECT COUNT(*) FROM Administrador WHERE userName = @usuario AND passAdmin = @pass", objConnect.conectar);
                sqlC.Parameters.AddWithValue("@usuario", usuario);
                sqlC.Parameters.AddWithValue("pass", pass);
                int existe = (int)sqlC.ExecuteScalar();
                objConnect.Cerrar();
                return existe == 1;

            }catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public List<Administrador> listarAdministradores()
        {
            List<Administrador> administradores = new List<Administrador>();
            try
            {
                objConnect.Abrir();
                SqlCommand sqlC = new SqlCommand("SELECT * FROM Administrador", objConnect.conectar);
                SqlDataReader reader = sqlC.ExecuteReader();
                while (reader.Read())
                {
                    Administrador admin = new Administrador
                    {
                        cedulaAdmin = Convert.ToString(reader["cedula"]),
                        nombreAdmin = Convert.ToString(reader["nombreAdmin"]),
                        apellidoAdmin = Convert.ToString(reader["apellidoAdmin"]),
                        correoAdmin = Convert.ToString(reader["e_mail"]),
                        userAdmin = Convert.ToString(reader["userName"]),
                        passAdmin = Convert.ToString(reader["passAdmin"])
                    };
                    administradores.Add(admin);
                }
                objConnect.Cerrar();
                reader.Close();
                return administradores;
            }catch( Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }

        ///////////////// OPERACIONESS DE CLIENTE //////////////////////////
        /* Metodos
         * 1    bool ingresarCliente
         * 2    Cliente buscarCliente - retorna un cliente o null
         */

        public bool ingresarCliente(Cliente cliente)
        {
            try
            {
                bool tieneCedula = !string.IsNullOrWhiteSpace(cliente.cedulaCliente);
                bool tienePasaporte = !string.IsNullOrWhiteSpace(cliente.pasaporteCliente);

                if (tieneCedula == tienePasaporte) return false;

                objConnect.Abrir();
                SqlCommand sqlC = new SqlCommand("INSERT INTO Cliente(cedula, nombreCli, apellidoCli, genero, Direccion, ciudadCli, provinciaCli, e_mail, userCliente, passCli, pasaporte) VALUES(@cedula, @nombre, @apellido, @genero, @direccion, @ciudad, @provinci, @correo, @usuario, @contra, @passport)", objConnect.conectar);
                sqlC.Parameters.AddWithValue("@cedula", tieneCedula ? cliente.cedulaCliente : (object)DBNull.Value);
                sqlC.Parameters.AddWithValue("@passport", tienePasaporte ? cliente.pasaporteCliente : (object)DBNull.Value);
                sqlC.Parameters.AddWithValue("@nombre", cliente.nombreCliente);
                sqlC.Parameters.AddWithValue("@apellido", cliente.apellidoCliente);
                sqlC.Parameters.AddWithValue("@genero", cliente.generoCliente);
                sqlC.Parameters.AddWithValue("@direccion", cliente.direccionCliente);
                sqlC.Parameters.AddWithValue("@ciudad", cliente.ciudadCliente);
                sqlC.Parameters.AddWithValue("@provinci", cliente.provinciaCliente);
                sqlC.Parameters.AddWithValue("@correo", cliente.correoCliente);
                sqlC.Parameters.AddWithValue("@usuario", cliente.userCliente);
                sqlC.Parameters.AddWithValue("@contra", cliente.passCliente);
                int clienteAgregado = sqlC.ExecuteNonQuery();
                objConnect.Cerrar();
                return clienteAgregado == 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

    }
}

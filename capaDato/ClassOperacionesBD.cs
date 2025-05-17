using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
         * ingresarAdmin
         * modificarAdmin 
         * buscarAdmin
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

        ///////////////// OPERACIONESS DE CLIENTE //////////////////////////
    }
}

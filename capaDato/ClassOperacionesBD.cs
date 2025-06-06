﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
         * 7    List listaClientes - retorna una lista
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
                throw new Exception("Error al insertar administrador: " + ex.Message);
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
                SqlCommand sqlC = new SqlCommand(@"
                SELECT COUNT(*)
                FROM Administrador
                WHERE userName COLLATE Latin1_General_CS_AS = @usuario
                AND passAdmin COLLATE Latin1_General_CS_AS = @contrasenia ", objConnect.conectar);
                sqlC.Parameters.AddWithValue("@usuario", usuario);
                sqlC.Parameters.AddWithValue("@contrasenia", pass);
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
        public List<Cliente> listarClientes()
        {
            List<Cliente> listaCliente = new List<Cliente>();
            try
            {
                objConnect.Abrir();
                SqlCommand sqlC = new SqlCommand(@"
                SELECT * 
                FROM Cliente", objConnect.conectar);
                SqlDataReader reader = sqlC.ExecuteReader();
                while (reader.Read())
                {
                    Cliente cliente = new Cliente
                    {
                        idCliente = Convert.ToInt32(reader["idCliente"]),
                        cedulaCliente = Convert.ToString(reader["cedula"]),
                        nombreCliente = Convert.ToString(reader["nombreCli"]),
                        apellidoCliente = Convert.ToString(reader["apellidoCli"]),
                        generoCliente = Convert.ToChar(reader["genero"]),
                        direccionCliente = Convert.ToString(reader["direccion"]),
                        ciudadCliente = Convert.ToString(reader["ciudadCli"]),
                        provinciaCliente = Convert.ToString(reader["provinciaCli"]),
                        correoCliente = Convert.ToString(reader["e_mail"]),
                        userCliente = Convert.ToString(reader["userCliente"]),
                        passCliente = Convert.ToString(reader["passCli"]),
                        pasaporteCliente = Convert.ToString(reader["pasaporte"])
                    };
                    listaCliente.Add(cliente);
                }
                reader.Close();
                return listaCliente;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
            finally
            {
                objConnect.Cerrar();
            }
        }

        ///////////////// OPERACIONESS DE CLIENTE //////////////////////////
        /* Metodos
         * 1    bool ingresarCliente
         * 2    Cliente buscarCliente - retorna un cliente o null
         * 3    bool modificarCliente
         * 4    bool autenticacion del cliente
         * 5    bool cedulaValida - verifica si es una cedula valida
         * 6    bool existeCliente 
         * 7    bool autenticacionCliente
         * 8    bool existeUsuario
         * 9    Cliente buscarClienteUC(string usuario, string contra)
         */

        public Cliente buscarClienteUC(string usuario, string contra)
        {
            try
            {
                objConnect.Abrir();
                SqlCommand sqlC = new SqlCommand("SELECT * FROM Cliente WHERE userCliente = @usuario AND passCli = @pass", objConnect.conectar);
                sqlC.Parameters.AddWithValue("@usuario", usuario);
                sqlC.Parameters.AddWithValue("@pass", contra);
                SqlDataReader reader = sqlC.ExecuteReader();
                if (reader.Read())
                {
                    Cliente clienteEncontrado = new Cliente
                    {
                        idCliente = Convert.ToInt32(reader["idCliente"]),
                        cedulaCliente = Convert.ToString(reader["cedula"]),
                        nombreCliente = Convert.ToString(reader["nombreCli"]),
                        apellidoCliente = Convert.ToString(reader["apellidoCli"]),
                        generoCliente = Convert.ToChar(reader["genero"]),
                        direccionCliente = Convert.ToString(reader["direccion"]),
                        ciudadCliente = Convert.ToString(reader["ciudadCli"]),
                        provinciaCliente = Convert.ToString(reader["provinciaCli"]),
                        correoCliente = Convert.ToString(reader["e_mail"]),
                        userCliente = Convert.ToString(reader["userCliente"]),
                        passCliente = Convert.ToString(reader["passCli"]),
                        pasaporteCliente = Convert.ToString(reader["pasaporte"])
                    };
                    reader.Close();
                    objConnect.Cerrar();
                    return clienteEncontrado; ;
                }
                else
                {
                    reader.Close();
                    objConnect.Cerrar();
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }

        public bool existeUsuario(string usuario)
        {
            try
            {
                objConnect.Abrir();
                SqlCommand sqlC = new SqlCommand(@"
                SELECT COUNT(*)
                FROM Cliente
                WHERE userCliente COLLATE Latin1_General_CS_AS = @usuario", objConnect.conectar);
                sqlC.Parameters.AddWithValue("@usuario", usuario);
                int usuarioEncontraC = (int)sqlC.ExecuteScalar();
                SqlCommand sqlCC = new SqlCommand(@"
                SELECT COUNT(*)
                FROM Administrador
                WHERE userName COLLATE Latin1_General_CS_AS = @user", objConnect.conectar);
                sqlCC.Parameters.AddWithValue("@user", usuario);
                int usuarioEncontraA = (int)sqlCC.ExecuteScalar();
                if(usuarioEncontraA == 1 || usuarioEncontraC == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                objConnect.Cerrar();
            }
        }
        public bool existeCliente(string cedulaR)
        {
            try
            {
                objConnect.Abrir();
                SqlCommand sqlC = new SqlCommand(@"
                SELECT COUNT(*) 
                FROM Cliente    
                WHERE cedula = @cedulaR", objConnect.conectar);
                sqlC.Parameters.AddWithValue("@cedulaR", cedulaR);
                int clienteEncontrado = (int)sqlC.ExecuteScalar();
                return clienteEncontrado == 1;  
            }catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                objConnect.Cerrar();
            }
        }
        public bool ingresarCliente(Cliente cliente)
        {
            try
            {
                bool tieneCedula = !string.IsNullOrWhiteSpace(cliente.cedulaCliente);
                bool tienePasaporte = !string.IsNullOrWhiteSpace(cliente.pasaporteCliente);

                if (!tieneCedula && !tienePasaporte) return false;

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
                throw new Exception("Error al insertar cliente: " + ex.Message);
                //return false;
            }
        }

        public Cliente buscarCliente(int idR)
        {
            try
            {
                objConnect.Abrir();
                SqlCommand sqlC = new SqlCommand("SELECT * FROM Cliente WHERE idCliente = @idR", objConnect.conectar);
                sqlC.Parameters.AddWithValue("@idR", idR);
                SqlDataReader reader = sqlC.ExecuteReader();
                if (reader.Read())
                {
                    Cliente clienteEncontrado = new Cliente
                    {
                        idCliente = Convert.ToInt32(reader["idCliente"]),
                        cedulaCliente = Convert.ToString(reader["cedula"]),
                        nombreCliente = Convert.ToString(reader["nombreCli"]),
                        apellidoCliente = Convert.ToString(reader["apellidoCli"]),
                        generoCliente = Convert.ToChar(reader["genero"]),
                        direccionCliente = Convert.ToString(reader["direccion"]),
                        ciudadCliente = Convert.ToString(reader["ciudadCli"]),
                        provinciaCliente = Convert.ToString(reader["provinciaCli"]),
                        correoCliente = Convert.ToString(reader["e_mail"]),
                        userCliente = Convert.ToString(reader["userCliente"]),
                        passCliente = Convert.ToString(reader["passCli"]),
                        pasaporteCliente = Convert.ToString(reader["pasaporte"])
                    };
                    reader.Close();
                    objConnect.Cerrar();
                    return clienteEncontrado; ;
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
        public bool modificarCliente(Cliente cliente)
        {
            try
            {
                objConnect.Abrir();
                SqlCommand sqlC = new SqlCommand(@"UPDATE Cliente SET nombreCli = @nombre, apellidoCli = @apellido, direccion = @direccion, ciudadCli = @ciudad, provinciaCli = @provincia, e_mail = @correo, userCliente = @usuario, passCli = @contra WHERE idCliente = @id", objConnect.conectar);
                sqlC.Parameters.AddWithValue("@nombre", cliente.nombreCliente);
                sqlC.Parameters.AddWithValue("@apellido", cliente.apellidoCliente);
                sqlC.Parameters.AddWithValue("@direccion", cliente.direccionCliente);
                sqlC.Parameters.AddWithValue("@ciudad", cliente.ciudadCliente);
                sqlC.Parameters.AddWithValue("@provincia", cliente.provinciaCliente);
                sqlC.Parameters.AddWithValue("@correo", cliente.correoCliente);
                sqlC.Parameters.AddWithValue("@usuario", cliente.userCliente);
                sqlC.Parameters.AddWithValue("@contra", cliente.passCliente);
                sqlC.Parameters.AddWithValue("@id", cliente.idCliente);
                int clienteModificado = sqlC.ExecuteNonQuery();
                objConnect.Cerrar();
                return clienteModificado == 1;
            }catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }
        public bool validarCedula(string cedula)
        {
            if (cedula.Length == 10 && cedula.All(char.IsDigit))
            {
                int provincia = int.Parse(cedula.Substring(0, 2));
                if (provincia >= 1 && provincia <= 24)
                {
                    int suma = 0;
                    for (int i = 0; i < 9; i++)
                    {
                        int digito = int.Parse(cedula[i].ToString());
                        if (i % 2 == 0)
                        {
                            digito *= 2;
                            if (digito > 9)
                                digito -= 9;
                        }
                        suma += digito;
                    }

                    int verificador = (10 - (suma % 10)) % 10;
                    int ultimoDigito = int.Parse(cedula[9].ToString());

                    return verificador == ultimoDigito;
                }
            }

            return false;
        }

        public bool autenticacionCliente(string usuario, string contra)
        {
            try
            {
                objConnect.Abrir();
                string sentencia = @"
                SELECT COUNT(*)
                FROM Cliente
                WHERE userCliente COLLATE Latin1_General_CS_AS = @usuario
                AND passCli COLLATE Latin1_General_CS_AS = @contrasenia ";
                SqlCommand sqlC = new SqlCommand(sentencia, objConnect.conectar);
                sqlC.Parameters.AddWithValue("@usuario", usuario);
                sqlC.Parameters.AddWithValue("@contrasenia", contra);
                int clienteEncontrado = (int)sqlC.ExecuteScalar();
                return clienteEncontrado == 1;
            }catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                objConnect.Cerrar();
            }
        }

        ///////////////// OPERACIONES VEHICULO //////////////////
        /*  Metodos
         *  1   bool ingresarVehiculo
         *  2   bool eliminarVehiculo
         *  3   bool modificarVehiculo
         *  4   bool existeVehiculo
         *  5   Vehiculo buscarVehiculo
         *  6   List<Vehiculo> listarVehiculosCliente
         *  7   List<string> PlacasCliente
         */

        public List<string> placasCliente(int id)
        {
            List<string> placas = new List<string>();
            try
            {
                objConnect.Abrir();
                SqlCommand sqlC = new SqlCommand(@"
                SELECT placa
                FROM Vehiculo
                WHERE idCliente = @id", objConnect.conectar);
                sqlC.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = sqlC.ExecuteReader();
                while (reader.Read())
                {
                    placas.Add(Convert.ToString(reader["placa"]));
                }
                reader.Close();
                return placas;
            }catch(Exception ex)
            {
                throw new Exception("Error: ", ex);
            }
            finally
            {
                objConnect.Cerrar();
            }
        }

        public List<Vehiculo> listarVehiculosCliente(int idCliente)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            try
            {
                objConnect.Abrir();
                SqlCommand sqlC = new SqlCommand(@"
                SELECT *
                FROM Cliente cli inner join Vehiculo vh on cli.idCliente = vh.idCliente
                WHERE cli.idCliente = @id", objConnect.conectar);
                sqlC.Parameters.AddWithValue("@id", idCliente);
                SqlDataReader reader = sqlC.ExecuteReader();
                while (reader.Read())
                {
                    Vehiculo vh = new Vehiculo
                    {
                        placaVehiculo = Convert.ToString(reader["placa"]),
                        idCliente = Convert.ToInt32(reader["idCliente"]),
                        modeloVehiculo = Convert.ToString(reader["modelo"]),
                        marcaVehiculo = Convert.ToString(reader["marca"]),
                        numChasisVehiculo = Convert.ToString(reader["numChasis"]),
                        colorVehiculo = Convert.ToString(reader["color"]),
                        fechaFabricacionVehiculo = Convert.ToDateTime(reader["fechaFabricacion"]),
                        cilindrajeVehiculo = Convert.ToString(reader["cilindraje"]),
                        combustibleVehiculo = Convert.ToString(reader["combustible"]),
                        aseguradoVehiculo = Convert.ToChar(reader["asegurado"]),
                        fotoVehiculo = reader["foto"] == DBNull.Value ? null : (byte[])reader["foto"]
                    };
                    vehiculos.Add(vh);
                }
                reader.Close();
                return vehiculos;
            }catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
            finally
            {
                objConnect.Cerrar();
            }
        }
        public Vehiculo buscarVehiculo(string placa)
        {
            try
            {
                objConnect.Abrir();
                SqlCommand sqlC = new SqlCommand(@"
                SELECT * 
                FROM Vehiculo
                WHERE placa = @placa", objConnect.conectar);
                sqlC.Parameters.AddWithValue("@placa", placa);
                SqlDataReader reader = sqlC.ExecuteReader();
                if (reader.Read())
                {
                    Vehiculo vhEncontrado = new Vehiculo
                    {
                        placaVehiculo = Convert.ToString(reader["placa"]),
                        idCliente = Convert.ToInt32(reader["idCliente"]),
                        modeloVehiculo = Convert.ToString(reader["modelo"]),
                        marcaVehiculo = Convert.ToString(reader["marca"]),
                        numChasisVehiculo = Convert.ToString(reader["numChasis"]),
                        colorVehiculo = Convert.ToString(reader["color"]),
                        fechaFabricacionVehiculo = Convert.ToDateTime(reader["fechaFabricacion"]),
                        cilindrajeVehiculo = Convert.ToString(reader["cilindraje"]),
                        combustibleVehiculo = Convert.ToString(reader["combustible"]),
                        aseguradoVehiculo = Convert.ToChar(reader["asegurado"]),
                        fotoVehiculo = reader["foto"] == DBNull.Value ? null : (byte[])reader["foto"]
                    };
                    reader.Close();
                    return vhEncontrado;
                }
                else
                {
                    reader.Close();
                    return null;
                }
            }catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
            finally
            {
                objConnect.Cerrar();
            }
        }
        public bool existeVehiculo(string placa, string chasis)
        {
            try
            {
                objConnect.Abrir();
                SqlCommand sqlC = new SqlCommand(@"
                SELECT COUNT(*)
                FROM Vehiculo
                WHERE placa = @placa OR numChasis = @chasis", objConnect.conectar);
                int existe = (int)sqlC.ExecuteScalar();
                objConnect.Cerrar();
                return existe == 1;
                
            }catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }
        public bool modificarVehiculo(Vehiculo vehiculo)
        {
            try
            {
                objConnect.Abrir();
                SqlCommand sqlC = new SqlCommand(@"
                UPDATE Vehiculo
                SET idCliente = @id, modelo = @modelo,marca = @marca, numChasis = @chasis, color = @color, fechaFabricacion = @fabricacion, cilindraje = @cilindraje, combustible = @combustible, asegurado = @asegurado, foto = @foto
                WHERE placa = @placa", objConnect.conectar);
                sqlC.Parameters.AddWithValue("@placa", vehiculo.placaVehiculo);
                sqlC.Parameters.AddWithValue("@id", vehiculo.idCliente);
                sqlC.Parameters.AddWithValue("@modelo", vehiculo.modeloVehiculo);
                sqlC.Parameters.AddWithValue("@marca", vehiculo.marcaVehiculo);
                sqlC.Parameters.AddWithValue("@chasis", vehiculo.numChasisVehiculo);
                sqlC.Parameters.AddWithValue("@color", vehiculo.colorVehiculo);
                sqlC.Parameters.AddWithValue("@fabricacion", vehiculo.fechaFabricacionVehiculo);
                sqlC.Parameters.AddWithValue("@cilindraje", vehiculo.cilindrajeVehiculo);
                sqlC.Parameters.AddWithValue("@combustible", vehiculo.combustibleVehiculo);
                sqlC.Parameters.AddWithValue("@asegurado", vehiculo.aseguradoVehiculo);
                sqlC.Parameters.AddWithValue("@foto", vehiculo.fotoVehiculo);
                int vehiculoModificado = sqlC.ExecuteNonQuery();
                objConnect.Cerrar();
                return vehiculoModificado == 1;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public bool eliminarVehiculo(string placa)
        {
            try
            {
                // CONTROLAR EN EL FOMRULARIO QUE SEA UNA PLACA CORRECTA
                objConnect.Abrir();
                SqlCommand sqlC = new SqlCommand(@"
                DELETE
                FROM Vehiculo
                WHERE placa = @placa", objConnect.conectar);
                sqlC.Parameters.AddWithValue("@placa", placa);
                int vehiculoEliminado = sqlC.ExecuteNonQuery();
                objConnect.Cerrar();
                return vehiculoEliminado == 1;
            }catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }
        public bool ingresarVehiculo(Vehiculo vehiculo)
        {
            try
            {
                objConnect.Abrir();
                SqlCommand sqlC = new SqlCommand(@"
                INSERT INTO Vehiculo(placa, idCliente, modelo, marca, numChasis, color, fechaFabricacion, cilindraje, combustible, asegurado, foto)
                VALUES (@placa, @id, @modelo, @marca, @chasis, @color, @fabricacion, @cilindraje, @combustible, @asegurado, @foto)", objConnect.conectar);
                sqlC.Parameters.AddWithValue("@placa", vehiculo.placaVehiculo);
                sqlC.Parameters.AddWithValue("@id", vehiculo.idCliente);
                sqlC.Parameters.AddWithValue("@modelo", vehiculo.modeloVehiculo);
                sqlC.Parameters.AddWithValue("@marca", vehiculo.marcaVehiculo);
                sqlC.Parameters.AddWithValue("@chasis", vehiculo.numChasisVehiculo);
                sqlC.Parameters.AddWithValue("@color", vehiculo.colorVehiculo);
                sqlC.Parameters.AddWithValue("@fabricacion", vehiculo.fechaFabricacionVehiculo);
                sqlC.Parameters.AddWithValue("@cilindraje", vehiculo.cilindrajeVehiculo);
                sqlC.Parameters.AddWithValue("@combustible", vehiculo.combustibleVehiculo);
                sqlC.Parameters.AddWithValue("@asegurado", vehiculo.aseguradoVehiculo);
                sqlC.Parameters.AddWithValue("@foto", vehiculo.fotoVehiculo);
                int vehiculoAgregado = sqlC.ExecuteNonQuery();
                return vehiculoAgregado == 1;
            }
            catch(Exception ex)
            {
                throw new Exception("Error: ", ex);
            }
            finally
            {
                objConnect.Cerrar();
            }
        }

        ///////////////// OPERACIONES DE SERVICIOS ////////////////////////
        /*  Metodos
         *  1   bool ingresarServicio
         *  2   bool modificarServicio
         *  3   Servicio buscarServicio
         *  4   List<string> RetornarTiposServicios
         *  5   List<Servicio> listarServicios
         *  6   list<Servicio> filtrarServicios
         *  7   bool eliminarServicio
         *  8   List<serviciosCliente> serviciosCliente
         *  9   bool AgendarServicio
         *  10  List<string> serviciosPlaca
         *  11  List<string> tenerFechas
         *  12  bool eliminarServicio
         */

        public bool eliminarServicio(string placa, DateTime fecha)
        {
            try
            {
                objConnect.Abrir();
                SqlCommand sqlC = new SqlCommand(@"
                DELETE FROM Vehiculo_Servicio 
                WHERE placa = @placa AND fechaServicio = @fecha", objConnect.conectar);
                sqlC.Parameters.AddWithValue("@placa", placa);
                sqlC.Parameters.AddWithValue("@fecha", fecha);
                int filaBorrada = sqlC.ExecuteNonQuery();
                return filaBorrada == 1;
            }catch(Exception ex)
            {
                throw new Exception("Error: ", ex);
            }
            finally
            {
                objConnect.Cerrar();
            }
        }

        public List<DateTime> tenerFechas(string placa, string servicio)
        {
            List<DateTime> fechas = new List<DateTime>();
            try
            {
                if (string.IsNullOrWhiteSpace(placa) || string.IsNullOrWhiteSpace(servicio))
                    throw new Exception("La placa o el servicio están vacíos o nulos.");

                objConnect.Abrir();

                SqlCommand sqlC = new SqlCommand(@"
            SELECT vs.fechaServicio
            FROM Vehiculo_Servicio vs 
            INNER JOIN Servicio sv ON vs.idServicio = sv.idServicio
            WHERE vs.placa = @placa AND CAST(sv.descripcion AS NVARCHAR(MAX)) = @servicio", objConnect.conectar);

                sqlC.Parameters.AddWithValue("@placa", placa);
                sqlC.Parameters.AddWithValue("@servicio", servicio);

                SqlDataReader reader = sqlC.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["fechaServicio"] != DBNull.Value)
                        fechas.Add(Convert.ToDateTime(reader["fechaServicio"]));
                }
                reader.Close();
                return fechas;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las fechas: " + ex.Message, ex);
            }
            finally
            {
                objConnect.Cerrar();
            }
        }
        public List<string> serviciosPlaca(string placa)
        {
            List<string> serviciosPlaca = new List<string>();
            try
            {
                objConnect.Abrir();
                SqlCommand sqlC = new SqlCommand(@"
                SELECT sv.descripcion 
                FROM Vehiculo_Servicio vs inner join Servicio sv on vs.idServicio = sv.idServicio
                WHERE placa = @placa", objConnect.conectar);
                sqlC.Parameters.AddWithValue("@placa", placa);
                SqlDataReader reader = sqlC.ExecuteReader();
                while (reader.Read())
                {
                    serviciosPlaca.Add(Convert.ToString(reader["descripcion"]));
                }
                reader.Close();
                return serviciosPlaca;
            }catch(Exception ex)
            {
                throw new Exception("Error: ", ex);
            }
            finally
            {
                objConnect.Cerrar();
            }
        }
        public bool agendarServicio(vehiculoServicio vhServicio)
        {
            try
            {
                objConnect.Abrir();
                SqlCommand sqlC = new SqlCommand(@"
                INSERT INTO Vehiculo_Servicio(placa, idServicio, fechaServicio)
                VALUES (@placa, @id, @fecha)", objConnect.conectar);
                sqlC.Parameters.AddWithValue("@placa", vhServicio.placa);
                sqlC.Parameters.AddWithValue("@id", vhServicio.idServicio);
                sqlC.Parameters.AddWithValue("@fecha", vhServicio.fechaServicio);
                int filaAgregada = sqlC.ExecuteNonQuery();
                return filaAgregada == 1;
            }catch(Exception ex)
            {
                throw new Exception("Error: ", ex);
            }
            finally
            {
                objConnect.Cerrar();
            }
        }

        public List<serviciosCliente> serviciosCliente(int id)
        {
            List<serviciosCliente> servicios = new List<serviciosCliente>();
            try
            {
                objConnect.Abrir();
                SqlCommand sqlC = new SqlCommand(@"
                SELECT vh.placa as Placa, sr.tipo as Servicio, sr.descripcion as Descripcion, sr.costoTotal as costoTotal, vs.fechaServicio as Fecha
                FROM Vehiculo vh inner join Vehiculo_Servicio vs on vh.placa = vs.placa
				                 inner join Servicio sr on vs.idServicio = sr.idServicio
                WHERE vh.idCliente = @id", objConnect.conectar);
                sqlC.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = sqlC.ExecuteReader();
                while (reader.Read())
                {
                    serviciosCliente servis = new serviciosCliente
                    {
                        placa = Convert.ToString(reader["Placa"]),
                        servicio = Convert.ToString(reader["Servicio"]),
                        descripcion = Convert.ToString(reader["Descripcion"]),
                        costoTotal = Convert.ToDecimal(reader["costoTotal"]),
                        fecha = Convert.ToDateTime(reader["Fecha"])
                    };
                    servicios.Add(servis);
                }
                reader.Close();
                return servicios;
            }catch(Exception ex)
            {
                throw new Exception("Error: ", ex);
            }
            finally
            {
                objConnect.Cerrar();
            }
        }
        public bool eliminarServicion(int idS)
        {
            try
            {
                objConnect.Abrir();
                SqlCommand sqlC = new SqlCommand(@"
                DELETE FROM Servicio WHERE idServicio = @id", objConnect.conectar);
                sqlC.Parameters.AddWithValue("@id", idS);
                int servicioEliminado = sqlC.ExecuteNonQuery();
                return servicioEliminado == 1;
            }catch(Exception ex)
            {
                throw new Exception("Error: ", ex);
            }
            finally
            {
                objConnect.Cerrar();
            }
        }
        public List<Servicio> filtrarServicios(string tipo, decimal dinero)
        {
            List<Servicio> filtro = new List<Servicio>();
            try
            {
                objConnect.Abrir();
                SqlCommand sqlC = new SqlCommand(@"
                SELECT *
                FROM Servicio
                WHERE tipo = @tipo AND costoTotal >= @dinero", objConnect.conectar);
                sqlC.Parameters.AddWithValue("@tipo", tipo);
                sqlC.Parameters.AddWithValue("@dinero", dinero);
                SqlDataReader reader = sqlC.ExecuteReader();
                while (reader.Read())
                {
                    Servicio servis = new Servicio
                    {
                        idServicio = Convert.ToInt32(reader["idServicio"]),
                        nombreServicio = Convert.ToString(reader["nombreServicio"]),
                        tipoServicio = Convert.ToString(reader["tipo"]),
                        descripcionServicio = Convert.ToString(reader["descripcion"]),
                        costoUnitarioServicio = Convert.ToDecimal(reader["costoUnitario"]),
                        ivaServicio = Convert.ToInt32(reader["iva"]),
                        costoTotalServicio = Convert.ToDecimal(reader["costoTotal"]),
                        garantiaServicio = Convert.ToInt32(reader["garantiaServicio"])
                    };
                    filtro.Add(servis);
                }
                reader.Close();
                return filtro;
            }catch(Exception ex)
            {
                throw new Exception("Error: ", ex);
            }
            finally
            {
                objConnect.Cerrar();
            }
        }
        public List<Servicio> listarServicios()
        {
            List<Servicio> listaS = new List<Servicio>();
            try
            {
                objConnect.Abrir();
                SqlCommand sqlC = new SqlCommand(@"
                SELECT * 
                FROM Servicio", objConnect.conectar);
                SqlDataReader reader = sqlC.ExecuteReader();
                while (reader.Read())
                {
                    Servicio servis = new Servicio
                    {
                        idServicio = Convert.ToInt32(reader["idServicio"]),
                        nombreServicio = Convert.ToString(reader["nombreServicio"]),
                        tipoServicio = Convert.ToString(reader["tipo"]),
                        descripcionServicio = Convert.ToString(reader["descripcion"]),
                        costoUnitarioServicio = Convert.ToDecimal(reader["costoUnitario"]),
                        ivaServicio = Convert.ToInt32(reader["iva"]),
                        costoTotalServicio = Convert.ToDecimal(reader["costoTotal"]),
                        garantiaServicio = Convert.ToInt32(reader["garantiaServicio"])
                    };
                    listaS.Add(servis);
                }
                reader.Close();
                return listaS;
            }catch(Exception ex)
            {
                throw new Exception("Error: ", ex);
            }
            finally
            {
                objConnect.Cerrar();
            }
        }
        public List<string> tipoServicios()
        {
            List<string> tipos = new List<string>();
            try
            {
                objConnect.Abrir();
                SqlCommand sqlC = new SqlCommand(@"
                SELECT DISTINCT tipo
                FROM Servicio", objConnect.conectar);
                SqlDataReader reader = sqlC.ExecuteReader();
                while (reader.Read())
                {
                    tipos.Add(Convert.ToString(reader["tipo"]));
                }
                reader.Close();
                return tipos;
            }catch(Exception ex)
            {
                throw new Exception("Error: ", ex);
            }
            finally
            {
                objConnect.Cerrar();
            }
        }

        public Servicio buscarServicio(int idSer)
        {
            try
            {
                objConnect.Abrir();
                SqlCommand sqlC = new SqlCommand(@"
                SELECT *
                FROM Servicio
                WHERE idServicio = @id", objConnect.conectar);
                sqlC.Parameters.AddWithValue("@id", idSer);
                SqlDataReader reader = sqlC.ExecuteReader();
                if (reader.Read())
                {
                    Servicio servicioEncontrado = new Servicio
                    {
                        idServicio = idSer,
                        nombreServicio = Convert.ToString(reader["nombreServicio"]),
                        tipoServicio = Convert.ToString(reader["tipo"]),
                        descripcionServicio = Convert.ToString(reader["descripcion"]),
                        costoUnitarioServicio = Convert.ToDecimal(reader["costoUnitario"]),
                        ivaServicio = Convert.ToInt32(reader["iva"]),
                        costoTotalServicio = Convert.ToDecimal(reader["costoTotal"]),
                        garantiaServicio = Convert.ToInt32(reader["garantiaServicio"])
                    };
                    reader.Close();
                    return servicioEncontrado;
                }
                return null;
            }catch(Exception ex)
            {
                throw new Exception("Error: ", ex);
            }
            finally
            {
                objConnect.Cerrar();
            }
        }
        public bool modificarServicio(Servicio servicio)
        {
            try
            {
                objConnect.Abrir();
                SqlCommand sqlC = new SqlCommand(@"
                UPDATE Servicio
                SET nombreServicio = @nombre, descripcion = @descripcion, costoUnitario = @costoU, iva = @iva, costoTotal = @costoT, garantiaServicio = @garantia
                WHERE idServicio = @id", objConnect.conectar);
                sqlC.Parameters.AddWithValue("@id", servicio.idServicio);
                sqlC.Parameters.AddWithValue("@nombre", servicio.nombreServicio);
                sqlC.Parameters.AddWithValue("@descripcion", servicio.descripcionServicio);
                sqlC.Parameters.AddWithValue("@costoU", servicio.costoUnitarioServicio);
                sqlC.Parameters.AddWithValue("@costoT", servicio.costoTotalServicio);
                sqlC.Parameters.AddWithValue("@garantia", servicio.garantiaServicio);
                sqlC.Parameters.AddWithValue("@iva", servicio.ivaServicio);
                int servicioModificado = sqlC.ExecuteNonQuery();
                return servicioModificado == 1;
            }
            catch(Exception ex)
            {
                throw new Exception("Error: ", ex);
            }
            finally
            {
                objConnect.Cerrar();
            }
        }
        public bool ingresarServicio(Servicio servicio)
        {
            try
            {
                objConnect.Abrir();
                SqlCommand sqlC = new SqlCommand(@"
                INSERT INTO Servicio (nombreServicio, tipo, descripcion, costoUnitario, iva, costoTotal, garantiaServicio)
                VALUES (@nombre, @tipo, @descripcion, @costoU, @iva, @costoT, @garantia)", objConnect.conectar);
                sqlC.Parameters.AddWithValue("@nombre", servicio.nombreServicio);
                sqlC.Parameters.AddWithValue("@tipo", servicio.tipoServicio);
                sqlC.Parameters.AddWithValue("@descripcion", servicio.descripcionServicio);
                sqlC.Parameters.AddWithValue("@costoU", servicio.costoUnitarioServicio);
                sqlC.Parameters.AddWithValue("@iva", servicio.ivaServicio);
                sqlC.Parameters.AddWithValue("@costoT", servicio.costoTotalServicio);
                sqlC.Parameters.AddWithValue("@garantia", servicio.garantiaServicio);
                int servicioAgregado = sqlC.ExecuteNonQuery();
                return servicioAgregado == 1;
            }catch(Exception ex)
            {
                throw new Exception("Error: ", ex);
            }
            finally
            {
                objConnect.Cerrar();
            }
        }


       
    }
}

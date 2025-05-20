using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // para conexion

namespace capaDato
{
    public class ClassConexion

    {

        // Jordan Alava:        DESKTOP-EO71RE8
        // Gonzalo Romero       MSI


        string nombreServidor = "DESKTOP-EO71RE8";
        // en Data Source poner el nombre del servidor de su maquina
        // en Initial Catalog poner el nombre del base de datos que crearon, aunque debe ser la misma BDTallerMecanico

        private string cadena;
        public SqlConnection conectar = new SqlConnection();
        public ClassConexion()
        {
            cadena = "Data Source = " + nombreServidor + "; Initial Catalog = BDTallerMecanico; Integrated Security = True";
            conectar.ConnectionString = cadena;
        }
        public void Abrir()
        {
            try
            {
                conectar.Open();
                Console.WriteLine("Conexión abierta");
            }catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public void Cerrar()
        {
            try
            {
                conectar.Close();
                Console.WriteLine("Conexión cerrada");
            }catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}

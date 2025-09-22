using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Conexion
{
    internal class ConexionDB
    {
        private static string servidor = "(localdb)\\MSSQLLocalDB";
        private static string basededatos = "Medicos";

        public static SqlConnection Conectar()
        {
            string cadena = $"Data source={servidor};Initial Catalog={basededatos};Integrated Security=true";
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            return conexion;
        }
    }
}

using Modelo.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Usuarios
    {
        private int idUsuarios;
        private int idRol;
        private string nombreUsuario;
        private string clave;
        private string email;

        public int IdUsuarios { get => idUsuarios; set => idUsuarios = value; }
        public int IdRol { get => idRol; set => idRol = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Clave { get => clave; set => clave = value; }
        public string Email { get => email; set => email = value; }

        public static DataTable cargarUsuarios() {

            SqlConnection conexion = ConexionDB.Conectar();
            string consultaQuery = "select idUsuario, idRol, nombreUsuario, clave, email FROM Usuarios";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;
        }
    }
}

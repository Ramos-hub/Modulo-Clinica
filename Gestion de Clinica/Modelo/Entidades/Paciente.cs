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
    public class Paciente
    {
        private int idPaciente;
        private string nombrePaciente;
        private string email;
        private string telefono;

        public int IdPaciente { get => idPaciente; set => idPaciente = value; }
        public string NombrePaciente { get => nombrePaciente; set => nombrePaciente = value; }
        public string Email { get => email; set => email = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        public static DataTable cargarPaciente() {

            SqlConnection conexion = ConexionDB.Conectar();
            string consultaQuery = "select idPaciente, nombrePaciente, email, telefono FROM Paciente";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;
        }
    }
}

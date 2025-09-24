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
    public class Citas
    {
        private int idCitas;
        private int idDiagnostico;
        private int idPaciente;
        private DateTime fechaCita;

        public int IdCitas { get => idCitas; set => idCitas = value; }
        public int IdDiagnostico { get => idDiagnostico; set => idDiagnostico = value; }
        public int IdPaciente { get => idPaciente; set => idPaciente = value; }
        public DateTime FechaCita { get => fechaCita; set => fechaCita = value; }

        public static DataTable cargarCitas() {

            SqlConnection conexion = ConexionDB.Conectar();
            string consultaQuery = "select idCita, idDiagnostico, idPaciente, fechaCita FROM Citas";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;
        }
    }
}

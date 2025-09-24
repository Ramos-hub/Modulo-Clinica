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
    internal class Diagnostico
    {
        private int idDiagnostico;
        private int idMedico;
        private string descripcion;
        private string medicamentos;
        public int IdDiagnostico { get => idDiagnostico; set => idDiagnostico = value; }
        public int IdMedico { get => idMedico; set => idMedico = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Medicamentos { get => medicamentos; set => medicamentos = value; }

        public static DataTable cargarDiagnostico() {

            SqlConnection conexion = ConexionDB.Conectar();
            string consultaQuery = "select idDiagnostico, idMedico, descripcion, medicamentos FROM Diagnostico";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;
        }
    }
}

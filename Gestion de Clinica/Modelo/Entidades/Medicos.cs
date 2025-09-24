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
    public class Medicos
    {
        private int idMedico;
        private int idEspecialidad;
        private string nombreMedico;
        private int dui;
        private string telefono;

        public int IdMedico { get => idMedico; set => idMedico = value; }
        public int IdEspecialidad { get => idEspecialidad; set => idEspecialidad = value; }
        public string NombreMedico { get => nombreMedico; set => nombreMedico = value; }
        public int Dui { get => dui; set => dui = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        public static DataTable cargarMedicos() {

            SqlConnection conexion = ConexionDB.Conectar();
            string consultaQuery = "select idMedico, idEspecialidad, nombreMedico, dui, telefono FROM Medicos";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;
        }
    }
}

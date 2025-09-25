using Modelo.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Vista.Formularios
{
    public partial class frmInicio : Form
    {
        SqlConnection conexion = ConexionDB.Conectar();
        SqlCommand cmd;
        SqlDataAdapter dr;
        public frmInicio()
        {
            InitializeComponent();
        }

        ArrayList Especialidades new ArrayList();
        ArrayList CantMedicos new ArrayList();
        private void grafEspecialidades() {
            cmd = new SqlCommand("MedicosPorEspecialidad", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
            
            }
        }

        private void chartEspecialidades_Click(object sender, EventArgs e)
        {
            
        }
    }
}

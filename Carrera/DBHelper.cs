using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ABMCarrera
{
    public class DBHelper
    {
        private SqlConnection conexion;
        private string cadenaConexion = @"Data Source=DESKTOP-3PA9VUQ\SQLEXPRESS;Initial Catalog=Carrera;Integrated Security=True";
        public DBHelper()
        {
            conexion = new SqlConnection(cadenaConexion);
        }
        public int ProximaCarrera()
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "Sp_ProximaCarrera";
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@next";
            parametro.SqlDbType = SqlDbType.Int;
            parametro.Direction = ParameterDirection.Output;
            comando.Parameters.Add(parametro);
            comando.ExecuteNonQuery();
            conexion.Close();
            return (int)parametro.Value;

        }
        //public DataTable Consultar(string nombreSP)
        //{
            
        //}
        //public bool ConfirmarCarrera(Carrera carrera)
        //{

        //}
    }
}


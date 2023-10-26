using ABMCarrera2.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMCarrera2.Datos
{
    public class DBHelper
    {
        private static DBHelper instancia;
        private SqlConnection conexion;
        private string cadenaConexion = @"Data Source=DESKTOP-3PA9VUQ\SQLEXPRESS;Initial Catalog=Carrera1;Integrated Security=True";

        public DBHelper()
        {
            conexion = new SqlConnection(cadenaConexion);
        }
        public static DBHelper ObtenerInstancia()
        {
            if(instancia  == null)
            {
                instancia = new DBHelper();
            }
            return instancia;
        }
        public DataTable ConsultaSQL(string spNombre,List<Parametro> valor)
        {
            DataTable tabla = new DataTable();
            conexion.Open();
            SqlCommand cmd = new SqlCommand(spNombre, conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            if(valor != null)
            {
                foreach(Parametro oParametro in valor)
                {
                    cmd.Parameters.AddWithValue(oParametro.Nombre, oParametro.Valor);
                }
            }
            tabla.Load(cmd.ExecuteReader());
            conexion.Close();
            return tabla;
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
        public bool ConfirmarCarrera(Carrera carrera)
        {
            bool resultado = true;
            SqlTransaction t = null;
            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.Transaction = t;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_INSERTAR_MAESTRO";
                comando.Parameters.AddWithValue("@nom_carrera", carrera.NombreCarrera);
                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@id_Carrera";
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parametro);
                comando.ExecuteNonQuery();

                int idCarrera = (int)parametro.Value;

                SqlCommand cmdDetalle;
                foreach(DetalleCarrera dc in carrera.lDetalle)
                {
                    cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLE",conexion,t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@id_Carrera", idCarrera);
                    cmdDetalle.Parameters.AddWithValue("@anioCursado", dc.AñoCursado);
                    cmdDetalle.Parameters.AddWithValue("@Cuatrimestre", dc.Cuatrimestre);
                    cmdDetalle.Parameters.AddWithValue("@id_Asignatura", dc.Asignatura);
                    cmdDetalle.ExecuteNonQuery();
                }
                t.Commit();
            }
            catch
            {
                t.Rollback();
                resultado = false;
            }
            finally
            {
                if(conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return resultado;
        }
        public DataTable Consultar(string nombreSp)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSp;
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return tabla;
        }
        public int EjecutarSQL(string sql,List<Parametro> valor)
        {
            int afectadas = 0;
            SqlTransaction t = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                conexion.Open();
                t = conexion.BeginTransaction();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sql;
                cmd.Transaction = t;

                if(valor != null)
                {
                    foreach(Parametro parametro in valor)
                    {
                        cmd.Parameters.AddWithValue(parametro.Nombre, parametro.Valor);

                    }
                }
                afectadas = cmd.ExecuteNonQuery();
                t.Commit();

            }
            catch(SqlException)
            {
                if(t != null) t.Rollback();
            }
            finally
            {
                if(conexion != null && conexion.State == ConnectionState.Open) 
                    conexion.Close();
            }
            return afectadas;
        }
       public bool ModificarCarrera(Carrera oCarrera)
        {
            bool resultado = true;
            SqlTransaction t = null;

            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.Transaction = t;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_MODIFICAR_MAESTRO";
                comando.Parameters.AddWithValue("@Titulo", oCarrera.NombreCarrera);
                comando.Parameters.AddWithValue("@id_Carrera", oCarrera.IdCarrera);
                comando.ExecuteNonQuery();

                SqlCommand cmdDetalle;
                foreach (DetalleCarrera dc in oCarrera.lDetalle)
                {
                    cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLE", conexion, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@id_Carrera", oCarrera.IdCarrera);
                    cmdDetalle.Parameters.AddWithValue("@anioCursado", dc.AñoCursado);
                    cmdDetalle.Parameters.AddWithValue("@Cuatrimestre", dc.Cuatrimestre);
                    cmdDetalle.Parameters.AddWithValue("@id_asignatura", dc.Asignatura.IdAsignatura);
                    cmdDetalle.ExecuteNonQuery();
                }
                t.Commit();
            }
            catch (Exception)
            {
                if (t != null)
                    t.Rollback();
                resultado = false;
            }

            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            return resultado;
        }
    
    }
}

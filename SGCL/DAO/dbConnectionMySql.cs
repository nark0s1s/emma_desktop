using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace SGCL.DAO
{
    class dbConnectionMySql
    {

        string myConnectionString;
        private MySqlConnection conn;
        
        
        public dbConnectionMySql()
        {            
                                    
            myConnectionString = "server=localhost;uid=emma;pwd=Andrea15072003$;database=emma;";
            conn = new MySqlConnection(myConnectionString);

        }
        
        // Open Database Connection if Closed or Broken
        private MySqlConnection abrirConexion()
        {
            if (conn.State == ConnectionState.Closed || conn.State == 
						ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }

        public void EjecutarDML_SP(String p_nombre_sp, MySqlParameter[] sqlParameter)
        {

            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = abrirConexion();
            cmd.CommandText = p_nombre_sp;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(sqlParameter);            
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        public DataTable CargarDataTable_SP(String p_nombre_sp)
        {

            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = abrirConexion();
            cmd.CommandText = p_nombre_sp;
            cmd.CommandType = CommandType.StoredProcedure;        

            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            da.Fill(dt);

            return dt;

        }

        public DataTable CargarDataTable_SP(String p_nombre_sp, MySqlParameter[] sqlParameter)
        {

            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = abrirConexion();
            cmd.CommandText = p_nombre_sp;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(sqlParameter);            
                                                 
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            cmd.CommandTimeout = 240;
                       
            da.Fill(dt);                        
            
            return dt;

        }

        public string Output_String_SP(String p_nombre_sp, MySqlParameter[] sqlParameter)
        {

            string result;
            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = abrirConexion();
            cmd.CommandText = p_nombre_sp;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(sqlParameter);            

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            result = cmd.Parameters["?p_val_resu"].Value.ToString();

            return result;

        }

        public int Output_Int_SP(String p_nombre_sp, MySqlParameter[] sqlParameter)
        {

            int result;
            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = abrirConexion();
            cmd.CommandText = p_nombre_sp;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddRange(sqlParameter);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            
            result = Int32.Parse(cmd.Parameters["?p_val_resu"].Value.ToString());

            return result;

        }

    }
}

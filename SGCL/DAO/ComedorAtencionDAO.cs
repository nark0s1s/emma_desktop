using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SGCL.BE;
using System.Data;


namespace SGCL.DAO
{
    class ComedorAtencionDAO
    {

        MySqlCommand cmd = new MySqlCommand();

        public DataTable obtenerComedorByOid(int oid)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();
            MySqlParameter[] sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("?p_oid", oid);
            DataTable dt = new DataTable();

            dt = oDB.CargarDataTable_SP("sp_ComedorAtencion_SelByOid", sqlParameters);

            return dt;

        }

        public DataTable ObtenerListado() {

            dbConnectionMySql oDB = new dbConnectionMySql();            
            DataTable  dt = new DataTable ();

            dt = oDB.CargarDataTable_SP("sp_ComedorAtencion_Sel");

            return dt;

        }

        public DataTable ObtenerListadoPorProyecto(int oid)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();
            MySqlParameter[] sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("?p_oid", oid);
            DataTable dt = new DataTable();

            dt = oDB.CargarDataTable_SP("sp_ComedorAtencion_SelByProyecto", sqlParameters);

            return dt;

        }

        public void Insertar(ComedorAtencionBE oComedorAtencionBE)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();

            MySqlParameter[] sqlParameters = new MySqlParameter[3];
            sqlParameters[0] = new MySqlParameter("?p_val_desc", oComedorAtencionBE.val_desc);
            sqlParameters[1] = new MySqlParameter("?p_proy_oid_proy", oComedorAtencionBE.proy_oid_proy);            
            sqlParameters[2] = new MySqlParameter("?p_ind_acti", oComedorAtencionBE.ind_acti);                        
            
            oDB.EjecutarDML_SP("sp_ComedorAtencion_Ins", sqlParameters);

        }

        public void Actualizar(ComedorAtencionBE oComedorAtencionBE)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();

            MySqlParameter[] sqlParameters = new MySqlParameter[3];
            sqlParameters[0] = new MySqlParameter("?p_val_desc", oComedorAtencionBE.val_desc);
            sqlParameters[1] = new MySqlParameter("?p_proy_oid_proy", oComedorAtencionBE.proy_oid_proy);            
            sqlParameters[2] = new MySqlParameter("?p_ind_acti", oComedorAtencionBE.ind_acti);            
                                    
            oDB.EjecutarDML_SP("sp_ComedorAtencion_Upd", sqlParameters);

        }

        public void Eliminar(int oid)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();

            MySqlParameter[] sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("?p_oid", oid);

            oDB.EjecutarDML_SP("sp_ComedorAtencion_Del", sqlParameters);

        }


    }
}

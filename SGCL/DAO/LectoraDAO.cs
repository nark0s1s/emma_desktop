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
    class LectoraDAO
    {

        MySqlCommand cmd = new MySqlCommand();

        public DataTable obtenerLectoraByOid(int oid)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();
            MySqlParameter[] sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("?p_oid", oid);
            DataTable dt = new DataTable();

            dt = oDB.CargarDataTable_SP("sp_Lectora_SelByOid", sqlParameters);

            return dt;

        }

        public DataTable ObtenerListado() {

            dbConnectionMySql oDB = new dbConnectionMySql();            
            DataTable  dt = new DataTable ();

            dt = oDB.CargarDataTable_SP("sp_Lectora_Sel");

            return dt;

        }

        public DataTable ObtenerListadoPorComedor(int oid)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();
            MySqlParameter[] sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("?p_oid", oid);
            DataTable dt = new DataTable();

            dt = oDB.CargarDataTable_SP("sp_Lectora_SelByComedor", sqlParameters);

            return dt;

        }

        public void Insertar(LectoraBE oLectoraBE)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();

            MySqlParameter[] sqlParameters = new MySqlParameter[5];
            sqlParameters[0] = new MySqlParameter("?p_val_desc", oLectoraBE.val_desc);
            sqlParameters[1] = new MySqlParameter("?p_clie_oid_clie", oLectoraBE.clie_oid_clie);
            sqlParameters[2] = new MySqlParameter("?p_proy_oid_proy", oLectoraBE.proy_oid_proy);
            sqlParameters[3] = new MySqlParameter("?p_come_oid_come", oLectoraBE.come_oid_come_aten);
            sqlParameters[4] = new MySqlParameter("?p_ind_acti", oLectoraBE.ind_acti);                        
            
            oDB.EjecutarDML_SP("sp_Lectora_Ins", sqlParameters);

        }

        public void Actualizar(LectoraBE oLectoraBE)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();

            MySqlParameter[] sqlParameters = new MySqlParameter[4];
            sqlParameters[0] = new MySqlParameter("?p_val_desc", oLectoraBE.val_desc);
            sqlParameters[1] = new MySqlParameter("?p_proy_oid_proy", oLectoraBE.proy_oid_proy);
            sqlParameters[2] = new MySqlParameter("?p_clie_oid_clie", oLectoraBE.clie_oid_clie);
            sqlParameters[3] = new MySqlParameter("?p_come_oid_come", oLectoraBE.come_oid_come_aten);
            sqlParameters[4] = new MySqlParameter("?p_ind_acti", oLectoraBE.ind_acti);            
                                    
            oDB.EjecutarDML_SP("sp_Lectora_Upd", sqlParameters);

        }

        public void Eliminar(int oid)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();

            MySqlParameter[] sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("?p_oid", oid);

            oDB.EjecutarDML_SP("sp_Lectora_Del", sqlParameters);

        }


    }
}

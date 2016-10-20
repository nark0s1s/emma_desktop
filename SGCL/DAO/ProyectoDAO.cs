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
    class ProyectoDAO
    {

        MySqlCommand cmd = new MySqlCommand();

        public DataTable obtenerProyectoByOid(int oid)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();
            MySqlParameter[] sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("?p_oid", oid);
            DataTable dt = new DataTable();

            dt = oDB.CargarDataTable_SP("sp_Proyecto_SelByOid", sqlParameters);

            return dt;

        }

        public DataTable ObtenerListadoPorCliente(int oid)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();
            MySqlParameter[] sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("?p_oid", oid);
            DataTable dt = new DataTable();

            dt = oDB.CargarDataTable_SP("sp_Proyecto_SelByCliente", sqlParameters);

            return dt;

        }

        public DataTable ObtenerListado() {

            dbConnectionMySql oDB = new dbConnectionMySql();            
            DataTable  dt = new DataTable ();

            dt = oDB.CargarDataTable_SP("sp_Proyecto_Sel");

            return dt;

        }

        public void Insertar(ProyectoBE oProyectoBE)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();

            MySqlParameter[] sqlParameters = new MySqlParameter[5];
            sqlParameters[0] = new MySqlParameter("?p_val_desc", oProyectoBE.val_desc);
            sqlParameters[1] = new MySqlParameter("?p_val_dept", oProyectoBE.val_dept);
            sqlParameters[2] = new MySqlParameter("?p_val_prov", oProyectoBE.val_prov);
            sqlParameters[3] = new MySqlParameter("?p_val_dist", oProyectoBE.val_dist);            
            sqlParameters[4] = new MySqlParameter("?p_clie_oid_clie", oProyectoBE.clie_oid_clie);
            
            oDB.EjecutarDML_SP("sp_Proyecto_Ins", sqlParameters);

        }

        public void Actualizar(ProyectoBE oProyectoBE)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();

            MySqlParameter[] sqlParameters = new MySqlParameter[5];
            sqlParameters[0] = new MySqlParameter("?p_val_desc", oProyectoBE.val_desc);
            sqlParameters[1] = new MySqlParameter("?p_val_dept", oProyectoBE.val_dept);
            sqlParameters[2] = new MySqlParameter("?p_val_prov", oProyectoBE.val_prov);
            sqlParameters[3] = new MySqlParameter("?p_val_dist", oProyectoBE.val_dist);            
            sqlParameters[4] = new MySqlParameter("?p_clie_oid_clie", oProyectoBE.clie_oid_clie);
            
            
            oDB.EjecutarDML_SP("sp_Proyecto_Upd", sqlParameters);

        }

        public void Eliminar(int oid)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();

            MySqlParameter[] sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("?p_oid", oid);

            oDB.EjecutarDML_SP("sp_Proyecto_Del", sqlParameters);

        }

        public DataTable ObtenerListadoPorUsuario(string cod_usua, out string des_usua)
        {
            DataTable dt = new DataTable();
            dbConnectionMySql oDB = new dbConnectionMySql();
            MySqlParameter[] sqlParameters = new MySqlParameter[2];
            sqlParameters[0] = new MySqlParameter("?p_cod_usua", cod_usua);            
            sqlParameters[1] = new MySqlParameter("?p_des_usua", MySqlDbType.String, 150, ParameterDirection.Output, true, 0, 0, null, DataRowVersion.Current, null);

            dt = oDB.CargarDataTable_SP("sp_Proyecto_SelByUsuario", sqlParameters);          
            des_usua = (string)sqlParameters[1].Value;

            return dt;

        }


    }
}

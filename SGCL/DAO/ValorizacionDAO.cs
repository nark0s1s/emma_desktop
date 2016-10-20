using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace SGCL.DAO
{
    class ValorizacionDAO
    {

        public DataTable ObtenerListadoFechas(string val_fech_desd, string val_fech_hast)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();
            MySqlParameter[] sqlParameters = new MySqlParameter[2];
            sqlParameters[0] = new MySqlParameter("?p_val_fech_desd", val_fech_desd);
            sqlParameters[1] = new MySqlParameter("?p_val_fech_hast", val_fech_hast);
            DataTable dt = new DataTable();

            dt = oDB.CargarDataTable_SP("sp_Valorizacion_SelFechas",sqlParameters);

            return dt;
        }

        public DataTable ObtenerListadoComedorPorProyecto(int oid_proy)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();
            MySqlParameter[] sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("?p_oid_proy", oid_proy);
            DataTable dt = new DataTable();

            dt = oDB.CargarDataTable_SP("sp_Valorizacion_SelComedorByProyecto", sqlParameters);

            return dt;
        }

        public DataTable ObtenerListadoTipoServicioPorProyecto(int oid_proy)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();
            MySqlParameter[] sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("?p_oid_proy", oid_proy);            
            DataTable dt = new DataTable();

            dt = oDB.CargarDataTable_SP("sp_Valorizacion_SelTipoServicioByProyecto", sqlParameters);

            return dt;
        }

        public DataTable ObtenerListadoTipoServicioPorComedor(int oid_come)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();
            MySqlParameter[] sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("?p_oid_come", oid_come);
            DataTable dt = new DataTable();

            dt = oDB.CargarDataTable_SP("sp_Valorizacion_SelTipoServicioByComedor", sqlParameters);

            return dt;
        }

        public int ValidarAtecionByFechaTipoServicio(int oid_proy, string cod_tipo_serv, string val_fech_aten,int oid_come)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();
            MySqlParameter[] sqlParameters = new MySqlParameter[5];
            sqlParameters[0] = new MySqlParameter("?p_oid_proy", oid_proy);
            sqlParameters[1] = new MySqlParameter("?p_cod_tipo_Serv", cod_tipo_serv);
            sqlParameters[2] = new MySqlParameter("?p_val_fech_aten", val_fech_aten);
            sqlParameters[3] = new MySqlParameter("?p_oid_come", oid_come);
            sqlParameters[4] = new MySqlParameter("?p_val_resu", MySqlDbType.Int32, 11, ParameterDirection.Output, true, 0, 0, null, DataRowVersion.Current, null);

            int result;
            result = oDB.Output_Int_SP("sp_Valorizacion_ValidarAtencionByFechaTipoServicio", sqlParameters);

            return result;

        }

        public DataTable ObtenerListadoAtencionesPorComensal(int oid_proy,string val_fech_desd, string val_fech_hast, int oid_come)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();
            MySqlParameter[] sqlParameters = new MySqlParameter[4];
            sqlParameters[0] = new MySqlParameter("?p_oid_proy", oid_proy);
            sqlParameters[1] = new MySqlParameter("?p_val_fech_desd", val_fech_desd);
            sqlParameters[2] = new MySqlParameter("?p_val_fech_hast", val_fech_hast);
            sqlParameters[3] = new MySqlParameter("?p_oid_come_aten", oid_come);
            DataTable dt = new DataTable();

            dt = oDB.CargarDataTable_SP("sp_Valorizacion_SelAtencionesByComensal", sqlParameters);

            return dt;
        }
        

        public DataTable ObtenerListadoComensalesPorProyecto(int oid_proy)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();
            MySqlParameter[] sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("?p_oid_proy", oid_proy);
            DataTable dt = new DataTable();

            dt = oDB.CargarDataTable_SP("sp_Valorizacion_SelComemsalByProyecto", sqlParameters);

            return dt;
        }

        public DataTable ObtenerListadoComensalesPorComedor(int oid_come)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();
            MySqlParameter[] sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("?p_oid_come", oid_come);
            DataTable dt = new DataTable();

            dt = oDB.CargarDataTable_SP("sp_Valorizacion_SelComemsalByComedor", sqlParameters);

            return dt;
        }
    }
}

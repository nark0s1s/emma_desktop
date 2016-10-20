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
    class ComedorTipoServicioDAO
    {

        MySqlCommand cmd = new MySqlCommand();

        public DataTable obtenerComedorTipoServicioByOid(int oid)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();
            MySqlParameter[] sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("?p_oid", oid);
            DataTable dt = new DataTable();

            dt = oDB.CargarDataTable_SP("sp_ComedorTipoServicio_SelByOid", sqlParameters);

            return dt;

        }

        public DataTable ObtenerListado() {

            dbConnectionMySql oDB = new dbConnectionMySql();            
            DataTable  dt = new DataTable ();

            dt = oDB.CargarDataTable_SP("sp_ComedorTipoServicio_Sel");

            return dt;

        }

        public void Insertar(ComedorTipoServicioBE oComedorTipoServicioBE)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();

            MySqlParameter[] sqlParameters = new MySqlParameter[6];            
            sqlParameters[0] = new MySqlParameter("?p_clie_oid_clie", oComedorTipoServicioBE.clie_oid_clie);
            sqlParameters[1] = new MySqlParameter("?p_proy_oid_proy", oComedorTipoServicioBE.proy_oid_proy);            
            sqlParameters[2] = new MySqlParameter("?p_come_oid_come_aten", oComedorTipoServicioBE.come_oid_come_aten);
            sqlParameters[3] = new MySqlParameter("?p_tipo_cod_tipo_serv_come", oComedorTipoServicioBE.tipo_cod_tipo_serv_come);
            sqlParameters[4] = new MySqlParameter("?p_imp_prec_fact", oComedorTipoServicioBE.imp_prec_fact);
            sqlParameters[5] = new MySqlParameter("?p_ind_acti", oComedorTipoServicioBE.ind_acti);                        
            
            oDB.EjecutarDML_SP("sp_ComedorTipoServicio_Ins", sqlParameters);

        }

        public void Actualizar(ComedorTipoServicioBE oComedorTipoServicioBE)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();

            MySqlParameter[] sqlParameters = new MySqlParameter[5];
            sqlParameters[0] = new MySqlParameter("?p_clie_oid_clie", oComedorTipoServicioBE.clie_oid_clie);
            sqlParameters[1] = new MySqlParameter("?p_proy_oid_proy", oComedorTipoServicioBE.proy_oid_proy);
            sqlParameters[2] = new MySqlParameter("?p_come_oid_come_aten", oComedorTipoServicioBE.come_oid_come_aten);
            sqlParameters[3] = new MySqlParameter("?p_tipo_cod_tipo_serv_come", oComedorTipoServicioBE.tipo_cod_tipo_serv_come);
            sqlParameters[4] = new MySqlParameter("?p_ind_acti", oComedorTipoServicioBE.ind_acti);                        
                                                            
            oDB.EjecutarDML_SP("sp_ComedorTipoServicio_Upd", sqlParameters);

        }

        public void Eliminar(int oid)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();

            MySqlParameter[] sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("?p_oid", oid);

            oDB.EjecutarDML_SP("sp_ComedorTipoServicio_Del", sqlParameters);

        }


    }
}

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
    class TipoServicioComedorDAO
    {

        MySqlCommand cmd = new MySqlCommand();

        public DataTable obtenerTipoServicioComedorByCod(string cod)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();
            MySqlParameter[] sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("?p_cod", cod);
            DataTable dt = new DataTable();

            dt = oDB.CargarDataTable_SP("sp_TipoServicioComedor_SelByCod", sqlParameters);

            return dt;

        }

        public DataTable ObtenerListado() {

            dbConnectionMySql oDB = new dbConnectionMySql();            
            DataTable  dt = new DataTable ();

            dt = oDB.CargarDataTable_SP("sp_TipoServicioComedor_Sel");

            return dt;

        }

        public DataTable ObtenerListadoCombo()
        {

            dbConnectionMySql oDB = new dbConnectionMySql();
            DataTable dt = new DataTable();
            
            dt = oDB.CargarDataTable_SP("sp_TipoServicioComedor_Combo");

            return dt;

        }

        public DataTable ObtenerListadoPorComedor(int oid)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();
            MySqlParameter[] sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("?p_oid", oid);
            DataTable dt = new DataTable();

            dt = oDB.CargarDataTable_SP("sp_TipoServicioComedor_SelByComedor", sqlParameters);

            return dt;

        }

        public void Insertar(TipoServicioComedorBE oTipoServicioComedorBE)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();

            MySqlParameter[] sqlParameters = new MySqlParameter[4];
            sqlParameters[0] = new MySqlParameter("?p_cod", oTipoServicioComedorBE.cod_tipo_docu_iden);
            sqlParameters[1] = new MySqlParameter("?p_val_desc", oTipoServicioComedorBE.val_desc);
            sqlParameters[2] = new MySqlParameter("?p_num_orde_repo", oTipoServicioComedorBE.num_orde_repo);
            sqlParameters[3] = new MySqlParameter("?p_ind_acti", oTipoServicioComedorBE.ind_acti);

            oDB.EjecutarDML_SP("sp_TipoServicioComedor_Ins", sqlParameters);

        }

        public void Actualizar(TipoServicioComedorBE oTipoServicioComedorBE)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();

            MySqlParameter[] sqlParameters = new MySqlParameter[4];
            sqlParameters[0] = new MySqlParameter("?p_cod", oTipoServicioComedorBE.cod_tipo_docu_iden);            
            sqlParameters[1] = new MySqlParameter("?p_val_desc", oTipoServicioComedorBE.val_desc);
            sqlParameters[2] = new MySqlParameter("?p_num_orde_repo", oTipoServicioComedorBE.num_orde_repo);
            sqlParameters[3] = new MySqlParameter("?p_ind_acti", oTipoServicioComedorBE.ind_acti);
            
            oDB.EjecutarDML_SP("sp_TipoServicioComedor_Upd", sqlParameters);

        }

        public void Eliminar(string cod)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();

            MySqlParameter[] sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("?p_cod", cod);

            oDB.EjecutarDML_SP("sp_TipoServicioComedor_Del", sqlParameters);

        }


    }
}

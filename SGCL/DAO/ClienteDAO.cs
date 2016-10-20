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
    class ClienteDAO
    {

        MySqlCommand cmd = new MySqlCommand();

        public DataTable obtenerClienteByOid(int oid)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();
            MySqlParameter[] sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("?p_oid", oid);
            DataTable dt = new DataTable();
            
            dt = oDB.CargarDataTable_SP("sp_Cliente_SelByOid", sqlParameters);

            return dt;

        }

        public DataTable ObtenerListado() {

            dbConnectionMySql oDB = new dbConnectionMySql();            
            DataTable  dt = new DataTable ();

            dt = oDB.CargarDataTable_SP("sp_Cliente_Sel");

            return dt;

        }

        public DataTable ObtenerListadoCombo()
        {

            dbConnectionMySql oDB = new dbConnectionMySql();
            DataTable dt = new DataTable();

            dt = oDB.CargarDataTable_SP("sp_Cliente_Combo");

            return dt;

        }

        public DataTable ObtenerListadoPorProyecto(int oid)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();
            MySqlParameter[] sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("?p_oid", oid);
            DataTable dt = new DataTable();

            dt = oDB.CargarDataTable_SP("sp_Cliente_SelByProyecto", sqlParameters);

            return dt;

        }

        public void Insertar(ClienteBE oClienteBE)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();

            MySqlParameter[] sqlParameters = new MySqlParameter[7];
            sqlParameters[0] = new MySqlParameter("?p_val_deno_soci", oClienteBE.val_deno_soci);
            sqlParameters[1] = new MySqlParameter("?p_val_nom1", oClienteBE.val_nom1);
            sqlParameters[2] = new MySqlParameter("?p_val_nom2", oClienteBE.val_nom2);
            sqlParameters[3] = new MySqlParameter("?p_val_ape1", oClienteBE.val_ape1);
            sqlParameters[4] = new MySqlParameter("?p_val_ape2", oClienteBE.val_ape2);
            sqlParameters[5] = new MySqlParameter("?p_tipo_cod_tipo_docu_iden", oClienteBE.tipo_cod_tipo_docu_iden);
            sqlParameters[6] = new MySqlParameter("?p_val_nume_docu_iden", oClienteBE.val_nume_docu_iden);

            oDB.EjecutarDML_SP("sp_Cliente_Ins", sqlParameters);

        }

        public void Actualizar(ClienteBE oClienteBE)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();

            MySqlParameter[] sqlParameters = new MySqlParameter[8];
            sqlParameters[0] = new MySqlParameter("?p_oid_clie", oClienteBE.oid_clie);
            sqlParameters[1] = new MySqlParameter("?p_val_deno_soci", oClienteBE.val_deno_soci);
            sqlParameters[2] = new MySqlParameter("?p_val_nom1", oClienteBE.val_nom1);
            sqlParameters[3] = new MySqlParameter("?p_val_nom2", oClienteBE.val_nom2);
            sqlParameters[4] = new MySqlParameter("?p_val_ape1", oClienteBE.val_ape1);
            sqlParameters[5] = new MySqlParameter("?p_val_ape2", oClienteBE.val_ape2);
            sqlParameters[6] = new MySqlParameter("?p_tipo_cod_tipo_docu_iden", oClienteBE.tipo_cod_tipo_docu_iden);
            sqlParameters[7] = new MySqlParameter("?p_val_nume_docu_iden", oClienteBE.val_nume_docu_iden);
            
            oDB.EjecutarDML_SP("sp_Cliente_Upd", sqlParameters);

        }

        public void Eliminar(int oid)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();

            MySqlParameter[] sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("?p_oid", oid);

            oDB.EjecutarDML_SP("sp_Cliente_Del", sqlParameters);

        }


    }
}

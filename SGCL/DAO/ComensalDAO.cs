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
    class ComensalDAO
    {

        MySqlCommand cmd = new MySqlCommand();

        public DataTable obtenerComensalByOid(int oid)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();
            MySqlParameter[] sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("?p_oid", oid);
            DataTable dt = new DataTable();

            dt = oDB.CargarDataTable_SP("sp_Comensal_SelByOid", sqlParameters);

            return dt;

        }

        public string ObtenerNombreByIdentificador(string num_iden_come, int come_oid_come_aten)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();
            MySqlParameter[] sqlParameters = new MySqlParameter[3];
            sqlParameters[0] = new MySqlParameter("?p_num_iden_come", num_iden_come);
            sqlParameters[1] = new MySqlParameter("?p_come_oid_come_aten", come_oid_come_aten);
            sqlParameters[2] = new MySqlParameter("?p_val_resu", MySqlDbType.VarChar, 500, ParameterDirection.Output, true, 0, 0, null, DataRowVersion.Current, null);

            string result;
            result = oDB.Output_String_SP("sp_Comensal_NombreByIdentificador", sqlParameters);

            return result;

        }

        public int ValidarDocumentoIdentidad(string num_docu_iden)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();
            MySqlParameter[] sqlParameters = new MySqlParameter[2];
            sqlParameters[0] = new MySqlParameter("?p_num_docu_iden", num_docu_iden);
            sqlParameters[1] = new MySqlParameter("?p_val_resu", MySqlDbType.Int32, 11, ParameterDirection.Output, true, 0, 0, null, DataRowVersion.Current, null);

            int result;
            result = oDB.Output_Int_SP("sp_Comensal_ValidarDocumentoIdentidad", sqlParameters);

            return result;

        }

        public int ValidarIdentificacionComedor(string num_iden_come)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();
            MySqlParameter[] sqlParameters = new MySqlParameter[2];
            sqlParameters[0] = new MySqlParameter("?p_num_iden_come", num_iden_come);
            sqlParameters[1] = new MySqlParameter("?p_val_resu", MySqlDbType.Int32, 11, ParameterDirection.Output, true, 0, 0, null, DataRowVersion.Current, null);

            int result;
            result = oDB.Output_Int_SP("sp_Comensal_ValidarIdentificacionComedor", sqlParameters);

            return result;

        }
        
        public int ObtenerOidByDocumentoIdentidad(string num_docu_iden)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();
            MySqlParameter[] sqlParameters = new MySqlParameter[2];
            sqlParameters[0] = new MySqlParameter("?p_num_docu_iden", num_docu_iden);            
            sqlParameters[1] = new MySqlParameter("?p_val_resu", MySqlDbType.Int32, 11, ParameterDirection.Output, true, 0, 0, null, DataRowVersion.Current, null);

            int result;
            result = oDB.Output_Int_SP("sp_Comensal_OidByDocumentoIdentidad", sqlParameters);

            return result;

        }

        public int ObtenerOidByIdentificador(string num_iden_come, int come_oid_come_aten)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();
            MySqlParameter[] sqlParameters = new MySqlParameter[3];
            sqlParameters[0] = new MySqlParameter("?p_num_iden_come", num_iden_come);
            sqlParameters[1] = new MySqlParameter("?p_come_oid_come_aten", come_oid_come_aten);
            sqlParameters[2] = new MySqlParameter("?p_val_resu", MySqlDbType.Int32, 11, ParameterDirection.Output, true, 0, 0, null, DataRowVersion.Current, null);

            int result;
            result = oDB.Output_Int_SP("sp_Comensal_OidByIdentificador", sqlParameters);

            return result;

        }

        public DataTable ObtenerComensalByOid(int oid)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();
            MySqlParameter[] sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("?p_oid", oid);
            DataTable dt = new DataTable();
            
            dt = oDB.CargarDataTable_SP("sp_Comensal_SelByOid", sqlParameters);

            return dt;

        }

        public DataTable ObtenerListado() {

            dbConnectionMySql oDB = new dbConnectionMySql(); 
           
            DataTable  dt = new DataTable ();

            dt = oDB.CargarDataTable_SP("sp_Comensal_Sel");

            return dt;

        }

        public DataTable ObtenerComedoresAtencion(int oid_come_clien)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();
            MySqlParameter[] sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("?p_oid_come_clie", oid_come_clien);
            DataTable dt = new DataTable();

            dt = oDB.CargarDataTable_SP("sp_Comensal_SelComedores", sqlParameters);

            return dt;

        }

        public DataTable ObtenerListadoCombo()
        {

            dbConnectionMySql oDB = new dbConnectionMySql();
            DataTable dt = new DataTable();

            dt = oDB.CargarDataTable_SP("sp_Comensal_Combo");

            return dt;

        }

        public void InsertarPorExcel(ComensalBE oComensalBE)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();

            MySqlParameter[] sqlParameters = new MySqlParameter[9];
            sqlParameters[0] = new MySqlParameter("?p_num_iden_come", oComensalBE.num_iden_come);
            sqlParameters[1] = new MySqlParameter("?p_val_desc", oComensalBE.val_desc);
            sqlParameters[2] = new MySqlParameter("?p_tipo_cod_tipo_docu_iden", oComensalBE.tipo_cod_tipo_docu_iden);
            sqlParameters[3] = new MySqlParameter("?p_val_num_docu_iden", oComensalBE.val_num_docu_iden);
            sqlParameters[4] = new MySqlParameter("?p_val_carg", oComensalBE.val_carg);
            sqlParameters[5] = new MySqlParameter("?p_val_tipo_carg", oComensalBE.val_tipo_carg);            
            sqlParameters[6] = new MySqlParameter("?p_clie_oid_clie", oComensalBE.clie_oid_clie);
            sqlParameters[7] = new MySqlParameter("?p_proy_oid_proy", oComensalBE.proy_oid_proy);
            sqlParameters[8] = new MySqlParameter("?p_come_oid_come_aten", oComensalBE.come_oid_come_aten);            

            oDB.EjecutarDML_SP("sp_Comensal_InsByExcel", sqlParameters);

        }

        public void Insertar(ComensalBE oComensalBE)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();

            MySqlParameter[] sqlParameters = new MySqlParameter[8];
            sqlParameters[0] = new MySqlParameter("?p_num_iden_come", oComensalBE.num_iden_come);
            sqlParameters[1] = new MySqlParameter("?p_val_desc", oComensalBE.val_desc);
            sqlParameters[2] = new MySqlParameter("?p_tipo_cod_tipo_docu_iden", oComensalBE.tipo_cod_tipo_docu_iden);
            sqlParameters[3] = new MySqlParameter("?p_val_num_docu_iden", oComensalBE.val_num_docu_iden);
            sqlParameters[4] = new MySqlParameter("?p_val_carg", oComensalBE.val_carg);
            sqlParameters[5] = new MySqlParameter("?p_val_tipo_carg", oComensalBE.val_tipo_carg);                        
            sqlParameters[6] = new MySqlParameter("?p_clie_oid_clie", oComensalBE.clie_oid_clie);
            sqlParameters[7] = new MySqlParameter("?p_proy_oid_proy", oComensalBE.proy_oid_proy);            

            oDB.EjecutarDML_SP("sp_Comensal_Ins", sqlParameters);

        }

        public void Actualizar(ComensalBE oComensalBE)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();

            MySqlParameter[] sqlParameters = new MySqlParameter[9];
            sqlParameters[0] = new MySqlParameter("?p_oid_come_clie", oComensalBE.oid_come);
            sqlParameters[1] = new MySqlParameter("?p_num_iden_come", oComensalBE.num_iden_come);
            sqlParameters[2] = new MySqlParameter("?p_val_desc", oComensalBE.val_desc);
            sqlParameters[3] = new MySqlParameter("?p_tipo_cod_tipo_docu_iden", oComensalBE.tipo_cod_tipo_docu_iden);
            sqlParameters[4] = new MySqlParameter("?p_val_num_docu_iden", oComensalBE.val_num_docu_iden);
            sqlParameters[5] = new MySqlParameter("?p_val_carg", oComensalBE.val_carg);
            sqlParameters[6] = new MySqlParameter("?p_val_tipo_carg", oComensalBE.val_tipo_carg);           
            sqlParameters[7] = new MySqlParameter("?p_clie_oid_clie", oComensalBE.clie_oid_clie);
            sqlParameters[8] = new MySqlParameter("?p_proy_oid_proy", oComensalBE.proy_oid_proy);            
            
            oDB.EjecutarDML_SP("sp_Comensal_Upd", sqlParameters);

        }

        public void Eliminar(int oid)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();

            MySqlParameter[] sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("?p_oid", oid);

            oDB.EjecutarDML_SP("sp_Comensal_Del", sqlParameters);

        }


    }
}

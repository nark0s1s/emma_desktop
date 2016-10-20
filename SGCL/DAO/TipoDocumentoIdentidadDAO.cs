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
    class TipoDocumentoIdentidadDAO
    {

        MySqlCommand cmd = new MySqlCommand();

        public DataTable obtenerTipoDocumentoIdentidadByCod(string cod)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();
            MySqlParameter[] sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("?p_cod", cod);
            DataTable dt = new DataTable();

            dt = oDB.CargarDataTable_SP("sp_TipoDocumentoIdentidad_SelByCod", sqlParameters);

            return dt;

        }

        public DataTable ObtenerListado() {

            dbConnectionMySql oDB = new dbConnectionMySql();            
            DataTable  dt = new DataTable ();

            dt = oDB.CargarDataTable_SP("sp_TipoDocumentoIdentidad_Sel");

            return dt;

        }

        public void Insertar(TipoDocumentoIdentidadBE oTipoDocumentoIdentidadBE)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();

            MySqlParameter[] sqlParameters = new MySqlParameter[2];
            sqlParameters[0] = new MySqlParameter("?p_cod", oTipoDocumentoIdentidadBE.cod_tipo_docu_iden);
            sqlParameters[1] = new MySqlParameter("?p_val_desc", oTipoDocumentoIdentidadBE.val_desc);

            oDB.EjecutarDML_SP("sp_TipoDocumentoIdentidad_Ins", sqlParameters);

        }

        public void Actualizar(TipoDocumentoIdentidadBE oTipoDocumentoIdentidadBE)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();

            MySqlParameter[] sqlParameters = new MySqlParameter[2];
            sqlParameters[0] = new MySqlParameter("?p_cod", oTipoDocumentoIdentidadBE.cod_tipo_docu_iden);            
            sqlParameters[1] = new MySqlParameter("?p_val_desc", oTipoDocumentoIdentidadBE.val_desc);
            
            oDB.EjecutarDML_SP("sp_TipoDocumentoIdentidad_Upd", sqlParameters);

        }

        public void Eliminar(string cod)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();

            MySqlParameter[] sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("?p_cod", cod);

            oDB.EjecutarDML_SP("sp_TipoDocumentoIdentidad_Del", sqlParameters);

        }


    }
}

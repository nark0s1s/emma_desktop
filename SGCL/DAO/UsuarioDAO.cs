using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGCL.DAO;
using MySql.Data.MySqlClient;
using System.Data;

namespace EMMA.DAO
{
    class UsuarioDAO
    {

        MySqlCommand cmd = new MySqlCommand();

        public void ValidarLogin(string cod_usua, string val_clav, int oid_proy, out string val_resu, out int oid_usua, out string des_usua)
        {
            dbConnectionMySql oDB = new dbConnectionMySql();
            MySqlParameter[] sqlParameters = new MySqlParameter[6];
            sqlParameters[0] = new MySqlParameter("?p_cod_usua", cod_usua);
            sqlParameters[1] = new MySqlParameter("?p_val_clav", val_clav);
            sqlParameters[2] = new MySqlParameter("?p_oid_proy", oid_proy);            
            sqlParameters[3] = new MySqlParameter("?p_val_resu", MySqlDbType.String, 50, ParameterDirection.Output, true, 0, 0, null, DataRowVersion.Current, null);
            sqlParameters[4] = new MySqlParameter("?p_oid_usua", MySqlDbType.Int32, 50, ParameterDirection.Output, true, 0, 0, null, DataRowVersion.Current, null);
            sqlParameters[5] = new MySqlParameter("?p_des_usua", MySqlDbType.String, 150, ParameterDirection.Output, true, 0, 0, null, DataRowVersion.Current, null);

            oDB.Output_String_SP("sp_Usuario_ValidarLogin", sqlParameters);
            val_resu = (string)sqlParameters[3].Value;
            oid_usua = (Int32)sqlParameters[4].Value;
            des_usua = (string)sqlParameters[5].Value;

        }


    }
}

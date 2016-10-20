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
    class TurnoDAO
    {

        MySqlCommand cmd = new MySqlCommand();

        public DataTable obtenerTurnoByOid(int oid)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();
            MySqlParameter[] sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("?p_oid", oid);
            DataTable dt = new DataTable();

            dt = oDB.CargarDataTable_SP("sp_Turno_SelByOid", sqlParameters);

            return dt;

        }

        public DataTable ObtenerListado() {

            dbConnectionMySql oDB = new dbConnectionMySql();            
            DataTable  dt = new DataTable ();

            dt = oDB.CargarDataTable_SP("sp_Turno_Sel");

            return dt;

        }

        public int ValidarTurno(TurnoBE oTurnoBE)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();

            MySqlParameter[] sqlParameters = new MySqlParameter[6];            
            sqlParameters[0] = new MySqlParameter("?p_proy_oid_proy", oTurnoBE.proy_oid_proy);
            sqlParameters[1] = new MySqlParameter("?p_come_oid_come", oTurnoBE.come_oid_come);
            sqlParameters[2] = new MySqlParameter("?p_tise_cod_tipo_serv", oTurnoBE.tise_cod_tipo_serv);
            sqlParameters[3] = new MySqlParameter("?p_lect_oid_lect", oTurnoBE.lect_oid_lect);
            sqlParameters[4] = new MySqlParameter("?p_val_fech", oTurnoBE.val_fech);
            sqlParameters[5] = new MySqlParameter("?p_val_resu", MySqlDbType.Int32, 11, ParameterDirection.Output, true, 0, 0, null, DataRowVersion.Current, null);
            
            int result;
            result = oDB.Output_Int_SP("sp_Turno_Validar_Ins", sqlParameters);

            return result;

        }

        public void Insertar(TurnoBE oTurnoBE)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();

            MySqlParameter[] sqlParameters = new MySqlParameter[8];            
            sqlParameters[0] = new MySqlParameter("?p_proy_oid_proy", oTurnoBE.proy_oid_proy);
            sqlParameters[1] = new MySqlParameter("?p_come_oid_come", oTurnoBE.come_oid_come);
            sqlParameters[2] = new MySqlParameter("?p_tise_cod_tipo_serv", oTurnoBE.tise_cod_tipo_serv);
            sqlParameters[3] = new MySqlParameter("?p_lect_oid_lect", oTurnoBE.lect_oid_lect);
            sqlParameters[4] = new MySqlParameter("?p_val_fech", oTurnoBE.val_fech);
            sqlParameters[5] = new MySqlParameter("?p_val_cant", oTurnoBE.val_cant);                                   
            sqlParameters[6] = new MySqlParameter("?p_ind_cier", oTurnoBE.ind_cier);
            sqlParameters[7] = new MySqlParameter("?p_ind_elim", oTurnoBE.ind_elim);                        
            
            oDB.EjecutarDML_SP("sp_Turno_Ins", sqlParameters);

        }

        public void Cerrar(int oid)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();

            MySqlParameter[] sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("?p_oid", oid);

            oDB.EjecutarDML_SP("sp_Turno_Cerr", sqlParameters);

        }        
          
        public void Eliminar(int oid)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();

            MySqlParameter[] sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("?p_oid", oid);

            oDB.EjecutarDML_SP("sp_Turno_Del", sqlParameters);

        }


    }
}

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
    class TurnoDetalleDAO
    {

        MySqlCommand cmd = new MySqlCommand();

        public DataTable obtenerTurnoDetalleByOid(int oid)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();
            MySqlParameter[] sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("?p_oid", oid);
            DataTable dt = new DataTable();

            dt = oDB.CargarDataTable_SP("sp_TurnoDetalle_SelByOid", sqlParameters);

            return dt;

        }

        public DataTable ObtenerListadoPorTurno(int oid_turn) {

            dbConnectionMySql oDB = new dbConnectionMySql();
            MySqlParameter[] sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("?p_oid", oid_turn);
            DataTable  dt = new DataTable ();

            dt = oDB.CargarDataTable_SP("sp_TurnoDetalle_SelByTurno", sqlParameters);

            return dt;

        }

        public int ValidarComensal(int oid_turn, int oid_come)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();
            MySqlParameter[] sqlParameters = new MySqlParameter[3];
            sqlParameters[0] = new MySqlParameter("?p_oid_turn", oid_turn);
            sqlParameters[1] = new MySqlParameter("?p_oid_come", oid_come);
            sqlParameters[2] = new MySqlParameter("?p_val_resu", MySqlDbType.Int32, 11, ParameterDirection.Output, true, 0, 0, null, DataRowVersion.Current, null);

            int result;
            result = oDB.Output_Int_SP("sp_Comensal_ValidarComensal", sqlParameters);

            return result;

        }

        public void Insertar(TurnoDetalleBE oTurnoDetalleBE)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();

            MySqlParameter[] sqlParameters = new MySqlParameter[3];
            sqlParameters[0] = new MySqlParameter("?p_turn_oid_turn", oTurnoDetalleBE.turn_oid_turn);
            sqlParameters[1] = new MySqlParameter("?p_oid_come_clie", oTurnoDetalleBE.oid_come_clie);
            sqlParameters[2] = new MySqlParameter("?p_ind_tipo_entr", oTurnoDetalleBE.ind_tipo_entr);                                   
            
            oDB.EjecutarDML_SP("sp_TurnoDetalle_Ins", sqlParameters);

        }

        /*
        public void Actualizar(TurnoDetalleBE oTurnoDetalleBE)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();

            MySqlParameter[] sqlParameters = new MySqlParameter[4];
            sqlParameters[0] = new MySqlParameter("?p_val_desc", oTurnoDetalleBE.val_desc);
            sqlParameters[1] = new MySqlParameter("?p_proy_oid_proy", oTurnoDetalleBE.proy_oid_proy);
            sqlParameters[2] = new MySqlParameter("?p_clie_oid_clie", oTurnoDetalleBE.clie_oid_clie);
            sqlParameters[3] = new MySqlParameter("?p_ind_acti", oTurnoDetalleBE.ind_acti);            
                                    
            oDB.EjecutarDML_SP("sp_TurnoDetalle_Upd", sqlParameters);

        }
        */
          
        public void Eliminar(int oid)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();

            MySqlParameter[] sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("?p_oid", oid);

            oDB.EjecutarDML_SP("sp_TurnoDetalle_Del", sqlParameters);

        }


    }
}

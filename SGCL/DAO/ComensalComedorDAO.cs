﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SGCL.BE;
using System.Data;


namespace SGCL.DAO
{
    class ComensalComedorDAO
    {

        MySqlCommand cmd = new MySqlCommand();

        public DataTable obtenerComedorByOid(int oid)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();
            MySqlParameter[] sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("?p_oid", oid);
            DataTable dt = new DataTable();

            dt = oDB.CargarDataTable_SP("sp_ComensalComedor_SelByOid", sqlParameters);

            return dt;

        }

        public DataTable ObtenerListado() {

            dbConnectionMySql oDB = new dbConnectionMySql();            
            DataTable  dt = new DataTable ();

            dt = oDB.CargarDataTable_SP("sp_ComensalComedor_Sel");

            return dt;

        }

        public DataTable ObtenerListadoPorProyecto(int oid)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();
            MySqlParameter[] sqlParameters = new MySqlParameter[1];
            sqlParameters[0] = new MySqlParameter("?p_oid", oid);
            DataTable dt = new DataTable();

            dt = oDB.CargarDataTable_SP("sp_ComensalComedor_SelByProyecto", sqlParameters);

            return dt;

        }

        public void Insertar(ComensalComedorBE oComensalComedorBE)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();

            MySqlParameter[] sqlParameters = new MySqlParameter[4];
            sqlParameters[0] = new MySqlParameter("?p_clie_oid_clie", oComensalComedorBE.clie_oid_clie);
            sqlParameters[1] = new MySqlParameter("?p_proy_oid_proy", oComensalComedorBE.proy_oid_proy);
            sqlParameters[2] = new MySqlParameter("?p_oid_come_aten", oComensalComedorBE.oid_come_aten);                        
            sqlParameters[3] = new MySqlParameter("?p_oid_come_clie", oComensalComedorBE.oid_come_clie);                        
            
            oDB.EjecutarDML_SP("sp_ComensalComedor_Ins", sqlParameters);

        }

        public void Actualizar(ComensalComedorBE oComensalComedorBE)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();

            MySqlParameter[] sqlParameters = new MySqlParameter[5];
            sqlParameters[0] = new MySqlParameter("?p_oid_come_come", oComensalComedorBE.oid_come_come);                                    
            sqlParameters[1] = new MySqlParameter("?p_clie_oid_clie", oComensalComedorBE.clie_oid_clie);
            sqlParameters[2] = new MySqlParameter("?p_proy_oid_proy", oComensalComedorBE.proy_oid_proy);
            sqlParameters[3] = new MySqlParameter("?p_oid_come_aten", oComensalComedorBE.oid_come_aten);
            sqlParameters[4] = new MySqlParameter("?p_oid_come_clie", oComensalComedorBE.oid_come_clie);            
                                    
            oDB.EjecutarDML_SP("sp_ComensalComedor_Upd", sqlParameters);

        }

        public void Eliminar(int oid_come_clie, int oid_come_aten)
        {

            dbConnectionMySql oDB = new dbConnectionMySql();

            MySqlParameter[] sqlParameters = new MySqlParameter[2];
            sqlParameters[0] = new MySqlParameter("?p_oid_come_clie", oid_come_clie);
            sqlParameters[1] = new MySqlParameter("?p_oid_come_aten", oid_come_aten);

            oDB.EjecutarDML_SP("sp_ComensalComedor_Del", sqlParameters);

        }


    }
}

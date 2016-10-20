using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGCL.BE;
using SGCL.DAO;
using System.Windows.Forms;
using System.Data;

namespace SGCL.BR
{
    class TurnoBR
    {

        public TurnoBE ObtenerTurnoByOid(int oid)
        {

            TurnoBE oBE = new TurnoBE();

            DataTable dt = new DataTable();

            TurnoDAO oTurnoDAO = new TurnoDAO();

            dt = oTurnoDAO.obtenerTurnoByOid(oid);

            foreach (DataRow dr in dt.Rows)
            {
                oBE.oid_turn = Int32.Parse(dr["oid_turn"].ToString());                
                oBE.proy_oid_proy = Int32.Parse(dr["proy_oid_proy"].ToString());                
                oBE.clie_oid_clie = Int32.Parse(dr["clie_oid_clie"].ToString());
                oBE.come_oid_come = Int32.Parse(dr["come_oid_come"].ToString());
                oBE.tise_cod_tipo_serv = dr["tise_cod_tipo_serv"].ToString();
                oBE.lect_oid_lect = Int32.Parse(dr["lect_oid_lect"].ToString());
                oBE.val_fech = dr["val_fech"].ToString();
                oBE.ind_cier = Int32.Parse(dr["ind_cier"].ToString());
                oBE.ind_elim = Int32.Parse(dr["ind_elim"].ToString());                                

            }

            return oBE;

        }        

        public DataTable ObtenerListado () {

            DataTable dt = new DataTable();

            TurnoDAO oTurnoDAO = new TurnoDAO();
            
            dt = oTurnoDAO.ObtenerListado();

            return dt;
        }

        public int ValidarTurno(TurnoBE oTurnoBE)
        {

            TurnoDAO oTurnoDAO = new TurnoDAO();

            int result;
            result = oTurnoDAO.ValidarTurno(oTurnoBE);

            return result;
        }

        public void Insertar(TurnoBE oTurnoBE) {

            TurnoDAO oTurnoDAO = new TurnoDAO();
            oTurnoDAO.Insertar(oTurnoBE);

        }


        public void Cerrar(int oid)
        {

            TurnoDAO oTurnoDAO = new TurnoDAO();
            
            oTurnoDAO.Cerrar(oid);

        }
        

        public void Eliminar(int oid)
        {

            TurnoDAO oTurnoDAO = new TurnoDAO();
            oTurnoDAO.Eliminar(oid);

        }

    }
}

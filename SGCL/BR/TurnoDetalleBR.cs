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
    class TurnoDetalleBR
    {

        public TurnoDetalleBE obtenerTurnoDetalleByOid(int oid)
        {

            TurnoDetalleBE oBE = new TurnoDetalleBE();

            DataTable dt = new DataTable();

            TurnoDetalleDAO oTurnoDetalleDAO = new TurnoDetalleDAO();

            dt = oTurnoDetalleDAO.obtenerTurnoDetalleByOid(oid);

            foreach (DataRow dr in dt.Rows)
            {
                oBE.oid_turn_deta = Int32.Parse(dr["oid_turn_deta"].ToString());
                oBE.turn_oid_turn = Int32.Parse(dr["turn_oid_turn"].ToString());
                oBE.oid_come_clie = Int32.Parse(dr["oid_come_clie"].ToString());
                oBE.ind_tipo_entr = dr["ind_tipo_entr"].ToString();
                

            }

            return oBE;

        }        

        public DataTable ObtenerListadoPorTurno (int oid_turn) {

            DataTable dt = new DataTable();

            TurnoDetalleDAO oTurnoDetalleDAO = new TurnoDetalleDAO();

            dt = oTurnoDetalleDAO.ObtenerListadoPorTurno(oid_turn);

            return dt;
        }

        public int ValidarComensal(int oid_turn,int oid_come)
        {

            TurnoDetalleBE oBE = new TurnoDetalleBE();
            TurnoDetalleDAO oTurnoDetalleDAO = new TurnoDetalleDAO();

            int oid;
            oid = oTurnoDetalleDAO.ValidarComensal(oid_turn, oid_come);

            return oid;

        }

        public void Insertar(TurnoDetalleBE oTurnoDetalleBE) {

            TurnoDetalleDAO oTurnoDetalleDAO = new TurnoDetalleDAO();
            oTurnoDetalleDAO.Insertar(oTurnoDetalleBE);

        }

        /*
        public void Actualizar(TurnoDetalleBE oTurnoDetalleBE)
        {

            TurnoDetalleDAO oTurnoDetalleDAO = new TurnoDetalleDAO();
            
            oTurnoDetalleDAO.Actualizar(oTurnoDetalleBE);

        }
        */

        public void Eliminar(int oid)
        {

            TurnoDetalleDAO oTurnoDetalleDAO = new TurnoDetalleDAO();
            oTurnoDetalleDAO.Eliminar(oid);

        }

    }
}

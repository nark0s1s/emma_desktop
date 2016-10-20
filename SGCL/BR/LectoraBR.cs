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
    class LectoraBR
    {

        public LectoraBE obtenerLectoraByOid(int oid)
        {

            LectoraBE oBE = new LectoraBE();

            DataTable dt = new DataTable();

            LectoraDAO oLectoraDAO = new LectoraDAO();

            dt = oLectoraDAO.obtenerLectoraByOid(oid);

            foreach (DataRow dr in dt.Rows)
            {
                oBE.oid_lect = Int32.Parse(dr["oid_lect"].ToString());
                oBE.val_desc = dr["val_desc"].ToString();
                oBE.proy_oid_proy = Int32.Parse(dr["proy_oid_proy"].ToString());                
                oBE.clie_oid_clie = Int32.Parse(dr["clie_oid_clie"].ToString());
                oBE.come_oid_come_aten = Int32.Parse(dr["come_oid_come_aten"].ToString());                
                oBE.ind_acti = Int32.Parse(dr["ind_acti"].ToString());                                

            }

            return oBE;

        }        

        public DataTable ObtenerListado () {

            DataTable dt = new DataTable();

            LectoraDAO oLectoraDAO = new LectoraDAO();
            
            dt = oLectoraDAO.ObtenerListado();

            return dt;
        }

        public DataTable ObtenerListadoPorComedor(int oid)
        {

            DataTable dt = new DataTable();

            LectoraDAO oLectoraDAO = new LectoraDAO();

            dt = oLectoraDAO.ObtenerListadoPorComedor(oid);

            return dt;
        }

        public void Insertar(LectoraBE oLectoraBE) {

            LectoraDAO oLectoraDAO = new LectoraDAO();
            oLectoraDAO.Insertar(oLectoraBE);

        }

        public void Actualizar(LectoraBE oLectoraBE)
        {

            LectoraDAO oLectoraDAO = new LectoraDAO();
            
            oLectoraDAO.Actualizar(oLectoraBE);

        }

        public void Eliminar(int oid)
        {

            LectoraDAO oLectoraDAO = new LectoraDAO();
            oLectoraDAO.Eliminar(oid);

        }

    }
}

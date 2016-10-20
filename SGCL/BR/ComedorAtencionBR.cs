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
    class ComedorAtencionBR
    {

        public ComedorAtencionBE obtenerComedorByOid(int oid)
        {

            ComedorAtencionBE oBE = new ComedorAtencionBE();

            DataTable dt = new DataTable();

            ComedorAtencionDAO oComedorAtencionDAO = new ComedorAtencionDAO();

            dt = oComedorAtencionDAO.obtenerComedorByOid(oid);

            foreach (DataRow dr in dt.Rows)
            {
                oBE.oid_come_aten = Int32.Parse(dr["oid_come_aten"].ToString());
                oBE.val_desc = dr["val_desc"].ToString();
                oBE.proy_oid_proy = Int32.Parse(dr["proy_oid_proy"].ToString());                                
                oBE.ind_acti = Int32.Parse(dr["ind_acti"].ToString());                                

            }

            return oBE;

        }        

        public DataTable ObtenerListado () {

            DataTable dt = new DataTable();

            ComedorAtencionDAO oComedorAtencionDAO = new ComedorAtencionDAO();
            
            dt = oComedorAtencionDAO.ObtenerListado();

            return dt;
        }

        public DataTable ObtenerListadoPorProyecto(int oid)
        {

            DataTable dt = new DataTable();

            ComedorAtencionDAO oComedorAtencionDAO = new ComedorAtencionDAO();

            dt = oComedorAtencionDAO.ObtenerListadoPorProyecto(oid);

            return dt;
        }

        public void Insertar(ComedorAtencionBE oComedorAtencionBE) {

            ComedorAtencionDAO oComedorAtencionDAO = new ComedorAtencionDAO();
            oComedorAtencionDAO.Insertar(oComedorAtencionBE);

        }

        public void Actualizar(ComedorAtencionBE oComedorAtencionBE)
        {

            ComedorAtencionDAO oComedorAtencionDAO = new ComedorAtencionDAO();
            
            oComedorAtencionDAO.Actualizar(oComedorAtencionBE);

        }

        public void Eliminar(int oid)
        {

            ComedorAtencionDAO oComedorAtencionDAO = new ComedorAtencionDAO();
            oComedorAtencionDAO.Eliminar(oid);

        }

    }
}

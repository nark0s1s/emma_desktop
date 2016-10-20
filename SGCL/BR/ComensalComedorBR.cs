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
    class ComensalComedorBR
    {

        public ComensalComedorBE obtenerComedorByOid(int oid)
        {

            ComensalComedorBE oBE = new ComensalComedorBE();

            DataTable dt = new DataTable();

            ComensalComedorDAO oComensalComedorDAO = new ComensalComedorDAO();

            dt = oComensalComedorDAO.obtenerComedorByOid(oid);

            foreach (DataRow dr in dt.Rows)
            {
                oBE.oid_come_aten = Int32.Parse(dr["oid_come_aten"].ToString());
                //oBE.val_desc = dr["val_desc"].ToString();
                oBE.proy_oid_proy = Int32.Parse(dr["proy_oid_proy"].ToString());                
                oBE.clie_oid_clie = Int32.Parse(dr["clie_oid_clie"].ToString());                
                //oBE.ind_acti = Int32.Parse(dr["ind_acti"].ToString());                                

            }

            return oBE;

        }        

        public DataTable ObtenerListado () {

            DataTable dt = new DataTable();

            ComensalComedorDAO oComensalComedorDAO = new ComensalComedorDAO();
            
            dt = oComensalComedorDAO.ObtenerListado();

            return dt;
        }

        public DataTable ObtenerListadoPorProyecto(int oid)
        {

            DataTable dt = new DataTable();

            ComensalComedorDAO oComensalComedorDAO = new ComensalComedorDAO();

            dt = oComensalComedorDAO.ObtenerListadoPorProyecto(oid);

            return dt;
        }

        public void Insertar(ComensalComedorBE oComensalComedorBE) {

            ComensalComedorDAO oComensalComedorDAO = new ComensalComedorDAO();
            oComensalComedorDAO.Insertar(oComensalComedorBE);

        }

        public void Actualizar(ComensalComedorBE oComensalComedorBE)
        {

            ComensalComedorDAO oComensalComedorDAO = new ComensalComedorDAO();
            
            oComensalComedorDAO.Actualizar(oComensalComedorBE);

        }

        public void Eliminar(int oid_come_clie, int oid_come_aten)
        {

            ComensalComedorDAO oComensalComedorDAO = new ComensalComedorDAO();
            oComensalComedorDAO.Eliminar(oid_come_clie,oid_come_aten);

        }

    }
}

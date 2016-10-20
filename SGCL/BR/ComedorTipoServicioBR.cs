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
    class ComedorTipoServicioBR
    {

        public ComedorTipoServicioBE obtenerComedorTipoServicioByOid(int oid)
        {

            ComedorTipoServicioBE oBE = new ComedorTipoServicioBE();

            DataTable dt = new DataTable();

            ComedorTipoServicioDAO oComedorTipoServicioDAO = new ComedorTipoServicioDAO();

            dt = oComedorTipoServicioDAO.obtenerComedorTipoServicioByOid(oid);

            foreach (DataRow dr in dt.Rows)
            {
                oBE.oid_come_tipo_serv = Int32.Parse(dr["oid_come_tipo_serv"].ToString());
                oBE.clie_oid_clie = Int32.Parse(dr["clie_oid_clie"].ToString());
                oBE.proy_oid_proy = Int32.Parse(dr["proy_oid_proy"].ToString());
                oBE.come_oid_come_aten = Int32.Parse(dr["come_oid_come_aten"].ToString());
                oBE.tipo_cod_tipo_serv_come = dr["tipo_cod_tipo_serv_come"].ToString();
                oBE.imp_prec_fact = Decimal.Parse(dr["imp_prec_fact"].ToString());                                                
                oBE.ind_acti = Int32.Parse(dr["ind_acti"].ToString());                                

            }

            return oBE;

        }        

        public DataTable ObtenerListado () {

            DataTable dt = new DataTable();

            ComedorTipoServicioDAO oComedorTipoServicioDAO = new ComedorTipoServicioDAO();
            
            dt = oComedorTipoServicioDAO.ObtenerListado();

            return dt;
        }
        
        public void Insertar(ComedorTipoServicioBE oComedorTipoServicioBE) {

            ComedorTipoServicioDAO oComedorTipoServicioDAO = new ComedorTipoServicioDAO();
            oComedorTipoServicioDAO.Insertar(oComedorTipoServicioBE);

        }

        public void Actualizar(ComedorTipoServicioBE oComedorTipoServicioBE)
        {

            ComedorTipoServicioDAO oComedorTipoServicioDAO = new ComedorTipoServicioDAO();
            
            oComedorTipoServicioDAO.Actualizar(oComedorTipoServicioBE);

        }

        public void Eliminar(int oid)
        {

            ComedorTipoServicioDAO oComedorTipoServicioDAO = new ComedorTipoServicioDAO();
            oComedorTipoServicioDAO.Eliminar(oid);

        }

    }
}

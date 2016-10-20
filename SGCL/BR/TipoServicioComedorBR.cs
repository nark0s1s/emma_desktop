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
    class TipoServicioComedorBR
    {

        public TipoServicioComedorBE obtenerTipoServicioComedorByCod(string cod)
        {

            TipoServicioComedorBE oBE = new TipoServicioComedorBE();

            DataTable dt = new DataTable();

            TipoServicioComedorDAO oTipoServicioComedorDAO = new TipoServicioComedorDAO();

            dt = oTipoServicioComedorDAO.obtenerTipoServicioComedorByCod(cod);

            foreach (DataRow dr in dt.Rows)
            {
                oBE.cod_tipo_docu_iden = dr["cod_tipo_serv_come"].ToString();
                oBE.val_desc = dr["val_desc"].ToString();
                oBE.num_orde_repo = Int32.Parse(dr["ind_acti"].ToString());
                oBE.ind_acti = Int32.Parse(dr["ind_acti"].ToString());

            }

            return oBE;

        }

        public DataTable ObtenerListado () {

            DataTable dt = new DataTable();

            TipoServicioComedorDAO oTipoServicioComedorDAO = new TipoServicioComedorDAO();
            
            dt = oTipoServicioComedorDAO.ObtenerListado();

            return dt;
        }

        public DataTable ObtenerListadoCombo()
        {

            DataTable dt = new DataTable();

            TipoServicioComedorDAO oTipoServicioComedorDAO = new TipoServicioComedorDAO();

            dt = oTipoServicioComedorDAO.ObtenerListadoCombo();

            return dt;
        }

        public DataTable ObtenerListadoPorComedor(int oid)
        {

            DataTable dt = new DataTable();

            TipoServicioComedorDAO oTipoServicioComedorDAO = new TipoServicioComedorDAO();

            dt = oTipoServicioComedorDAO.ObtenerListadoPorComedor(oid);

            return dt;
        }

        public void Insertar(TipoServicioComedorBE oTipoServicioComedorBE) {

            TipoServicioComedorDAO oTipoServicioComedorDAO = new TipoServicioComedorDAO();
            oTipoServicioComedorDAO.Insertar(oTipoServicioComedorBE);

        }

        public void Actualizar(TipoServicioComedorBE oTipoServicioComedorBE)
        {

            TipoServicioComedorDAO oTipoServicioComedorDAO = new TipoServicioComedorDAO();
            
            oTipoServicioComedorDAO.Actualizar(oTipoServicioComedorBE);

        }

        public void Eliminar(string cod)
        {

            TipoServicioComedorDAO oTipoServicioComedorDAO = new TipoServicioComedorDAO();
            oTipoServicioComedorDAO.Eliminar(cod);

        }

    }
}

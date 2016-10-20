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
    class ProyectoBR
    {

        public ProyectoBE obtenerProyectoByOid(int oid)
        {

            ProyectoBE oBE = new ProyectoBE();

            DataTable dt = new DataTable();

            ProyectoDAO oProyectoDAO = new ProyectoDAO();

            dt = oProyectoDAO.obtenerProyectoByOid(oid);

            foreach (DataRow dr in dt.Rows)
            {
                oBE.oid_proy = Int32.Parse(dr["oid_proy"].ToString());
                oBE.val_desc = dr["val_desc"].ToString();
                oBE.val_dept = dr["val_dept"].ToString();
                oBE.val_prov = dr["val_prov"].ToString();
                oBE.val_dist = dr["val_dist"].ToString();                
                oBE.clie_oid_clie = Int32.Parse(dr["clie_oid_clie"].ToString());                

            }

            return oBE;

        }

        public DataTable ObtenerListadoPorCliente(int oid)
        {

            DataTable dt = new DataTable();

            ProyectoDAO oProyectoDAO = new ProyectoDAO();

            dt = oProyectoDAO.ObtenerListadoPorCliente(oid);

            return dt;
        }

        public DataTable ObtenerListado () {

            DataTable dt = new DataTable();

            ProyectoDAO oProyectoDAO = new ProyectoDAO();
            
            dt = oProyectoDAO.ObtenerListado();

            return dt;
        }

        public void Insertar(ProyectoBE oProyectoBE) {

            ProyectoDAO oProyectoDAO = new ProyectoDAO();
            oProyectoDAO.Insertar(oProyectoBE);

        }

        public void Actualizar(ProyectoBE oProyectoBE)
        {

            ProyectoDAO oProyectoDAO = new ProyectoDAO();
            
            oProyectoDAO.Actualizar(oProyectoBE);

        }

        public void Eliminar(int oid)
        {

            ProyectoDAO oProyectoDAO = new ProyectoDAO();
            oProyectoDAO.Eliminar(oid);

        }

        public DataTable ObtenerListadoPorUsuario(string cod_usua,out string des_usua)
        {

            DataTable dt = new DataTable();
            ProyectoDAO oProyectoDAO = new ProyectoDAO();

            dt = oProyectoDAO.ObtenerListadoPorUsuario(cod_usua, out des_usua);

            return dt;

        }

    }
}

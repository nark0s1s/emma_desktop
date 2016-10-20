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
    class ClienteBR
    {

        public ClienteBE obtenerClienteByOid(int oid)
        {

            ClienteBE oBE = new ClienteBE();

            DataTable dt = new DataTable();

            ClienteDAO oClienteDAO = new ClienteDAO();

            dt = oClienteDAO.obtenerClienteByOid(oid);

            foreach (DataRow dr in dt.Rows)
            {
                oBE.oid_clie = Int32.Parse(dr["oid_clie"].ToString());
                
                oBE.val_deno_soci = dr["val_deno_soci"].ToString();                
                oBE.val_nom1 = dr["val_nom1"].ToString();
                oBE.val_nom2 = dr["val_nom2"].ToString();
                oBE.val_ape1 = dr["val_ape1"].ToString();
                oBE.val_ape2 = dr["val_ape2"].ToString();
                oBE.tipo_cod_tipo_docu_iden = dr["tipo_cod_tipo_docu_iden"].ToString();
                oBE.val_nume_docu_iden = dr["val_nume_docu_iden"].ToString();

            }

            return oBE;

        }

        public DataTable ObtenerListado () {

            DataTable dt = new DataTable();

            ClienteDAO oClienteDAO = new ClienteDAO();
            
            dt = oClienteDAO.ObtenerListado();

            return dt;
        }

        public DataTable ObtenerListadoCombo()
        {

            DataTable dt = new DataTable();

            ClienteDAO oClienteDAO = new ClienteDAO();

            dt = oClienteDAO.ObtenerListadoCombo();

            return dt;
        }

        public DataTable ObtenerListadoPorProyecto(int oid)
        {

            DataTable dt = new DataTable();

            ClienteDAO oClienteDAO = new ClienteDAO();

            dt = oClienteDAO.ObtenerListadoPorProyecto(oid);

            return dt;
        }


        public void Insertar(ClienteBE oClienteBE) {

            ClienteDAO oClienteDAO = new ClienteDAO();
            oClienteDAO.Insertar(oClienteBE);

        }

        public void Actualizar(ClienteBE oClienteBE)
        {

            ClienteDAO oClienteDAO = new ClienteDAO();
            
            oClienteDAO.Actualizar(oClienteBE);

        }

        public void Eliminar(int oid)
        {

            ClienteDAO oClienteDAO = new ClienteDAO();
            oClienteDAO.Eliminar(oid);

        }

    }
}

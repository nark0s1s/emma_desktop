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
    class TipoDocumentoIdentidadBR
    {

        public TipoDocumentoIdentidadBE obtenerTipoDocumentoIdentidadByCod(string cod)
        {

            TipoDocumentoIdentidadBE oBE = new TipoDocumentoIdentidadBE();

            DataTable dt = new DataTable();

            TipoDocumentoIdentidadDAO oTipoDocumentoIdentidadDAO = new TipoDocumentoIdentidadDAO();

            dt = oTipoDocumentoIdentidadDAO.obtenerTipoDocumentoIdentidadByCod(cod);

            foreach (DataRow dr in dt.Rows)
            {
                oBE.cod_tipo_docu_iden = dr["cod_tipo_docu_iden"].ToString();
                oBE.val_desc = dr["val_desc"].ToString();

            }

            return oBE;

        }

        public DataTable ObtenerListado () {

            DataTable dt = new DataTable();

            TipoDocumentoIdentidadDAO oTipoDocumentoIdentidadDAO = new TipoDocumentoIdentidadDAO();
            
            dt = oTipoDocumentoIdentidadDAO.ObtenerListado();

            return dt;
        }

        public void Insertar(TipoDocumentoIdentidadBE oTipoDocumentoIdentidadBE) {

            TipoDocumentoIdentidadDAO oTipoDocumentoIdentidadDAO = new TipoDocumentoIdentidadDAO();
            oTipoDocumentoIdentidadDAO.Insertar(oTipoDocumentoIdentidadBE);

        }

        public void Actualizar(TipoDocumentoIdentidadBE oTipoDocumentoIdentidadBE)
        {

            TipoDocumentoIdentidadDAO oTipoDocumentoIdentidadDAO = new TipoDocumentoIdentidadDAO();
            
            oTipoDocumentoIdentidadDAO.Actualizar(oTipoDocumentoIdentidadBE);

        }

        public void Eliminar(string cod)
        {

            TipoDocumentoIdentidadDAO oTipoDocumentoIdentidadDAO = new TipoDocumentoIdentidadDAO();
            oTipoDocumentoIdentidadDAO.Eliminar(cod);

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using SGCL.BE;
using SGCL.DAO;

namespace SGCL.BR
{
    class ComensalBR
    {

        public ComensalBE obtenerComensalByOid(int oid)
        {

            ComensalBE oBE = new ComensalBE();

            System.Data.DataTable dt = new System.Data.DataTable();

            ComensalDAO oComensalDAO = new ComensalDAO();

            dt = oComensalDAO.obtenerComensalByOid(oid);

            foreach (DataRow dr in dt.Rows)
            {
                oBE.oid_come = Int32.Parse(dr["oid_come_clie"].ToString());
                oBE.num_iden_come = dr["num_iden_come"].ToString();
                oBE.val_desc = dr["val_desc"].ToString();
                oBE.tipo_cod_tipo_docu_iden = dr["tipo_cod_tipo_docu_iden"].ToString(); 
                oBE.val_num_docu_iden = dr["val_num_docu_iden"].ToString();
                oBE.val_carg = dr["val_carg"].ToString();
                oBE.val_tipo_carg = dr["val_tipo_carg"].ToString();                
                oBE.clie_oid_clie = Int32.Parse(dr["clie_oid_clie"].ToString()); 
                oBE.proy_oid_proy = Int32.Parse(dr["proy_oid_proy"].ToString());                 
                               
            }

            return oBE;

        }

        public string ObtenerNombreByIdentificador(string num_iden_come,int come_oid_come)
        {

            ComensalBE oBE = new ComensalBE();
            ComensalDAO oComensalDAO = new ComensalDAO();

            string nombre;

            nombre = oComensalDAO.ObtenerNombreByIdentificador(num_iden_come, come_oid_come);
            
            return nombre;

        }

        public int ObtenerOidByDocumentoIdentidad(string num_iden_docu)
        {

            ComensalBE oBE = new ComensalBE();
            ComensalDAO oComensalDAO = new ComensalDAO();

            int oid;
            oid = oComensalDAO.ObtenerOidByDocumentoIdentidad(num_iden_docu);

            return oid;

        }

        public int ValidarDocumentoIdentidad(string num_iden_docu)
        {

            ComensalBE oBE = new ComensalBE();
            ComensalDAO oComensalDAO = new ComensalDAO();

            int oid;
            oid = oComensalDAO.ValidarDocumentoIdentidad(num_iden_docu);

            return oid;

        }

        public int ValidarIdentificacionComedor(string num_iden_come)
        {

            ComensalBE oBE = new ComensalBE();
            ComensalDAO oComensalDAO = new ComensalDAO();

            int oid;
            oid = oComensalDAO.ValidarIdentificacionComedor(num_iden_come);

            return oid;

        }

        public int ObtenerOidByIdentificador(string num_iden_come,int come_oid_come)
        {

            ComensalBE oBE = new ComensalBE();
            ComensalDAO oComensalDAO = new ComensalDAO();

            int oid;
            oid = oComensalDAO.ObtenerOidByIdentificador(num_iden_come, come_oid_come);            

            return oid;

        }

        public System.Data.DataTable ObtenerListado()
        {

            System.Data.DataTable dt = new System.Data.DataTable();

            ComensalDAO oComensalDAO = new ComensalDAO();

            dt = oComensalDAO.ObtenerListado();

            return dt;
        }

        public System.Data.DataTable ObtenerComedoresAtencion(int oid_come_clien)
        {

            System.Data.DataTable dt = new System.Data.DataTable();

            ComensalDAO oComensalDAO = new ComensalDAO();

            dt = oComensalDAO.ObtenerComedoresAtencion(oid_come_clien);

            return dt;
        }

        public void Insertar(ComensalBE oComensalBE)
        {

            ComensalDAO oComensalDAO = new ComensalDAO();
            oComensalDAO.Insertar(oComensalBE);

        }

        public void InsertarPorExcel(ComensalBE oComensalBE)
        {

            ComensalDAO oComensalDAO = new ComensalDAO();
            oComensalDAO.InsertarPorExcel(oComensalBE);

        }

        public void Actualizar(ComensalBE oComensalBE)
        {

            ComensalDAO oComensalDAO = new ComensalDAO();

            oComensalDAO.Actualizar(oComensalBE);

        }

        public void Eliminar(int oid)
        {

            ComensalDAO oComensalDAO = new ComensalDAO();
            oComensalDAO.Eliminar(oid);

        }

        public void CargarDesdeExcel(string path,int p_oid_clie, int p_oid_proy, int p_oid_come_aten)
        {

            ComensalBE oBE = new ComensalBE();

            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@path, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = (Microsoft.Office.Interop.Excel._Worksheet)xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            for (int i = 1; i <= rowCount; i++)
            {
                if (((Microsoft.Office.Interop.Excel.Range)xlRange.Cells[i, 1]).Value2 == null)
                {
                    oBE.num_iden_come = String.Empty;
                }
                else
                {
                    oBE.num_iden_come = ((Microsoft.Office.Interop.Excel.Range)xlRange.Cells[i, 1]).Value2.ToString();
                }
                oBE.val_desc = ((Microsoft.Office.Interop.Excel.Range)xlRange.Cells[i, 2]).Value2.ToString();
                oBE.tipo_cod_tipo_docu_iden = ((Microsoft.Office.Interop.Excel.Range)xlRange.Cells[i, 3]).Value2.ToString();
                oBE.val_num_docu_iden = ((Microsoft.Office.Interop.Excel.Range)xlRange.Cells[i, 4]).Value2.ToString();                
                oBE.val_carg = ((Microsoft.Office.Interop.Excel.Range)xlRange.Cells[i, 5]).Value2.ToString();
                oBE.val_tipo_carg = ((Microsoft.Office.Interop.Excel.Range)xlRange.Cells[i, 6]).Value2.ToString();                
                oBE.clie_oid_clie = p_oid_clie;
                oBE.proy_oid_proy = p_oid_proy;
                oBE.come_oid_come_aten = p_oid_come_aten;
                
                
                InsertarPorExcel(oBE);
               
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGCL.BR;
using SGCL.BE;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Globalization;
using System.Reflection;

namespace SGCL.PL.Reportes
{
    public partial class FrmReporteComensalesPorComedor : Form
    {

        public FrmReporteComensalesPorComedor()
        {
            InitializeComponent();

            CHelper oCHelper = new CHelper();
            oCHelper.FormatearFormularioMantenimiento(this);

            ClienteBR oBRCliente = new ClienteBR();

            DataTable dt = new DataTable();

            dt = oBRCliente.ObtenerListadoCombo();
            cboCliente.DataSource = dt;
            cboCliente.DisplayMember = "Descripcion";           

        }
                                       
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargarExcel_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range aRange;
            ValorizacionBR oBR = new ValorizacionBR();

            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
                                    
            DataRowView rvProy = cboProyecto.SelectedItem as DataRowView;

            int oid_proy;
            oid_proy = Int32.Parse(rvProy["Codigo"].ToString());

            DataTable dtComedores = new DataTable();
            
            dtComedores = oBR.ObtenerListadoComedorPorProyecto(oid_proy);

            int oid_come_aten;
            int hoja_exce = 1;

            foreach (DataRow dtRowCom in dtComedores.Rows)
            {

                oid_come_aten = Int32.Parse(dtRowCom[0].ToString());

                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(hoja_exce);

                xlWorkSheet.Name = dtRowCom[1].ToString();

                // Inicio Cabecera del Reporte
                xlWorkSheet.Cells[1, 1] = "   REPORTE DETALLADO ALIMENTACION";
                xlWorkSheet.Range[xlWorkSheet.Cells[1, 1], xlWorkSheet.Cells[1, 10]].Merge();
                xlWorkSheet.Cells[1, 1].Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                xlWorkSheet.Cells[1, 1].Font.Bold = true;
                
                xlWorkSheet.Range[xlWorkSheet.Cells[2, 1], xlWorkSheet.Cells[2, 10]].Merge();
                xlWorkSheet.Cells[2, 1].Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                xlWorkSheet.Cells[2, 1].Font.Bold = true;

                xlWorkSheet.Cells[3, 1] = "   " + dtRowCom[1].ToString();
                xlWorkSheet.Range[xlWorkSheet.Cells[3, 1], xlWorkSheet.Cells[3, 10]].Merge();
                xlWorkSheet.Cells[3, 1].Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                xlWorkSheet.Cells[3, 1].Font.Bold = true;
                // Fin Cabecera del Reporte


                //Inicio Titulos del Reporte
                xlWorkSheet.Cells[6, 1] = "N° Docu Iden";
                xlWorkSheet.Cells[6, 1].Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                xlWorkSheet.Cells[6, 1].Font.Bold = true;
                xlWorkSheet.Cells[6, 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightSteelBlue);
                xlWorkSheet.Range[xlWorkSheet.Cells[6, 1], xlWorkSheet.Cells[6, 1]].BorderAround(Type.Missing, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing);

                xlWorkSheet.Cells[6, 2] = "Nombres y Apellidos";
                xlWorkSheet.Cells[6, 2].Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                xlWorkSheet.Cells[6, 2].Font.Bold = true;
                xlWorkSheet.Cells[6, 2].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightSteelBlue);
                xlWorkSheet.Range[xlWorkSheet.Cells[6, 2], xlWorkSheet.Cells[6, 2]].BorderAround(Type.Missing, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing);

                xlWorkSheet.Cells[6, 3] = "Cargo";
                xlWorkSheet.Cells[6, 3].Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                xlWorkSheet.Cells[6, 3].Font.Bold = true;
                xlWorkSheet.Cells[6, 3].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightSteelBlue);
                xlWorkSheet.Range[xlWorkSheet.Cells[6, 3], xlWorkSheet.Cells[6, 3]].BorderAround(Type.Missing, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing);

                
                //Generando las Fechas            
                DataTable dtFechas = new DataTable();
                DataTable dtTipoServicio = new DataTable();
                DataTable dtComensales = new DataTable();
                DataTable dtAtenciones = new DataTable();

                // Generando Titulos
                
                int cFecha = dtFechas.Rows.Count;
                int iFecha = 4;                
                
                foreach (DataRow dtRow in dtFechas.Rows)
                {                    
                    xlWorkSheet.Cells[5, iFecha] = dtRow[0].ToString();
                    xlWorkSheet.Range[xlWorkSheet.Cells[5, iFecha], xlWorkSheet.Cells[5, iFecha + 2]].Merge();
                    xlWorkSheet.Cells[5, iFecha].Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    xlWorkSheet.Cells[5, iFecha].Font.Bold = true;
                    xlWorkSheet.Cells[5, iFecha].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
                    xlWorkSheet.Cells[5, iFecha].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.SteelBlue);
                    xlWorkSheet.Range[xlWorkSheet.Cells[5, iFecha], xlWorkSheet.Cells[5, iFecha + 2]].BorderAround(Type.Missing, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing);
                    iFecha = iFecha + 3;
                }

                
                                                                                                         
                //Fin Detalle
                
                aRange = xlWorkSheet.get_Range("A1", "DZ2000");
                aRange.Columns.AutoFit();
                hoja_exce = hoja_exce + 1;                                                
                releaseObject(xlWorkSheet);
                //Fin de Hoja    
                }

                                            
            Random rnd = new Random();
            int serie = rnd.Next(13102003,15072003);

            string nombre_reporte;
            nombre_reporte = "C:\\EMMA\\Reporte_Valorizacion_" + serie.ToString() + ".xlsx";

            //xlWorkBook.DoNotPromptForConvert = true;
            //xlWorkBook.SaveAs(nombre_reporte, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.SaveAs(nombre_reporte, Excel.XlFileFormat.xlOpenXMLWorkbook, Missing.Value,
                                 Missing.Value, false, false, Excel.XlSaveAsAccessMode.xlNoChange,
                                    Excel.XlSaveConflictResolution.xlUserResolution, true,
                                    Missing.Value, Missing.Value, Missing.Value);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
                        
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
            

            MessageBox.Show("El reporte ha sido generado, usted puede encontrar el archivo en la siguiente ruta c:\\csharp-Excel.xls");
        }            
                                
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProyectoBR oBRProyecto = new ProyectoBR();

            DataTable dt = new DataTable();

            DataRowView rv = cboCliente.SelectedItem as DataRowView;

            int oid_clie;

            oid_clie = Int32.Parse(rv["Codigo"].ToString());

            dt = oBRProyecto.ObtenerListadoPorCliente(oid_clie);
            cboProyecto.DataSource = dt;
            cboProyecto.DisplayMember = "Descripcion";
        }

        private void cboProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComedorAtencionBR oBRComedor = new ComedorAtencionBR();

            DataTable dt = new DataTable();

            DataRowView rv = cboProyecto.SelectedItem as DataRowView;

            int oid_proy;

            oid_proy = Int32.Parse(rv["Codigo"].ToString());

            dt = oBRComedor.ObtenerListadoPorProyecto(oid_proy);
            cboComedor.DataSource = dt;
            cboComedor.DisplayMember = "Descripcion";
        }

        
    }               
}

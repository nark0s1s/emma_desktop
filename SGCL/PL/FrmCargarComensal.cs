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
using EMMA.BE;

namespace SGCL.PL
{
    public partial class FrmCargarComensal : Form
    {
       
        public FrmCargarComensal()
        {
            InitializeComponent();

            CHelper oCHelper = new CHelper();
            oCHelper.FormatearFormularioMantenimiento(this);

            CargarClientes();
            CargarComedores();
        }
      
                                        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargarExcel_Click(object sender, EventArgs e)
        {
                       
            DialogResult result = openFileDialogExcel.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialogExcel.FileName;
                try
                {
                    txtArchivoExcel.Text = file;
                    
                }
                catch (IOException)
                {
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void CargarClientes()
        {

            try
            {
                ClienteBR oBRCliente = new ClienteBR();

                DataTable dt = new DataTable();

                dt = oBRCliente.ObtenerListadoPorProyecto(Global.oid_proy);
                cboCliente.DataSource = dt;
                cboCliente.DisplayMember = "Descripcion";
            }
            catch
            {
                cboCliente.DataSource = null;
            }
        }
                    
        private void CargarComedores()
        {
            
            try
            {
                ComedorAtencionBR oBRComedor = new ComedorAtencionBR();

                DataTable dt = new DataTable();

                int oid_proy;

                oid_proy = Global.oid_proy;
                dt = oBRComedor.ObtenerListadoPorProyecto(oid_proy);
                cboComedor.DataSource = dt;
                cboComedor.DisplayMember = "Descripcion";
            }
            catch
            {
                cboComedor.DataSource = null;                
            }
        }

        private void btnCargarExcel_Click_1(object sender, EventArgs e)
        {
            ComensalBR oComensalBR = new ComensalBR();
            
            int oid_proy = Global.oid_proy;

            DataRowView rvClie = cboCliente.SelectedItem as DataRowView;

            int oid_clie = Int32.Parse(rvClie["Codigo"].ToString());

            DataRowView rvCome = cboComedor.SelectedItem as DataRowView;

            int oid_come = Int32.Parse(rvCome["Codigo"].ToString());
           
            oComensalBR.CargarDesdeExcel(txtArchivoExcel.Text, oid_clie, oid_proy, oid_come);

            MessageBox.Show("Archivo Excel Cargado con Exito");
        }                                                           
    }               
}

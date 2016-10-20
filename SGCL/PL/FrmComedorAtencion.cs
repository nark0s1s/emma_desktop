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

namespace SGCL.PL
{
    public partial class FrmComedor : Form
    {

        private DataTable dt;
        public FrmComedor()
        {
            InitializeComponent();

            CHelper oCHelper = new CHelper();
            oCHelper.FormatearFormularioMantenimiento(this);
            oCHelper.FormatearDGVMantenimiento(dgv);
            txtBuscar.Focus();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmComedor_Load(object sender, EventArgs e)
        {
            CargarDGV();
            txtBuscar.Focus();

        }

        public void CargarDGV()
        {

            ComedorAtencionBR oComedorAtencionBR = new ComedorAtencionBR();
            
            dt = oComedorAtencionBR.ObtenerListado();
            dgv.DataSource = dt;
            dgv.Columns[0].Visible = false;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            int oid = new int();
            FrmComedorAdd oFrm = new FrmComedorAdd(this,oid,"C");
            oFrm.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
                        
            if (dgv.RowCount > 0)
            {

                int oid = new int();

                if (dgv.RowCount > 1)
                {
                    oid = int.Parse(dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString());
                }
                else
                {
                    oid = int.Parse(dgv.Rows[0].Cells[0].Value.ToString());
                }

                FrmComedorAdd oFrmAdd = new FrmComedorAdd(this,oid,"U");
                
                oFrmAdd.ShowDialog();
            }

            else
            {
                MessageBox.Show("Debe Seleccionar un Comedor");
            }
        }
        

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            ComedorAtencionBR oBR = new ComedorAtencionBR();

            if (dgv.RowCount > 0)
            {

                int oid = new int();

                if (dgv.RowCount > 1)
                {
                    oid = int.Parse(dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString());
                }
                else
                {
                    oid = int.Parse(dgv.Rows[0].Cells[0].Value.ToString());
                }

                oBR.Eliminar(oid);

                CargarDGV();

                MessageBox.Show("Comedor Eliminado");
            }

            else
            {
                MessageBox.Show("Debe Seleccionar un Comedor");
            }
        }



        private void btnConsultar_Click(object sender, EventArgs e)
        {

            if (dgv.RowCount > 0)
            {

                int oid = new int();

                if (dgv.RowCount > 1)
                {
                    oid = int.Parse(dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString());
                }
                else
                {
                    oid = int.Parse(dgv.Rows[0].Cells[0].Value.ToString());
                }

                FrmComedorAdd oFrmAdd = new FrmComedorAdd(this, oid,"R");

                oFrmAdd.ShowDialog();
            }

            else
            {
                MessageBox.Show("Debe Seleccionar un Comedor");
            }

        }        

        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = string.Format("descripcion LIKE '%{0}%'", txtBuscar.Text); 
        }
       
        
                
    }               
}

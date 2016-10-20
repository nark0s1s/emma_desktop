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
    public partial class FrmComedorTipoServicio : Form
    {

        private DataTable dt;
        public FrmComedorTipoServicio()
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

        private void FrmComedorTipoServicio_Load(object sender, EventArgs e)
        {
            CargarDGV();
            txtBuscar.Focus();

        }

        public void CargarDGV()
        {

            ComedorTipoServicioBR oComedorTipoServicioBR = new ComedorTipoServicioBR();
            
            dt = oComedorTipoServicioBR.ObtenerListado();
            dgv.DataSource = dt;
            dgv.Columns[0].Visible = false;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            int oid = new int();
            FrmComedorTipoServicioAdd oFrm = new FrmComedorTipoServicioAdd(this,oid,"C");
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

                FrmComedorTipoServicioAdd oFrmAdd = new FrmComedorTipoServicioAdd(this,oid,"U");
                
                oFrmAdd.ShowDialog();
            }

            else
            {
                MessageBox.Show("Debe Seleccionar un Comedor Tipo Servicio");
            }
        }
        

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            ComedorTipoServicioBR oBR = new ComedorTipoServicioBR();

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

                MessageBox.Show("Comedor Tipo Servicio Eliminado");
            }

            else
            {
                MessageBox.Show("Debe Seleccionar un Comedor Tipo Servicio");
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

                FrmComedorTipoServicioAdd oFrmAdd = new FrmComedorTipoServicioAdd(this, oid,"R");

                oFrmAdd.ShowDialog();
            }

            else
            {
                MessageBox.Show("Debe Seleccionar un Comedor Tipo Servicio");
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

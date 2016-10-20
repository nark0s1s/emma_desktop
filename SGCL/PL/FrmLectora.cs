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
    public partial class FrmLectora : Form
    {

        private DataTable dt;
        public FrmLectora()
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

        private void FrmLectora_Load(object sender, EventArgs e)
        {
            CargarDGV();
            txtBuscar.Focus();

        }

        public void CargarDGV()
        {

            LectoraBR oLectoraBR = new LectoraBR();
            
            dt = oLectoraBR.ObtenerListado();
            dgv.DataSource = dt;
            dgv.Columns[0].Visible = false;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            int oid = new int();
            FrmLectoraAdd oFrm = new FrmLectoraAdd(this,oid,"C");
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

                FrmLectoraAdd oFrmAdd = new FrmLectoraAdd(this,oid,"U");
                
                oFrmAdd.ShowDialog();
            }

            else
            {
                MessageBox.Show("Debe Seleccionar un Tipo de Documento de Identidad");
            }
        }
        

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            LectoraBR oBR = new LectoraBR();

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

                MessageBox.Show("Lectora Eliminado");
            }

            else
            {
                MessageBox.Show("Debe Seleccionar una Lectora");
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

                FrmLectoraAdd oFrmAdd = new FrmLectoraAdd(this, oid,"R");

                oFrmAdd.ShowDialog();
            }

            else
            {
                MessageBox.Show("Debe Seleccionar una Lectora");
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

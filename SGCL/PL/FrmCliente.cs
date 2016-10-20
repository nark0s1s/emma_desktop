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
    public partial class FrmCliente : Form
    {

        private DataTable dt;
        public FrmCliente()
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

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            CargarDGV();
            txtBuscar.Focus();

        }

        public void CargarDGV()
        {

            ClienteBR oClienteBR = new ClienteBR();
            
            dt = oClienteBR.ObtenerListado();
            dgv.DataSource = dt;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            int oid = new int();

            FrmClienteAdd oFrm = new FrmClienteAdd(this,oid,"C");
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

                FrmClienteAdd oFrmAdd = new FrmClienteAdd(this,oid,"U");
                
                oFrmAdd.ShowDialog();
            }

            else
            {
                MessageBox.Show("Debe Seleccionar un Tipo de Documento de Identidad");
            }
        }
        

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            ClienteBR oBR = new ClienteBR();

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

                MessageBox.Show("Tipo de Documento de Identidad Eliminado");
            }

            else
            {
                MessageBox.Show("Debe Seleccionar un Tipo de Documento de Identidads");
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

                FrmClienteAdd oFrmAdd = new FrmClienteAdd(this, oid,"R");

                oFrmAdd.ShowDialog();
            }

            else
            {
                MessageBox.Show("Debe Seleccionar un Tipo de Documento de Identidad");
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

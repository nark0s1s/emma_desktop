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
    public partial class FrmComensal : Form
    {

        private DataTable dt;
        public FrmComensal()
        {
            InitializeComponent();

            CHelper oCHelper = new CHelper();
            oCHelper.FormatearFormularioMantenimiento(this);
            oCHelper.FormatearDGVMantenimiento(dgv);
            //dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            txtBuscar.Focus();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmComensal_Load(object sender, EventArgs e)
        {
            CargarDGV();
            txtBuscar.Focus();

        }

        public void CargarDGV()
        {

            ComensalBR oComensalBR = new ComensalBR();
            
            dt = oComensalBR.ObtenerListado();            
            dgv.DataSource = dt;
            dgv.Columns[0].Visible = false;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            int oid = new int();

            FrmComensalAdd oFrm = new FrmComensalAdd(this,oid,"C");
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

                FrmComensalAdd oFrmAdd = new FrmComensalAdd(this,oid,"U");
                
                oFrmAdd.ShowDialog();
            }

            else
            {
                MessageBox.Show("Debe Seleccionar un Comensal");
            }
        }
        

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            ComensalBR oBR = new ComensalBR();

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

                MessageBox.Show("Comensal Eliminado");
            }

            else
            {
                MessageBox.Show("Debe Seleccionar un Comensal");
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

                FrmComensalAdd oFrmAdd = new FrmComensalAdd(this, oid,"R");

                oFrmAdd.ShowDialog();
            }

            else
            {
                MessageBox.Show("Debe Seleccionar un Comensal");
            }

        }        

        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = string.Format("Nombres_y_Apellidos LIKE '%{0}%'", txtBuscar.Text); 
        }
        
                
    }               
}

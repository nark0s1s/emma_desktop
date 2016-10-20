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
using EMMA.PL;
using EMMA.BE;

namespace SGCL.PL
{
    public partial class FrmComensalAdd : Form
    {

        private string mod;
        private int oid;
        private FrmComensal oFrm;

        public FrmComensalAdd()
        {
            InitializeComponent();

            //CHelper oCHelper = new CHelper();
            //oCHelper.FormatearDGVMantenimiento(dgvComedoresAtencion);
            dgvComedoresAtencion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //dgvComedoresAtencion.AllowUserToAddRows = false;
            //dgvComedoresAtencion.AllowUserToDeleteRows = false;
            //dgvComedoresAtencion.AllowUserToOrderColumns = true;
            dgvComedoresAtencion.ReadOnly = true;
            dgvComedoresAtencion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvComedoresAtencion.MultiSelect = false;
        }
        
        /*
        public FrmComensalAdd(FrmComensal p_oFrm): this()
        {
            this.oFrm = p_oFrm;            
            txtOid.Visible = false;

            txtOid.ReadOnly = false;
            txtDenoSoci.ReadOnly = false;

            this.mod = "C";
        }
        */

        public FrmComensalAdd(FrmComensal p_oFrm, int p_oid,string mod)
            : this()
        {
            this.oFrm = p_oFrm;
            this.oid = p_oid;
            this.mod = mod;

            CHelper oCHelper = new CHelper();
            oCHelper.FormatearFormularioMantenimientoAdd(this);

            txtProyecto.Text = Global.des_proy;

            ClienteBR oBRCliente = new ClienteBR();

            DataTable dt = new DataTable();
            dt = oBRCliente.ObtenerListadoPorProyecto(Global.oid_proy);
            cboCliente.DataSource = dt;
            cboCliente.DisplayMember = "Descripcion";

            TipoDocumentoIdentidadBR oBRTipo = new TipoDocumentoIdentidadBR();
            
            dt = oBRTipo.ObtenerListado();
            cboTipoDocuIden.DataSource = dt;
            cboTipoDocuIden.DisplayMember = "Descripcion";

            ComensalBR oBRComensal = new ComensalBR();

            dt = oBRComensal.ObtenerComedoresAtencion(p_oid);
            //dgvComedoresAtencion.DataSource = dt;

            int i = 0;
            foreach (DataRow dr in dt.Rows)
            {                
                    DataGridViewRow rowDGV = (DataGridViewRow)dgvComedoresAtencion.Rows[0].Clone();
                    rowDGV.Cells[0].Value = dr.Field<int>(0);
                    rowDGV.Cells[1].Value = dr.Field<string>(1);
                    dgvComedoresAtencion.Rows.Add(rowDGV);
                    i = 1 + 1;
                
            }                                                                 

            switch (this.mod)
            {

                case "C":

                    txtOid.Visible = true;

                    txtOid.ReadOnly = true;
                    txtDescripcion.ReadOnly = false;
                    txtNumeroIdentificacionComedor.ReadOnly = false;
                    txtCargo.ReadOnly = false;                    
                    break;

                case "U":

                    txtOid.Visible = true;

                    txtOid.ReadOnly = true;
                    txtDescripcion.ReadOnly = false;

                    ComensalBE oBE = new ComensalBE();
                    ComensalBR oBR = new ComensalBR();
                    
                    oBE = oBR.obtenerComensalByOid(oid);

                    txtOid.Text = oBE.oid_come.ToString();
                    
                    TipoDocumentoIdentidadBE oBETipoDocumento = new TipoDocumentoIdentidadBE();
                    TipoDocumentoIdentidadBR oBRTipoDocumento = new TipoDocumentoIdentidadBR();

                    oBETipoDocumento = oBRTipoDocumento.obtenerTipoDocumentoIdentidadByCod(oBE.tipo_cod_tipo_docu_iden);
                    cboTipoDocuIden.SelectedIndex = cboTipoDocuIden.FindStringExact(oBETipoDocumento.val_desc);
                   
                    txtNumeroIdentificacionComedor.Text = oBE.num_iden_come;
                    txtDescripcion.Text = oBE.val_desc;
                    txtNumDocuIden.Text = oBE.val_num_docu_iden;
                    txtCargo.Text = oBE.val_carg;
                    txtTipoCargo.Text = oBE.val_tipo_carg;                    
                                       
                    break;


                case "R":

                    txtOid.Visible = true;

                    txtOid.ReadOnly = true;
                    txtDescripcion.ReadOnly = true;
                    break;
            }           
        }

       
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            
            ComensalBE oBE = new ComensalBE();
            ComensalBR oBR = new ComensalBR();

            ComensalComedorBE oComeBE = new ComensalComedorBE();
            ComensalComedorBR oComeBR = new ComensalComedorBR();
           
            int oid_come_clie;

            /*
            oBE.num_iden_come = txtNumeroIdentificacionComedor.Text;            
            oBE.val_num_docu_iden = txtNumDocuIden.Text;

            if (this.mod == "C") {
                
            }

             */

            oBE.num_iden_come = txtNumeroIdentificacionComedor.Text;
            oBE.val_num_docu_iden = txtNumDocuIden.Text;
            
            oBE.val_desc = txtDescripcion.Text;
            oBE.val_carg = txtCargo.Text;
            oBE.val_tipo_carg = txtTipoCargo.Text;            
                        
            DataRowView rv = cboTipoDocuIden.SelectedItem as DataRowView;
            
            oBE.tipo_cod_tipo_docu_iden = rv["Codigo"].ToString();

            DataRowView rvClie = cboCliente.SelectedItem as DataRowView;

            oBE.clie_oid_clie = Int32.Parse(rvClie["Codigo"].ToString());

            oBE.proy_oid_proy = Global.oid_proy;
            
            if (mod == "C")
            {                
                oBR.Insertar(oBE);                                
            }
            else
            {
                oBE.oid_come = Int32.Parse(txtOid.Text);
                oBR.Actualizar(oBE);
            }

            oid_come_clie = oBR.ObtenerOidByDocumentoIdentidad(oBE.val_num_docu_iden);

            foreach (DataGridViewRow row in dgvComedoresAtencion.Rows)
            {
                if (row.Cells[0].Value != null)
                {

                    oComeBE.oid_come_aten = Int32.Parse(row.Cells[0].Value.ToString());
                    oComeBE.oid_come_clie = oid_come_clie;
                    oComeBE.clie_oid_clie = oBE.clie_oid_clie;
                    oComeBE.proy_oid_proy = oBE.proy_oid_proy;
                    
                    oComeBR.Insertar(oComeBE);
                }
            }
            
            oFrm.CargarDGV();

            this.Close();
                        
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboTipoDocuIden_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DataRowView rv = cboTipoDocuIden.SelectedItem as DataRowView;            
            
            /*
            if (rv["Codigo"].ToString() == "RUC")
            {
                
                txtDescripcion.Visible = true;                
                txtNumeroIdentificacion.Visible = false;
                txtCargo.Visible = false;
                //txtApe1.Visible = false;
                //txtApe2.Visible = false;
                
                txtIdentificacion.Visible = false;
                txtSegundoNombreLabel.Visible = false;
                //txtPrimerApellidoLabel.Visible = false;
                //txtSegundoApellidoLabel.Visible = false;

            }
            else {
                txtDescripcion.Visible = false;
                txtNumeroIdentificacion.Visible = true;
                txtCargo.Visible = true;                
                
                txtIdentificacion.Visible = true;
                txtSegundoNombreLabel.Visible = true;               

            }
            */
        }

       
        private void txtNumDocuIden_GotFocus(object sender, EventArgs e)
        {
            txtNumDocuIden.BackColor = Color.GreenYellow;
        }

        private void txtNumDocuIden_Leave(object sender, EventArgs e)
        {
            ComensalBR oBR = new ComensalBR();

            int ind_exis;

            ind_exis = oBR.ValidarDocumentoIdentidad(txtNumDocuIden.Text);

            if (ind_exis > 0) {
                MessageBox.Show("El numero de documento ya existe");
                txtNumeroIdentificacionComedor.BackColor = Color.White;
                txtNumDocuIden.Text = String.Empty;
                txtNumDocuIden.Focus();
            } else {
                txtNumDocuIden.BackColor = Color.White;
            }

            
        }

        private void txtNom1_GotFocus(object sender, EventArgs e)
        {
            txtNumeroIdentificacionComedor.BackColor = Color.GreenYellow;
        }

        private void txtNom1_Leave(object sender, EventArgs e)
        {
            txtNumeroIdentificacionComedor.BackColor = Color.White;
        }
        
        private void txtNom2_GotFocus(object sender, EventArgs e)
        {
            txtCargo.BackColor = Color.GreenYellow;
        }

        private void txtNom2_Leave(object sender, EventArgs e)
        {
            txtCargo.BackColor = Color.White;
        }

        
        private void txtDenoSoci_GotFocus(object sender, EventArgs e)
        {
            txtDescripcion.BackColor = Color.GreenYellow;
        }

        private void txtDenoSoci_Leave(object sender, EventArgs e)
        {
            txtDescripcion.BackColor = Color.White;
        }

        

        


        private void txtNumeroIdentificacionComedor_GotFocus(object sender, EventArgs e)
        {
            txtNumeroIdentificacionComedor.BackColor = Color.GreenYellow;
        }

        private void txtNumeroIdentificacionComedor_Leave(object sender, EventArgs e)
        {
            ComensalBR oBR = new ComensalBR();

            int ind_exis;

            ind_exis = oBR.ValidarIdentificacionComedor(txtNumeroIdentificacionComedor.Text);

            if (ind_exis > 0)
            {
                MessageBox.Show("El numero de identificacion en comedor ya existe");
                //txtNumeroIdentificacionComedor.BackColor = Color.White;
                txtNumeroIdentificacionComedor.Text = String.Empty;
                txtNumeroIdentificacionComedor.Focus();
            }
            else
            {
                txtNumeroIdentificacionComedor.BackColor = Color.White;
            }
            

            
        }

        private void txtDescripcion_GotFocus(object sender, EventArgs e)
        {
            txtDescripcion.BackColor = Color.GreenYellow;
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            txtDescripcion.BackColor = Color.White;
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTipoCargo_GotFocus(object sender, EventArgs e)
        {
            txtTipoCargo.BackColor = Color.GreenYellow;
        }

        private void txtTipoCargo_Leave(object sender, EventArgs e)
        {
            txtTipoCargo.BackColor = Color.White;
        }

        

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            

            int proy_oid_proy;

            proy_oid_proy = Global.oid_proy;

            FrmComensalComedorAtencionAdd oFrm = new FrmComensalComedorAtencionAdd(this,proy_oid_proy);
            oFrm.ShowDialog();
        }

        public void AgregarComedor(int oid_come_aten,String val_desc_come){

            int ind_exis = 0;

            if (dgvComedoresAtencion.Rows.Count <= 1)
            {
                DataGridViewRow rowNuevo = (DataGridViewRow)dgvComedoresAtencion.Rows[0].Clone();
                rowNuevo.Cells[0].Value = oid_come_aten;
                rowNuevo.Cells[1].Value = val_desc_come;
                dgvComedoresAtencion.Rows.Add(rowNuevo);
            }
            else
            {

                ind_exis = 0;

                foreach (DataGridViewRow rowSearch in dgvComedoresAtencion.Rows)
                {
                    if (rowSearch.Cells[0].Value != null) {

                        if (rowSearch.Cells[0].Value.ToString().Equals(oid_come_aten.ToString()))
                        {
                            MessageBox.Show("Comedor ya registrado");
                            ind_exis = 1;
                            break;
                        }                                                                           
                    }
                                                                                                        
                }

                if (ind_exis == 0) {
                DataGridViewRow row = (DataGridViewRow)dgvComedoresAtencion.Rows[0].Clone();
                row.Cells[0].Value = oid_come_aten;
                row.Cells[1].Value = val_desc_come;
                dgvComedoresAtencion.Rows.Add(row);
                }
            }

            
        }

        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvComedoresAtencion.RowCount > 0)
            {
                dgvComedoresAtencion.Rows.RemoveAt(this.dgvComedoresAtencion.SelectedRows[0].Index);

                if (mod == "U")
                {
                    ComensalComedorBR oBRCome = new ComensalComedorBR();                    
                    oBRCome.Eliminar(oid,int.Parse(dgvComedoresAtencion.Rows[dgvComedoresAtencion.SelectedRows[0].Index].Cells[0].Value.ToString()));
                }
            }

        }
                                                        
    }
}

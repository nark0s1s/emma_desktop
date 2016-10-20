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
    public partial class FrmProyectoAdd : Form
    {

        private string mod;
        private int oid;
        private FrmProyecto oFrm;

        public FrmProyectoAdd()
        {
            InitializeComponent();            
        }
        
        /*
        public FrmProyectoAdd(FrmProyecto p_oFrm): this()
        {
            this.oFrm = p_oFrm;            
            txtOid.Visible = false;

            txtOid.ReadOnly = false;
            txtDescripcion.ReadOnly = false;

            this.mod = "C";
        }
        */
          
        public FrmProyectoAdd(FrmProyecto p_oFrm, int p_oid,string mod)
            : this()
        {
            this.oFrm = p_oFrm;
            this.oid = p_oid;
            this.mod = mod;

            CHelper oCHelper = new CHelper();
            oCHelper.FormatearFormularioMantenimientoAdd(this);

            ClienteBR oBRCliente = new ClienteBR();

            DataTable dt = new DataTable();

            dt = oBRCliente.ObtenerListadoCombo();
            cboCliente.DataSource = dt;
            cboCliente.DisplayMember = "Descripcion";

            switch (this.mod)
            {

                case "C":

                    txtOid.Visible = true;

                    txtOid.ReadOnly = true;
                    txtDescripcion.ReadOnly = false;
                    txtDepartamento.ReadOnly = false;
                    txtProvincia.ReadOnly = false;
                    txtDistrito.ReadOnly = false; 
                   
                    break;

                case "U":

                    txtOid.Visible = true;

                    txtOid.ReadOnly = true;
                    txtDescripcion.ReadOnly = false;
                    txtDepartamento.ReadOnly = false;
                    txtProvincia.ReadOnly = false;
                    txtDistrito.ReadOnly = false;

                    ClienteBE oBE = new ClienteBE();
                    ClienteBR oBR = new ClienteBR();

                    TipoDocumentoIdentidadBE oBETipoDocumento = new TipoDocumentoIdentidadBE();
                    TipoDocumentoIdentidadBR oBRTipoDocumento = new TipoDocumentoIdentidadBR();

                    oBE = oBR.obtenerClienteByOid(oid);
                    
                    txtOid.Text = oBE.oid_clie.ToString();
                    txtDescripcion.Text = oBE.val_deno_soci;
                    
                    /*
                    txtNumDocuIden.Text = oBE.val_nume_docu_iden;
                    
                    txtNom1.Text = oBE.val_nom1;
                    txtNom2.Text = oBE.val_nom2;
                    txtApe1.Text = oBE.val_ape1;
                    txtApe2.Text = oBE.val_ape2;

                    oBETipoDocumento = oBRTipoDocumento.obtenerTipoDocumentoIdentidadByCod(oBE.tipo_cod_tipo_docu_iden);
                    cboTipoDocuIden.SelectedIndex = cboTipoDocuIden.FindStringExact(oBETipoDocumento.val_desc);
                    */ 
                    break;


                case "R":

                    txtOid.Visible = true;

                    txtOid.ReadOnly = true;
                    txtDescripcion.ReadOnly = true;
                    txtDepartamento.ReadOnly = true;
                    txtProvincia.ReadOnly = true;
                    txtDistrito.ReadOnly = true;
                    break;
            }           
                        
        }

        
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            
            ProyectoBE oBE = new ProyectoBE();
            ProyectoBR oBR = new ProyectoBR();
            
            oBE.val_desc = txtDescripcion.Text;

            DataRowView rv = cboCliente.SelectedItem as DataRowView;

            oBE.clie_oid_clie = Int32.Parse(rv["Codigo"].ToString()); 

            if (mod == "C")
            {                
                oBR.Insertar(oBE);
            }
            else
            {
                oBE.oid_proy = Int32.Parse(txtOid.Text);
                oBR.Actualizar(oBE);
            }

            
            oFrm.CargarDGV();

            this.Close();
                        
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDescripcion_GotFocus(object sender, EventArgs e)
        {
            txtDescripcion.BackColor = Color.GreenYellow;
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            txtDescripcion.BackColor = Color.White;
        }
      
        private void txtDepartamento_GotFocus(object sender, EventArgs e)
        {
            txtDepartamento.BackColor = Color.GreenYellow;
        }

        private void txtDepartamento_Leave(object sender, EventArgs e)
        {
            txtDepartamento.BackColor = Color.White;
        }

        private void txtProvincia_GotFocus(object sender, EventArgs e)
        {
            txtProvincia.BackColor = Color.GreenYellow;
        }

        private void txtProvincia_Leave(object sender, EventArgs e)
        {
            txtProvincia.BackColor = Color.White;
        }

        private void txtDistrito_GotFocus(object sender, EventArgs e)
        {
            txtDistrito.BackColor = Color.GreenYellow;
        }

        private void txtDistrito_Leave(object sender, EventArgs e)
        {
            txtDistrito.BackColor = Color.White;
        }
                                              
    }
}

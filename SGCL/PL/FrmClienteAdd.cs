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
    public partial class FrmClienteAdd : Form
    {

        private string mod;
        private int oid;
        private FrmCliente oFrm;

        public FrmClienteAdd()
        {
            InitializeComponent();            

        }
        
        /*
        public FrmClienteAdd(FrmCliente p_oFrm): this()
        {
            this.oFrm = p_oFrm;            
            txtOid.Visible = false;

            txtOid.ReadOnly = false;
            txtDenoSoci.ReadOnly = false;

            this.mod = "C";
        }
        */

        public FrmClienteAdd(FrmCliente p_oFrm, int p_oid,string mod)
            : this()
        {
            this.oFrm = p_oFrm;
            this.oid = p_oid;
            this.mod = mod;

            CHelper oCHelper = new CHelper();
            oCHelper.FormatearFormularioMantenimientoAdd(this);

            TipoDocumentoIdentidadBR oBRTipo = new TipoDocumentoIdentidadBR();

            DataTable dt = new DataTable();

            dt = oBRTipo.ObtenerListado();
            cboTipoDocuIden.DataSource = dt;
            cboTipoDocuIden.DisplayMember = "Descripcion";

            switch (this.mod)
            {

                case "C":

                    //txtOid.Visible = true;

                    //txtOid.ReadOnly = true;
                    txtDenoSoci.ReadOnly = false;
                    txtNom1.ReadOnly = false;
                    txtNom2.ReadOnly = false;
                    txtApe1.ReadOnly = false;
                    txtApe2.ReadOnly = false;
                    break;

                case "U":

                    //txtOid.Visible = true;

                    //txtOid.ReadOnly = true;
                    txtDenoSoci.ReadOnly = false;

                    ClienteBE oBE = new ClienteBE();
                    ClienteBR oBR = new ClienteBR();

                    TipoDocumentoIdentidadBE oBETipoDocumento = new TipoDocumentoIdentidadBE();
                    TipoDocumentoIdentidadBR oBRTipoDocumento = new TipoDocumentoIdentidadBR();

                    oBE = oBR.obtenerClienteByOid(oid);

                    txtOid.Text = oBE.oid_clie.ToString();
                    txtDenoSoci.Text = oBE.val_deno_soci;
                    txtNumDocuIden.Text = oBE.val_nume_docu_iden;
                    txtNom1.Text = oBE.val_nom1;
                    txtNom2.Text = oBE.val_nom2;
                    txtApe1.Text = oBE.val_ape1;
                    txtApe2.Text = oBE.val_ape2;

                    oBETipoDocumento = oBRTipoDocumento.obtenerTipoDocumentoIdentidadByCod(oBE.tipo_cod_tipo_docu_iden);
                    cboTipoDocuIden.SelectedIndex = cboTipoDocuIden.FindStringExact(oBETipoDocumento.val_desc);
                    break;


                case "R":

                    txtOid.Visible = true;

                    txtOid.ReadOnly = true;
                    txtDenoSoci.ReadOnly = true;
                    break;
            }           
        }

       
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            
            ClienteBE oBE = new ClienteBE();
            ClienteBR oBR = new ClienteBR();

            oBE.proy_oid_proy = EMMA.BE.Global.oid_proy;
            oBE.val_deno_soci = txtDenoSoci.Text;
            oBE.val_nom1 = txtNom1.Text;
            oBE.val_nom2 = txtNom2.Text;
            oBE.val_ape1 = txtApe1.Text;
            oBE.val_ape2 = txtApe2.Text;
            oBE.val_nume_docu_iden = txtNumDocuIden.Text;

            DataRowView rv = cboTipoDocuIden.SelectedItem as DataRowView;
            
            oBE.tipo_cod_tipo_docu_iden = rv["Codigo"].ToString(); 

            if (mod == "C")
            {                
                oBR.Insertar(oBE);
            }
            else
            {
                oBE.oid_clie = Int32.Parse(txtOid.Text);
                oBR.Actualizar(oBE);
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
            
            if (rv["Codigo"].ToString() == "RUC")
            {
                
                txtDenoSoci.Visible = true;                
                txtNom1.Visible = false;
                txtNom2.Visible = false;
                txtApe1.Visible = false;
                txtApe2.Visible = false;

                txtRazonSocialLabel.Visible = true;
                txtPrimerNombreLabel.Visible = false;
                txtSegundoNombreLabel.Visible = false;
                txtPrimerApellidoLabel.Visible = false;
                txtSegundoApellidoLabel.Visible = false;

            }
            else {
                txtDenoSoci.Visible = false;
                txtNom1.Visible = true;
                txtNom2.Visible = true;
                txtApe1.Visible = true;
                txtApe2.Visible = true;

                txtRazonSocialLabel.Visible = false;
                txtPrimerNombreLabel.Visible = true;
                txtSegundoNombreLabel.Visible = true;
                txtPrimerApellidoLabel.Visible = true;
                txtSegundoApellidoLabel.Visible = true;

            }
          
        }

       
        private void txtNumDocuIden_GotFocus(object sender, EventArgs e)
        {
            txtNumDocuIden.BackColor = Color.GreenYellow;
        }

        private void txtNumDocuIden_Leave(object sender, EventArgs e)
        {
            txtNumDocuIden.BackColor = Color.White;
        }

        private void txtNom1_GotFocus(object sender, EventArgs e)
        {
            txtNom1.BackColor = Color.GreenYellow;
        }

        private void txtNom1_Leave(object sender, EventArgs e)
        {
            txtNom1.BackColor = Color.White;
        }
        
        private void txtNom2_GotFocus(object sender, EventArgs e)
        {
            txtNom2.BackColor = Color.GreenYellow;
        }

        private void txtNom2_Leave(object sender, EventArgs e)
        {
            txtNom2.BackColor = Color.White;
        }

        private void txtApe1_GotFocus(object sender, EventArgs e)
        {
            txtApe1.BackColor = Color.GreenYellow;
        }

        private void txtApe1_Leave(object sender, EventArgs e)
        {
            txtApe1.BackColor = Color.White;
        }

        private void txtApe2_GotFocus(object sender, EventArgs e)
        {
            txtApe2.BackColor = Color.GreenYellow;
        }

        private void txtApe2_Leave(object sender, EventArgs e)
        {
            txtApe2.BackColor = Color.White;
        }

        private void txtDenoSoci_GotFocus(object sender, EventArgs e)
        {
            txtDenoSoci.BackColor = Color.GreenYellow;
        }

        private void txtDenoSoci_Leave(object sender, EventArgs e)
        {
            txtDenoSoci.BackColor = Color.White;
        }
    
    }
}

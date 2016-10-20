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
    public partial class FrmTipoDocumentoIdentidadAdd : Form
    {

        private string mod;
        private string cod;
        private FrmTipoDocumentoIdentidad oFrm;

        public FrmTipoDocumentoIdentidadAdd()
        {
            InitializeComponent();
            CHelper oCHelper = new CHelper();
            oCHelper.FormatearFormularioMantenimientoAdd(this);
        }
        
        public FrmTipoDocumentoIdentidadAdd(FrmTipoDocumentoIdentidad p_oFrm): this()
        {
            this.oFrm = p_oFrm;
            txtCodigoLabel.Visible = true;
            txtOid.Visible = true;            

            txtOid.ReadOnly = false;
            txtDescripcion.ReadOnly = false;
            
            this.mod = "C";
        }

        public FrmTipoDocumentoIdentidadAdd(FrmTipoDocumentoIdentidad p_oFrm, string p_cod,string mod)
            : this()
        {
            this.oFrm = p_oFrm;
            this.cod = p_cod;
            this.mod = mod;            

            if (this.mod == "U")
            {                
                txtCodigoLabel.Visible = true;
                txtOid.Visible = true;

                txtOid.ReadOnly = true;
                txtDescripcion.ReadOnly = false;
            }
            else {


                txtCodigoLabel.Visible = true;
                txtOid.Visible = true;

                txtOid.ReadOnly = true;
                txtDescripcion.ReadOnly = true;
            }
                        
        }

        private void FrmTipoDocumentoIdentidadAdd_Load(object sender, EventArgs e)
        {

            TipoDocumentoIdentidadBE oBE = new TipoDocumentoIdentidadBE();
            TipoDocumentoIdentidadBR oBR = new TipoDocumentoIdentidadBR();

            oBE = oBR.obtenerTipoDocumentoIdentidadByCod(cod);

            txtOid.Text = oBE.cod_tipo_docu_iden.ToString();
            txtDescripcion.Text = oBE.val_desc;

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            
            TipoDocumentoIdentidadBE oBE = new TipoDocumentoIdentidadBE();
            TipoDocumentoIdentidadBR oBR = new TipoDocumentoIdentidadBR();

            oBE.cod_tipo_docu_iden = txtOid.Text;
            oBE.val_desc = txtDescripcion.Text;

            if (mod == "C")
            {                
                oBR.Insertar(oBE);
            }
            else
            {
                oBE.cod_tipo_docu_iden = txtOid.Text;
                oBR.Actualizar(oBE);
            }

            
            oFrm.CargarDGV();

            this.Close();
                        
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
        private void txtOid_GotFocus(object sender, EventArgs e)
        {
            txtOid.BackColor = Color.GreenYellow;
        }

        private void txtOid_Leave(object sender, EventArgs e)
        {
            txtOid.BackColor = Color.White;
        }

        private void txtDescripcion_GotFocus(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.GreenYellow;
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }
        
      
    }
}

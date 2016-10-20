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
    public partial class FrmTipoServicioComedorAdd : Form
    {

        private string mod;
        private string cod;
        private FrmTipoServicioComedor oFrm;

        public FrmTipoServicioComedorAdd()
        {
            InitializeComponent();
            CHelper oCHelper = new CHelper();
            oCHelper.FormatearFormularioMantenimientoAdd(this);
        }
        
        public FrmTipoServicioComedorAdd(FrmTipoServicioComedor p_oFrm): this()
        {
            this.oFrm = p_oFrm;
            txtCodigoLabel.Visible = true;
            txtOid.Visible = true;            

            txtOid.ReadOnly = false;
            txtDescripcion.ReadOnly = false;
            
            this.mod = "C";
        }

        public FrmTipoServicioComedorAdd(FrmTipoServicioComedor p_oFrm, string p_cod,string mod)
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

        private void FrmTipoServicioComedorAdd_Load(object sender, EventArgs e)
        {

            TipoServicioComedorBE oBE = new TipoServicioComedorBE();
            TipoServicioComedorBR oBR = new TipoServicioComedorBR();
            
            oBE = oBR.obtenerTipoServicioComedorByCod(cod);
           
            txtOid.Text = oBE.cod_tipo_docu_iden.ToString();
            txtDescripcion.Text = oBE.val_desc;

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            
            TipoServicioComedorBE oBE = new TipoServicioComedorBE();
            TipoServicioComedorBR oBR = new TipoServicioComedorBR();

            oBE.cod_tipo_docu_iden = txtOid.Text;
            oBE.val_desc = txtDescripcion.Text;
            oBE.num_orde_repo = Int32.Parse(txtOrdenReporte.Text);

            if (rbtActivo.Checked == true)
            {
                oBE.ind_acti = 1;
            }
            else
            {
                oBE.ind_acti = 0;
            }

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

        
        private void txtOrdenReporte_GotFocus(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.GreenYellow;
        }

        private void txtOrdenReporte_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }
        
        
      
    }
}

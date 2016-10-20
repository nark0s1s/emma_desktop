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
using EMMA.BE;

namespace SGCL.PL
{
    public partial class FrmComedorAdd : Form
    {

        private string mod;
        private int oid;
        private FrmComedor oFrm;

        public FrmComedorAdd()
        {
            InitializeComponent();            
        }
        
        /*
        public FrmComedorAdd(FrmComedor p_oFrm): this()
        {
            this.oFrm = p_oFrm;            
            txtOid.Visible = false;

            txtOid.ReadOnly = false;
            txtDescripcion.ReadOnly = false;

            this.mod = "C";
        }
        */
          
        public FrmComedorAdd(FrmComedor p_oFrm, int p_oid,string mod)
            : this()
        {
            this.oFrm = p_oFrm;
            this.oid = p_oid;
            this.mod = mod;

            CHelper oCHelper = new CHelper();
            oCHelper.FormatearFormularioMantenimientoAdd(this);
                                    
            switch (this.mod)
            {

                case "C":

                    txtOid.Visible = true;

                    txtOid.ReadOnly = true;
                    txtDescripcion.ReadOnly = false;

                    txtProyecto.Text = Global.des_proy;

                    break;

                case "U":

                    txtOid.Visible = true;

                    txtOid.ReadOnly = true;
                    txtDescripcion.ReadOnly = false;

                    txtProyecto.Text = Global.des_proy;
                                        
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
            
            ComedorAtencionBE oBE = new ComedorAtencionBE();
            ComedorAtencionBR oBR = new ComedorAtencionBR();

            oBE.proy_oid_proy = Global.oid_proy;

            oBE.val_desc = txtDescripcion.Text;

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
                oBE.oid_come_aten = Int32.Parse(txtOid.Text);
                oBR.Actualizar(oBE);
            }

            
            oFrm.CargarDGV();

            this.Close();
                        
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        private void txtDescripcion_GotFocus(object sender, EventArgs e)
        {
            txtDescripcion.BackColor = Color.GreenYellow;
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            txtDescripcion.BackColor = Color.White;
        }
                                     
    }
}

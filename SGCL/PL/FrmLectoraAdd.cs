﻿using System;
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
    public partial class FrmLectoraAdd : Form
    {

        private string mod;
        private int oid;
        private FrmLectora oFrm;

        public FrmLectoraAdd()
        {
            InitializeComponent();            
        }
        
        /*
        public FrmLectoraAdd(FrmLectora p_oFrm): this()
        {
            this.oFrm = p_oFrm;            
            txtOid.Visible = false;

            txtOid.ReadOnly = false;
            txtDescripcion.ReadOnly = false;

            this.mod = "C";
        }
        */
          
        public FrmLectoraAdd(FrmLectora p_oFrm, int p_oid,string mod)
            : this()
        {
            this.oFrm = p_oFrm;
            this.oid = p_oid;
            this.mod = mod;

            CHelper oCHelper = new CHelper();
            oCHelper.FormatearFormularioMantenimientoAdd(this);

            txtProyecto.Text = Global.des_proy;

            DataTable dt = new DataTable();

            ComedorAtencionBR oComedorAtencionBR = new ComedorAtencionBR();

            dt = oComedorAtencionBR.ObtenerListadoPorProyecto(Global.oid_proy);
            cboComedor.DataSource = dt;
            cboComedor.DisplayMember = "Descripcion";

            ComboBoxItem itemActivo = new ComboBoxItem();
            itemActivo.Text = "Activo";
            itemActivo.Value = 1;
            cboEstado.Items.Add(itemActivo);

            ComboBoxItem itemInactivo = new ComboBoxItem();
            itemInactivo.Text = "Inactivo";
            itemInactivo.Value = 0;
            cboEstado.Items.Add(itemInactivo);

            cboEstado.SelectedIndex = 0;
            
            switch (this.mod)
            {

                case "C":

                    txtOid.Visible = true;

                    txtOid.ReadOnly = true;
                    txtDescripcion.ReadOnly = false;                    
                   
                    break;

                case "U":

                    txtOid.Visible = true;

                    txtOid.ReadOnly = true;
                    txtDescripcion.ReadOnly = false;                    
                    
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
            
            LectoraBE oBE = new LectoraBE();
            LectoraBR oBR = new LectoraBR();
            
            oBE.val_desc = txtDescripcion.Text;

            oBE.proy_oid_proy = Global.oid_proy;

            DataRowView rvCome = cboComedor.SelectedItem as DataRowView;

            oBE.come_oid_come_aten = Int32.Parse(rvCome["Codigo"].ToString());

            if ((cboEstado.SelectedItem as ComboBoxItem).Value.ToString() == "1")
            {
                oBE.ind_acti = 1;
            }
            else
            {
                oBE.ind_acti = 0;
            };

            if (mod == "C")
            {                
                oBR.Insertar(oBE);
            }
            else
            {
                oBE.oid_lect = Int32.Parse(txtOid.Text);
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGCL.BR;
using EMMA.BR;
using SGCL;
using SGCL.PL;
using EMMA.BE;

namespace EMMA.PL
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            txtUsuario.Focus();
        }
        
             
        private void btnAceptar_Click(object sender, EventArgs e)
        {
                                               
            string val_resu;
            string des_usua;
            int oid_usua;

            DataRowView rv = cboProyecto.SelectedItem as DataRowView;
            int lv_oid_proy = Int32.Parse(rv["Codigo"].ToString());

            UsuarioBR oBR = new UsuarioBR();
            oBR.ValidarLogin(txtUsuario.Text, txtClave.Text, lv_oid_proy, out val_resu, out oid_usua, out des_usua);

            if (val_resu == String.Empty)
            {

                Global.oid_proy = lv_oid_proy;
                Global.des_proy = rv["Descripcion"].ToString();
                /*
                Global.oid_caja = lv_oid_caja;
                Global.NombreCaja = rv["Descripcion"].ToString();
                Global.OidUsuario = oid_usua;
                Global.NombreUsuario = des_usua;
                */

                this.Hide();

                FrmPrincipal oFrmPrincipal = new FrmPrincipal();
                oFrmPrincipal.ShowDialog();
                
                this.Close();
             
            }
            else
            {
                MessageBox.Show(val_resu);
            }                           

        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {            
            DataTable dt = new DataTable();
            ProyectoBR oBRProyecto = new ProyectoBR();
            
            string cod_usua;
            string des_usua;
            cod_usua = txtUsuario.Text;
            
            dt = oBRProyecto.ObtenerListadoPorUsuario(cod_usua,out des_usua);

            if (des_usua == "OK") {
                cboProyecto.DataSource = dt;
                cboProyecto.DisplayMember = "Descripcion";
            }
            else {
               MessageBox.Show(des_usua);
               txtUsuario.Focus();
            }                        

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}

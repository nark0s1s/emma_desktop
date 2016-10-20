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
    public partial class FrmTurnoAdd : Form
    {

        private string mod;
        private int oid;
        private FrmTurno oFrm;

        public FrmTurnoAdd()
        {
            InitializeComponent();
            
        }
        
        /*
        public FrmTurnoAdd(FrmTurno p_oFrm): this()
        {
            this.oFrm = p_oFrm;            
            txtOid.Visible = false;

            txtOid.ReadOnly = false;
            txtDescripcion.ReadOnly = false;

            this.mod = "C";
        }
        */
          
        public FrmTurnoAdd(FrmTurno p_oFrm, int p_oid,string mod)
            : this()
        {
            this.oFrm = p_oFrm;
            this.oid = p_oid;
            this.mod = mod;

            CHelper oCHelper = new CHelper();
            oCHelper.FormatearFormularioMantenimientoAdd(this);

            txtProyecto.Text = Global.des_proy;
                       
            switch (this.mod)
            {

                case "C":

                    txtOid.Visible = true;

                    txtOid.ReadOnly = true;
                    //dtpFecha.ReadOnly = false;    

                    ComedorAtencionBR oBRComedorAtencion = new ComedorAtencionBR();

                    DataTable dt = new DataTable();

                    dt = oBRComedorAtencion.ObtenerListadoPorProyecto(Global.oid_proy);
                    cboComedor.DataSource = dt;
                    cboComedor.DisplayMember = "Descripcion";

                   
                    break;

                case "U":

                    txtOid.Visible = true;

                    txtOid.ReadOnly = true;
                    //dtpFecha.ReadOnly = false;                    

                    ClienteBE oBE = new ClienteBE();
                    ClienteBR oBR = new ClienteBR();

                    TipoDocumentoIdentidadBE oBETipoDocumento = new TipoDocumentoIdentidadBE();
                    TipoDocumentoIdentidadBR oBRTipoDocumento = new TipoDocumentoIdentidadBR();

                    oBE = oBR.obtenerClienteByOid(oid);
                    /*
                    txtOid.Text = oBE.oid_clie.ToString();
                    txtDenoSoci.Text = oBE.val_deno_soci;
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
                    //txtDescripcion.ReadOnly = true;                    
                    break;
            }           
                        
        }

        
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            
            TurnoBE oBE = new TurnoBE();
            TurnoBR oBR = new TurnoBR();

            oBE.proy_oid_proy = Global.oid_proy;

            DataRowView rvCome = cboComedor.SelectedItem as DataRowView;

            oBE.come_oid_come = Int32.Parse(rvCome["Codigo"].ToString());

            DataRowView rvTipoServ = cboTipoServicio.SelectedItem as DataRowView;

            oBE.tise_cod_tipo_serv = rvTipoServ["Codigo"].ToString();

            DataRowView rvLect = cboLectora.SelectedItem as DataRowView;

            oBE.lect_oid_lect = Int32.Parse(rvLect["Codigo"].ToString());
           
            oBE.val_fech = dtpFecha.Value.Date.ToString("dd/MM/yyyy");

            int ind_vali;

            ind_vali = oBR.ValidarTurno(oBE);

            
            if (ind_vali == 0)
            {
                if (mod == "C")
                {
                    oBR.Insertar(oBE);
                }
                else
                {
                    oBE.oid_turn = Int32.Parse(txtOid.Text);
                    //oBR.Actualizar(oBE);
                }

                oFrm.CargarDGV();

                this.Close();
            }
            else
            {
                MessageBox.Show("El Turno ya ha sido creado",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
            }            
            
                        
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        /*
        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProyectoBR oBRProyecto = new ProyectoBR();

            DataTable dt = new DataTable();

            DataRowView rv = cboCliente.SelectedItem as DataRowView;

            int oid_clie;

            oid_clie = Int32.Parse(rv["Codigo"].ToString());

            dt = oBRProyecto.ObtenerListadoPorCliente(oid_clie);
            cboProyecto.DataSource = dt;
            cboProyecto.DisplayMember = "Descripcion";

        }
        */
        
        private void cboComedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            LectoraBR oBRLectora = new LectoraBR();

            DataTable dt = new DataTable();

            DataRowView rv = cboComedor.SelectedItem as DataRowView;

            int oid_come;

            oid_come = Int32.Parse(rv["Codigo"].ToString());

            dt = oBRLectora.ObtenerListadoPorComedor(oid_come);
            cboLectora.DataSource = dt;
            cboLectora.DisplayMember = "Descripcion";

            TipoServicioComedorBR oBRTipoServicioComedor = new TipoServicioComedorBR();

            DataTable dts = new DataTable();

            dts = oBRTipoServicioComedor.ObtenerListadoPorComedor(oid_come);
            cboTipoServicio.DataSource = dts;
            cboTipoServicio.DisplayMember = "Descripcion";


        }
                              
    }
}

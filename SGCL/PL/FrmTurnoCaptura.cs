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
//using SGCL.PL;
using EMMA.PL;
using EMMA.BE;

namespace SGCL.PL
{
    public partial class FrmTurnoCaptura : Form
    {
        
        private int oid_turn;
        private int come_oid_come;
        private FrmTurno oFrm;
        private DataTable dt;

        public FrmTurnoCaptura()
        {
            InitializeComponent();            
        }
                         
        public FrmTurnoCaptura(FrmTurno p_oFrm, int p_oid, int p_come_oid_come,string p_val_desc_come,string p_val_desc_tipo_serv,string p_val_fech)
            : this()
        {
            this.oFrm = p_oFrm;
            this.oid_turn = p_oid;
            this.come_oid_come = p_come_oid_come;

            CHelper oCHelper = new CHelper();
            oCHelper.FormatearFormularioMantenimientoAdd(this);
            oCHelper.FormatearDGVMantenimiento(dgv);
                                               
                                
            txtComedor.Text  = p_val_desc_come;
            txtTipoServicio.Text = p_val_desc_tipo_serv;
            dtpFecha.Text = p_val_fech;
            
            CargarDGV();

            txtIdentificacion.Focus();

        }
       

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            
            TurnoBE oBE = new TurnoBE();
            TurnoBR oBR = new TurnoBR();
            
            //oBE.val_fech = txtDescripcion.Text;
                        
            //MessageBox.Show(dtpFecha.Value.Date.ToString("dd/MM/yyyy"));

            oBE.val_fech = dtpFecha.Value.Date.ToString("dd/MM/yyyy");

            
            oBR.Insertar(oBE);                        

            oFrm.CargarDGV();

            this.Close();
                        
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIdentificacion_KeyDown(object sender, KeyEventArgs e)
        {

            if (txtIdentificacion.Text == String.Empty)
            {
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {

                    ComensalBR oBR = new ComensalBR();
                    string nombre;
                    string num_iden_come;
                    num_iden_come = txtIdentificacion.Text;

                    //MessageBox.Show(num_iden_come);
                    //MessageBox.Show(come_oid_come.ToString());

                    nombre = oBR.ObtenerNombreByIdentificador(num_iden_come, come_oid_come);

                    if (nombre != "NE")
                    {

                        txtNombre.Text = nombre;

                        int oid_come_clie;

                        oid_come_clie = oBR.ObtenerOidByIdentificador(num_iden_come, come_oid_come);

                        TurnoDetalleBE oBETurnoDetalle = new TurnoDetalleBE();
                        TurnoDetalleBR oBRTurnoDetalle = new TurnoDetalleBR();

                        // Validando si ya ingreso al comedor
                        oBETurnoDetalle.turn_oid_turn = oid_turn;
                        oBETurnoDetalle.oid_come_clie = oid_come_clie;
                        oBETurnoDetalle.ind_tipo_entr = "A";

                        int ind_vali_come = 0;

                        ind_vali_come = oBRTurnoDetalle.ValidarComensal(oid_turn, oid_come_clie);

                        if (ind_vali_come == 0)
                        {

                            oBRTurnoDetalle.Insertar(oBETurnoDetalle);
                            CargarDGV();

                            ImprimirTicket(txtComedor.Text, txtTipoServicio.Text, dtpFecha.Value.Date.ToString("dd/MM/yyyy"), num_iden_come);

                            //AutoClosingMessageBox oAutoClosingMessageBox = new AutoClosingMessageBox("Ingreso Autorizado", "Acceso Comedor", 2000);

                            txtIdentificacion.Text = "";
                            txtNombre.ForeColor = Color.Blue;
                            txtNombre.Text = "INGRESO CORRECTO";
                            txtIdentificacion.Focus();
                        }
                        else
                        {
                            AutoClosingMessageBox oAutoClosingMessageBox = new AutoClosingMessageBox("Usuario Ya Fue Registrado en el Comedor", "Acceso Comedor", 2000);

                            txtIdentificacion.Text = "";
                            txtNombre.ForeColor = Color.Red;
                            txtNombre.Text = "USUARIO YA INGRESO AL COMEDOR";
                            txtIdentificacion.Focus();
                        }



                    }
                    else
                    {
                        AutoClosingMessageBox oAutoClosingMessageBox = new AutoClosingMessageBox("Ingreso No Autorizado", "Acceso Comedor", 3000);

                        txtIdentificacion.Text = "";
                        txtNombre.ForeColor = Color.Red;
                        txtNombre.Text = "INGRESO NO AUTORIZADO";
                        txtIdentificacion.Focus();
                    }
                }
            }
                                                    
        }

        private void CargarDGV()
        {
            TurnoDetalleBR oTurnoDetalleBR = new TurnoDetalleBR();

            dt = oTurnoDetalleBR.ObtenerListadoPorTurno(oid_turn);
            dgv.DataSource = dt;
            dgv.Columns[0].Visible = false;

            txtCantidad.Text = dgv.RowCount.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImprimirTicket(string p_des_come, string p_tip_serv, string p_val_fech, string p_num_iden_come)
        {
            Ticket oTicket = new Ticket();

            DataTable dt = new DataTable();

            oTicket.MaxChar = 31;
            oTicket.MaxCharDescription = 15;
            
            oTicket.AddHeaderLine("**** CONCESIONARIA EMMA ****");
            oTicket.AddHeaderLine(" ");
            oTicket.AddHeaderLine(Global.des_proy);
            oTicket.AddHeaderLine(" ");
            oTicket.AddHeaderLine("Comedor : " + p_des_come);
            oTicket.AddHeaderLine(" ");
            oTicket.AddHeaderLine("Fecha : " + p_val_fech);
            oTicket.AddHeaderLine(" ");
            oTicket.AddHeaderLine("Tpo Servicio : " + p_tip_serv);
            oTicket.AddHeaderLine(" ");
            oTicket.AddHeaderLine("N° Identificacion : " + p_num_iden_come);
            
            

            //Y por ultimo llamamos al metodo PrintTicket para imprimir el ticket, este metodo necesita un
            //parametro de tipo string que debe de ser el nombre de la impresora.
            oTicket.PrintTicket("EMMA");
        }
       
    }
                                                          
}

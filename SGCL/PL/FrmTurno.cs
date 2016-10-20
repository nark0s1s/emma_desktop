using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using SGCL.PL;
using SGCL.BR;

namespace SGCL
{
    public partial class FrmTurno : Form
    {

        private DataTable dt;

        //private OleDbConnection conn;
        //private OleDbCommand cmd;
        //private OleDbDataAdapter adapter;
        //private DataSet ds;

        public FrmTurno()
        {
            InitializeComponent();
            CHelper oCHelper = new CHelper();
            oCHelper.FormatearFormularioMantenimiento(this);
            oCHelper.FormatearDGVMantenimiento(dgv);
        }

        /*
        private void CargarTurnos()
        {

            conn = new OleDbConnection();
            cmd = new OleDbCommand();
            adapter = new OleDbDataAdapter();
            ds = new DataSet();

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            conn.ConnectionString =
                @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\SGCL\emma.accdb;" +
                "Persist Security Info=False";

            cmd.Connection = conn;
            cmd.CommandText = "SELECT  Turno.IdTurno as IdTurno, TipoTurno.Descripcion as Tipo, Turno.FechaTurno as Fecha, SWITCH(IndicadorCierre=0,'Abierto',IndicadorCierre=1,'Cerrado') as Estado FROM Turno INNER JOIN TipoTurno ON TipoTurno.IdTipoTurno = Turno.IdTipoTurno ORDER BY IdTurno Desc;";

            adapter.SelectCommand = cmd;

            try
            {
                adapter.Fill(ds, "turno");
                dgv.DataSource = ds.Tables["turno"];
                conn.Close();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Error con la Base de Datos - ERROR " + ex.Message);
                Application.Exit();
            }
        }
        */

        private void FrmTurno_Load(object sender, EventArgs e)
        {

            CFormateador oCFormateador = new CFormateador();

            oCFormateador.FormatearDGV(dgv);


            CargarDGV();                        
        }

        private void btnAbrirTurno_Click(object sender, EventArgs e)
        {

            if (dgv.RowCount > 0)
            {

                int valor = new int();

                if (dgv.RowCount > 1)
                {
                    valor = int.Parse(dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString());
                }
                else
                {
                    valor = int.Parse(dgv.Rows[0].Cells[0].Value.ToString());
                }
                
            }
            else
            {
                MessageBox.Show("Debe Seleccionar un Turno");
            }
        }


        private void btnCerrarTurno_Click(object sender, EventArgs e)
        {

            if (dgv.RowCount > 0) {

                int valor = new int(); 
                        
                if (dgv.RowCount > 1) {
                    valor = int.Parse(dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString());                                        
                }                
                else
                {
                    valor = int.Parse(dgv.Rows[0].Cells[0].Value.ToString());                                        
                }
                            
                try
                {
                    TurnoBR oTurnoBR = new TurnoBR();

                    oTurnoBR.Cerrar(valor);

                    MessageBox.Show("Turno Cerrado");
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Problemas de Conexion con la Base de Datos - ERROR : " + ex.Message);                    
                }
            }    
            else
                {
                    MessageBox.Show("Debe Seleccionar un Turno"); 
                }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            int oid = new int();
            FrmTurnoAdd oFrm = new FrmTurnoAdd(this, oid, "C");
            oFrm.ShowDialog();
        }

        private void btnEliminarTurno_Click(object sender, EventArgs e)
        {
            if (dgv.RowCount > 0)
            {

                int valor = new int();

                if (dgv.RowCount > 1)
                {
                    valor = int.Parse(dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString());
                }
                else
                {
                    valor = int.Parse(dgv.Rows[0].Cells[0].Value.ToString());
                }                
            }
            else
            {
                MessageBox.Show("Debe Seleccionar un Turno");
            }
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (dgv.RowCount > 0)                 
            {
                int oid_turn = new int();
                int oid_come = new int();

                oid_turn = int.Parse(dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString());
                oid_come = int.Parse(dgv.Rows[dgv.SelectedRows[0].Index].Cells[1].Value.ToString());

                FrmTurnoCaptura oFrmTurnoCaptura =
                    new FrmTurnoCaptura(this, oid_turn,oid_come,
                                        dgv.Rows[dgv.SelectedRows[0].Index].Cells[3].Value.ToString(),
                                        dgv.Rows[dgv.SelectedRows[0].Index].Cells[4].Value.ToString(),
                                        dgv.Rows[dgv.SelectedRows[0].Index].Cells[6].Value.ToString());

                oFrmTurnoCaptura.ShowDialog(); 
            }

            
        }

        public void CargarDGV()
        {

            TurnoBR oTurnoBR = new TurnoBR();

            dt = oTurnoBR.ObtenerListado();
            dgv.DataSource = dt;
            dgv.Columns[0].Visible = false;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

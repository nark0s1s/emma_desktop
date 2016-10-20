using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SGCL
{
    public partial class FrmCaptura : Form
    {

        private int pIdTurno;

        public FrmCaptura()
        {
            InitializeComponent();
        }

        public FrmCaptura(int Idturno)
        {               
            InitializeComponent();
            pIdTurno = Idturno;
        }

        private void FrmCaptura_Load(object sender, EventArgs e)
        {
            txtTipoTurno.ReadOnly = true;
            txtFechaTurno.ReadOnly = true;
            txtHora.ReadOnly = true;
            txtHora.Text = DateTime.Now.ToString("hh : mm : ss tt");


            //Cargar Turno
            OleDbConnection  conn = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            DataSet ds = new DataSet();

            
            conn.ConnectionString =
                @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\SGCL\emma.accdb;" +
                "Persist Security Info=False";

            cmd.Connection = conn;
            cmd.CommandText = "SELECT  TipoTurno.Descripcion as Tipo, Turno.FechaTurno as Fecha FROM Turno INNER JOIN TipoTurno ON TipoTurno.IdTipoTurno = Turno.IdTipoTurno WHERE Turno.IdTurno = @IdTurno";
            cmd.Parameters.Add("@IdTipoTurno", OleDbType.Integer).Value = pIdTurno ;
            adapter.SelectCommand = cmd;

            try
            {
                DataTable dtTurno = new DataTable();
                adapter.Fill(dtTurno);
                txtTipoTurno.Text = dtTurno.Rows[0][0].ToString();
                txtFechaTurno.Text = dtTurno.Rows[0][1].ToString();

                conn.Close();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Error con la Base de Datos - ERROR " + ex.Message);
                Application.Exit();
            }
        }        
    }
}

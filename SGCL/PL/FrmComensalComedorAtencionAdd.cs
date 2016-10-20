using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGCL.BR;
using SGCL.PL;

namespace EMMA.PL
{
    public partial class FrmComensalComedorAtencionAdd : Form
    {
        private FrmComensalAdd oFrm;

        public FrmComensalComedorAtencionAdd()
        {
            InitializeComponent();
        }


        public FrmComensalComedorAtencionAdd(FrmComensalAdd p_oFrm, int proy_oid_proy)
            : this()
        {

            oFrm = p_oFrm;
            ComedorAtencionBR oBRComedor = new ComedorAtencionBR();
            DataTable dt = new DataTable();

            dt = oBRComedor.ObtenerListadoPorProyecto(proy_oid_proy);
            cboComedor.DataSource = dt;
            cboComedor.DisplayMember = "Descripcion";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            DataRowView rvCome = cboComedor.SelectedItem as DataRowView;

            int oid_come_aten = Int32.Parse(rvCome["Codigo"].ToString());
            string desc_come_aten = rvCome["Descripcion"].ToString();

            oFrm.AgregarComedor(oid_come_aten, desc_come_aten);
            this.Close();
        }
         
    }
}

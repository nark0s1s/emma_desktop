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

namespace SGCL.PL
{
    public partial class FrmTipoServicioComedor : Form
    {

        private DataTable dt;
        public FrmTipoServicioComedor()
        {
            InitializeComponent();

            CHelper oCHelper = new CHelper();
            oCHelper.FormatearFormularioMantenimiento(this);
            oCHelper.FormatearDGVMantenimiento(dgv);
            txtBuscar.Focus();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTipoServicioComedor_Load(object sender, EventArgs e)
        {
            CargarDGV();
            txtBuscar.Focus();

        }

        public void CargarDGV()
        {

            TipoServicioComedorBR oTipoServicioComedorBR = new TipoServicioComedorBR();
            
            dt = oTipoServicioComedorBR.ObtenerListado();
            dgv.DataSource = dt;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmTipoServicioComedorAdd oFrm = new FrmTipoServicioComedorAdd(this);
            oFrm.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
                        
            if (dgv.RowCount > 0)
            {

                string cod;

                if (dgv.RowCount > 1)
                {
                    cod = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString();
                }
                else
                {
                    cod = dgv.Rows[0].Cells[0].Value.ToString();
                }
               
                FrmTipoServicioComedorAdd oFrmAdd = new FrmTipoServicioComedorAdd(this,cod,"U");
                
                oFrmAdd.ShowDialog();
            }

            else
            {
                MessageBox.Show("Debe Seleccionar un Tipo de Servicio Comedor");
            }
        }
        

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            TipoServicioComedorBR oBR = new TipoServicioComedorBR();

            if (dgv.RowCount > 0)
            {

                string cod;

                if (dgv.RowCount > 1)
                {
                    cod = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString();
                }
                else
                {
                    cod = dgv.Rows[0].Cells[0].Value.ToString();
                }

                if (DialogResult.Yes == MessageBox.Show("¿ Esta seguro que desea eliminar el registro ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    oBR.Eliminar(cod);

                    CargarDGV();

                    MessageBox.Show("Tipo de Servicio Comedor Eliminado");
                }
                
            }

            else
            {
                MessageBox.Show("Debe Seleccionar un Tipo de Servicio Comedor");
            }
        }



        private void btnConsultar_Click(object sender, EventArgs e)
        {

            if (dgv.RowCount > 0)
            {

                string cod;

                if (dgv.RowCount > 1)
                {
                    cod = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString();
                }
                else
                {
                    cod = dgv.Rows[0].Cells[0].Value.ToString();
                }

                FrmTipoServicioComedorAdd oFrmAdd = new FrmTipoServicioComedorAdd(this, cod,"R");

                oFrmAdd.ShowDialog();
            }

            else
            {
                MessageBox.Show("Debe Seleccionar un Tipo de Documento de Identidad");
            }

        }        

        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = string.Format("descripcion LIKE '%{0}%'", txtBuscar.Text); 
        }
        
                
    }               
}

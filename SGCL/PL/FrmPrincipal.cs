using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGCL.PL;
using SGCL.PL.Reportes;

namespace SGCL.PL
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;           
            this.ControlBox = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            FrmTurno oFrmTurno = new FrmTurno();
            oFrmTurno.MdiParent = this;
            oFrmTurno.Show(); 
        }

      

        private void comensalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmComensal oFrmComensal = new FrmComensal();
            oFrmComensal.MdiParent = this;            
            oFrmComensal.Show(); 
        }

        private void proyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProyecto oFrmProyecto = new FrmProyecto();
            oFrmProyecto.MdiParent = this;
            oFrmProyecto.Show(); 

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente oFrmCliente = new FrmCliente();
            oFrmCliente.MdiParent = this;
            oFrmCliente.Show(); 
        }

        private void tiposDocumentoIdentidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipoDocumentoIdentidad oFrmTipoDocumentoIdentidad = new FrmTipoDocumentoIdentidad();
            oFrmTipoDocumentoIdentidad.MdiParent = this;
            oFrmTipoDocumentoIdentidad.Show(); 
        }
      
        private void lectorasStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmLectora oFrmLectora = new FrmLectora();
            oFrmLectora.MdiParent = this;
            oFrmLectora.Show();
        }
      
        private void tipoServicioComedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipoServicioComedor oFrmTipoServicioComedor = new FrmTipoServicioComedor();
            oFrmTipoServicioComedor.MdiParent = this;
            oFrmTipoServicioComedor.Show();
        }

        private void comedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmComedor oFrmComedor = new FrmComedor();
            oFrmComedor.MdiParent = this;
            oFrmComedor.Show();
        }

        private void comedorTipoServicioStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmComedorTipoServicio oFrmComedorTipoServicios = new FrmComedorTipoServicio();
            oFrmComedorTipoServicios.MdiParent = this;
            oFrmComedorTipoServicios.Show();
        }

        private void cargarComensalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCargarComensal oFrmCargarComensal = new FrmCargarComensal();
            oFrmCargarComensal.MdiParent = this;
            oFrmCargarComensal.Show();
        }

        private void gestionarTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTurno oFrmTurno = new FrmTurno();
            oFrmTurno.MdiParent = this;
            oFrmTurno.Show(); 
        }

        private void valorizacionPorRangoDeFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteValorizacion oFrmReporteValorizacion = new FrmReporteValorizacion();
            oFrmReporteValorizacion.MdiParent = this;
            oFrmReporteValorizacion.Show(); 
            
        }

        private void comensalesPorComedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteComensalesPorComedor oFrmReporteComensalesPorComedor = new FrmReporteComensalesPorComedor();
            oFrmReporteComensalesPorComedor.MdiParent = this;
            oFrmReporteComensalesPorComedor.Show(); 
        }

        
        
             
    }
}

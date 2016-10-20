namespace SGCL.PL
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.maestrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comedorTipoServicioStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lectorasStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.comensalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDocumentoIdentidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDocumentoIdentidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposServicioComedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarComensalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarTurnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valorizacionPorRangoDeFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comensalesPorComedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SkyBlue;
            this.menuStrip1.Font = new System.Drawing.Font("VAGRounded BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maestrosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1114, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // maestrosToolStripMenuItem
            // 
            this.maestrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.proyectosToolStripMenuItem,
            this.comedoresToolStripMenuItem,
            this.comedorTipoServicioStripMenuItem1,
            this.lectorasStripMenuItem1,
            this.comensalesToolStripMenuItem,
            this.tipoDocumentoIdentidadToolStripMenuItem});
            this.maestrosToolStripMenuItem.Name = "maestrosToolStripMenuItem";
            this.maestrosToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.maestrosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // proyectosToolStripMenuItem
            // 
            this.proyectosToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.proyectosToolStripMenuItem.Name = "proyectosToolStripMenuItem";
            this.proyectosToolStripMenuItem.Size = new System.Drawing.Size(273, 24);
            this.proyectosToolStripMenuItem.Text = "Proyectos";
            this.proyectosToolStripMenuItem.Click += new System.EventHandler(this.proyectosToolStripMenuItem_Click);
            // 
            // comedoresToolStripMenuItem
            // 
            this.comedoresToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.comedoresToolStripMenuItem.Name = "comedoresToolStripMenuItem";
            this.comedoresToolStripMenuItem.Size = new System.Drawing.Size(273, 24);
            this.comedoresToolStripMenuItem.Text = "Comedores";
            this.comedoresToolStripMenuItem.Click += new System.EventHandler(this.comedoresToolStripMenuItem_Click);
            // 
            // comedorTipoServicioStripMenuItem1
            // 
            this.comedorTipoServicioStripMenuItem1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.comedorTipoServicioStripMenuItem1.Name = "comedorTipoServicioStripMenuItem1";
            this.comedorTipoServicioStripMenuItem1.Size = new System.Drawing.Size(273, 24);
            this.comedorTipoServicioStripMenuItem1.Text = "Comedor Tipo de Servicios";
            this.comedorTipoServicioStripMenuItem1.Click += new System.EventHandler(this.comedorTipoServicioStripMenuItem1_Click);
            // 
            // lectorasStripMenuItem1
            // 
            this.lectorasStripMenuItem1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lectorasStripMenuItem1.Name = "lectorasStripMenuItem1";
            this.lectorasStripMenuItem1.Size = new System.Drawing.Size(273, 24);
            this.lectorasStripMenuItem1.Text = "Lectoras";
            this.lectorasStripMenuItem1.Click += new System.EventHandler(this.lectorasStripMenuItem1_Click);
            // 
            // comensalesToolStripMenuItem
            // 
            this.comensalesToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.comensalesToolStripMenuItem.Name = "comensalesToolStripMenuItem";
            this.comensalesToolStripMenuItem.Size = new System.Drawing.Size(273, 24);
            this.comensalesToolStripMenuItem.Text = "Comensales";
            this.comensalesToolStripMenuItem.Click += new System.EventHandler(this.comensalesToolStripMenuItem_Click);
            // 
            // tipoDocumentoIdentidadToolStripMenuItem
            // 
            this.tipoDocumentoIdentidadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiposDocumentoIdentidadToolStripMenuItem,
            this.tiposServicioComedorToolStripMenuItem});
            this.tipoDocumentoIdentidadToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.tipoDocumentoIdentidadToolStripMenuItem.Name = "tipoDocumentoIdentidadToolStripMenuItem";
            this.tipoDocumentoIdentidadToolStripMenuItem.Size = new System.Drawing.Size(273, 24);
            this.tipoDocumentoIdentidadToolStripMenuItem.Text = "Generales";
            this.tipoDocumentoIdentidadToolStripMenuItem.Click += new System.EventHandler(this.tiposDocumentoIdentidadToolStripMenuItem_Click);
            // 
            // tiposDocumentoIdentidadToolStripMenuItem
            // 
            this.tiposDocumentoIdentidadToolStripMenuItem.Name = "tiposDocumentoIdentidadToolStripMenuItem";
            this.tiposDocumentoIdentidadToolStripMenuItem.Size = new System.Drawing.Size(281, 24);
            this.tiposDocumentoIdentidadToolStripMenuItem.Text = "Tipos Documento Identidad";
            this.tiposDocumentoIdentidadToolStripMenuItem.Click += new System.EventHandler(this.tiposDocumentoIdentidadToolStripMenuItem_Click);
            // 
            // tiposServicioComedorToolStripMenuItem
            // 
            this.tiposServicioComedorToolStripMenuItem.Name = "tiposServicioComedorToolStripMenuItem";
            this.tiposServicioComedorToolStripMenuItem.Size = new System.Drawing.Size(281, 24);
            this.tiposServicioComedorToolStripMenuItem.Text = "Tipos de Servicio Comedor";
            this.tiposServicioComedorToolStripMenuItem.Click += new System.EventHandler(this.tipoServicioComedorToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarComensalesToolStripMenuItem,
            this.gestionarTurnoToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // cargarComensalesToolStripMenuItem
            // 
            this.cargarComensalesToolStripMenuItem.Name = "cargarComensalesToolStripMenuItem";
            this.cargarComensalesToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            this.cargarComensalesToolStripMenuItem.Text = "Cargar Comensales";
            this.cargarComensalesToolStripMenuItem.Click += new System.EventHandler(this.cargarComensalesToolStripMenuItem_Click);
            // 
            // gestionarTurnoToolStripMenuItem
            // 
            this.gestionarTurnoToolStripMenuItem.Name = "gestionarTurnoToolStripMenuItem";
            this.gestionarTurnoToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            this.gestionarTurnoToolStripMenuItem.Text = "Gestionar Turno";
            this.gestionarTurnoToolStripMenuItem.Click += new System.EventHandler(this.gestionarTurnoToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.valorizacionPorRangoDeFechasToolStripMenuItem,
            this.comensalesPorComedorToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // valorizacionPorRangoDeFechasToolStripMenuItem
            // 
            this.valorizacionPorRangoDeFechasToolStripMenuItem.Name = "valorizacionPorRangoDeFechasToolStripMenuItem";
            this.valorizacionPorRangoDeFechasToolStripMenuItem.Size = new System.Drawing.Size(330, 24);
            this.valorizacionPorRangoDeFechasToolStripMenuItem.Text = "Valorizacion Por Rango de Fechas";
            this.valorizacionPorRangoDeFechasToolStripMenuItem.Click += new System.EventHandler(this.valorizacionPorRangoDeFechasToolStripMenuItem_Click);
            // 
            // comensalesPorComedorToolStripMenuItem
            // 
            this.comensalesPorComedorToolStripMenuItem.Name = "comensalesPorComedorToolStripMenuItem";
            this.comensalesPorComedorToolStripMenuItem.Size = new System.Drawing.Size(330, 24);
            this.comensalesPorComedorToolStripMenuItem.Text = "Comensales Por Comedor";
            this.comensalesPorComedorToolStripMenuItem.Click += new System.EventHandler(this.comensalesPorComedorToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(273, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1114, 583);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("VAGRounded BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPrincipal";
            this.Text = "Sistema Gestion Comedor Administrador";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem maestrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comensalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarTurnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proyectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDocumentoIdentidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDocumentoIdentidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposServicioComedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lectorasStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem comedorTipoServicioStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cargarComensalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valorizacionPorRangoDeFechasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comensalesPorComedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
    }
}
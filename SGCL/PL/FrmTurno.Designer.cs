namespace SGCL
{
    partial class FrmTurno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTurno));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnAbrirTurno = new System.Windows.Forms.Button();
            this.btnCerrarTurno = new System.Windows.Forms.Button();
            this.btnEliminarTurno = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 160);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(1004, 357);
            this.dgv.TabIndex = 0;
            // 
            // btnAbrirTurno
            // 
            this.btnAbrirTurno.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAbrirTurno.Font = new System.Drawing.Font("VAGRounded BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirTurno.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnAbrirTurno.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirTurno.Image")));
            this.btnAbrirTurno.Location = new System.Drawing.Point(421, 55);
            this.btnAbrirTurno.Name = "btnAbrirTurno";
            this.btnAbrirTurno.Size = new System.Drawing.Size(94, 86);
            this.btnAbrirTurno.TabIndex = 1;
            this.btnAbrirTurno.Text = "Abrir";
            this.btnAbrirTurno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbrirTurno.UseVisualStyleBackColor = false;
            this.btnAbrirTurno.Click += new System.EventHandler(this.btnAbrirTurno_Click);
            // 
            // btnCerrarTurno
            // 
            this.btnCerrarTurno.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCerrarTurno.Font = new System.Drawing.Font("VAGRounded BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarTurno.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnCerrarTurno.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarTurno.Image")));
            this.btnCerrarTurno.Location = new System.Drawing.Point(526, 55);
            this.btnCerrarTurno.Name = "btnCerrarTurno";
            this.btnCerrarTurno.Size = new System.Drawing.Size(94, 86);
            this.btnCerrarTurno.TabIndex = 2;
            this.btnCerrarTurno.Text = "Cerrar";
            this.btnCerrarTurno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrarTurno.UseVisualStyleBackColor = false;
            this.btnCerrarTurno.Click += new System.EventHandler(this.btnCerrarTurno_Click);
            // 
            // btnEliminarTurno
            // 
            this.btnEliminarTurno.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEliminarTurno.Font = new System.Drawing.Font("VAGRounded BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTurno.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnEliminarTurno.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarTurno.Image")));
            this.btnEliminarTurno.Location = new System.Drawing.Point(631, 55);
            this.btnEliminarTurno.Name = "btnEliminarTurno";
            this.btnEliminarTurno.Size = new System.Drawing.Size(94, 86);
            this.btnEliminarTurno.TabIndex = 3;
            this.btnEliminarTurno.Text = "Eliminar";
            this.btnEliminarTurno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminarTurno.UseVisualStyleBackColor = false;
            this.btnEliminarTurno.Click += new System.EventHandler(this.btnEliminarTurno_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnNuevo.Font = new System.Drawing.Font("VAGRounded BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(211, 55);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(94, 86);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCapturar
            // 
            this.btnCapturar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCapturar.Font = new System.Drawing.Font("VAGRounded BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapturar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnCapturar.Image = ((System.Drawing.Image)(resources.GetObject("btnCapturar.Image")));
            this.btnCapturar.Location = new System.Drawing.Point(316, 55);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(94, 86);
            this.btnCapturar.TabIndex = 5;
            this.btnCapturar.Text = "Ingresos";
            this.btnCapturar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCapturar.UseVisualStyleBackColor = false;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCerrar.Font = new System.Drawing.Font("VAGRounded BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(736, 55);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(94, 86);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTitulo.Font = new System.Drawing.Font("VAGRounded BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(-1, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1038, 39);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Gestionar Turno";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1040, 529);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEliminarTurno);
            this.Controls.Add(this.btnCerrarTurno);
            this.Controls.Add(this.btnAbrirTurno);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmTurno";
            this.Load += new System.EventHandler(this.FrmTurno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnAbrirTurno;
        private System.Windows.Forms.Button btnCerrarTurno;
        private System.Windows.Forms.Button btnEliminarTurno;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblTitulo;
    }
}
namespace SGCL.PL
{
    partial class FrmTipoServicioComedorAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTipoServicioComedorAdd));
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtOid = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtDescripcionLabel = new System.Windows.Forms.TextBox();
            this.txtCodigoLabel = new System.Windows.Forms.TextBox();
            this.txtSegundoNombreLabel = new System.Windows.Forms.TextBox();
            this.rbtActivo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtOrdenReporte = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Font = new System.Drawing.Font("VAGRounded BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(146, 97);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(480, 27);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.GotFocus += new System.EventHandler(this.txtDescripcion_GotFocus);
            this.txtDescripcion.Leave += new System.EventHandler(this.txtDescripcion_Leave);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(320, 248);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 68);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar.Image = ((System.Drawing.Image)(resources.GetObject("btnGrabar.Image")));
            this.btnGrabar.Location = new System.Drawing.Point(239, 248);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 68);
            this.btnGrabar.TabIndex = 4;
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtOid
            // 
            this.txtOid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOid.Font = new System.Drawing.Font("VAGRounded BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOid.Location = new System.Drawing.Point(146, 52);
            this.txtOid.Name = "txtOid";
            this.txtOid.Size = new System.Drawing.Size(123, 27);
            this.txtOid.TabIndex = 0;
            this.txtOid.GotFocus += new System.EventHandler(this.txtOid_GotFocus);
            this.txtOid.Leave += new System.EventHandler(this.txtOid_Leave);
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTitulo.Font = new System.Drawing.Font("VAGRounded BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, -1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(635, 39);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "Tipo Servicio en Comedor";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescripcionLabel
            // 
            this.txtDescripcionLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.txtDescripcionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcionLabel.Font = new System.Drawing.Font("VAGRounded BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionLabel.ForeColor = System.Drawing.Color.White;
            this.txtDescripcionLabel.Location = new System.Drawing.Point(8, 97);
            this.txtDescripcionLabel.Name = "txtDescripcionLabel";
            this.txtDescripcionLabel.ReadOnly = true;
            this.txtDescripcionLabel.Size = new System.Drawing.Size(137, 27);
            this.txtDescripcionLabel.TabIndex = 15;
            this.txtDescripcionLabel.Text = "Descripcion  ";
            this.txtDescripcionLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCodigoLabel
            // 
            this.txtCodigoLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.txtCodigoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoLabel.Font = new System.Drawing.Font("VAGRounded BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoLabel.ForeColor = System.Drawing.Color.White;
            this.txtCodigoLabel.Location = new System.Drawing.Point(8, 52);
            this.txtCodigoLabel.Name = "txtCodigoLabel";
            this.txtCodigoLabel.ReadOnly = true;
            this.txtCodigoLabel.Size = new System.Drawing.Size(137, 27);
            this.txtCodigoLabel.TabIndex = 16;
            this.txtCodigoLabel.Text = "Codigo  ";
            this.txtCodigoLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSegundoNombreLabel
            // 
            this.txtSegundoNombreLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.txtSegundoNombreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSegundoNombreLabel.Font = new System.Drawing.Font("VAGRounded BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundoNombreLabel.ForeColor = System.Drawing.Color.White;
            this.txtSegundoNombreLabel.Location = new System.Drawing.Point(8, 179);
            this.txtSegundoNombreLabel.Name = "txtSegundoNombreLabel";
            this.txtSegundoNombreLabel.ReadOnly = true;
            this.txtSegundoNombreLabel.Size = new System.Drawing.Size(137, 27);
            this.txtSegundoNombreLabel.TabIndex = 70;
            this.txtSegundoNombreLabel.Text = "Estado  ";
            this.txtSegundoNombreLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rbtActivo
            // 
            this.rbtActivo.AutoSize = true;
            this.rbtActivo.Font = new System.Drawing.Font("VAGRounded BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtActivo.ForeColor = System.Drawing.Color.White;
            this.rbtActivo.Location = new System.Drawing.Point(22, 8);
            this.rbtActivo.Name = "rbtActivo";
            this.rbtActivo.Size = new System.Drawing.Size(70, 24);
            this.rbtActivo.TabIndex = 1;
            this.rbtActivo.TabStop = true;
            this.rbtActivo.Text = "Activo";
            this.rbtActivo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtActivo);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(142, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 35);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("VAGRounded BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(8, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(137, 27);
            this.textBox1.TabIndex = 73;
            this.textBox1.Text = "Orden Reporte  ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOrdenReporte
            // 
            this.txtOrdenReporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOrdenReporte.Font = new System.Drawing.Font("VAGRounded BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrdenReporte.Location = new System.Drawing.Point(146, 138);
            this.txtOrdenReporte.Name = "txtOrdenReporte";
            this.txtOrdenReporte.Size = new System.Drawing.Size(123, 27);
            this.txtOrdenReporte.TabIndex = 2;
            this.txtOrdenReporte.GotFocus += new System.EventHandler(this.txtOrdenReporte_GotFocus);
            this.txtOrdenReporte.Leave += new System.EventHandler(this.txtOrdenReporte_Leave);
            // 
            // FrmTipoServicioComedorAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 330);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtOrdenReporte);
            this.Controls.Add(this.txtSegundoNombreLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCodigoLabel);
            this.Controls.Add(this.txtDescripcionLabel);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtOid);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtDescripcion);
            this.Name = "FrmTipoServicioComedorAdd";
            this.Load += new System.EventHandler(this.FrmTipoServicioComedorAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtOid;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtDescripcionLabel;
        private System.Windows.Forms.TextBox txtCodigoLabel;
        private System.Windows.Forms.TextBox txtSegundoNombreLabel;
        private System.Windows.Forms.RadioButton rbtActivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtOrdenReporte;
    }
}
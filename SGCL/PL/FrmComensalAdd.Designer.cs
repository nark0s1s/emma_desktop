namespace SGCL.PL
{
    partial class FrmComensalAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmComensalAdd));
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.cboTipoDocuIden = new System.Windows.Forms.ComboBox();
            this.txtNumDocuIden = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNumeroDocumentoLabel = new System.Windows.Forms.TextBox();
            this.txtSegundoNombreLabel = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.txtNumeroIdentificacionComedor = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.txtDescripcionLabel = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtOid = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtTipoCargo = new System.Windows.Forms.TextBox();
            this.dgvComedoresAtencion = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtProyecto = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComedoresAtencion)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCargo
            // 
            this.txtCargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCargo.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.Location = new System.Drawing.Point(254, 246);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(578, 26);
            this.txtCargo.TabIndex = 7;
            this.txtCargo.GotFocus += new System.EventHandler(this.txtNom2_GotFocus);
            this.txtCargo.Leave += new System.EventHandler(this.txtNom2_Leave);
            // 
            // cboTipoDocuIden
            // 
            this.cboTipoDocuIden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDocuIden.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoDocuIden.FormattingEnabled = true;
            this.cboTipoDocuIden.Location = new System.Drawing.Point(254, 117);
            this.cboTipoDocuIden.Name = "cboTipoDocuIden";
            this.cboTipoDocuIden.Size = new System.Drawing.Size(273, 27);
            this.cboTipoDocuIden.TabIndex = 3;
            this.cboTipoDocuIden.SelectedIndexChanged += new System.EventHandler(this.cboTipoDocuIden_SelectedIndexChanged);
            // 
            // txtNumDocuIden
            // 
            this.txtNumDocuIden.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumDocuIden.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumDocuIden.Location = new System.Drawing.Point(254, 149);
            this.txtNumDocuIden.Name = "txtNumDocuIden";
            this.txtNumDocuIden.Size = new System.Drawing.Size(273, 26);
            this.txtNumDocuIden.TabIndex = 4;
            this.txtNumDocuIden.GotFocus += new System.EventHandler(this.txtNumDocuIden_GotFocus);
            this.txtNumDocuIden.Leave += new System.EventHandler(this.txtNumDocuIden_Leave);
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTitulo.Font = new System.Drawing.Font("VAGRounded BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(-1, -1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(855, 39);
            this.lblTitulo.TabIndex = 39;
            this.lblTitulo.Text = "Comensal";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumeroDocumentoLabel
            // 
            this.txtNumeroDocumentoLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.txtNumeroDocumentoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroDocumentoLabel.Font = new System.Drawing.Font("VAGRounded BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroDocumentoLabel.ForeColor = System.Drawing.Color.White;
            this.txtNumeroDocumentoLabel.Location = new System.Drawing.Point(10, 149);
            this.txtNumeroDocumentoLabel.Name = "txtNumeroDocumentoLabel";
            this.txtNumeroDocumentoLabel.ReadOnly = true;
            this.txtNumeroDocumentoLabel.Size = new System.Drawing.Size(243, 27);
            this.txtNumeroDocumentoLabel.TabIndex = 40;
            this.txtNumeroDocumentoLabel.Text = "Numero Documento Identidad  ";
            this.txtNumeroDocumentoLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSegundoNombreLabel
            // 
            this.txtSegundoNombreLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.txtSegundoNombreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSegundoNombreLabel.Font = new System.Drawing.Font("VAGRounded BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundoNombreLabel.ForeColor = System.Drawing.Color.White;
            this.txtSegundoNombreLabel.Location = new System.Drawing.Point(178, 247);
            this.txtSegundoNombreLabel.Name = "txtSegundoNombreLabel";
            this.txtSegundoNombreLabel.ReadOnly = true;
            this.txtSegundoNombreLabel.Size = new System.Drawing.Size(75, 27);
            this.txtSegundoNombreLabel.TabIndex = 43;
            this.txtSegundoNombreLabel.Text = "Cargo  ";
            this.txtSegundoNombreLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("VAGRounded BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(88, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(165, 27);
            this.textBox2.TabIndex = 46;
            this.textBox2.Text = "Tipo de Documento  ";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.BackColor = System.Drawing.Color.SteelBlue;
            this.txtIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdentificacion.Font = new System.Drawing.Font("VAGRounded BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacion.ForeColor = System.Drawing.Color.White;
            this.txtIdentificacion.Location = new System.Drawing.Point(27, 183);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.ReadOnly = true;
            this.txtIdentificacion.Size = new System.Drawing.Size(226, 27);
            this.txtIdentificacion.TabIndex = 48;
            this.txtIdentificacion.Text = "N° Identificacion Comedor  ";
            this.txtIdentificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNumeroIdentificacionComedor
            // 
            this.txtNumeroIdentificacionComedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroIdentificacionComedor.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroIdentificacionComedor.Location = new System.Drawing.Point(254, 182);
            this.txtNumeroIdentificacionComedor.Name = "txtNumeroIdentificacionComedor";
            this.txtNumeroIdentificacionComedor.Size = new System.Drawing.Size(480, 26);
            this.txtNumeroIdentificacionComedor.TabIndex = 5;
            this.txtNumeroIdentificacionComedor.GotFocus += new System.EventHandler(this.txtNumeroIdentificacionComedor_GotFocus);
            this.txtNumeroIdentificacionComedor.Leave += new System.EventHandler(this.txtNumeroIdentificacionComedor_Leave);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("VAGRounded BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(116, 80);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(137, 27);
            this.textBox4.TabIndex = 77;
            this.textBox4.Text = "Cliente  ";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(254, 80);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(517, 27);
            this.cboCliente.TabIndex = 0;
            // 
            // txtDescripcionLabel
            // 
            this.txtDescripcionLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.txtDescripcionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcionLabel.Font = new System.Drawing.Font("VAGRounded BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionLabel.ForeColor = System.Drawing.Color.White;
            this.txtDescripcionLabel.Location = new System.Drawing.Point(68, 216);
            this.txtDescripcionLabel.Name = "txtDescripcionLabel";
            this.txtDescripcionLabel.ReadOnly = true;
            this.txtDescripcionLabel.Size = new System.Drawing.Size(185, 27);
            this.txtDescripcionLabel.TabIndex = 79;
            this.txtDescripcionLabel.Text = "Nombres y Apellidos  ";
            this.txtDescripcionLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(254, 215);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(480, 26);
            this.txtDescripcion.TabIndex = 6;
            this.txtDescripcion.GotFocus += new System.EventHandler(this.txtDescripcion_GotFocus);
            this.txtDescripcion.Leave += new System.EventHandler(this.txtDescripcion_Leave);
            // 
            // txtOid
            // 
            this.txtOid.Enabled = false;
            this.txtOid.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOid.Location = new System.Drawing.Point(27, 466);
            this.txtOid.Name = "txtOid";
            this.txtOid.ReadOnly = true;
            this.txtOid.Size = new System.Drawing.Size(123, 26);
            this.txtOid.TabIndex = 82;
            this.txtOid.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(435, 424);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 68);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar.Image = ((System.Drawing.Image)(resources.GetObject("btnGrabar.Image")));
            this.btnGrabar.Location = new System.Drawing.Point(354, 424);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 68);
            this.btnGrabar.TabIndex = 10;
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("VAGRounded BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(128, 278);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(125, 27);
            this.textBox5.TabIndex = 84;
            this.textBox5.Text = "Tipo de Cargo  ";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTipoCargo
            // 
            this.txtTipoCargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipoCargo.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoCargo.Location = new System.Drawing.Point(254, 278);
            this.txtTipoCargo.Name = "txtTipoCargo";
            this.txtTipoCargo.Size = new System.Drawing.Size(480, 26);
            this.txtTipoCargo.TabIndex = 8;
            this.txtTipoCargo.GotFocus += new System.EventHandler(this.txtTipoCargo_GotFocus);
            this.txtTipoCargo.Leave += new System.EventHandler(this.txtTipoCargo_Leave);
            // 
            // dgvComedoresAtencion
            // 
            this.dgvComedoresAtencion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComedoresAtencion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.Descripcion});
            this.dgvComedoresAtencion.Location = new System.Drawing.Point(253, 314);
            this.dgvComedoresAtencion.Name = "dgvComedoresAtencion";
            this.dgvComedoresAtencion.Size = new System.Drawing.Size(257, 98);
            this.dgvComedoresAtencion.TabIndex = 87;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("VAGRounded BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(132, 314);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(119, 27);
            this.textBox3.TabIndex = 88;
            this.textBox3.Text = "Comedores    ";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(597, 314);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(59, 58);
            this.btnEliminar.TabIndex = 90;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(532, 314);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(59, 57);
            this.btnNuevo.TabIndex = 89;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtProyecto
            // 
            this.txtProyecto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProyecto.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProyecto.Location = new System.Drawing.Point(257, 45);
            this.txtProyecto.Name = "txtProyecto";
            this.txtProyecto.ReadOnly = true;
            this.txtProyecto.Size = new System.Drawing.Size(517, 26);
            this.txtProyecto.TabIndex = 93;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("VAGRounded BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(114, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(137, 27);
            this.textBox1.TabIndex = 92;
            this.textBox1.Text = "Proyecto  ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmComensalAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 507);
            this.Controls.Add(this.txtProyecto);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dgvComedoresAtencion);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtTipoCargo);
            this.Controls.Add(this.txtOid);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtDescripcionLabel);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.txtNumeroIdentificacionComedor);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtSegundoNombreLabel);
            this.Controls.Add(this.txtNumeroDocumentoLabel);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cboTipoDocuIden);
            this.Controls.Add(this.txtNumDocuIden);
            this.Controls.Add(this.txtCargo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmComensalAdd";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComedoresAtencion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.ComboBox cboTipoDocuIden;
        private System.Windows.Forms.TextBox txtNumDocuIden;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNumeroDocumentoLabel;
        private System.Windows.Forms.TextBox txtSegundoNombreLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.TextBox txtNumeroIdentificacionComedor;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.TextBox txtDescripcionLabel;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtOid;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtTipoCargo;
        private System.Windows.Forms.DataGridView dgvComedoresAtencion;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.TextBox txtProyecto;
        private System.Windows.Forms.TextBox textBox1;
    }
}
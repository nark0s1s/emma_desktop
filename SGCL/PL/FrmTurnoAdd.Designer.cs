namespace SGCL.PL
{
    partial class FrmTurnoAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTurnoAdd));
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cboComedor = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.cboTipoServicio = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.cboLectora = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtOid = new System.Windows.Forms.TextBox();
            this.txtProyecto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.Color.SteelBlue;
            this.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFecha.Font = new System.Drawing.Font("VAGRounded BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.ForeColor = System.Drawing.Color.White;
            this.txtFecha.Location = new System.Drawing.Point(62, 222);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(137, 27);
            this.txtFecha.TabIndex = 57;
            this.txtFecha.Text = "Fecha  ";
            this.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTitulo.Font = new System.Drawing.Font("VAGRounded BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(-1, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(745, 39);
            this.lblTitulo.TabIndex = 56;
            this.lblTitulo.Text = "Turno  ";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(374, 286);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 68);
            this.btnCancel.TabIndex = 55;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar.Image = ((System.Drawing.Image)(resources.GetObject("btnGrabar.Image")));
            this.btnGrabar.Location = new System.Drawing.Point(293, 286);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 68);
            this.btnGrabar.TabIndex = 54;
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("VAGRounded BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(62, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(137, 27);
            this.textBox1.TabIndex = 66;
            this.textBox1.Text = "Proyecto  ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("VAGRounded BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(62, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(137, 27);
            this.textBox3.TabIndex = 71;
            this.textBox3.Text = "Comedor  ";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboComedor
            // 
            this.cboComedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboComedor.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboComedor.FormattingEnabled = true;
            this.cboComedor.Location = new System.Drawing.Point(204, 96);
            this.cboComedor.Name = "cboComedor";
            this.cboComedor.Size = new System.Drawing.Size(517, 27);
            this.cboComedor.TabIndex = 70;
            this.cboComedor.SelectedIndexChanged += new System.EventHandler(this.cboComedor_SelectedIndexChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("VAGRounded BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(62, 137);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(137, 27);
            this.textBox4.TabIndex = 73;
            this.textBox4.Text = "Tipo Servicio  ";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboTipoServicio
            // 
            this.cboTipoServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoServicio.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoServicio.FormattingEnabled = true;
            this.cboTipoServicio.Location = new System.Drawing.Point(204, 137);
            this.cboTipoServicio.Name = "cboTipoServicio";
            this.cboTipoServicio.Size = new System.Drawing.Size(517, 27);
            this.cboTipoServicio.TabIndex = 72;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("VAGRounded BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(62, 176);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(137, 27);
            this.textBox5.TabIndex = 75;
            this.textBox5.Text = "Lectora  ";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboLectora
            // 
            this.cboLectora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLectora.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLectora.FormattingEnabled = true;
            this.cboLectora.Location = new System.Drawing.Point(204, 176);
            this.cboLectora.Name = "cboLectora";
            this.cboLectora.Size = new System.Drawing.Size(517, 27);
            this.cboLectora.TabIndex = 74;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("VAGRounded BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(204, 222);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(515, 27);
            this.dtpFecha.TabIndex = 76;
            // 
            // txtOid
            // 
            this.txtOid.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOid.Location = new System.Drawing.Point(25, 362);
            this.txtOid.Name = "txtOid";
            this.txtOid.ReadOnly = true;
            this.txtOid.Size = new System.Drawing.Size(123, 26);
            this.txtOid.TabIndex = 64;
            this.txtOid.Visible = false;
            // 
            // txtProyecto
            // 
            this.txtProyecto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProyecto.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProyecto.Location = new System.Drawing.Point(202, 55);
            this.txtProyecto.Name = "txtProyecto";
            this.txtProyecto.ReadOnly = true;
            this.txtProyecto.Size = new System.Drawing.Size(517, 26);
            this.txtProyecto.TabIndex = 77;
            // 
            // FrmTurnoAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 367);
            this.Controls.Add(this.txtProyecto);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.cboLectora);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.cboTipoServicio);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.cboComedor);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtOid);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGrabar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmTurnoAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox cboComedor;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox cboTipoServicio;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox cboLectora;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtOid;
        private System.Windows.Forms.TextBox txtProyecto;

    }
}
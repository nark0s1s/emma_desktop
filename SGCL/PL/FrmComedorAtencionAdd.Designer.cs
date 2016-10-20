namespace SGCL.PL
{
    partial class FrmComedorAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmComedorAdd));
            this.txtSegundoNombreLabel = new System.Windows.Forms.TextBox();
            this.txtNumeroDocumentoLabel = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtOid = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtProyecto = new System.Windows.Forms.TextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtSegundoNombreLabel
            // 
            this.txtSegundoNombreLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.txtSegundoNombreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSegundoNombreLabel.Font = new System.Drawing.Font("VAGRounded BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundoNombreLabel.ForeColor = System.Drawing.Color.White;
            this.txtSegundoNombreLabel.Location = new System.Drawing.Point(58, 144);
            this.txtSegundoNombreLabel.Name = "txtSegundoNombreLabel";
            this.txtSegundoNombreLabel.ReadOnly = true;
            this.txtSegundoNombreLabel.Size = new System.Drawing.Size(137, 27);
            this.txtSegundoNombreLabel.TabIndex = 60;
            this.txtSegundoNombreLabel.Text = "Estado  ";
            this.txtSegundoNombreLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNumeroDocumentoLabel
            // 
            this.txtNumeroDocumentoLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.txtNumeroDocumentoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroDocumentoLabel.Font = new System.Drawing.Font("VAGRounded BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroDocumentoLabel.ForeColor = System.Drawing.Color.White;
            this.txtNumeroDocumentoLabel.Location = new System.Drawing.Point(81, 97);
            this.txtNumeroDocumentoLabel.Name = "txtNumeroDocumentoLabel";
            this.txtNumeroDocumentoLabel.ReadOnly = true;
            this.txtNumeroDocumentoLabel.Size = new System.Drawing.Size(114, 27);
            this.txtNumeroDocumentoLabel.TabIndex = 57;
            this.txtNumeroDocumentoLabel.Text = "Descripcion  ";
            this.txtNumeroDocumentoLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.lblTitulo.Text = "Comedor";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(196, 97);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(517, 26);
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
            this.btnCancel.Location = new System.Drawing.Point(367, 201);
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
            this.btnGrabar.Location = new System.Drawing.Point(286, 201);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 68);
            this.btnGrabar.TabIndex = 3;
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtOid
            // 
            this.txtOid.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOid.Location = new System.Drawing.Point(12, 243);
            this.txtOid.Name = "txtOid";
            this.txtOid.ReadOnly = true;
            this.txtOid.Size = new System.Drawing.Size(123, 26);
            this.txtOid.TabIndex = 64;
            this.txtOid.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("VAGRounded BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(104, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(91, 27);
            this.textBox1.TabIndex = 66;
            this.textBox1.Text = "Proyecto  ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtProyecto
            // 
            this.txtProyecto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProyecto.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProyecto.Location = new System.Drawing.Point(196, 56);
            this.txtProyecto.Name = "txtProyecto";
            this.txtProyecto.ReadOnly = true;
            this.txtProyecto.Size = new System.Drawing.Size(517, 26);
            this.txtProyecto.TabIndex = 78;
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(201, 144);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(117, 27);
            this.cboEstado.TabIndex = 80;
            // 
            // FrmComedorAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 295);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.txtProyecto);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtOid);
            this.Controls.Add(this.txtSegundoNombreLabel);
            this.Controls.Add(this.txtNumeroDocumentoLabel);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGrabar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmComedorAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSegundoNombreLabel;
        private System.Windows.Forms.TextBox txtNumeroDocumentoLabel;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtOid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtProyecto;
        private System.Windows.Forms.ComboBox cboEstado;

    }
}
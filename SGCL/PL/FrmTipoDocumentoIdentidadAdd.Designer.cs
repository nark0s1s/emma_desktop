namespace SGCL.PL
{
    partial class FrmTipoDocumentoIdentidadAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTipoDocumentoIdentidadAdd));
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtOid = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtDescripcionLabel = new System.Windows.Forms.TextBox();
            this.txtCodigoLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Font = new System.Drawing.Font("VAGRounded BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(137, 101);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(480, 27);
            this.txtDescripcion.TabIndex = 2;
            this.txtDescripcion.GotFocus += new System.EventHandler(this.txtDescripcion_GotFocus);
            this.txtDescripcion.Leave += new System.EventHandler(this.txtDescripcion_Leave);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(318, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 68);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar.Image = ((System.Drawing.Image)(resources.GetObject("btnGrabar.Image")));
            this.btnGrabar.Location = new System.Drawing.Point(237, 150);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 68);
            this.btnGrabar.TabIndex = 3;
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtOid
            // 
            this.txtOid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOid.Font = new System.Drawing.Font("VAGRounded BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOid.Location = new System.Drawing.Point(137, 52);
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
            this.lblTitulo.Text = "Tipo Documento Identidad";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescripcionLabel
            // 
            this.txtDescripcionLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.txtDescripcionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcionLabel.Font = new System.Drawing.Font("VAGRounded BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionLabel.ForeColor = System.Drawing.Color.White;
            this.txtDescripcionLabel.Location = new System.Drawing.Point(12, 101);
            this.txtDescripcionLabel.Name = "txtDescripcionLabel";
            this.txtDescripcionLabel.ReadOnly = true;
            this.txtDescripcionLabel.Size = new System.Drawing.Size(124, 27);
            this.txtDescripcionLabel.TabIndex = 15;
            this.txtDescripcionLabel.Text = "Descripcion : ";
            this.txtDescripcionLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCodigoLabel
            // 
            this.txtCodigoLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.txtCodigoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoLabel.Font = new System.Drawing.Font("VAGRounded BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoLabel.ForeColor = System.Drawing.Color.White;
            this.txtCodigoLabel.Location = new System.Drawing.Point(12, 52);
            this.txtCodigoLabel.Name = "txtCodigoLabel";
            this.txtCodigoLabel.ReadOnly = true;
            this.txtCodigoLabel.Size = new System.Drawing.Size(124, 27);
            this.txtCodigoLabel.TabIndex = 16;
            this.txtCodigoLabel.Text = "Codigo :";
            this.txtCodigoLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmTipoDocumentoIdentidadAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 234);
            this.Controls.Add(this.txtCodigoLabel);
            this.Controls.Add(this.txtDescripcionLabel);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtOid);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtDescripcion);
            this.Name = "FrmTipoDocumentoIdentidadAdd";
            this.Load += new System.EventHandler(this.FrmTipoDocumentoIdentidadAdd_Load);
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
    }
}
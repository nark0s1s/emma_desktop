namespace SGCL.PL
{
    partial class FrmCargarComensal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCargarComensal));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cboComedor = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCargarExcel = new System.Windows.Forms.Button();
            this.btnSeleccionarArchivo = new System.Windows.Forms.Button();
            this.openFileDialogExcel = new System.Windows.Forms.OpenFileDialog();
            this.txtArchivoExcel = new System.Windows.Forms.TextBox();
            this.txtProyecto = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTitulo.Font = new System.Drawing.Font("VAGRounded BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, -1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(693, 39);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Carga Masiva Comensales";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("VAGRounded BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(19, 127);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(137, 27);
            this.textBox3.TabIndex = 79;
            this.textBox3.Text = "Comedor  ";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboComedor
            // 
            this.cboComedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboComedor.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboComedor.FormattingEnabled = true;
            this.cboComedor.Location = new System.Drawing.Point(157, 127);
            this.cboComedor.Name = "cboComedor";
            this.cboComedor.Size = new System.Drawing.Size(517, 27);
            this.cboComedor.TabIndex = 78;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("VAGRounded BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(19, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(137, 27);
            this.textBox2.TabIndex = 75;
            this.textBox2.Text = "Cliente  ";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(157, 87);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(517, 27);
            this.cboCliente.TabIndex = 72;            
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(330, 207);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 68);
            this.btnCancel.TabIndex = 74;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCargarExcel
            // 
            this.btnCargarExcel.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCargarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnCargarExcel.Image")));
            this.btnCargarExcel.Location = new System.Drawing.Point(249, 207);
            this.btnCargarExcel.Name = "btnCargarExcel";
            this.btnCargarExcel.Size = new System.Drawing.Size(75, 68);
            this.btnCargarExcel.TabIndex = 73;
            this.btnCargarExcel.UseVisualStyleBackColor = false;
            this.btnCargarExcel.Click += new System.EventHandler(this.btnCargarExcel_Click_1);
            // 
            // btnSeleccionarArchivo
            // 
            this.btnSeleccionarArchivo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSeleccionarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarArchivo.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarArchivo.Image")));
            this.btnSeleccionarArchivo.Location = new System.Drawing.Point(123, 175);
            this.btnSeleccionarArchivo.Name = "btnSeleccionarArchivo";
            this.btnSeleccionarArchivo.Size = new System.Drawing.Size(34, 27);
            this.btnSeleccionarArchivo.TabIndex = 81;
            this.btnSeleccionarArchivo.UseVisualStyleBackColor = false;
            this.btnSeleccionarArchivo.Click += new System.EventHandler(this.btnCargarExcel_Click);
            // 
            // openFileDialogExcel
            // 
            this.openFileDialogExcel.FileName = "*.xls";
            // 
            // txtArchivoExcel
            // 
            this.txtArchivoExcel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtArchivoExcel.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArchivoExcel.Location = new System.Drawing.Point(163, 175);
            this.txtArchivoExcel.Name = "txtArchivoExcel";
            this.txtArchivoExcel.ReadOnly = true;
            this.txtArchivoExcel.Size = new System.Drawing.Size(517, 26);
            this.txtArchivoExcel.TabIndex = 82;
            // 
            // txtProyecto
            // 
            this.txtProyecto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProyecto.Font = new System.Drawing.Font("VAGRounded BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProyecto.Location = new System.Drawing.Point(157, 48);
            this.txtProyecto.Name = "txtProyecto";
            this.txtProyecto.ReadOnly = true;
            this.txtProyecto.Size = new System.Drawing.Size(517, 26);
            this.txtProyecto.TabIndex = 85;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("VAGRounded BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(19, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(137, 27);
            this.textBox1.TabIndex = 84;
            this.textBox1.Text = "Proyecto  ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmCargarComensal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 294);
            this.Controls.Add(this.txtProyecto);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtArchivoExcel);
            this.Controls.Add(this.btnSeleccionarArchivo);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.cboComedor);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCargarExcel);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmCargarComensal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox cboComedor;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCargarExcel;
        private System.Windows.Forms.Button btnSeleccionarArchivo;
        private System.Windows.Forms.OpenFileDialog openFileDialogExcel;
        private System.Windows.Forms.TextBox txtArchivoExcel;
        private System.Windows.Forms.TextBox txtProyecto;
        private System.Windows.Forms.TextBox textBox1;
    }
}
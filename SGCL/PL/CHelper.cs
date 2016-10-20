using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace SGCL.PL
{
    class CHelper
    {

        public void FormatearFormularioMantenimiento(Form oForm)
        {
            oForm.BackColor = Color.LightSteelBlue;
            oForm.ControlBox = false;
            oForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            oForm.StartPosition = FormStartPosition.Manual;
            oForm.Top = 0;
            oForm.Left = 0;
            //oForm.Location = new Point(0, 0);
            oForm.Font = new Font("VAGRounded BT", 10, FontStyle.Regular);
            oForm.ForeColor = Color.LightSteelBlue;
                
        }

        public void FormatearFormularioMantenimientoAdd(Form oForm)
        {
            oForm.BackColor = Color.LightSteelBlue;
            oForm.ControlBox = false;
            oForm.FormBorderStyle = FormBorderStyle.FixedSingle;   
            oForm.Font = new Font("VAGRounded BT", 10, FontStyle.Regular);
            oForm.ForeColor = Color.LightSteelBlue;
            oForm.StartPosition = FormStartPosition.CenterScreen;

            foreach (Control c in oForm.Controls)
            {
                if (c.GetType().ToString() == "System.Windows.Form.Textbox")
                {                    
                    c.ForeColor = Color.LightSteelBlue;
                    c.Font = new Font("VAGRounded BT", 10, FontStyle.Regular);
                }

                if (c.GetType().ToString() == "System.Windows.Forms.Label")
                {
                    if (c.Name != "lblTitulo")
                    {
                        c.ForeColor = Color.White;
                        c.BackColor = Color.SteelBlue;
                        c.Font = new Font("VAGRounded BT", 10, FontStyle.Bold);
                    }
                    else
                    {
                        c.ForeColor = Color.White;                        
                    }
                }

                

                
            }

        }

        public void FormatearDGVMantenimiento(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToOrderColumns = true;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;

        }
                   
    }
}

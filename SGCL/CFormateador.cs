using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SGCL
{
    class CFormateador
    {

        public void FormatearDGV(DataGridView dgv)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGCL.BE
{
    class ComedorAtencionBE
    {

        private int _oid_come_aten;
        private string _val_desc;
        private int _proy_oid_proy;                
        private int _ind_acti;

        public int oid_come_aten
        {
            get { return _oid_come_aten; }
            set { _oid_come_aten = value; }
        }

        public string val_desc
        {
            get { return _val_desc; }
            set { _val_desc = value; }
        }

        public int proy_oid_proy
        {
            get { return _proy_oid_proy; }
            set { _proy_oid_proy = value; }
        }
        
        public int ind_acti
        {
            get { return _ind_acti; }
            set { _ind_acti = value; }
        }
        
    }
}

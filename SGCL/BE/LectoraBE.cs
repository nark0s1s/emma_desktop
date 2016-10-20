using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGCL.BE
{
    class LectoraBE
    {

        private int _oid_lect;
        private string _val_desc;                
        private int _clie_oid_clie;
        private int _proy_oid_proy;
        private int _come_oid_come_aten;
        private int _ind_acti;
        

        public int oid_lect
        {
            get {   return _oid_lect;    }
            set {   _oid_lect = value;  }
        }

        public string val_desc
        {
            get { return _val_desc; }
            set { _val_desc = value; }
        }

        public int clie_oid_clie
        {
            get { return _clie_oid_clie; }
            set { _clie_oid_clie = value; }
        }

        public int proy_oid_proy
        {
            get { return _proy_oid_proy; }
            set { _proy_oid_proy = value; }
        }

        public int come_oid_come_aten
        {
            get { return _come_oid_come_aten; }
            set { _come_oid_come_aten = value; }
        }

        public int ind_acti
        {
            get { return _ind_acti; }
            set { _ind_acti = value; }
        }
        
    }
}

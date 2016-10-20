using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGCL.BE
{
    class ComensalComedorBE
    {
        
        private int _oid_come_come;
        private int _clie_oid_clie;
        private int _proy_oid_proy;        
        private int _oid_come_aten;
        private int _oid_come_clie;        

        public int oid_come_come
        {
            get { return _oid_come_come; }
            set { _oid_come_come = value; }
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

        public int oid_come_aten
        {
            get { return _oid_come_aten; }
            set { _oid_come_aten = value; }
        }

        public int oid_come_clie
        {
            get { return _oid_come_clie; }
            set { _oid_come_clie = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGCL.BE
{
    class ProyectoBE
    {

        private int _oid_proy;
        private string _val_desc;
        private string _val_dept;
        private string _val_prov;
        private string _val_dist;
        private int _clie_oid_clie;        

        public int oid_proy
        {
            get {   return _oid_proy;    }
            set {   _oid_proy = value;  }
        }

        public string val_desc
        {
            get { return _val_desc; }
            set { _val_desc = value; }
        }

        public string val_dept
        {
            get { return _val_dept; }
            set { _val_dept = value; }
        }

        public string val_prov
        {
            get { return _val_prov; }
            set { _val_prov = value; }
        }

        public string val_dist
        {
            get { return _val_dist; }
            set { _val_dist = value; }
        }

        public int clie_oid_clie
        {
            get { return _clie_oid_clie; }
            set { _clie_oid_clie = value; }
        }
        
    }
}

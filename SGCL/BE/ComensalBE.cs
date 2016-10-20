using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGCL.BE
{
    class ComensalBE
    {
        
        private int _oid_come;
        private string _num_iden_come;
        private string _val_desc;        
        private string _tipo_cod_tipo_docu_iden;
        private string _val_num_docu_iden;
        private string _val_carg;
        private string _val_tipo_carg;               
        private int _clie_oid_clie;
        private int _proy_oid_proy;
        private int _come_oid_come_aten;

        public int oid_come
        {
            get { return _oid_come; }
            set { _oid_come = value; }
        }

        public string num_iden_come
        {
            get { return _num_iden_come; }
            set { _num_iden_come = value; }
        }

        public string val_desc
        {
            get { return _val_desc; }
            set { _val_desc = value; }
        }
        
        public string tipo_cod_tipo_docu_iden
        {
            get { return _tipo_cod_tipo_docu_iden; }
            set { _tipo_cod_tipo_docu_iden = value; }
        }

        public string val_num_docu_iden
        {
            get { return _val_num_docu_iden; }
            set { _val_num_docu_iden = value; }
        }

        public string val_carg
        {
            get { return _val_carg; }
            set { _val_carg = value; }
        }

        public string val_tipo_carg
        {
            get { return _val_tipo_carg; }
            set { _val_tipo_carg = value; }
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
    }
}

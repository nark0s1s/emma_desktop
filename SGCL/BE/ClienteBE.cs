using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGCL.BE
{
    class ClienteBE
    {

        private int _oid_clie;
        private string _val_deno_soci;
        private string _val_nom1;
        private string _val_nom2;
        private string _val_ape1;
        private string _val_ape2;
        private string _tipo_cod_tipo_docu_iden;
        private string _val_nume_docu_iden;
        private int _proy_oid_proy;

        public int oid_clie
        {
            get {   return _oid_clie;    }
            set {   _oid_clie = value;  }
        }

        public string val_deno_soci
        {
            get { return _val_deno_soci; }
            set { _val_deno_soci = value; }
        }

        public string val_nom1
        {
            get { return _val_nom1; }
            set { _val_nom1 = value; }
        }

        public string val_nom2
        {
            get { return _val_nom2; }
            set { _val_nom2 = value; }
        }

        public string val_ape1
        {
            get { return _val_ape1; }
            set { _val_ape1 = value; }
        }

        public string val_ape2
        {
            get { return _val_ape2; }
            set { _val_ape2 = value; }
        }

        public string tipo_cod_tipo_docu_iden
        {
            get { return _tipo_cod_tipo_docu_iden; }
            set { _tipo_cod_tipo_docu_iden = value; }
        }

        public string val_nume_docu_iden
        {
            get { return _val_nume_docu_iden; }
            set { _val_nume_docu_iden = value; }
        }

        public int proy_oid_proy
        {
            get { return _proy_oid_proy; }
            set { _proy_oid_proy = value; }
        }

    }
}

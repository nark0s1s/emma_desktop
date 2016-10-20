using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGCL.BE
{
    class ComedorTipoServicioBE
    {

        private int _oid_come_tipo_serv;        
        private int _clie_oid_clie;
        private int _proy_oid_proy;
        private int _come_oid_come_aten;
        private string _tipo_cod_tipo_serv_come;
        private decimal _imp_prec_fact;
        private int _ind_acti;


        public int oid_come_tipo_serv
        {
            get { return _oid_come_tipo_serv; }
            set { _oid_come_tipo_serv = value; }
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
       
        public string tipo_cod_tipo_serv_come
        {
            get { return _tipo_cod_tipo_serv_come; }
            set { _tipo_cod_tipo_serv_come = value; }
        }

        public decimal imp_prec_fact
        {
            get { return _imp_prec_fact; }
            set { _imp_prec_fact = value; }
        }

        public int ind_acti
        {
            get { return _ind_acti; }
            set { _ind_acti = value; }
        }
        
    }
}

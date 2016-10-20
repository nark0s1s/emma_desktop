using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGCL.BE
{
    class TipoServicioComedorBE
    {   
     
        private string _cod_tipo_docu_iden;      
        private string _val_desc;
        private int _num_orde_repo;                
        private int _ind_acti; 
                
        public string cod_tipo_docu_iden
        {
            get { return _cod_tipo_docu_iden; }
            set { _cod_tipo_docu_iden = value; }
        }

        public string val_desc
        {
            get{    return _val_desc;   }
            set{    _val_desc = value;  }
        }

        public int num_orde_repo
        {
            get { return _num_orde_repo; }
            set { _num_orde_repo = value; }
        }


        public int ind_acti
        {
            get { return _ind_acti; }
            set { _ind_acti = value; }
        }

    }
}

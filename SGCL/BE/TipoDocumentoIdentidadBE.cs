using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGCL.BE
{
    class TipoDocumentoIdentidadBE
    {   
     
        private string _cod_tipo_docu_iden;      
        private string _val_desc;        
                
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

    }
}

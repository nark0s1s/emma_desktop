using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGCL.BE
{
    class TurnoDetalleBE
    {

        private int _oid_turn_deta;        
        private int _turn_oid_turn;
        private int _oid_come_clie;                
        private string _ind_tipo_entr;
        

        public int oid_turn_deta
        {
            get {   return _oid_turn_deta;    }
            set {   _oid_turn_deta = value;  }
        }

        public int turn_oid_turn
        {
            get { return _turn_oid_turn; }
            set { _turn_oid_turn = value; }
        }

        public int oid_come_clie
        {
            get { return _oid_come_clie; }
            set { _oid_come_clie = value; }
        }
        
        public string ind_tipo_entr
        {
            get { return _ind_tipo_entr; }
            set { _ind_tipo_entr = value; }
        }

    }
}

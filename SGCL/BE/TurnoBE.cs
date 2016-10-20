using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGCL.BE
{
    class TurnoBE
    {

        private int _oid_turn;        
        private int _clie_oid_clie;
        private int _proy_oid_proy;
        private int _come_oid_come;
        private string _tise_cod_tipo_serv;
        private int _lect_oid_lect;
        private string _val_fech;
        private int _val_cant;
        private int _ind_cier;
        private int _ind_elim;
        

        public int oid_turn
        {
            get {   return _oid_turn;    }
            set {   _oid_turn = value;  }
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

        public int come_oid_come
        {
            get { return _come_oid_come; }
            set { _come_oid_come = value; }
        }

        public int lect_oid_lect
        {
            get { return _lect_oid_lect; }
            set { _lect_oid_lect = value; }
        }

        public string tise_cod_tipo_serv
        {
            get { return _tise_cod_tipo_serv; }
            set { _tise_cod_tipo_serv = value; }
        }

        public string val_fech
        {
            get { return _val_fech; }
            set { _val_fech = value; }
        }

        public int val_cant
        {
            get { return _val_cant; }
            set { val_cant = value; }
        }

        public int ind_cier
        {
            get { return _ind_cier; }
            set { _ind_cier = value; }
        }

        public int ind_elim
        {
            get { return _ind_elim; }
            set { _ind_elim = value; }
        }
    }
}

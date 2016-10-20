using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EMMA.BE
{
    static class Global
    {
        private static int _oid_proy = 0;
        private static string _des_proy = "";

        public static int oid_proy
        {
            get { return _oid_proy; }
            set { _oid_proy = value; }
        }

        public static string des_proy
        {
            get { return _des_proy; }
            set { _des_proy = value; }
        }
    }
}

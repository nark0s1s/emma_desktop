using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EMMA.DAO;

namespace EMMA.BR
{
    class UsuarioBR
    {
         
        public void ValidarLogin(string cod_usua, string val_clav,int oid_proy,out string val_resu,out int oid_usua,out string des_usua)
        {

            UsuarioDAO oUsuarioDAO = new UsuarioDAO();

            oUsuarioDAO.ValidarLogin(cod_usua, val_clav, oid_proy, out val_resu, out oid_usua, out des_usua);
            
        }

    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SGCL.DAO;

namespace SGCL.BR
{
    class ValorizacionBR
    {

        public DataTable ObtenerListadoFechas(string val_fech_desd, string val_fech_hast)
        {

            DataTable dt = new DataTable();

            ValorizacionDAO oValorizacionDAO = new ValorizacionDAO();

            dt = oValorizacionDAO.ObtenerListadoFechas(val_fech_desd, val_fech_hast);

            return dt;
        }

        public DataTable ObtenerListadoTipoServicioPorProyecto(int oid_proy)
        {

            DataTable dt = new DataTable();

            ValorizacionDAO oValorizacionDAO = new ValorizacionDAO();

            dt = oValorizacionDAO.ObtenerListadoTipoServicioPorProyecto(oid_proy);

            return dt;
        }

        public DataTable ObtenerListadoTipoServicioPorComedor(int oid_come)
        {

            DataTable dt = new DataTable();

            ValorizacionDAO oValorizacionDAO = new ValorizacionDAO();

            dt = oValorizacionDAO.ObtenerListadoTipoServicioPorComedor(oid_come);

            return dt;
        }

        public DataTable ObtenerListadoComedorPorProyecto(int oid_proy)
        {

            DataTable dt = new DataTable();

            ValorizacionDAO oValorizacionDAO = new ValorizacionDAO();

            dt = oValorizacionDAO.ObtenerListadoComedorPorProyecto(oid_proy);

            return dt;
        }

        public int ValidarAtecionByFechaTipoServicio(int oid_proy, string cod_tipo_serv, string val_fech_aten,int oid_come)
        {

            ValorizacionDAO oValorizacionDAO = new ValorizacionDAO();

            int result;
            result = oValorizacionDAO.ValidarAtecionByFechaTipoServicio(oid_proy, cod_tipo_serv, val_fech_aten, oid_come);

            return result;
        }

        public DataTable ObtenerListadoAtencionesPorComensal(int oid_proy, string val_fech_desd, string val_fech_hast, int oid_come)
        {
            DataTable dt = new DataTable();

            ValorizacionDAO oValorizacionDAO = new ValorizacionDAO();

            dt = oValorizacionDAO.ObtenerListadoAtencionesPorComensal(oid_proy,val_fech_desd,val_fech_hast,oid_come);

            return dt;
        }

        public DataTable ObtenerListadoComensalesPorProyecto(int oid_proy)
        {

            DataTable dt = new DataTable();

            ValorizacionDAO oValorizacionDAO = new ValorizacionDAO();

            dt = oValorizacionDAO.ObtenerListadoComensalesPorProyecto(oid_proy);

            return dt;
        }

        public DataTable ObtenerListadoComensalesPorComedor(int oid_come)
        {

            DataTable dt = new DataTable();

            ValorizacionDAO oValorizacionDAO = new ValorizacionDAO();

            dt = oValorizacionDAO.ObtenerListadoComensalesPorComedor(oid_come);

            return dt;
        }
        
    }
}

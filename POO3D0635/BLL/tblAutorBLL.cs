using POO3D0635.DAL;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POO3D0635.BLL
{
    public class tblAutorBLL
    {
        private DALMysql daoBanco = new DALMysql();
        public DataTable ListarAutores()
        {
            string sql = string.Format($@"select * from TBL_Autor");
            return daoBanco.executarConsulta(sql);
        }
    }
}
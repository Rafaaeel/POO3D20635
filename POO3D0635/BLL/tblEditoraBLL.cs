using POO3D0635.DAL;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POO3D0635.BLL
{
    public class tblEditoraBLL
    {
        private DALMysql daoBanco = new DALMysql();
        public DataTable ListarEditoras()
        {
            string sql = string.Format($@"select * from TBL_Editora");
            return daoBanco.executarConsulta(sql);
        }
    }
}
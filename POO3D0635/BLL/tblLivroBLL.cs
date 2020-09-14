using POO3D0635.DAL;
using POO3D0635.DTO;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POO3D0635.BLL
{
    public class tblLivroBLL
    {
        private DALMysql daoBanco = new DALMysql();
        public DataTable ListarLivros()
        {
            string sql = string.Format($@"select * from TBL_Livro");
            return daoBanco.executarConsulta(sql);
        }

        public void InserirLivro(tblLivroDTO dtoLivro)
        {
            string sql = string.Format($@"INSERT INTO TBL_Livro VALUES (NULL,'{dtoLivro.IdAutor}',
                                                                               '{dtoLivro.IdEditora}',
                                                                               '{dtoLivro.Titulo}',
                                                                               '{dtoLivro.NumPaginas}',
                                                                               '{dtoLivro.Valor}');");
            daoBanco.executarComando(sql);

        }

        public void ExcluirLivro(tblLivroDTO dtoLivro)
        {
            string sql = string.Format($@"DELETE FROM TBL_Livro where idLivro = {dtoLivro.IdLivro};");
            daoBanco.executarComando(sql);
        }

        public void AlterarLivro(tblLivroDTO dtoLivro)
        {
            string sql = string.Format($@"UPDATE TBL_Livro set idAutor = '{dtoLivro.IdAutor}',
                                                                 idEditora = '{dtoLivro.IdEditora}',
                                                                 titulo = '{dtoLivro.Titulo}',
                                                                 numPaginas = '{dtoLivro.NumPaginas}',
                                                                 valor = '{dtoLivro.Valor}'
                                                where idLivro = '{dtoLivro.IdLivro}';");
            daoBanco.executarComando(sql);

        }
    }
}
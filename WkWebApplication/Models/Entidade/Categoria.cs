using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WkWebApplication.Models.DAL;

namespace WkWebApplication.Models
{
    public class Categoria
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string descricao;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public Categoria ObterPorId(int id)
        {
            return new CategoriaDAO().ObterPorId(id);
        }
        public List<Categoria> ObterTodos()
        {
            return new CategoriaDAO().ObterTodos();
        }
        internal int Gravar(Categoria c)
        {
            return new CategoriaDAO().Gravar(c);
        }
        internal int Editar(Categoria c)
        {
            return new CategoriaDAO().Editar(c);
        }

        internal bool PodeExcluir(Categoria c)
        {
            return new CategoriaDAO().PodeExcluir(c);
        }

        internal int Excluir(Categoria c)
        {
            return new CategoriaDAO().Excluir(c);
        }
        public List<Categoria> ObterPorPesquisa(string pesquisa)
        {
            return new CategoriaDAO().ObterPorPesquisa(pesquisa);
        }

    }
}

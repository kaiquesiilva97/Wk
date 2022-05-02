using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WkWebApplication.Models.DAL;

namespace WkWebApplication.Models
{
    public class Produto
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string codigoBarra;

        public string CodigoBarra
        {
            get { return codigoBarra; }
            set { codigoBarra = value; }
        }

        private string descricao;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        private string observacao;

        public string Observacao
        {
            get { return observacao; }
            set { observacao = value; }
        }

        private decimal qtdeAtual;

        public decimal QtdeAtual
        {
            get { return qtdeAtual; }
            set { qtdeAtual = value; }
        }


        private decimal qtdeMinima;

        public decimal QtdeMinima
        {
            get { return qtdeAtual; }
            set { qtdeAtual = value; }
        }

        private decimal valorCusto;

        public decimal ValorCusto
        {
            get { return valorCusto; }
            set { valorCusto = value; }
        }

        private decimal valorVenda;

        public decimal ValorVenda
        {
            get { return valorVenda; }
            set { valorVenda = value; }
        }

        private Categoria categoria;

        public Categoria Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        private char status;

        public char Status
        {
            get { return status; }
            set { status = value; }
        }


        public Produto ObterPorId(int id)
        {
            return new ProdutoDAO().ObterPorId(id);
        }
        public List<Produto> ObterTodos()
        {
            return new ProdutoDAO().ObterTodos();
        }

        public int Gravar(Produto p)
        {
            return new ProdutoDAO().Gravar(p);
        }
        public int Editar(Produto p)
        {
            return new ProdutoDAO().Editar(p);
        }
        public int Excluir(Produto p)
        {
            return new ProdutoDAO().Excluir(p);
        }

        public List<Produto> ObterTodosAtivoPesquisa(string pesquisa)
        {
            return new ProdutoDAO().ObterTodosAtivoPesquisa(pesquisa);
        }
        public List<Produto> ObterTodosInativoPesquisa(string pesquisa)
        {
            return new ProdutoDAO().ObterTodosInativoPesquisa(pesquisa);
        }
        public List<Produto> ObterTodosPesquisa(string pesquisa)
        {
            return new ProdutoDAO().ObterTodosPesquisa(pesquisa);
        }
    }
}

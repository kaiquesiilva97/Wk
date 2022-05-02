using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebSGC.Models.DAL;

namespace WkWebApplication.Models.DAL
{
    public class ProdutoDAO : BancoDAL
    {
        private List<Produto> TableToList(DataTable dt)
        {
            List<Produto> dados = null;
            if (dt != null && dt.Rows.Count > 0)
                dados = (from DataRow row in dt.Rows
                         select new Produto()
                         {
                             Id = Convert.ToInt32(row["prod_id"]),
                             CodigoBarra = row["prod_cod_barra"].ToString(),
                             Descricao = row["prod_descricao"].ToString(),
                             Observacao = row["prod_observacao"].ToString(),
                             QtdeAtual = row["prod_qtde_atual"].ToString() != "" ? Convert.ToDecimal(row["prod_qtde_atual"].ToString()) : 0,
                             QtdeMinima = row["prod_qtde_min"].ToString() != "" ? Convert.ToDecimal(row["prod_qtde_min"].ToString()) : 0,
                             ValorCusto = row["prod_valor_custo"].ToString() != "" ? Convert.ToDecimal(row["prod_valor_custo"].ToString()) : 0,
                             ValorVenda = row["prod_valor_venda"].ToString() != "" ? Convert.ToDecimal(row["prod_valor_venda"].ToString()) : 0,
                             Categoria = new Categoria().ObterPorId(Convert.ToInt32(row["prod_id_categoria"])),
                             Status = Convert.ToChar(row["prod_status"].ToString())
                         }).ToList();
            return dados;
        }

        internal Produto ObterPorId(int id)
        {
            ComandoSQL.Parameters.Clear();
            ComandoSQL.CommandText = @"SELECT * FROM produto WHERE prod_id = @id";
            ComandoSQL.Parameters.AddWithValue("@id", id);
            DataTable dt = ExecutaSelect();
            var dados = TableToList(dt);
            return dados == null ? null : dados.FirstOrDefault();
        }

        internal List<Produto> ObterTodos()
        {
            ComandoSQL.Parameters.Clear();
            ComandoSQL.CommandText = @"SELECT * FROM produto";
            DataTable dt = ExecutaSelect();
            var dados = TableToList(dt);
            return dados == null ? null : dados;
        }
        internal List<Produto> ObterTodosAtivoPesquisa(string pesquisa)
        {
            ComandoSQL.Parameters.Clear();
            ComandoSQL.CommandText = @"SELECT * FROM produto WHERE UPPER(prod_descricao) 
			LIKE UPPER(@pesquisa) AND prod_status = 'A'";
            ComandoSQL.Parameters.AddWithValue("@pesquisa", "%" + pesquisa + "%");
            DataTable dt = ExecutaSelect();
            var dados = TableToList(dt);
            return dados == null ? null : dados;
        }
        internal List<Produto> ObterTodosInativoPesquisa(string pesquisa)
        {
            ComandoSQL.Parameters.Clear();
            ComandoSQL.CommandText = @"SELECT * FROM produto WHERE UPPER(prod_descricao) 
			LIKE UPPER(@pesquisa) AND prod_status = 'I'";
            ComandoSQL.Parameters.AddWithValue("@pesquisa", "%" + pesquisa + "%");
            DataTable dt = ExecutaSelect();
            var dados = TableToList(dt);
            return dados == null ? null : dados;
        }

        internal List<Produto> ObterTodosPesquisa(string pesquisa)
        {
            ComandoSQL.Parameters.Clear();
            ComandoSQL.CommandText = @"SELECT * FROM produto WHERE UPPER(prod_descricao) 
			LIKE UPPER(@pesquisa)";
            ComandoSQL.Parameters.AddWithValue("@pesquisa", "%" + pesquisa + "%");
            DataTable dt = ExecutaSelect();
            var dados = TableToList(dt);
            return dados == null ? null : dados;
        }

        internal int Gravar(Produto p)
        {
            ComandoSQL.Parameters.Clear();

            ComandoSQL.CommandText = @"INSERT INTO produto
            (prod_cod_barra, prod_descricao, prod_observacao, prod_qtde_atual, prod_qtde_min, prod_valor_custo, prod_valor_venda, prod_id_categoria, prod_status)
            VALUES (@codigoBarra, @descricao, @observacao, @qtdeAtual, @qtdeMinima, @valorCusto, @valorVenda, @categoria, @status);";

            ComandoSQL.Parameters.AddWithValue("@codigoBarra", p.CodigoBarra);
            ComandoSQL.Parameters.AddWithValue("@descricao", p.Descricao);
            ComandoSQL.Parameters.AddWithValue("@observacao", p.Observacao);
            ComandoSQL.Parameters.AddWithValue("@qtdeAtual", p.QtdeAtual);
            ComandoSQL.Parameters.AddWithValue("@qtdeMinima", p.QtdeMinima);
            ComandoSQL.Parameters.AddWithValue("@valorCusto", p.ValorCusto);
            ComandoSQL.Parameters.AddWithValue("@valorVenda", p.ValorVenda);
            ComandoSQL.Parameters.AddWithValue("@categoria", p.Categoria.Id);
            ComandoSQL.Parameters.AddWithValue("@status", p.Status.ToString());

            return ExecutaComando();
        }

        internal int Editar(Produto p)
        {
            ComandoSQL.Parameters.Clear();

            ComandoSQL.CommandText = @"UPDATE produto
            set prod_cod_barra = @codigoBarra, prod_descricao = @descricao, prod_observacao= @observacao, prod_qtde_atual= @qtdeAtual, prod_qtde_min = @qtdeMinima, prod_valor_custo = @valorCusto,
            prod_valor_venda = @valorVenda, prod_id_categoria = @categoria, prod_status = @status where prod_id = @id";

            ComandoSQL.Parameters.AddWithValue("@codigoBarra", p.CodigoBarra);
            ComandoSQL.Parameters.AddWithValue("@descricao", p.Descricao);
            ComandoSQL.Parameters.AddWithValue("@observacao", p.Observacao);
            ComandoSQL.Parameters.AddWithValue("@qtdeAtual", p.QtdeAtual);
            ComandoSQL.Parameters.AddWithValue("@qtdeMinima", p.QtdeMinima);
            ComandoSQL.Parameters.AddWithValue("@valorCusto", p.ValorCusto);
            ComandoSQL.Parameters.AddWithValue("@valorVenda", p.ValorVenda);
            ComandoSQL.Parameters.AddWithValue("@categoria", p.Categoria.Id);
            ComandoSQL.Parameters.AddWithValue("@status", p.Status.ToString());
            ComandoSQL.Parameters.AddWithValue("@id", p.Id);

            return ExecutaComando();
        }

        internal int Excluir(Produto p)
        {
            ComandoSQL.Parameters.Clear();
            ComandoSQL.CommandText = @"DELETE FROM produto WHERE prod_id = @id";
            ComandoSQL.Parameters.AddWithValue("@id", p.Id);
            return ExecutaComando();
        }
    }
}

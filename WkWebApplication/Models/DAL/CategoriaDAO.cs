using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebSGC.Models.DAL;

namespace WkWebApplication.Models.DAL
{
    public class CategoriaDAO : BancoDAL
    {
        private List<Categoria> TableToList(DataTable dt)
        {
            List<Categoria> dados = null;
            if (dt != null && dt.Rows.Count > 0)
                dados = (from DataRow row in dt.Rows
                         select new Categoria()
                         {
                             Id = Convert.ToInt32(row["cat_id"]),
                             Descricao = row["cat_descricao"].ToString()
                         }).ToList();
            return dados;
        }
        internal Categoria ObterPorId(int id)
        {
            ComandoSQL.Parameters.Clear();
            ComandoSQL.CommandText = @"SELECT * FROM categoria where cat_id = @id";
            ComandoSQL.Parameters.AddWithValue("@id", id);
            DataTable dt = ExecutaSelect();
            var dados = TableToList(dt);
            return dados == null ? null : dados.FirstOrDefault();
        }

        internal List<Categoria> ObterTodos()
        {
            ComandoSQL.Parameters.Clear();
            ComandoSQL.CommandText = @"SELECT * FROM categoria";
            DataTable dt = ExecutaSelect();
            var dados = TableToList(dt);
            return dados == null ? null : dados;
        }
        internal List<Categoria> ObterPorPesquisa(string pesquisa)
        {
            ComandoSQL.Parameters.Clear();
            ComandoSQL.CommandText = @"SELECT * FROM categoria WHERE UPPER(cat_descricao) 
			LIKE UPPER(@pesquisa) ";
            ComandoSQL.Parameters.AddWithValue("@pesquisa", "%"+pesquisa+"%");
            DataTable dt = ExecutaSelect();
            var dados = TableToList(dt);
            return dados == null ? null : dados;
        }

        internal bool PodeExcluir(Categoria c)
        {
            ComandoSQL.Parameters.Clear();
            ComandoSQL.CommandText = @"SELECT COUNT(*) FROM produto where prod_id_categoria = @id";
            ComandoSQL.Parameters.AddWithValue("@id", c.Id);
            DataTable dt = ExecutaSelect();
            if (Convert.ToInt32(dt.Rows[0][0]) > 0)
                return false;
            else
                return true;
        }
        internal int Excluir(Categoria c)
        {
            ComandoSQL.Parameters.Clear();
            ComandoSQL.CommandText = @"DELETE FROM categoria WHERE cat_id = @id";
            ComandoSQL.Parameters.AddWithValue("@id", c.Id);
            return ExecutaComando();
        }

        internal int Editar(Categoria c)
        {
            ComandoSQL.Parameters.Clear();
            ComandoSQL.CommandText = @"UPDATE categoria SET cat_descricao = @descricao WHERE cat_id = @id";
            ComandoSQL.Parameters.AddWithValue("@descricao", c.Descricao);
            ComandoSQL.Parameters.AddWithValue("@id", c.Id);
            return ExecutaComando();
        }

        internal int Gravar(Categoria c)
        {
            ComandoSQL.Parameters.Clear();

            ComandoSQL.CommandText = @"INSERT INTO categoria(cat_descricao) VALUES (@descricao)";

            ComandoSQL.Parameters.AddWithValue("@descricao", c.Descricao);

            return ExecutaComando();
        }
    }
}

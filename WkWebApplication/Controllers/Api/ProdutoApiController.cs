using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WkWebApplication.Models;

namespace WkWebApplication.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoApiController : ControllerBase
    {
        // GET: api/<controller>
        [HttpGet]
        public JsonResult Get(string resultado, string filtro)
        {
            if (resultado == null)
                resultado = "";
            if (filtro == "Todos")
                return new JsonResult(new Produto().ObterTodosAtivoPesquisa(resultado));
            else if (filtro == "Ativo")
                return new JsonResult(new Produto().ObterTodosAtivoPesquisa(resultado));
            else
                return new JsonResult(new Produto().ObterTodosInativoPesquisa(resultado));

        }
        public string VerificaDados(Produto p)
        {
            string msg = "";
            if (!(p.Descricao.Length > 0 && p.Descricao.Length < 120))
                msg += "Erro Descricao\n";
            if (!(p.CodigoBarra.Length < 30))
                msg += "Erro Codigo de Barra\n";
            if (!(p.Observacao.Length < 500))
                msg += "Erro na descrição\n";
            return msg;
        }
        // GET api/<controller>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Produto p = new Produto().ObterPorId(id);
            return new JsonResult(p);
        }

        // POST api/<controller>
        [HttpPost]
        public JsonResult Post([FromBody] Produto prod)
        {
            if (prod == null)
                return new JsonResult(0);
            string msg = VerificaDados(prod);
            if (msg == "")
                return new Produto().Gravar(prod) > 0 ? new JsonResult(1) : new JsonResult(0);
            else return new JsonResult(0);
        }

        // PUT api/<controller>/5
        [HttpPut]
        public JsonResult Put([FromBody] Produto prod)
        {
            if (prod == null)
                return new JsonResult(0);
            string msg = VerificaDados(prod);
            if (msg == "")
                return new Produto().Editar(prod) > 0 ? new JsonResult(1) : new JsonResult(0);
            else return new JsonResult(0);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            Produto c = new Produto() { Id = id };
            return new Produto().Excluir(c) > 0 ? new JsonResult(1) : new JsonResult(0);
        }
    }
}

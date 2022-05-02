using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WkWebApplication.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WkWebApplication.Controllers.Api
{
    [Route("api/[controller]")]
    public class CategoriaApi : Controller
    {

        // GET: api/<controller>
        [HttpGet]
        public JsonResult Get(string resultado)
        {
            if(resultado == "" || resultado == null)
                return new JsonResult(new Categoria().ObterTodos());
            else
                return new JsonResult(new Categoria().ObterPorPesquisa(resultado));
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Categoria c = new Categoria().ObterPorId(id);
            return new JsonResult(c);
        }
        public string VerificaDados(Categoria c)
        {
            string msg = "";
            if (!(c.Descricao.Length > 0 && c.Descricao.Length < 80))
                msg +="Erro Descricao\n";
            return msg;
        }
        // POST api/<controller>
        [HttpPost]
        public JsonResult Post([FromBody]Categoria cat)
        {
            if (cat == null)
                return new JsonResult(0);
            string msg = VerificaDados(cat);
            if(msg == "")
                return new Categoria().Gravar(cat) > 0 ? new JsonResult(1) : new JsonResult(0);
            else
                return new JsonResult(0);
        }

        // PUT api/<controller>/5
        [HttpPut]
        public JsonResult Put([FromBody]Categoria cat)
        {
            if (cat == null)
                return new JsonResult(0);
            string msg = VerificaDados(cat);
            if (msg == "")
                return new Categoria().Editar(cat) > 0 ? new JsonResult(1) : new JsonResult(0);
            else
                return new JsonResult(0);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            Categoria c = new Categoria() { Id = id };
            if (new Categoria().PodeExcluir(c))
            {
                return new Categoria().Excluir(c) > 0 ? new JsonResult(1) : new JsonResult(0);
            }
            else
                return new JsonResult(0);
      
        }
    }
}
